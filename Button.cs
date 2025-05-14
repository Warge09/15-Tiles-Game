using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Button
{
    abstract class Button
    {

        public string name;
        

        public Button(string name)
        {
            this.name = name;
        }

    }

    ~Button()
    {
        // Destructor
    }
}
