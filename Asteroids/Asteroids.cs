using Asteroids.GameStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Asteroids
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Asteroids : GameEnvironment
    {       
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            base.LoadContent();
            screen = new Point(800, 600);
            ApplyResolutionSettings();

            // TODO: use this.Content to load your game content here
            GameStateManager.AddGameState("TitleScreenState", new TitleScreenState());
            GameStateManager.AddGameState("PlayingState", new PlayingState());
            GameStateManager.AddGameState("GameOverState", new GameOverState());
            GameStateManager.AddGameState("WinState", new WinState());
            GameStateManager.SwitchTo("TitleScreenState");
        }



    }
}
