using System;

namespace GameEngine
{
    public class GameService
    {
        public const int MaxMoves = 128;
        private readonly Player _currentMovePlayer;

        public GameService(Player currentMovePlayer)
        {
            _currentMovePlayer = currentMovePlayer;
        }

        // TODO: Brain exercise :) Without changing Process method signature, change
        // ProcessCommand to use pattern matching and as little ifs as possible 
        // (or none at all, the best solution!)
        public bool ProcessCommand(CommandDTO command) => command switch
        {
            null => throw new ArgumentNullException(nameof(command)),
            var (_, p, _) when p != _currentMovePlayer => throw new InvalidMoveException("Invalid player side"),
            { Index: > MaxMoves or < 0 } => throw new InvalidMoveException("Invalid game index"),
            _ => Process(command.PlayerSide, (uint)command.Index, command.Move)
        };

        private bool Process(Player player, uint index, MoveType move)
        {
            Console.WriteLine($"[#{index:D3}] {player} make {move} move.");
            return true;
        }
    }
}