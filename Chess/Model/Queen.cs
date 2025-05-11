namespace Chess.Model;

public class Queen : Piece
{
    public Queen(bool isWhite) : base(isWhite) { }

    public override bool IsValidMove(Move move, Board board)
    {
        var bishop = new Bishop(IsWhite);
        var rook = new Rook(IsWhite);
        return bishop.IsValidMove(move, board) || rook.IsValidMove(move, board);
    }
}