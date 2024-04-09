using Raylib_cs;
using System.Numerics;

class Collision
{


    public static void collision(WallsC wall, Player gubbe)
    {

        foreach (Rectangle f in wall.floor)
            if (Raylib.CheckCollisionRecs(f, gubbe.player))
            {
                gubbe.movement.Y = 0;
                gubbe.player.Y = f.Y - 50;
            }
        foreach (Rectangle p in wall.pole)
            if (Raylib.CheckCollisionRecs(p, gubbe.player))
            {
                gubbe.player.X = p.X -50;
                
            
            }
    }
}