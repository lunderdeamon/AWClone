using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace AdvancedWarsClone {
         
    public class Game1 : Game {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;


        Gameboard playerBoard;
        AwCursor cursor;
        MouseState mousePos;
        PlaytimeUI playUI;

        MainMenu mainMenu;

        int TOTALWIDTH, TOTALHEIGHT;

        // Constructors

        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        // Monogame Methods

        protected override void Initialize() {
            // TODO: Add your initialization logic here
            playerBoard = new Gameboard(this);            

            //create size 
            TOTALWIDTH = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            TOTALHEIGHT = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height; //full screen

            playUI = new PlaytimeUI(TOTALWIDTH, TOTALHEIGHT, this);

            playerBoard.RefUI();

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

            //Cursor
            cursor = new AwCursor(playerBoard, this, PlayUI.PlayArea);

            base.Initialize();
        }

        protected override void LoadContent() {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            cursor.Image = Content.Load<Texture2D>("cursor");
            
            cursor.DebugTex = Content.Load<Texture2D>("debugcursor");

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
            mainMenu.Update(cursorPos, cursor.CurrentTileTag, playerBoard.OffsetIndex, PlayUI.PlayArea, totalSize, PlayUI.SizeIndex);


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            PlayUI.Draw(spriteBatch);
            playerBoard.Draw(spriteBatch);
            cursor.Draw(spriteBatch);           

            base.Draw(gameTime);
        }


        // Public 
        public Vector2 Size {
            get { return PlayUI.Size; }
        }
        public Vector2 SizeIndex {
            get { return PlayUI.SizeIndex; }
        }
        public Gameboard PlayerBoard {
            get { return playerBoard; }
        }
        public PlaytimeUI PlayUI {
            get { return playUI; }
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
