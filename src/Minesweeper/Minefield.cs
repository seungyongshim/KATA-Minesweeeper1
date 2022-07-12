namespace Minesweeper;

public class Minefield
{
    public Cell[] Cells { get; }

    public Minefield(int width, int height)
    {
        Width = width;
        Height = height;


        Cells = new Cell[width * height];

        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                Cells[i + j * Width] = new ();
            }
        }
    }

    public int Height { get; }

    public int Width { get;  }

    public override string ToString()
    {
        return Cells.Aggregate("", (s, cell) => s + cell.ToString());
    }
}
