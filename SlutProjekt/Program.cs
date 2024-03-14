using System.Numerics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;

Raylib.InitWindow(1920, 1080, "Mario");
Raylib.SetTargetFPS(60);

Player player = new Player();

while (!Raylib.WindowShouldClose())
{

player.rörelse();


    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Green);
Raylib.DrawRectangleRec(player.player,Color.Purple);




    Raylib.EndDrawing();
}

