using Chess.Chess.Characters;
using Chess.Chess.Utils;
using SFML.Graphics;
using SFML.Window;

namespace Chess.Chess.Board
{
    internal class Board
    {
        int _width, _height;
        public Tile[,] tiles;

        public Board(int width = 8, int height = 8)
        {
            _width = width;
            _height = height;
            tiles = new Tile[_width, _height];
            initBoard();
        }

        public void draw(View view)
        {
            view.Rotation = 0;
            foreach (Tile t in tiles)
            {
                t.draw();
            }
        }

        public void drawFlipped(View view)
        {
            view.Rotation = 180;
            foreach (Tile t in tiles)
            {
                t.drawFlipped();
            }
        }

        private void initBoard()
        {
            for(int i = 1; i <= _width; i++)
            {
                for(int j = 1; j <= _height; j++)
                {
                    tiles[i-1, j-1] = new Tile(i, j);
                }
            }

            initPawns();
        }

        private void initPawns()
        {
            for(int i = 0; i < _width; i++)
            {
                tiles[i, 1].assignGamePiece(new Pawn(false, 1, i));
                tiles[i, _width-2].assignGamePiece(new Pawn(true, 1, i));
            }
        }
    }
}
