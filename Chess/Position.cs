namespace Chess;

public record Position(int Row, int Col)
{
    public static Position FromAlgebraic(string notation)
    {
        int col = notation[0] - 'a';
        int row = 8 - (notation[1] - '0');
        return new Position(row, col);
    }
}
