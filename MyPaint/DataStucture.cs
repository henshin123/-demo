﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyPaint
{
    class DataStucture
    {
        public class Line
        {
            public int ID;
            public int[] Point = new int[2];
            public int[] Bor = new int[2];
        }
        public class Triangle
        {
            public int ID;
            public int[] Peak = new int[3];
            public Line[] Line = new Line[3];
            public int[] Bor = new int[3];

        }
    }
}
