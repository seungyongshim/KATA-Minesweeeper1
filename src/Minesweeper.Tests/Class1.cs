namespace Minesweeper.Tests;

public class MinefieldSpec
{
    [Fact]
    public void Init()
    {
        var sut = new Minefield(3, 4);

        Assert.Equal("............", $"{sut}");
    }
}
