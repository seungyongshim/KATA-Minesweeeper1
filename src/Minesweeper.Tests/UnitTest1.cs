namespace Minesweeper.Tests;

public class CellSpec
{
    [Fact]
    public void IsBomb()
    {
        var sut = new Cell();
        sut.SetBomb();

        Assert.Equal("*", sut.ToString());
    }
}
