using Raylib_cs;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


public class Player
{


    public Vector2 movement = new Vector2(0, 0);

    public float Jump = -10;
    // int start;

    // adds gravity 
    public float Gravity = +0.3f;

    public Rectangle Character = new Rectangle(100, 500, 50, 50);

public void Svår()
{
    Console.WriteLine();
}

    public void Move(WallsC wall)
    {

        // if (player.X >= 800)
        // {
        //     player.X = 799;
        //     movement.X = 0;
        //     WallsC.start -= 1;   
        // }
        // foreach (Rectangle a in wall1)

        // Character movement left and right 
        movement.X = Vector2.Zero.X;

        if (Raylib.IsKeyDown(KeyboardKey.A))
        {
            movement.X = -3;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            movement.X = 3;
        }

        // if you are on the floor jump = true, and you can jump
        bool jumpT = false;
        jumpT = Collision.CanJump;
        if (jumpT)
        {
            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                movement.Y = Jump;
                Collision.CanJump = false;
            }
        }

        // applies the movement to the character 
        Character.X += movement.X;
        Character.Y += movement.Y;
        movement.Y += Gravity;

    }

}
// && player.Y = 1080