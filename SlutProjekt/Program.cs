using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;


Raylib.InitWindow(1200, 600, "Jag vet inte");
Raylib.SetTargetFPS(60);

Player gubbe = new Player();
WallsC wall = new WallsC();


string scene = "start";

// logic for 3D array
wall.Logic();

while (!Raylib.WindowShouldClose())
{
    // if start then draw and write this
    if (scene == "start")
    {
        Raylib.ClearBackground(Color.Yellow);
        Raylib.DrawText("Press Space to play", 150, 310, 35, Color.Black);
        Raylib.DrawText("A and D to move Space to jump", 100, 370, 35, Color.Black);
        if (Raylib.IsKeyDown(KeyboardKey.Space))
        {
            // changes scene to play
            scene = "play";
            // game = true;

        }
    }

    if (scene == "play")
    {
        // movement method
        gubbe.Rörelse(wall);
        // draws 3D array
        wall.Draw();


        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.SkyBlue);
        // draws character
        Raylib.DrawRectangleRec(gubbe.Character, Color.Purple);

        // if wall and gubbe collide change scene
        Collision.Check(wall, gubbe);
        scene = Collision.Games;

        // used for testing jump
        // Console.WriteLine(Collision.hopp);

    }
    // when dead
    if (scene == "dead")
    {
        Raylib.ClearBackground(Color.Yellow);
        Raylib.DrawText("Press space to try again", 150, 310, 35, Color.Black);

        if (Raylib.IsKeyDown(KeyboardKey.Space))
        {
            // If you press space game is restarted
            gubbe.Character.Y = 500;
            gubbe.Character.X = 100;
            scene = "play";
        }
    }
    // if you somehow manage to win
    if (scene == "win")
    {
        Raylib.ClearBackground(Color.Yellow);
        Raylib.DrawText("WOW, YOU WIN", 150, 310, 35, Color.Black);
        Raylib.DrawText("Press Space to play again", 150, 350, 35, Color.Black);
        Raylib.DrawText("Press ESC to exit", 150, 400, 35, Color.Black);

        if (Raylib.IsKeyDown(KeyboardKey.Space))
        {
            // also restarts the game. If you want to play again
            gubbe.Character.Y = 500;
            gubbe.Character.X = 100;
            scene = "play";
        }

    }

    Raylib.EndDrawing();
}

