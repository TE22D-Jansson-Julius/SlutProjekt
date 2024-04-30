using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Collision
{
    public static string Games = "play";
    public static bool CanJump = false;

    public static void Check(WallsC wall, Player player)
    {
        // method checking if the character is colliding with things
        // bool undoX = false;

        foreach (Rectangle f in wall.Floor)
            if (Raylib.CheckCollisionRecs(f, player.Character))
            {
                // teleports you above the floor and makes it so you can jump
                player.movement.Y = 0;
                player.Character.Y = f.Y - 50;
                CanJump = true;
            }


        bool game = true;
        foreach (Rectangle p in wall.Pole)
        {

            if (Raylib.CheckCollisionRecs(p, player.Character))
            {
                //   Console.WriteLine("iuhawefailjh");
                game = false;
            }
            else Games = "play";
        }
        bool end = false;
        foreach (Rectangle g in wall.Goals)
            if (Raylib.CheckCollisionRecs(g, player.Character))
            {
                end = true;
            }


        if (end)
        {
            Games = "win";
        }


        if (!game)
        {
            Games = "dead";
        }

    }
    // gubbe.player.X -= gubbe.movement.X;
}