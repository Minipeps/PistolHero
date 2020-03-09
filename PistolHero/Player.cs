using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace PistolHero
{
    public class Player : Asset
    {
        PlayerController m_playerController;


        public Player(Game game) : base(game)
        {
            m_playerController = new PlayerController();
        }

        public Player(Game game, string textureName, Vector2 position) : 
            base(game, textureName, position)
        {
            m_playerController = new PlayerController();
        }

        public override void Initialize()
        {
            m_playerController.Initialize();
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            m_playerController.Update(gameTime, ref m_position);
            Console.WriteLine(m_position);
            base.Update(gameTime);
        }
    }
}
