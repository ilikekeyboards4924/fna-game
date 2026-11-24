using Microsoft.Xna.Framework;

using var game = new fna_game.Game1();
game.Run();

namespace fna_game
{
    public class Game1 : Game
    {
        public Game1()
        {
            new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 960,
                PreferredBackBufferHeight = 540
            };
            Window.Title = "fna_game";
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
    }
}