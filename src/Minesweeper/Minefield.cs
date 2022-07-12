namespace Minesweeper;

public class Minefield
{
    public Cell[] Cells { get; }

    public Minefield(int width, int height)
    {
        Width = width;
        Height = height;


        Cells = Enumerable.Range(0, width * height)
                          .Select(i => new Cell())
                          .ToArray();
    }

    public int Height { get; }

    public int Width { get;  }

    public override string ToString()
    {
        return Cells.Aggregate("", (s, cell) => s + cell.ToString());
    }
}
