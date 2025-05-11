using Chess;
using Chess.Model;

var board = new Board();
var validator = new MoveValidator(board);

// Example move: White pawn from e2 to e4
var move = new Move(Position.FromAlgebraic("e2"), Position.FromAlgebraic("e4"));

if (validator.IsMoveLegal(move))
{
    Console.WriteLine("Move is legal");
    board.MovePiece(move);
}
else
{
    Console.WriteLine("Move is illegal");
}

move = new Move(Position.FromAlgebraic("f1"), Position.FromAlgebraic("c4"));

if (validator.IsMoveLegal(move))
{
    Console.WriteLine("Move is legal");
    board.MovePiece(move);
}
else
{
    Console.WriteLine("Move is illegal");
}