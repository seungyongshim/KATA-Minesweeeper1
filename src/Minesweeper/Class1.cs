namespace Minesweeper;

public class Cell
{
    public bool IsCovered { get; set; } = true;

    public void SetBomb()
    {
        IsBomb = true;
    }

    public bool IsBomb { get; set; }

    public override string ToString()
    {
        return (IsCovered, IsBomb) switch
        {
            (true, _) => ".",
            (false, true) => "*",
            (false, false) => Number.ToString(),
        };
    }

    public void AddNumber()
    {
        Number++;
    }

    private int m_number;

    public int Number
    {
        get
        {
            return m_number;
        }
        set
        {
            m_number = value;
        }
    }

    public void Click()
    {
        IsCovered = false;
    }
}
