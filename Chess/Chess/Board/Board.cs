using Chess.Chess.Characters;
using Chess.Chess.Utils;
using SFML.Graphics;
using SFML.Window;
using static Chess.Chess.Board.BoardConstants;


namespace Chess.Chess.Board
{
    internal class Board
    {
        public int _boardWidth, _boardHeight, _screenWidth, _screenHeight;
        public Tile[,] tiles;
        IntRect _boardBounds;
        private bool isFlipped;

        public Board(int width = 8, int height = 8)
        {
            clampBoard(width, height);
            _screenWidth = _boardWidth * TILE_LENGTH;
            _screenHeight = _boardHeight * TILE_LENGTH;
            _boardBounds = new IntRect(0, 0, _screenWidth, _screenHeight);
            tiles = new Tile[_boardWidth, _boardHeight];
            initBoard();
            Main.window.MouseButtonPressed += OnMouseButtonPressed;
            isFlipped = false;

        }

        public void clampBoard(int width, int height)
        {
            _boardHeight = Math.Clamp(height, MIN_TILES_HEIGHT, MAX_TILES_HEIGHT);
            _boardWidth = Math.Clamp(width, MIN_TILES_WIDTH, MAX_TILES_WIDTH);
        }

        public void draw(View view)
        {
            isFlipped = false;
            view.Rotation = 0;
            foreach (Tile t in tiles)
            {
                t.draw();
            }
        }

        public void drawFlipped(View view)
        {
            isFlipped = true;
            view.Rotation = 180;
            foreach (Tile t in tiles)
            {
                t.drawFlipped();
            }
        }

        private void initBoard()
        {
            for(int i = 0; i < _boardWidth; i++)
            {
                for(int j = 0; j < _boardHeight; j++)
                {
                    tiles[i, j] = new Tile(i + 1, j + 1); //not zero indexed
                }
            }

            initPawns();

        }

        private void initPawns()
        {
            for(int i = 0; i < _boardWidth; i++)
            {
                tiles[i, 1].assignGamePiece(new Pawn(false, 1, i));
                tiles[i, _boardHeight-2].assignGamePiece(new Pawn(true, 1, i));
            }
        }

        private void OnMouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            // Check if the mouse click occurred within the boundaries of the tile
            if (_boardBounds.Contains(e.X, e.Y))
            {
                Tile t;
                int tile_x = e.X / TILE_LENGTH;
                int tile_y = e.Y / TILE_LENGTH;
                if (isFlipped)
                {
                   t = tiles[_screenWidth / TILE_LENGTH - tile_x - 1, _screenHeight / TILE_LENGTH - tile_y - 1];
                }
                else
                {
                    t = tiles[ tile_x, tile_y];
                }
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
