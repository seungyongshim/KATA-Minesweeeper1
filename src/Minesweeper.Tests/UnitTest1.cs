namespace Minesweeper.Tests;

public class CellSpec
{
    [Fact]
    public void IsBomb()
    {
        var sut = new Cell();
        var ret = sut.SetBomb();

        Assert.Equal("*", ret.ToString());
    }
}
