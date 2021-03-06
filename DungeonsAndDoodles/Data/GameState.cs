﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Text;

namespace DungeonsAndDoodles
{
    // Stores data that is shared between classes and UI elements
    public class GameState
    {
        public string SavedStateFilePath = null;
        public string MapImageFile = null;
        public PrivateFontCollection FontCollection;
        public FontFamily MapFontFamily;
        public Font MapLabelsFont;
        public TokenLibraryCollection TokenLibrary = new TokenLibraryCollection();
        public MapTokenCollection ActiveTokens = new MapTokenCollection();
    }
}
