using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PistolHero
{
    public class Asset : GameComponent
    {
        protected string m_textureName;
        protected Vector2 m_position;

        public Asset(Game game) : base(game)
        { 
            m_textureName = "";
            m_position = new Vector2();
        }

        public Asset(Game game, string textureName, Vector2 position) : base(game)
        {
            m_textureName = textureName;
            m_position = position;
        }

        public string GetTexName() { return m_textureName; }

        public void SetTexID(string newName) { m_textureName = newName; }

        public Vector2 GetPosition() { return m_position; }

        public void SetPosition(Vector2 newPosition) { m_position = newPosition; }
    }
}
