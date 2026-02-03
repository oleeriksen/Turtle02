using System;
using Turtle02.Model;

namespace Turtle02.Drawings
{
	public class SquareDrawing
	{
        public void DrawSquare(ITurtle t, double width, int level)
        {
            var nw = width / 3;
            if (level == 0 || nw < 3)
                t.Move(width);
            else
            {
                
                DrawSquare(t, nw, level - 1);
                t.Turn(-90);
                DrawSquare(t, nw, level - 1);
                t.Turn(90);
                DrawSquare(t, nw, level - 1);
                t.Turn(90);
                DrawSquare(t, nw, level - 1);
                t.Turn(-90);
                DrawSquare(t, nw, level - 1);
            }
        }
    }
}

