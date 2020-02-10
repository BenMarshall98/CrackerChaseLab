using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace CrackerChase
{
    class BadTarget : Target
    {
        public BadTarget(int inScreenWidth, int inScreenHeight, Texture2D inSpriteTexture, int inDrawWidth, float inRestX, float inResetY) :
            base(inScreenWidth, inScreenHeight, inSpriteTexture, inDrawWidth, inRestX, inResetY)
        {
            Score = -100;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            rectangle.X = (int)Math.Round(xPosition);
            rectangle.Y = (int)Math.Round(yPosition);
            spriteBatch.Draw(texture, rectangle, Color.Red);
        }
    }
}
