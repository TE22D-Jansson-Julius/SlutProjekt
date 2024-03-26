using System.Diagnostics.Tracing;
using System.Numerics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Mario");
Raylib.SetTargetFPS(60);

Player gubbe = new Player();
WallsC wall = new WallsC();



while (!Raylib.WindowShouldClose())
{

    gubbe.rörelse();


    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.SkyBlue);
    Raylib.DrawRectangleRec(gubbe.player, Color.Purple);


    wall.wall1();
    wall.wall2();

    foreach (Rectangle w in wall.walls)
        if (Raylib.CheckCollisionRecs(w, gubbe.player))
        {
            gubbe.movement.Y = 0;
            gubbe.player.Y = w.Y-50;
        }

    Raylib.EndDrawing();
}

