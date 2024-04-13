using Chess.Chess.Board;
using Chess.Chess.Utils;
using SFML.Graphics;
using SFML.Window;

namespace Chess.Game
{
    public class Game
    {
        Board b;
        public Game()
        {
            b = new Board(8,8);
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
