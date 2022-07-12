namespace Minesweeper;

public class Cell
{

    public void SetBomb()
    {
        IsBomb = true;
    }

    public bool IsBomb { get; set; }

    public override string ToString()
    {
        if (IsBomb)
        {
            return "*";
        }

        return "";
    }
}
