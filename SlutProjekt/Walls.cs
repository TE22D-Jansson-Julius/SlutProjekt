using Raylib_cs;
using System.Numerics;



public class WallsC
{
    public  List<Rectangle> walls = new();
    List<Rectangle> goals = new();
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
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
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
                    walls.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
                if (grid[y, x] == 2)
                {

                    goals.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
            }
        }
    }
    public void wall2()
    {


        foreach (Rectangle w in walls)
        {
            Raylib.DrawRectangleRec(w, Color.Green);
            Raylib.DrawRectangleLinesEx(w, 1, Color.DarkGreen);
        }
        foreach (Rectangle g in goals)
        {
            Raylib.DrawRectangleRec(g, Color.Purple);
            Raylib.DrawRectangleLinesEx(g, 1, Color.Red);

        }
    }
}


