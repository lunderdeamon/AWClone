using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AdvancedWarsClone {
    class AwCursor {
        // Private 
        MouseState currentState;
        MouseState oldState; // state for previous frame to prevent super fast scrolling 
        private Vector2 cursorPos;
        private Vector2 tilePos;
        private Vector2 tileIndex;

        private Terrain currentTile;
        private Unit currentUnit;

        private Vector2 offsetIndex;

        Texture2D image;
        Gameboard boardReference; // reference to get tile data
        Game1 gameReference; // reference to get game window

        Rectangle playArea;

        public Texture2D DebugTex;
        Vector2 actualPos;


        // Constructors

        public AwCursor(Gameboard gameBoard, Game1 gameRef, Rectangle playAreaRef) {
            cursorPos = new Vector2(0, 0);
            offsetIndex = new Vector2(0, 0);
            boardReference = gameBoard;
            gameReference = gameRef;
            playArea = playAreaRef;
        }


        // Public
        public Vector2 OffsetIndex {
            get { return offsetIndex; }
            set { offsetIndex = value; }
        }
        public Texture2D Image {
            get { return image; }
            set { image = value; }
        }

        public string CurrentTileTag {
            get { return currentTile.Tag; }
        }
        // Methods 
        public void Update(Vector2 offset) {
            //first step get mouse position passed from game1
            oldState = currentState;
            currentState = Mouse.GetState();
            cursorPos = new Vector2(currentState.X, currentState.Y);
            actualPos = cursorPos;
            offsetIndex = offset;
            Align();
            currentTile = boardReference.TerrainGrid[(int)tileIndex.X + (int)offsetIndex.X, (int)tileIndex.Y + (int)offsetIndex.Y];
            CheckClick();

        }

        public void Align() {

            int x, y;
            if (gameReference.IsMouseInsideWindow()) {
                if (playArea.Contains(cursorPos.ToPoint())) {
                    tilePos = cursorPos;
                    x = ((int)tilePos.X - 20) / boardReference.unitSize;
                    y = ((int)tilePos.Y - 20) / boardReference.unitSize;
                    tileIndex.X = x;
                    tileIndex.Y = y;
                    tilePos.X = x * boardReference.unitSize + 20;
                    tilePos.Y = y * boardReference.unitSize + 20;
                }
            }


            cursorPos = tilePos;
        }

        public void CheckClick() {
            // here we will check
            //if the mouse is being clicked
            //what is it is clicking on
            //what can we do with what its clicking on
            //create a menu if there are multiple options 
            if (currentState.LeftButton == ButtonState.Pressed && oldState.LeftButton == ButtonState.Released) {

                if (!(playArea.Contains(actualPos))) { //if the cursor is not on a play tile 
                    //if (gameReference.sideBoard.Contains(actualPos)) {
                    //    // if the cursor is in the side board
                    //}                  

                    //if you are scrolling 
                    if (gameReference.scrollLeftRect.Contains(actualPos) && boardReference.OffsetIndexX > 0) { // left
                        boardReference.OffsetIndexX--;
                        if (boardReference.OffsetIndexX == 0) gameReference.boolLeft = false;
                        gameReference.boolRight = true;
                    }
                    else if (gameReference.scrollRightRect.Contains(actualPos) && boardReference.OffsetIndexX < boardReference.UpperIndex.X - gameReference.SizeIndex.X) { // right 
                        boardReference.OffsetIndexX++;
                        if (boardReference.OffsetIndexX == boardReference.UpperIndex.X - gameReference.SizeIndex.X) gameReference.boolRight = false;
                        gameReference.boolLeft = true;
                    }
                    if (gameReference.scrollUpRect.Contains(actualPos) && boardReference.OffsetIndexY > 0) { // up
                        boardReference.OffsetIndexY--;
                        if (boardReference.OffsetIndexY == 0) gameReference.boolUp = false;
                        gameReference.boolDown = true;
                    }
                    else if (gameReference.scrollDownRect.Contains(actualPos) && boardReference.OffsetIndexY < boardReference.UpperIndex.Y - gameReference.SizeIndex.Y) {  // down
                        boardReference.OffsetIndexY++;
                        if (boardReference.OffsetIndexY == boardReference.UpperIndex.Y - gameReference.SizeIndex.Y) gameReference.boolDown = false;
                        gameReference.boolUp = true;
                    }
                }
            }// end click on non tile 


            //click on tile

        }

        public void Draw(SpriteBatch spriteBatch) {

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);

            spriteBatch.Draw(image, cursorPos);
            spriteBatch.Draw(DebugTex, actualPos);

            spriteBatch.End();
        }

    }
}