using SFML.Graphics;
using SFML.System;
using static Chess.Chess.Board.BoardConstants;



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

        public void initSprite()
        {
            _sprite.Position = new Vector2f(100, 100);
            _sprite.Origin = new Vector2f(_sprite.Origin.X + TILE_LENGTH / 2, _sprite.Origin.Y + TILE_LENGTH / 2);
        }

        public bool Selected { get { return _selected; } }
        public Sprite rect { get { return _sprite; } }

        public virtual void onSelect(){}
        public virtual void onSelectedClick(){}
        public virtual void draw(){}
        public virtual void drawFlipped(){}

        public void setPosition(int x, int y)
        {
            _sprite.Position = new Vector2f(x + TILE_LENGTH / 2, y + TILE_LENGTH / 2);
        }
        public void setPosition(Vector2f pos)
        {
            _sprite.Position = new Vector2f(pos.X + TILE_LENGTH / 2, pos.Y + TILE_LENGTH / 2);
        }
    }
}
