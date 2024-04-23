using Raylib_cs;
using System.Numerics;



public class WallsC
{
    //creates lists of rectangles for the 3d array
    public List<Rectangle> floor = new();
    public List<Rectangle> goals = new();
    public List<Rectangle> pole = new();
    public List<Rectangle> dirt = new();
    public List<Rectangle> sun = new();
    bool map = true;
    // public Rectangle wall = new Rectangle(0, 60, 60, 60);

      public static int start= 0;
    public void bana()
    {
        if (map)
        {
        }
    }

// method with the logic for the logic that makes the map
    public void wall1()
    {
// 0 = air
// 1 = floor
// 2 = danger
// 3 = goal
// 4 = dirt
// 5 = sun
        int[,] grid = {
    {5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0},
    {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
    {4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4}
     };


// makes the rectangle X and Y 50
        int tileSize = 50;
// logic saying what to put and when
        for (var x = start; x < grid.GetLength(1); x++)
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
                if (grid[y, x] == 4)
                {

                    dirt.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
                if (grid[y, x] == 5)
                {

                    sun.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
            }
        }
    }

    public void wall2()
    {
// draws the rectangles in the 3D Array
// draws the floor
        foreach (Rectangle f in floor)
        {
            Raylib.DrawRectangleRec(f, Color.Green);
            Raylib.DrawRectangleLinesEx(f, 1, Color.DarkGreen);
        }
        // draws the goals
        foreach (Rectangle g in goals)
        {
            Raylib.DrawRectangleRec(g, Color.Purple);
            Raylib.DrawRectangleLinesEx(g, 1, Color.Red);

        }
        // draws the pole
        foreach (Rectangle p in pole)
        {
            Raylib.DrawRectangleRec(p, Color.DarkGreen);
            Raylib.DrawRectangleLinesEx(p, 1, Color.Green);

        }
// draws the dirt
         foreach (Rectangle d in dirt)
        {
            Raylib.DrawRectangleRec(d, Color.Brown);
            Raylib.DrawRectangleLinesEx(d, 1, Color.DarkBrown);
        }
        // draws the sun
         foreach (Rectangle s in sun)
        {
            Raylib.DrawRectangleRec(s, Color.Yellow);
            Raylib.DrawRectangleLinesEx(s, 1, Color.Orange);
        }

    }
}


