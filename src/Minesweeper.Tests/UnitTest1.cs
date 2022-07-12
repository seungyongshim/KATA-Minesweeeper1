namespace Minesweeper.Tests;

public class CellSpec
{
    [Fact]
    public void IsBomb()
    {
        var sut = new Cell();
        
        sut.SetBomb();

        sut.Click();

        Assert.Equal("*", sut.ToString());
    }

    [Fact]
    public void Number()
    {
        var sut = new Cell();
        sut.AddNumber();
        sut.AddNumber();
        sut.AddNumber();

        sut.Click();

        Assert.Equal("3", sut.ToString());
    }

    [Fact]
    public void Covered()
    {
        var sut = new Cell();

        Assert.Equal(".", $"{sut}");
    }

}
