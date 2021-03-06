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
        public Rectangle pos;
        public Color col;
        public String type;
        public Texture2D tex;

        public Block(Rectangle p, Color col, String type)
        {
            pos = p;
            this.col = col;
            this.type = type;
        }

        public bool checkScreen()
        {
            if (pos.X <= 0 - pos.Width || pos.X >= 1800 || pos.Y <= 0 - pos.Height || pos.Y >= 900)
                return false;
            else
                return true;
        }

        public void moveX(int m)
        {
            pos.X += m;
        }

        public void moveY(int m)
        {
            pos.Y += m;
        }

        public Rectangle getPos()
        {
            return pos;
        }

        public Color getCol()
        {
            return col;
        }

        public void Draw()
        {

        }

        public String getType()
        {
            return type;
        }

        public Color getColor()
        {
            return col;
        }
    }
}
