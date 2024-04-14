using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Chess.Characters
{
    public abstract class GamePiece
    {
        int _row, _column;
        bool _selected;

        public bool Selected { get { return Selected; } }

        public abstract void onSelect(); 
        public abstract void onSelectedClick(); 
        public abstract void draw();
    }
    public class EmptyPiece : GamePiece
    {
        public override void onSelect() { }
        public override void onSelectedClick() { }
        public override void draw() { }
    }
}
