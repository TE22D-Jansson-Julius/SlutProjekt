using Raylib_cs;
    using System.Numerics;


 public class Player
 {


 
    Rectangle player = new Rectangle (50,50,50,50);

Vector2 movement = new Vector2(0, 0);
float speed = 2;


 public void rörelse(){
movement.X = Vector2.Zero.X;

        if (Raylib.IsKeyDown(KeyboardKey.A))
         {
          movement.X = -1;
     }
        else if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            movement.X = 1;
        }
      
        if (movement.Length() > 0)
        {
            movement = Vector2.Normalize(movement) * speed;
        }

        player.X += movement.X;
        player.Y += movement.Y;
        }

}