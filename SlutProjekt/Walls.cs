using Raylib_cs;
using System.Numerics;



public class WallsC
{
    public  List<Rectangle> floor = new();
  
    public  List<Rectangle> goals = new();

     public  List<Rectangle> pole = new();
    bool map = true;
    public Rectangle wall = new Rectangle(0, 60, 60, 60);

    public void bana()
    {
        if (map)
        {
        }
    }

    public void wall1()
    {
        int[,] grid = {
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,1,0,0,0,0,0,0,2,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,2,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
     };



        int tileSize = 50;

        for (var x = 0; x < grid.GetLength(1); x++)
        {
            for (var y = 0; y < grid.GetLength(0); y++)
            {
                if (grid[y, x] == 1)
                {
                    floor.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
                if (grid[y, x] == 3)
                {

                    goals.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
                    if (grid[y, x] == 2)
                {

                    pole.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
            }
        }
    }
    public void wall2()
    {


        foreach (Rectangle f in floor)
        {
            Raylib.DrawRectangleRec(f, Color.Green);
            Raylib.DrawRectangleLinesEx(f, 1, Color.DarkGreen);
        }
        foreach (Rectangle g in goals)
        {
            Raylib.DrawRectangleRec(g, Color.Purple);
            Raylib.DrawRectangleLinesEx(g, 1, Color.Red);

 }
foreach (Rectangle p in pole)
        {
            Raylib.DrawRectangleRec(p, Color.DarkGreen);
            Raylib.DrawRectangleLinesEx(p, 1, Color.Green);

        }
       
    }
}


