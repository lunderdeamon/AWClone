using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace AdvancedWarsClone {
    public class PlaytimeUI {
        // Private 
        ContentManager playtimeUIContent;

        // Size fields
        int TOTALWIDTH, TOTALHEIGHT, SCROLLSIZE, SINGLESCROLL, PLAYWIDTH, PLAYHEIGHT, SIDEBARSIZEX, SIDEBARSIZEY, MENUBAR; //size shits

        // Areas and their textures
        Texture2D menuBar;
        Rectangle menuBarArea;

        Texture2D sideBar;
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
            playtimeUIContent = new ContentManager(gameRef.Content.ServiceProvider, "Content\\UI\\PlaytimeUI");
            Load();

            TOTALWIDTH = width;
            TOTALHEIGHT = height;

            SCROLLSIZE = 40; //size of scroll areas
            SINGLESCROLL = SCROLLSIZE / 2;
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
            playArea = new Rectangle(SINGLESCROLL, MENUBAR + SINGLESCROLL, (int)playSize.X, (int)playSize.Y);

            //Scroll areas
            scrollLeftRect = new Rectangle(0, playArea.Y, SINGLESCROLL, playArea.Height);
            boolLeft = false;
            scrollRightRect = new Rectangle(playArea.X + playArea.Width, playArea.Y, SINGLESCROLL, playArea.Height);
            boolRight = true;
            scrollUpRect = new Rectangle(SINGLESCROLL, MENUBAR, playArea.Width, SINGLESCROLL);
            boolUp = false;
            scrollDownRect = new Rectangle(SINGLESCROLL, playArea.Y + playArea.Height, playArea.Width, SINGLESCROLL);
            boolDown = true;

            //menubar
            menuBarArea = new Rectangle(0, 0, TOTALWIDTH, MENUBAR);

            //Sideboard
            sideBoardArea = new Rectangle(PLAYWIDTH + SINGLESCROLL, SINGLESCROLL + MENUBAR, SIDEBARSIZEX, SIDEBARSIZEY);
            //inside of side
            //Cursor Status 
            cursorStatusArea = sideBoardArea;
            cursorStatusArea.Height = (cursorStatusArea.Height * 2) / 3;
            cursorStatusArea.Width -= 20;
            cursorStatusArea.X += 10;
            cursorStatusArea.Y += 10;

        }


        // Public
        public Vector2 Size {
            get { return playSize; }
        }
        public Vector2 SizeIndex {
            get { return playSizeIndex; }
        }
        public Rectangle PlayArea {
            get { return playArea; }
        }
        public int ScrollSize {
            get { return SCROLLSIZE; }
        }

        public int MenuBarSize;
        // Methods 
        public void Load() {
            scrollLeft = playtimeUIContent.Load<Texture2D>("left");
            scrollRight = playtimeUIContent.Load<Texture2D>("right");
            scrollUp = playtimeUIContent.Load<Texture2D>("up");
            scrollDown = playtimeUIContent.Load<Texture2D>("down");
            
            sideBar = playtimeUIContent.Load<Texture2D>("outline");
            menuBar = playtimeUIContent.Load<Texture2D>("outline");
            cursorStatus = playtimeUIContent.Load<Texture2D>("cursorstatus");
        }

        public void Unload() {
            
        }
        public void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.Opaque);
            if (boolLeft) spriteBatch.Draw(scrollLeft, scrollLeftRect, Color.White);
            if (boolRight) spriteBatch.Draw(scrollRight, scrollRightRect, Color.White);
            if (boolUp) spriteBatch.Draw(scrollUp, scrollUpRect, Color.White);
            if (boolDown) spriteBatch.Draw(scrollDown, scrollDownRect, Color.White);

            spriteBatch.Draw(menuBar, menuBarArea, Color.White);

            spriteBatch.Draw(sideBar, sideBoardArea, Color.White);
            spriteBatch.Draw(cursorStatus, cursorStatusArea, Color.White);

            spriteBatch.End();
        }
    }
}
