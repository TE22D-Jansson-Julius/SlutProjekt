using Raylib_cs;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


public class Player
{


    public Vector2 movement = new Vector2(0, 0);

    public float jump = -12;
    public float gravity = +0.3f;

    public Rectangle player = new Rectangle(300, 300, 50, 50);


    public void rörelse()
    {



        movement.X = Vector2.Zero.X;

        if (Raylib.IsKeyDown(KeyboardKey.A))
        {
            movement.X = -3;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            movement.X = 3;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            movement.Y = jump;
        }



        player.X += movement.X;
        player.Y += movement.Y;
        movement.Y += gravity;

    }

}
// && player.Y = 1080