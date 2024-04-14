using SFML.Graphics;
using SFML.System;

namespace Chess.Chess.Characters
{
    public class GamePiece
    {
        protected int _row, _column;
        protected bool _isWhite;
        protected bool _selected;
        protected Sprite _sprite;
        protected Texture _texture;
        public GamePiece() { }

        public GamePiece(bool isWhite, int row, int column)
        {
            _row = row;
            _column = column;
            _isWhite = isWhite;
            _selected = false;
        }

        public bool Selected { get { return _selected; } }
        public Sprite rect { get { return _sprite; } }

        public virtual void onSelect(){}
        public virtual void onSelectedClick(){}
        public virtual void draw(){}
    }
}
