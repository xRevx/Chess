using SFML.Graphics;
using Chess.Chess.Utils;
using SFML.System;
using Chess.Chess.Board.boardVisuals;
using Chess.Chess.Board;

namespace Chess.Chess.Characters
{
    public class Pawn : GamePiece
    {
        public Pawn(bool isWhite, int row, int column) : base(isWhite, row, column)
        {
            _texture = Graphics.getTexture(_isWhite, "pawn");
            _sprite = new Sprite(_texture);
            initSprite();
        }
        public override void draw()
        {
            var window = Main.window;
            _sprite.Rotation = 0;
            window.Draw(_sprite);
            if (_selected)
            {
                drawOnSelected();
            }
        }
        public override void drawFlipped()
        {
            var window = Main.window;
            _sprite.Rotation = 180;
            window.Draw(_sprite);
            if (_selected)
            {
                drawOnSelected();
            }
        }

        public void drawOnSelected()
        {
            Queue<(int, int)> tilesToDrawOn = new Queue<(int, int)>();
            int drawColumn = _column;
            int drawRow = _row + 1;
            if (_isWhite)
            {
                drawColumn = BoardConstants.Board_Height - _column;
                drawRow = BoardConstants.Board_Height - _row + 1;
                tilesToDrawOn.Enqueue((drawColumn, drawRow));

            }
            else
            {
                tilesToDrawOn.Enqueue((drawColumn, drawRow));

            }
            PathCircle.drawOnTiles(tilesToDrawOn);
            Console.WriteLine($"drawing on {drawColumn}, {drawRow}");

        }

        public override void onSelect()
        {
            _selected = true;
        }

        public override void onSelectedClick()
        {
            if (true)// is valid
            {
                _selected = false;
            }
        }
    }
}
