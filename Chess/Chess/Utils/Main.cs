using SFML.Graphics;
using SFML.Window;

namespace Chess.Chess.Utils
{
    public static class Main
    {
        private static RenderWindow _window = new RenderWindow(new VideoMode(800, 800), "chess.com");
        public static RenderWindow window { get { return _window; } }
    }

    public static class Graphics
    {
        private static string imagesFolderPath = "C:\\Users\\USER\\source\\repos\\Chess\\Chess\\Chess\\Characters\\Images\\";
        public static Texture getTexture(bool isWhite, string name)
        {
            string textureName = (isWhite ? "w" : "b") + name;
            string filePath = imagesFolderPath + textureName + ".png";
            return new Texture(filePath);
        }
    }

}
