﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{
    internal class drawRectangle
    {
        private int width;
        private int height;

        public drawRectangle(int x, int y, int width, int height) : base(x, y)
        { 
            this.width = width; 
            this.height = height; 
        }

        public drawRectangle() { }

        public override void set(Parameter int[] list)
        {
            base.set(list[0], list[1]);
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.FillRectangle(brush, this.width, this.height);
            graph.DrawRectangle(pen, this.width, this.height);
        }

    }
}
