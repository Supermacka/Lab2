﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Labb2_Library
{
    public abstract class Shape3D : Shape
    {
        public abstract float Volume { get; }
    }
}
