using SFML.Graphics;
using Chess.Chess.Utils;
using SFML.System;

namespace Chess.Chess.Characters
{
    public class Pawn : GamePiece
    {
        public Pawn(bool isWhite, int row, int column) : base(isWhite, row, column)
        {
            _texture = Graphics.getTexture(_isWhite, "pawn");
            _sprite = new Sprite(_texture);
            _sprite.Position = new Vector2f(100, 100);

        }
        public override void draw()
        {
            var window = Main.window;
            window.Draw(_sprite);
        }

        public override void onSelect()
        {
        }

        public override void onSelectedClick()
        {
        }
    }
}
