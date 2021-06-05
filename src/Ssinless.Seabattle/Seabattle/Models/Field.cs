﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seabattle.Models
{
    public class Field
    {
        public static int Width { get; }
        public static int Height { get; }
        public static int Gap { get; }

        static Field()
        {
            Width = Height = 10;
            Gap = 2;
        }

        public static implicit operator Cell[,](Field field) => field._cells;

        private readonly Cell[,] _cells;

        public Cell this[int y, int x] => _cells[y, x];

        public Field()
        {
            _cells = new Cell[Field.Height, Field.Width];

            for (var i = 0; i < Field.Height; i++)
                for (var j = 0; j < Field.Width; j++)
                    _cells[i, j] = new Cell(i, j);
        }
    }
}
