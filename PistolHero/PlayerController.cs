using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;


namespace PistolHero
{
    class PlayerController
    {
        static readonly float MAX_SPEED = 10.0f;

        static readonly float GRAVITY = 9.81f;

        string m_configFile;

        /// <summary>
        /// Previous Keyboard State
        /// </summary>
        KeyboardState m_previousKbState;

        /// <summary>
        /// The current speed of the player
        /// </summary>
        Vector3 m_speed;

        public PlayerController()
        {
            m_configFile = "";
            m_speed = new Vector3();
        }

        public void Initialize()
        {
            // TODO: Load config file
            m_previousKbState = Keyboard.GetState();
        }

        public void Update(GameTime gameTime, ref Vector2 position)
        {
            // Straffing
            if (IsKeyPressed(Keys.Q))
                m_speed.X = -1;
            if (IsKeyPressed(Keys.D))
                m_speed.X = 1;
            if (IsKeyReleased(Keys.Q) || IsKeyReleased(Keys.D))
                m_speed.X = 0;

            Console.WriteLine(m_speed);

            position += new Vector2(m_speed.X, m_speed.Y);

            m_previousKbState = Keyboard.GetState();
        }

        private bool IsKeyPressed(Keys key)
        {
            return Keyboard.GetState().IsKeyDown(key) && m_previousKbState.IsKeyUp(key);
        }
        
        private bool IsKeyReleased(Keys key)
        {
            return Keyboard.GetState().IsKeyUp(key) && m_previousKbState.IsKeyDown(key);
        }
    }
}
