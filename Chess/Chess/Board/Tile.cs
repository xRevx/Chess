using Chess.Chess.Utils;
using Chess.Chess.Board;
using SFML.Graphics;
using SFML.System;
using static Chess.Chess.Board.BoardConstants;

namespace Chess.Chess.Board
{
    public class Tile
    {
        int _row, _column;
        RectangleShape r;

        public Tile(int row, int column)
        {
            _row = row;
            _column = column;
            r = new RectangleShape(new Vector2f(TILE_LENGTH, TILE_LENGTH));
            r.Position = new Vector2f((_row - 1) * TILE_LENGTH, (_column - 1) * TILE_LENGTH);
            r.FillColor = assignColor(_row, _column);
        }

        public void draw()
        {
            var window = Main.window;
            window.Draw(r);
        }

        public Color assignColor(int row, int column)
        {
            bool isWhite = (row + column) % 2 == 0;

            if (isWhite) return white;
            return black;
        }
    }
}
