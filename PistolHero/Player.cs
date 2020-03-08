using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PistolHero
{
    public class Player : Asset
    {
        private Texture2D m_spriteTexture;
        private Vector3 m_position;

        public Player(Game game) : base(game)
        {
        
        }
    }
}
