using Raylib_cs;
using System.Numerics;

public class Scene
{

    string scene = "start";

   
    public void Window(WallsC wall, Player player)
    {

        // if start then draw and write this
        if (scene == "start")
        {
            Raylib.ClearBackground(Color.Yellow);
            Raylib.DrawText("Press Space to play", 150, 310, 35, Color.Black);
            Raylib.DrawText("A and D to move Space to jump", 100, 370, 35, Color.Black);
            Raylib.DrawText("Avoid the dark green rectangles and try to reach the purple", 50, 430, 35, Color.Black);
            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                // changes scene to play
                scene = "play";
                // game = true;

            }
        }

        if (scene == "play")
        {
            // movement method
            player.Move(wall);
            // draws 3D array
            wall.Draw();


            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.SkyBlue);
            // draws character
            Raylib.DrawRectangleRec(player.Character, Color.Purple);

            // if wall and gubbe collide change scene
            Collision.Check(wall, player);
            scene = Collision.Games;

            // used for testing jump
            // Console.WriteLine(Collision.hopp);

        }
        // when dead
        if (scene == "dead")
        {
            Raylib.ClearBackground(Color.Yellow);
            Raylib.DrawText("Press space to try again", 150, 310, 35, Color.Black);
            Raylib.DrawText("I SAID AVOID THE DARK GREEN RECTANGLES", 120, 370, 35, Color.Black);

            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                // If you press space game is restarted
                player.Character.Y = 500;
                player.Character.X = 100;
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

            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                // also restarts the game. If you want to play again
                player.Character.Y = 500;
                player.Character.X = 100;
                scene = "play";
            }

        }
    }

}