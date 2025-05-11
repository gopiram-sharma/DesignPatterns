namespace Chess.Model;

public class Rook : Piece
{
    public Rook(bool isWhite) : base(isWhite) { }

    public override bool IsValidMove(Move move, Board board)
    {
        if (move.From.Row != move.To.Row && move.From.Col != move.To.Col)
            return false;

        int rowStep = move.To.Row == move.From.Row ? 0 : (move.To.Row > move.From.Row ? 1 : -1);
        int colStep = move.To.Col == move.From.Col ? 0 : (move.To.Col > move.From.Col ? 1 : -1);

        int row = move.From.Row + rowStep;
        int col = move.From.Col + colStep;

        while (row != move.To.Row || col != move.To.Col)
        {
            if (board.GetPieceAt(new Position(row, col)) != null) return false;
            row += rowStep;
            col += colStep;
        }

        var target = board.GetPieceAt(move.To);
        return target == null || target.IsWhite != IsWhite;
    }
}