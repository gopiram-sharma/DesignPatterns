namespace Chess.Model;

public class Pawn : Piece
{
    public Pawn(bool isWhite) : base(isWhite) { }

    public override bool IsValidMove(Move move, Board board)
    {
        int dir = IsWhite ? -1 : 1;
        int startRow = IsWhite ? 6 : 1;

        int rowDiff = move.To.Row - move.From.Row;
        int colDiff = Math.Abs(move.To.Col - move.From.Col);

        var target = board.GetPieceAt(move.To);

        if (colDiff == 0 && target == null)
        {
            if (rowDiff == dir) return true;
            if (move.From.Row == startRow && rowDiff == 2 * dir && board.GetPieceAt(new Position(move.From.Row + dir, move.From.Col)) == null)
                return true;
        }
        else if (colDiff == 1 && rowDiff == dir && target != null && target.IsWhite != IsWhite)
        {
            return true;
        }

        return false;
    }
}