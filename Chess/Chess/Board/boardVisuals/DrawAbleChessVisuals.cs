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
            //Vector2f origin = drawable.Origin;
            //drawable.Origin = new Vector2f(origin.X + drawable.Scale.X / 2, origin.Y + drawable.Scale.Y / 2);
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

        private static void setPosition(int row, int column,Shape drawable)
        {
            drawable.Position = new SFML.System.Vector2f(row * TILE_LENGTH + TILE_LENGTH/2, column * TILE_LENGTH + TILE_LENGTH/2);
        }
    }
}
