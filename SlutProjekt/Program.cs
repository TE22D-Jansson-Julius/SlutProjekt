using System.Diagnostics.Tracing;
using System.Numerics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Mario");
Raylib.SetTargetFPS(60);

Player player = new Player();
WallsC walls = new WallsC();


while (!Raylib.WindowShouldClose())
{

player.rörelse();


    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Green);
Raylib.DrawRectangleRec(player.player,Color.Purple);


WallsC.wall1();



    Raylib.EndDrawing();
}

