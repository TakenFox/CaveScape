﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace CaveScape
{
    class Block
    {
        Rectangle pos;
        Color col;
        Texture2D tex;

        public Block(Rectangle p)
        {
            pos = p;
        }

        public Rectangle getPos()
        {
            return pos;
        }

        public void Draw()
        {

        }
    }
}
