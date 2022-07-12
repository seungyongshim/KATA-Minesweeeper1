namespace Minesweeper;

public class Cell
{
    public bool IsCovered { get; set; } = true;

    public void SetBomb() => IsBomb = true;

    public bool IsBomb { get; set; }

    public override string ToString() => (IsCovered, IsBomb) switch
    {
        (true, _) => ".",
        (false, true) => "*",
        (false, false) => Number.ToString(),
    };


    public void AddNumber() => Number++;

    public int Number { get; set; }

    public void Click() => IsCovered = false;
}
