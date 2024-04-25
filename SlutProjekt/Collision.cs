using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Collision
{
    public static string games = "play";
    public static bool hopp = false;

    public static void collision(WallsC wall, Player gubbe)
    {
        // method checking if the character is colliding with things
        // bool undoX = false;

        foreach (Rectangle f in wall.floor)
            if (Raylib.CheckCollisionRecs(f, gubbe.player))
            {
                // teleports you above the floor and makes it so you can jump
                gubbe.movement.Y = 0;
                gubbe.player.Y = f.Y - 50;
                hopp = true;
            }


        bool game = true;
        foreach (Rectangle p in wall.pole)
        {

            if (Raylib.CheckCollisionRecs(p, gubbe.player))
            {
                //   Console.WriteLine("iuhawefailjh");
                game = false;
            }
            else games = "play";
        }
        bool end = false;
        foreach (Rectangle g in wall.goals)
            if (Raylib.CheckCollisionRecs(g, gubbe.player))
            {
                end = true;
            }


        if (end)
        {
            games = "win";
        }


        if (!game)
        {
            games = "dead";
        }

    }
    // gubbe.player.X -= gubbe.movement.X;
}