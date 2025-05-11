namespace Chess;
using Chess.Model;
public class MoveValidator
{
    private readonly Board _board;
    public MoveValidator(Board board) => _board = board;

    public bool IsMoveLegal(Move move)
    {
        var piece = _board.GetPieceAt(move.From);
        if (piece == null) return false;
        return piece.IsValidMove(move, _board);
    }
}