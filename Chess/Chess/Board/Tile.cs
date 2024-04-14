using Chess.Chess.Utils;
using Chess.Chess.Board;
using SFML.Graphics;
using SFML.System;
using static Chess.Chess.Board.BoardConstants;
using Chess.Chess.Characters;
using SFML.Window;

namespace Chess.Chess.Board
{
    public class Tile
    {
        private int _row, _column;
        private RectangleShape r;
        private GamePiece _gamePiece;
        private bool _marked;

        public Tile(int row, int column)
        {
            _row = row;
            _column = column;
            r = new RectangleShape(new Vector2f(TILE_LENGTH, TILE_LENGTH));
            r.Position = new Vector2f((_row - 1) * TILE_LENGTH, (_column - 1) * TILE_LENGTH);
            r.FillColor = assignColor(_row, _column);
            _gamePiece = new GamePiece();
            _marked = false;
            Main.window.MouseButtonPressed += OnMouseButtonPressed;
        }

        public void draw()
        {
            var window = Main.window;
            window.Draw(r);
            _gamePiece.draw();
        }
        public void drawFlipped()
        {
            var window = Main.window;
            window.Draw(r);
            _gamePiece.drawFlipped();
        }

        public Color assignColor(int row, int column)
        {
            bool isWhite = (row + column) % 2 == 0;

            if (isWhite) return white;
            return black;
        }

        public void assignGamePiece(GamePiece gamePiece)
        {
            _gamePiece = gamePiece;
            _gamePiece.rect.Position = r.Position;
        }

        private void OnMouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            // Check if the mouse click occurred within the boundaries of the tile
            if (r.GetGlobalBounds().Contains(e.X, e.Y))
            {
                if (e.Button == Mouse.Button.Left)
                {
                    // Left mouse button clicked
                    onClickLeftClick();
                }
                else if (e.Button == Mouse.Button.Right)
                {
                    // Right mouse button clicked
                    if (!_marked)
                    {
                        r.FillColor = Color.Red;
                    }
                    else
                    {
                        r.FillColor = assignColor(_row, _column);
                    }
                    _marked = !_marked;

                }
            }
        }
        public void onClickLeftClick()
        {
            if (!_gamePiece.Selected)
            {
                _gamePiece.onSelect();
            }
            else
            {
                _gamePiece.onSelectedClick();
            }
        }
    }
}
