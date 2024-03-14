using Raylib_cs;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;


public class Player
{


 Vector2 movement = new Vector2(0, 0);
        float speed = 2;

float gravity = -5;

   public Rectangle player = new Rectangle(500, 500, 50, 50);


    public void rörelse()
    {



        movement.X = Vector2.Zero.X;

        if (Raylib.IsKeyDown(KeyboardKey.A))
        {
            movement.X = -1;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            movement.X = 1;
        }
        // if (Raylib.IsKeyPressed(KeyboardKey.Space))
        // {
        //     movement.Y = gravity;
        // }

        if (movement.Length() > 0)
        {
            movement = Vector2.Normalize(movement) * speed;
        }
        
// if (player.Y >= 1080){
//     gravity = 0;
// } 
// else if (player.Y < 1080){
//     gravity = +5;
// }
// player.Y += gravity;
       

        player.X += movement.X;
        player.Y += movement.Y;

        
    }

}