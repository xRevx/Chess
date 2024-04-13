using SFML.Graphics;
using SFML.Window;

namespace Chess.Chess.Utils
{
    public static class Main
    {
        private static RenderWindow _window = new RenderWindow(new VideoMode(800, 800), "chess.com");
        public static RenderWindow window { get { return _window; } }
    }
}
