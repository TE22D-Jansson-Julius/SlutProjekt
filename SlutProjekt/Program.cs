using System.Diagnostics.Tracing;
using System.Numerics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;


Raylib.InitWindow(800, 600, "Mario");
Raylib.SetTargetFPS(60);

Player gubbe = new Player();
WallsC wall = new WallsC();

 wall.wall1();


    

while (!Raylib.WindowShouldClose())
{

    gubbe.rörelse();


    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.SkyBlue);
    Raylib.DrawRectangleRec(gubbe.player, Color.Purple);

wall.wall2();
   
 Collision.collision(wall, gubbe);

 

    Raylib.EndDrawing();
}

