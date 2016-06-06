using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace AdvancedWarsClone {
         
    public class Game1 : Game {

        int TOTALWIDTH, TOTALHEIGHT , SCROLLSIZE, PLAYWIDTH, PLAYHEIGHT, SIDEBARSIZE; //size of the game sidebar

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Gameboard playerBoard;
        AwCursor cursor;
        MouseState mousePos;

        MainMenu mainMenu;

        Vector2 playSize;
        Vector2 playSizeIndex;
        Rectangle playArea;

        Rectangle scrollLeftRect, scrollRightRect, scrollUpRect, scrollDownRect;
        Texture2D scrollLeft, scrollRight, scrollUp, scrollDown;

        // Constructors

        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        // Monogame Methods

        protected override void Initialize() {
            // TODO: Add your initialization logic here


            //create size 
            TOTALWIDTH = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            TOTALHEIGHT = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

            SCROLLSIZE = 40; //size of scroll areas

            PLAYWIDTH = ((TOTALWIDTH / 3) * 2) - SCROLLSIZE; //use these to change size of terrain window
            PLAYHEIGHT = TOTALHEIGHT - SCROLLSIZE; //

            SIDEBARSIZE = 500; //size of the game sidebar

            //end create size

            //create window
            graphics.IsFullScreen = true;
            graphics.PreferredBackBufferWidth = TOTALWIDTH;
            graphics.PreferredBackBufferHeight = TOTALHEIGHT;
            graphics.ApplyChanges();

            mainMenu = new MainMenu();
            mainMenu.Activate();
            mainMenu.Enabled = true;
            mainMenu.Show();
            // end window


            // create rectangle and index stuff 
            playSizeIndex = new Vector2(PLAYWIDTH / 32, PLAYHEIGHT / 32);
            playSize = new Vector2(playSizeIndex.X * 32, playSizeIndex.Y * 32);
            playArea = new Rectangle(20, 20, PLAYWIDTH - 32, PLAYHEIGHT - 32);

            scrollLeftRect = new Rectangle(0, playArea.X, SCROLLSIZE / 2, PLAYHEIGHT);
            

            playerBoard = new Gameboard(this);
            cursor = new AwCursor(playerBoard, this, playArea);

            base.Initialize();
        }

        protected override void LoadContent() {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            cursor.Image = Content.Load<Texture2D>("cursor");
            scrollLeft = Content.Load<Texture2D>("left");

            ContentManager levels = new ContentManager(Content.ServiceProvider, "Levels");
            // more level loading from there            
        }

        protected override void UnloadContent() {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            cursor.Update( playerBoard.OffsetIndex);
            MainMenuAlign();
            mousePos = Mouse.GetState();                            //
            Vector2 cursorPos = new Vector2(mousePos.X, mousePos.Y);    // these two lines are to get current mouse position and convert it to point
            Vector2 totalSize = new Vector2(TOTALWIDTH, TOTALHEIGHT);
            mainMenu.Update(cursorPos, cursor.CurrentTileTag, playerBoard.OffsetIndex, playArea, totalSize, playSizeIndex);


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            spriteBatch.Draw(scrollLeft, scrollLeftRect, Color.White);

            spriteBatch.End();

            playerBoard.Draw(spriteBatch);
            cursor.Draw(spriteBatch);           

            base.Draw(gameTime);
        }


        // Public 
        public Vector2 Size {
            get { return playSize; }
        }
        public Vector2 SizeIndex {
            get { return playSizeIndex; }
        }
        // Other Methods

        public void MainMenuAlign() {
            int x, y;
            x = 0;
            y = 0;
            this.Window.Position = new Point(x, y);
            mainMenu.Location = new System.Drawing.Point(x - mainMenu.Width, y);
        }

        public bool IsMouseInsideWindow() {
            MouseState ms = Mouse.GetState();
            Point pos = new Point(ms.X, ms.Y);
            return GraphicsDevice.Viewport.Bounds.Contains(pos);
        }
    }
}
