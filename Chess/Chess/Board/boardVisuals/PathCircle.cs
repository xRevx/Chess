﻿using Chess.Chess.Utils;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Chess.Chess.Board.BoardConstants;


namespace Chess.Chess.Board.boardVisuals
{
    public static class PathCircle
    {
        public static int radius = 15;

        public static readonly Color circleColor = new Color(0, 0, 0, 50);
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

        public static void drawOnTiles(Queue<(int,int)> tileCoordinates)
        {
            DrawAbleChessVisuals.drawOnTiles(tileCoordinates, possiableMoveCirce); 
        }

    }
}
