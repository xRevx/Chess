using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Chess.Board
{
    internal class BoardConstants
    {
        public static readonly int TILE_LENGTH = 100;

        public static readonly int MAX_TILES_WIDTH = 12;
        public static readonly int MIN_TILES_WIDTH = 2;
        public static readonly int MIN_TILES_HEIGHT = 5;
        public static readonly int MAX_TILES_HEIGHT = 10;

        public static readonly Color white = new Color(235, 236, 208);
        public static readonly Color black = new Color(119, 149, 86);

        public static readonly Color circleColor = new Color(0, 0, 0, 25);
        public static readonly int possiableMoveRadius = 15;
        public static CircleShape getPossiableMoveCircle()
        {

            CircleShape possiableMove = new CircleShape(possiableMoveRadius);
            possiableMove.Origin = new SFML.System.Vector2f(possiableMove.Radius, possiableMove.Radius);
            possiableMove.FillColor = circleColor;
            possiableMove.Position = new SFML.System.Vector2f(100, 100);
            return possiableMove;
        }
        public static readonly CircleShape possiableMoveCirce = getPossiableMoveCircle();


    }

}
