using CocosSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultGame.Common
{
    public class GameScene : CCScene
    {
        CCLayer backgroundLayer;
        CCLayer gameplayLayer;
        CCLayer foregroundLayer;
        CCLayer hudLayer;
        bool hasGameEnded;
        CCLabel debugLabel;

        public GameScene(CCGameView gameView) : base(gameView)
        {
            hasGameEnded = false;
            CreateLayers();

            Schedule(Activity);

        }

        private void CreateLayers()
        {
            backgroundLayer = new CCLayer();
            this.AddLayer(backgroundLayer);

            gameplayLayer = new CCLayer();
            this.AddLayer(gameplayLayer);

            foregroundLayer = new CCLayer();
            this.AddLayer(foregroundLayer);

            hudLayer = new CCLayer();
            this.AddLayer(hudLayer);
        }

        private void Activity(float frameTimeInSeconds)
        {
            if (hasGameEnded == false)
            {

            }
        }
    }
}
