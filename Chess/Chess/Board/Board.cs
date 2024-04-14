using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void draw()
        {
            foreach(Tile t in tiles)
            {
                t.draw();
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
        }
    }
}
