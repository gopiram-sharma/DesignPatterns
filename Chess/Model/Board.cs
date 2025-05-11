namespace Chess.Model;

public class Board
{
    private Piece?[,] _grid = new Piece?[8, 8];

    public Board()
    {
        for (int col = 0; col < 8; col++)
        {
            _grid[6, col] = new Pawn(true);
            _grid[1, col] = new Pawn(false);
        }

        _grid[7, 0] = _grid[7, 7] = new Rook(true);
        _grid[0, 0] = _grid[0, 7] = new Rook(false);

        _grid[7, 1] = _grid[7, 6] = new Knight(true);
        _grid[0, 1] = _grid[0, 6] = new Knight(false);

        _grid[7, 2] = _grid[7, 5] = new Bishop(true);
        _grid[0, 2] = _grid[0, 5] = new Bishop(false);

        _grid[7, 3] = new Queen(true);
        _grid[0, 3] = new Queen(false);

        _grid[7, 4] = new King(true);
        _grid[0, 4] = new King(false);
    }

    public Piece? GetPieceAt(Position pos) => _grid[pos.Row, pos.Col];

    public void MovePiece(Move move)
    {
        var piece = GetPieceAt(move.From);
        _grid[move.From.Row, move.From.Col] = null;
        _grid[move.To.Row, move.To.Col] = piece;
    }
}