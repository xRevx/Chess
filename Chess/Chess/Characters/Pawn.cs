using SFML.Graphics;
using Chess.Chess.Utils;
using SFML.System;
using Chess.Chess.Board.boardVisuals;


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
        }
        public override void drawFlipped()
        {
            var window = Main.window;
            _sprite.Rotation = 180;
            window.Draw(_sprite);
        }

        public override void onSelect()
        {
            Queue<(int, int)> tilesToDrawOn = new Queue<(int, int)>();
            tilesToDrawOn.Enqueue((_row + 1, _column + 1));
            PathCircle.drawOnTiles(tilesToDrawOn);
            Console.WriteLine("drawing");
            _selected = true;
        }

        public override void onSelectedClick()
        {
            Queue<(int, int)> tilesToDrawOn = new Queue<(int, int)>();
            tilesToDrawOn.Enqueue((_row + 1, _column + 1));
            PathCircle.drawOnTiles(tilesToDrawOn);
            Console.WriteLine("drawing");
            _selected = true;



        }
    }
}
