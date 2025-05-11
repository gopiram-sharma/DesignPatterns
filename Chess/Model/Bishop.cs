namespace Chess.Model;

public class Bishop : Piece
{
    public Bishop(bool isWhite) : base(isWhite) { }

    public override bool IsValidMove(Move move, Board board)
    {
        int rowDiff = move.To.Row - move.From.Row;
        int colDiff = move.To.Col - move.From.Col;

        if (Math.Abs(rowDiff) != Math.Abs(colDiff)) return false;

        int rowStep = rowDiff > 0 ? 1 : -1;
        int colStep = colDiff > 0 ? 1 : -1;

        int row = move.From.Row + rowStep;
        int col = move.From.Col + colStep;

        while (row != move.To.Row && col != move.To.Col)
        {
            if (board.GetPieceAt(new Position(row, col)) != null) return false;
            row += rowStep;
            col += colStep;
        }

        var target = board.GetPieceAt(move.To);
        return target == null || target.IsWhite != IsWhite;
    }
}