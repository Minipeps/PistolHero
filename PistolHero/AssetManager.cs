using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System.Collections.Generic;

namespace PistolHero
{
    public class AssetManager : GameComponent
    {
        SpriteBatch m_spriteBatch;
        Dictionary<string, Texture2D> m_textures;
        List<Asset> m_assetList;

        public AssetManager(Game game) : base(game) { }

        // Use this for initialization
        public override void Initialize()
        {
            m_spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            m_textures = new Dictionary<string, Texture2D>();
            m_assetList = new List<Asset>();

            base.Initialize();
        }

        public void LoadAsset(Asset asset)
        {
            LoadTexture2D(asset.GetTexName());
            m_assetList.Add(asset);
        }

        // Load new Texture2D if the asset wasn't already loaded
        public bool LoadTexture2D(string assetName)
        {
            if (m_textures.ContainsKey(assetName))
                return false;

            Texture2D newTexture = Game.Content.Load<Texture2D>(assetName);
            m_textures.Add(assetName, newTexture);
            return true;
        }

        public Texture2D GetTexture2D(string newName)
        {
            Texture2D texture;
            if (!m_textures.TryGetValue(newName, out texture))
            {

                return null;
            }

            return texture;
        }

        public void DrawAssets()
        {
            Vector2 pos;
            m_spriteBatch.Begin();
            foreach (Asset asset in m_assetList)
            {
                pos = asset.GetPosition();
                m_spriteBatch.Draw(GetTexture2D(asset.GetTexName()), new Rectangle((int) pos.X, (int) pos.Y, 100, 100), Color.White);
            }
            m_spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
