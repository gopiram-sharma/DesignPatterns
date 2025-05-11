namespace Chess.Model;

public abstract class Piece
{
    public bool IsWhite { get; }
    protected Piece(bool isWhite) => IsWhite = isWhite;
    public abstract bool IsValidMove(Move move, Board board);
}