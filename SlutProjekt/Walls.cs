using Raylib_cs;
using System.Numerics;



public class WallsC
{
    //creates lists of rectangles for the 3d array
    public List<Rectangle> Floor = new();
    public List<Rectangle> Goals = new();
    public List<Rectangle> Pole = new();
    public List<Rectangle> Dirt = new();
    public List<Rectangle> Sun = new();
    // bool Map = true;
    // public Rectangle wall = new Rectangle(0, 60, 60, 60);

    public static int Start = 0;
    // public void Bana()
    // {
    //     if (Map)
    //     {
    //     }
    // }

    // method with the logic for the logic that makes the map
    public void Logic()
    {
        // 0 = air
        // 1 = floor
        // 2 = danger
        // 3 = goal
        // 4 = dirt
        // 5 = sun
        
        // Using an array instead of list since it is faster and you can't have a 2D list.
        int[,] Grid = {
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
        for (var x = Start; x < Grid.GetLength(1); x++)
        {
            for (var y = 0; y < Grid.GetLength(0); y++)
            {
                if (Grid[y, x] == 1)
                {
                    Floor.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
                if (Grid[y, x] == 3)
                {

                    Goals.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
                if (Grid[y, x] == 2)
                {

                    Pole.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
                if (Grid[y, x] == 4)
                {

                    Dirt.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
                if (Grid[y, x] == 5)
                {

                    Sun.Add(new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize));
                }
            }
        }
    }

    public void Draw()
    {
        // draws the rectangles in the 3D Array
        // draws the floor
        foreach (Rectangle f in Floor)
        {
            Raylib.DrawRectangleRec(f, Color.Green);
            Raylib.DrawRectangleLinesEx(f, 1, Color.DarkGreen);
        }
        // draws the goals
        foreach (Rectangle g in Goals)
        {
            Raylib.DrawRectangleRec(g, Color.Purple);
            Raylib.DrawRectangleLinesEx(g, 1, Color.Red);

        }
        // draws the pole
        foreach (Rectangle p in Pole)
        {
            Raylib.DrawRectangleRec(p, Color.DarkGreen);
            Raylib.DrawRectangleLinesEx(p, 1, Color.Green);

        }
        // draws the dirt
        foreach (Rectangle d in Dirt)
        {
            Raylib.DrawRectangleRec(d, Color.Brown);
            Raylib.DrawRectangleLinesEx(d, 1, Color.DarkBrown);
        }
        // draws the sun
        foreach (Rectangle s in Sun)
        {
            Raylib.DrawRectangleRec(s, Color.Yellow);
            Raylib.DrawRectangleLinesEx(s, 1, Color.Orange);
        }

    }
}


