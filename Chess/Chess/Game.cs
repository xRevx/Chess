using Chess.Chess.Board;
using Chess.Chess.Characters;
using Chess.Chess.Utils;
using SFML.Graphics;
using SFML.System;
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
            window.Closed += (sender, e) => window.Close();
            View view = new View(new FloatRect(0, 0, window.Size.X, window.Size.Y));
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Black);
                window.SetView(view);
                b.drawFlipped();
                window.Display();
            }
        }

    }
}
