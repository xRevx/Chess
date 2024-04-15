using SFML.Graphics;
using SFML.Window;

namespace Chess.Chess.Utils
{
    public static class Main
    {
        private static RenderWindow _window = new RenderWindow(new VideoMode(1000, 1000), "chess.com");
        public static RenderWindow window { get { return _window; } }
    }

    public static class Graphics
    {
        private static string projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
        private static string imagesFolderPath = Path.Combine(projectDirectory,"Chess\\", "Characters", "Images\\");
        public static Texture getTexture(bool isWhite, string name)
        {
            string textureName = (isWhite ? "w" : "b") + name;
            string filePath = imagesFolderPath + textureName + ".png";
            return new Texture(filePath);
        }
    }

}
