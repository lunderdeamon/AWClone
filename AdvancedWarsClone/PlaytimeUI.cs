using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AdvancedWarsClone {
    class PlaytimeUI {
        // Private 
        int TOTALWIDTH, TOTALHEIGHT, SCROLLSIZE, PLAYWIDTH, PLAYHEIGHT, SIDEBARSIZEX, SIDEBARSIZEY, MENUBAR; //size shits

        Texture2D menuBarTex;
        Rectangle menuBar;

        Texture2D sideBarTex;
        public Rectangle sideBoardArea;

        Texture2D cursorStatus;
        Rectangle cursorStatusArea;

        Texture2D COstatus;
        Rectangle COstatusArea;

        Texture2D OpCOstatus;
        Rectangle OpCOstatusArea;


        Vector2 playSize;
        Vector2 playSizeIndex;
        Rectangle playArea;

        public Rectangle scrollLeftRect, scrollRightRect, scrollUpRect, scrollDownRect;
        Texture2D scrollLeft, scrollRight, scrollUp, scrollDown;
        public bool boolLeft, boolRight, boolUp, boolDown;

        Game1 gameReference;

        // Constructors
        public PlaytimeUI(int width, int height, Game1 gameRef) {
            gameReference = gameRef;

            TOTALWIDTH = width;
            TOTALHEIGHT = height;

            SCROLLSIZE = 40; //size of scroll areas
            MENUBAR = 32;

            PLAYWIDTH = ((TOTALWIDTH / 3) * 2) - SCROLLSIZE; //use these to change size of terrain window
            PLAYHEIGHT = TOTALHEIGHT - SCROLLSIZE - MENUBAR; //

            SIDEBARSIZEX = TOTALWIDTH - PLAYWIDTH - SCROLLSIZE; //size of the game sidebar
            SIDEBARSIZEY = TOTALHEIGHT - SCROLLSIZE - MENUBAR;

            //end create size




            // create rectangle and index stuff 
            //Play area
            playSizeIndex = new Vector2(PLAYWIDTH / gameReference.PlayerBoard.unitSize, PLAYHEIGHT / 32);
            playSize = new Vector2(playSizeIndex.X * 32, playSizeIndex.Y * 32);
            playArea = new Rectangle(20, 20, (int)playSize.X, (int)playSize.Y);

            //Scroll areas
            scrollLeftRect = new Rectangle(0, playArea.Y, SCROLLSIZE / 2, playArea.Height);
            boolLeft = false;
            scrollRightRect = new Rectangle(playArea.X + playArea.Width, playArea.Y, SCROLLSIZE / 2, playArea.Height);
            boolRight = true;
            scrollUpRect = new Rectangle(SCROLLSIZE / 2, 0, playArea.Width, SCROLLSIZE / 2);
            boolUp = false;
            scrollDownRect = new Rectangle(SCROLLSIZE / 2, playArea.Y + playArea.Height, playArea.Width, SCROLLSIZE / 2);
            boolDown = true;

            //Sideboard
            sideBoardArea = new Rectangle(PLAYWIDTH + SCROLLSIZE / 2, SCROLLSIZE / 2, SIDEBARSIZEX, SIDEBARSIZEY);
        }


        // Public

        // Methods 
        public void Load() {

        }

        public void Unload() {
            scrollLeft = Content.Load<Texture2D>("left");
            scrollRight = Content.Load<Texture2D>("right");
            scrollUp = Content.Load<Texture2D>("up");
            scrollDown = Content.Load<Texture2D>("down");
            
            sideBarTex = Content.Load<Texture2D>("outline");
        }
        public void Draw(SpriteBatch spriteBatch) {

        }
    }
}
