using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CrackerChase
{
    class BadTarget : Target
    {
        public BadTarget(int inScreenWidth, int inScreenHeight, Texture2D inSpriteTexture, int inDrawWidth, float inRestX, float inResetY) :
            base(inScreenWidth, inScreenHeight, inSpriteTexture, inDrawWidth, inRestX, inResetY)
        {
            Score = -100;
        }
    }
}
