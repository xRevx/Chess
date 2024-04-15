using Chess.Chess.Characters;
using Chess.Chess.Utils;
using SFML.Graphics;
using SFML.Window;
using static Chess.Chess.Board.BoardConstants;


namespace Chess.Chess.Board
{
    internal class Board
    {
        int _width, _height;
        public Tile[,] tiles;
        IntRect _boardBounds;

        public Board(int width = 8, int height = 8)
        {
            _width = width;
            _height = height;
            _boardBounds = new IntRect(0, 0, _width * TILE_LENGTH, _height * TILE_LENGTH);
            tiles = new Tile[_width, _height];
            initBoard();
            Main.window.MouseButtonPressed += OnMouseButtonPressed;

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
            for(int i = 0; i < _width; i++)
            {
                for(int j = 0; j < _height; j++)
                {
                    tiles[i, j] = new Tile(i + 1, j + 1); //not zero indexed
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

        private void OnMouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
           
            // Check if the mouse click occurred within the boundaries of the tile
            if (_boardBounds.Contains(e.X, e.Y))
            {
                Tile t = tiles[_width - 1 - e.X / TILE_LENGTH,_height - 1 - e.Y / TILE_LENGTH];
                if (e.Button == Mouse.Button.Left)
                {
                    // Left mouse button clicked
                    t.gamePieceAction();
                }
                else if (e.Button == Mouse.Button.Right)
                {
                    // Right mouse button clicked
                    t.markTile();
                }
            }
        }
    }
}
