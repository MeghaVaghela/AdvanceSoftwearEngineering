﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{
    interface designInterface
    {
        void set(params int[] list);

        void setTriangle(int x, int y, Point[] points);

        void Draw(Graphics graph, Pen pen, Brush brush);
    }
}
