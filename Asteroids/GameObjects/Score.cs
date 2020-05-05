using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.GameObjects
{
    class Score : TextGameObject
    {

        private int gameScore;

        public int GameScore
        {
            get { return gameScore; }
            set { gameScore = value; }
        }
        
        public Score() : base("GameFont")
        {
            position = new Vector2(0, 0);
            text = "0";

        }
        
        public void AddScore()
        {
            int scoreToAdd = 10;
            gameScore += scoreToAdd;
            text = (int.Parse(text) + scoreToAdd).ToString();
        }
    }

}
