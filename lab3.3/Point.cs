﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33
{
    internal class Point
    {
        private int x = 0;
        private int y = 0;
        private string name;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
