namespace Chess.Model;

public class King : Piece
{
    public King(bool isWhite) : base(isWhite) { }

    public override bool IsValidMove(Move move, Board board)
    {
        int rowDiff = Math.Abs(move.To.Row - move.From.Row);
        int colDiff = Math.Abs(move.To.Col - move.From.Col);

        if (rowDiff > 1 || colDiff > 1) return false;

        var target = board.GetPieceAt(move.To);
        return target == null || target.IsWhite != IsWhite;
    }
}