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

        public void onSelect(){ }
        public void onSelectedClick() { }
        public void draw() { }
    }
}
