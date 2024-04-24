using Chess.Chess.Utils;
using SFML.Graphics;
using SFML.System;
using static Chess.Chess.Board.BoardConstants;


namespace Chess.Chess.Board.boardVisuals
{
    public class DrawAbleChessVisuals
    {
        public static void drawOnTiles(Queue<(int, int)> tileCoordinates, Shape drawable)
        {
            var winodw = Main.window;

            foreach (var coordinate in tileCoordinates)
            {
                int row = coordinate.Item1;
                int column = coordinate.Item2;

                setPosition(row, column,drawable);
                winodw.Draw(drawable);
            }

            tileCoordinates.Clear();
        }
        public static void drawOnTile(int row, int column, Shape drawable)
        {
            var winodw = Main.window;

            setPosition(row, column, drawable);
            winodw.Draw(drawable);

        }

        private static void setPosition(int row, int column,Shape drawable)
        {
            drawable.Position = new SFML.System.Vector2f(row * TILE_LENGTH + TILE_LENGTH/2, column * TILE_LENGTH + TILE_LENGTH/2);
        }
    }
}
