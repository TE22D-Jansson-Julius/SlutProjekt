using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;


Raylib.InitWindow(1200, 600, "Jag vet inte");
Raylib.SetTargetFPS(60);

Player player = new Player();
WallsC wall = new WallsC();
Scene scene = new Scene();

// string scene = "start";

// logic for 3D array
wall.Logic();

while (!Raylib.WindowShouldClose())
{
   
   //changes scenes 
   scene.Window(wall, player);
   

    Raylib.EndDrawing();
}

