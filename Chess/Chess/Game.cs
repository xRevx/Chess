using Chess.Chess.Board;
using Chess.Chess.Characters;
using Chess.Chess.Utils;
using SFML.Graphics;
using SFML.Window;

namespace Chess.Game
{
    public class Game
    {
        Board b;
        GamePiece pawn;
        public Game()
        {
            pawn = new Pawn(false, 1, 1);
            b = new Board(8,8);
            b.tiles[1, 1].assignGamePiece(pawn);
        }

        public void play()
        {
            var window = Main.window;
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Black);
                b.draw();
                window.Display();
            }
        }

    }
}
