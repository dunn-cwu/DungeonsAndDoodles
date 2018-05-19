using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsAndDoodles
{
    // ========================================================

    public enum TokenType
    {
        Player,
        Enemy,
        NPC
    }

  // ========================================================

    // Struct to hold basic token data
    public struct TokenData
    {
        private string name;
        private TokenType tokenType;
        private int maxHP;
        private int currentHP;

        public int ArmorClass;
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;
        public string PictureFileName;

        public string Notes;

        public TokenData(string name, TokenType tokenType)
        {
            this.name = name;
            this.tokenType = tokenType;

            this.maxHP = 100;
            this.currentHP = 100;
            this.ArmorClass = 10;
            this.Strength = 10;
            this.Dexterity = 10;
            this.Constitution = 10;
            this.Intelligence = 10;
            this.Wisdom = 10;
            this.Charisma = 10;
            this.Notes = "";
            this.PictureFileName = "";
        }

        // Copy constructor
        public TokenData(ref TokenData other)
        {
            this.name = other.Name;
            this.tokenType = other.TokenType;

            this.maxHP = other.MaxHP;
            this.currentHP = other.CurrentHP;
            this.ArmorClass = other.ArmorClass;
            this.Strength = other.Strength;
            this.Dexterity = other.Dexterity;
            this.Constitution = other.Constitution;
            this.Intelligence = other.Intelligence;
            this.Wisdom = other.Wisdom;
            this.Charisma = other.Charisma;
            this.Notes = other.Notes;
            this.PictureFileName = other.PictureFileName;
        }


        public string Name
        {
            get { return this.name;  }
        }

        public TokenType TokenType
        {
            get { return this.tokenType; }
        }

        public int MaxHP
        {
            get { return this.maxHP; }
            set
            {
                // Ensure max hp is at least 1
                this.maxHP = value > 0 ? value : 1;

                // Ensure current hp is less than or equal to max hp
                this.currentHP = Math.Min(this.currentHP, this.maxHP);
            }
        }

        public int CurrentHP
        {
            get { return this.currentHP; }
            set
            {
                // Ensure current hp is at least 0
                this.currentHP = value >= 0 ? value : 0;

                // Ensure current hp is less than or equal to max hp
                this.currentHP = Math.Min(this.currentHP, this.maxHP);
            }
        }

        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) { return false; }

            return this.name.Equals(((TokenData)obj).Name);
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }
    }

    // ========================================================

    public enum TokenMouseState
    {
        Idle,
        Hover,
        Drag,
        Selected
    }

    public class MapToken
    {
        public static readonly Color COLOR_IDLE = Color.Red;
        public static readonly Color COLOR_HOVER = Color.Yellow;
        public static readonly Color COLOR_DRAG = Color.Green;
        public static readonly Color COLOR_SELECTED = Color.Gray;
        public static readonly float STRING_VERTICAL_PADDING = 2.0f;
        public static readonly float STRING_HORIZONTAL_PADDING = 5.0f;

        protected MapControl mapCtrl;
        protected TokenData tokenData;
        protected TokenMouseState mouseState = TokenMouseState.Idle;
        protected PointF position;
        protected bool selected = false;
        protected float scale = 1.0f;
        protected Image charImage = null;
        protected TokenListItemControl control = null;

        protected ViewStatsForm viewStatsForm;


        public MapToken(MapControl mapCtrl, ref TokenData tokenData, PointF mapPosition)
        {
            this.mapCtrl = mapCtrl;
            this.tokenData = new TokenData(ref tokenData);
            this.position = mapPosition;
            this.control = new TokenListItemControl(this);
        }



        // Copy constructor
        public MapToken(MapToken other)
        {
            TokenData otherTokenData = other.GetTokenData();

            this.mapCtrl = other.mapCtrl;
            this.tokenData = new TokenData(ref otherTokenData);
            this.position = other.Position;
        }

        public TokenData GetTokenData()
        {
            return this.tokenData;
        }

        public void SetTokenData(ref TokenData otherData)
        {
            this.tokenData = new TokenData(ref otherData);
            resetSprite();
            mapCtrl.Refresh();
        }

        public TokenListItemControl Control
        {
            get
            {
                return control;

            }
        }

        public int CurrentHP
        {
            get { return tokenData.CurrentHP; }
            set
            {
                tokenData.CurrentHP = value;
                control.UpdateData();
            }
        }

        public int MaxHP
        {
            get { return tokenData.MaxHP; }
            set
            {
                tokenData.MaxHP = value;
                control.UpdateData();
            }
        }

        public string Notes
        {
            get { return tokenData.Notes; }
            set { tokenData.Notes = value; }
        }

        public TokenType TokenType
        {
            get { return tokenData.TokenType; }
        }

        public PointF Position
        {
            get { return this.position; }
            set
            {
                RectangleF worldRect = mapCtrl.GetWorldUnitRect();
                PointF newPos = value;

                // Make sure token is within the bounds of the map
                if (mapCtrl.HasBackground && !worldRect.Contains(newPos))
                {
                    // Move token back onto map
                    newPos.X = Math.Min(Math.Max(0, newPos.X), worldRect.Width);
                    newPos.Y = Math.Min(Math.Max(0, newPos.Y), worldRect.Height);
                }

                if (mapCtrl.TokenSnapToGrid)
                {
                    // Snap token to nearest grid square
                    newPos.X = (float)Math.Floor(newPos.X - mapCtrl.GridHorizontalOffset) + 0.5f + mapCtrl.GridHorizontalOffset;
                    newPos.Y = (float)Math.Floor(newPos.Y - mapCtrl.GridVerticalOffset) + 0.5f + mapCtrl.GridVerticalOffset;

                    // Walk token back onto map
                    while(newPos.X < 0)
                    {
                        newPos.X += 1.0f;
                    }

                    while (newPos.X > worldRect.Right)
                    {
                        newPos.X -= 1.0f;
                    }

                    while (newPos.Y < 0)
                    {
                        newPos.Y += 1.0f;
                    }

                    while (newPos.Y > worldRect.Bottom)
                    {
                        newPos.Y -= 1.0f;
                    }
                }

                if (!position.Equals(newPos))
                {
                    mapCtrl.RedrawNeeded = true;
                    this.position = newPos;
                }      
            }
        }

        public bool Selected
        {
            get { return selected; }
            set
            {
                if (selected != value)
                {
                    selected = value;
                    mapCtrl.RedrawNeeded = true;

                    if (selected)
                    {
                        viewStatsForm = new ViewStatsForm(this, Cursor.Position);
                        viewStatsForm.Show(mapCtrl.ParentForm);
                    }
                    else { viewStatsForm.Close(); }
                }
            }
        }

        // Draws the token using the given graphics
        public void DrawToken(Graphics graphics, ref RectangleF viewportRect)
        {
            RectangleF tokenRect = GetUnitRect();

            // Token is offscreen, so no need to draw it
            if (!viewportRect.IntersectsWith(tokenRect)) { return; }

            bool loaded = charImage != null;

            if(!loaded)
            {
                loaded = loadTokenImage();
            }

            if (!loaded)
            {
                DrawBasicToken(graphics, ref viewportRect, ref tokenRect);
            }
            else
            {
                DrawSpriteToken(graphics, ref viewportRect, ref tokenRect);
            }
        }

        public void DrawSpriteToken(Graphics graphics, ref RectangleF viewportRect, ref RectangleF tokenRect)
        {
            Rectangle pixelRect = mapCtrl.UnitRectToPixelRect(tokenRect, viewportRect);

            graphics.DrawImage(charImage, pixelRect);
        }

        public void DrawBasicToken(Graphics graphics, ref RectangleF viewportRect, ref RectangleF tokenRect)
        {
            Rectangle pixelRect = mapCtrl.UnitRectToPixelRect(tokenRect, viewportRect);
            Point pixelPos = mapCtrl.UnitPosToPixelPos(position.X, position.Y, viewportRect);

            Color drawColor = Color.White;

            switch (mouseState)
            {
                case TokenMouseState.Hover:
                    drawColor = COLOR_HOVER;
                    break;
                case TokenMouseState.Drag:
                    drawColor = COLOR_DRAG;
                    break;
                case TokenMouseState.Idle:
                    if (!selected) { drawColor = COLOR_IDLE; }
                    else { drawColor = COLOR_SELECTED; }
                    break;
            }

            SolidBrush baseBrush = new SolidBrush(drawColor);
            Pen outlinePen;

            if (selected)
            {
                outlinePen = new Pen(Color.White, 4.0f);
            }
            else
            {
                outlinePen = new Pen(Color.Black, 4.0f);
            }

            // Placeholder graphics.
            // TODO: Draw token image
            graphics.FillEllipse(baseBrush, pixelRect);
            graphics.DrawEllipse(outlinePen, pixelRect);
        }

        // Draws the token label using the given graphics
        public void DrawTokenLabel(Graphics graphics, ref RectangleF viewportRect)
        {
            RectangleF tokenRect = GetUnitRect();

            // Token is offscreen, so no need to draw it
            if (!viewportRect.IntersectsWith(tokenRect)) { return; }

            if (mapCtrl.MapLabelFont != null)
            {
                Rectangle pixelRect = mapCtrl.UnitRectToPixelRect(tokenRect, viewportRect);
                Point pixelPos = mapCtrl.UnitPosToPixelPos(position.X, position.Y, viewportRect);

                RectangleF stringRect = new RectangleF();
                RectangleF stringBckRect = new RectangleF();

                SizeF strSize = graphics.MeasureString(tokenData.Name, mapCtrl.MapLabelFont);

                stringBckRect.Width = strSize.Width + (STRING_HORIZONTAL_PADDING * 2);
                stringBckRect.Height = strSize.Height + (STRING_VERTICAL_PADDING * 2);
                stringBckRect.X = (float)pixelPos.X - (stringBckRect.Width / 2);
                stringBckRect.Y = (float)pixelRect.Bottom + STRING_VERTICAL_PADDING;

                stringRect.Width = strSize.Width;
                stringRect.Height = strSize.Height;
                stringRect.X = (float)pixelPos.X - (stringRect.Width / 2);
                stringRect.Y = (float)pixelRect.Bottom + (STRING_VERTICAL_PADDING * 2);

                SolidBrush textBckBrush = new SolidBrush(Color.FromArgb(200, Color.Black));
                SolidBrush textBrush = new SolidBrush(Color.White);

                graphics.FillRectangle(textBckBrush, stringBckRect);
                graphics.DrawString(tokenData.Name, mapCtrl.MapLabelFont, textBrush, stringRect.X, stringRect.Y, StringFormat.GenericDefault);
            }
        }

        public RectangleF GetUnitRect()
        {
            RectangleF unitRect = new RectangleF();

            unitRect.Width = this.scale;
            unitRect.Height = this.scale;

            unitRect.X = position.X - (unitRect.Width / 2); // Center Rect over X pos
            unitRect.Y = position.Y - (unitRect.Height / 2); // Center Rect over Y pos

            return unitRect;
        }

        public Point GetPixelPos()
        {
            return mapCtrl.UnitPosToPixelPos(position.X, position.Y, mapCtrl.GetViewportUnitRect());
        }

        public TokenMouseState MouseState
        {
            get { return mouseState; }
            set
            {
                if (mouseState != value)
                {
                    mapCtrl.RedrawNeeded = true;
                    mouseState = value;
                }
            }
        }

        public void resetSprite()
        {
            if (charImage != null)
            {
                charImage.Dispose();
                charImage = null;
            }
        }

        public override string ToString()
        {
            return tokenData.Name;
        }


        private bool loadTokenImage()
        {
            try {
                if (charImage != null)
                {
                    charImage.Dispose();
                    charImage = null;
                }

                charImage = Bitmap.FromFile(tokenData.PictureFileName);
            }
            catch(Exception e)
            {
                return false;
            }

            return true;
        }
    }

}
