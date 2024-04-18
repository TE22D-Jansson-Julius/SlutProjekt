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


wall.wall1();

while (!Raylib.WindowShouldClose())
{
    if (scene == "start")
    {
        Raylib.ClearBackground(Color.Yellow);
        Raylib.DrawText("Press Space to play", 150, 310, 35, Color.Black);
        Raylib.DrawText("A and D to move Space to jump", 100, 370, 35, Color.Black);
        if (Raylib.IsKeyDown(KeyboardKey.Space))
        {

            scene = "play";
            // game = true;

        }
    }

    if (scene == "play")
    {

        gubbe.rörelse(wall);
        wall.wall2();

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.SkyBlue);
        Raylib.DrawRectangleRec(gubbe.player, Color.Purple);


        Collision.collision(wall, gubbe);
        scene = Collision.games;

Console.WriteLine(Collision.hopp);

    }

    if (scene == "dead")
    {
        Raylib.ClearBackground(Color.Yellow);
        Raylib.DrawText("Press space to try again", 150, 310, 35, Color.Black);

        if (Raylib.IsKeyDown(KeyboardKey.Space))
        {

            gubbe.player.Y = 500;
            gubbe.player.X = 100;
            scene = "play";

        }
    }

    if (scene == "win")
    {
        Raylib.ClearBackground(Color.Yellow);
        Raylib.DrawText("WOW, YOU WIN", 150, 310, 35, Color.Black);
        Raylib.DrawText("Press Space to play again", 150, 350, 35, Color.Black);
        Raylib.DrawText("Press ESC to exit", 150, 400, 35, Color.Black);

        if (Raylib.IsKeyDown(KeyboardKey.Space))
        {

            gubbe.player.Y = 500;
            gubbe.player.X = 100;
            scene = "play";

        }

    }

    Raylib.EndDrawing();
}

