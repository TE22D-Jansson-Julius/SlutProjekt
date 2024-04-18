using Raylib_cs;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


public class Player
{


    public Vector2 movement = new Vector2(0, 0);

    public float jump = -10;
    public float gravity = +0.3f;

    public Rectangle player = new Rectangle(100, 500, 50, 50);


    public void rörelse(WallsC wall)
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
       
       bool jumpT = false;
       jumpT = Collision.hopp;
       if (jumpT)
       {
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            movement.Y = jump;
            Collision.hopp = false;
        }
}


        player.X += movement.X;
        player.Y += movement.Y;
        movement.Y += gravity;

    }

}
// && player.Y = 1080