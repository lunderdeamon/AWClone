using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AdvancedWarsClone {
    public class Gameboard {
        // Private 
        private int rows = 100;   // this is limited by speed/memory        
        private int cols = 100;   // 
        public int unitSize = 32;
        Vector2 upperIndex;

        private Game1 game;

        Texture2D defaultTex;

        Terrain[,] terrainGrid;
        Unit[,] unitGrid;

        Vector2 offsetIndex;

        enum tags { city, grass, mount, road, water };// enum-ed tags to allow random determination of terrain tile 


        // Constructors
        public Gameboard(Game1 game1) {
           
            game = game1;//store game reference 

            //grid shits, need to do unit grid- fill with "empty" units 
            upperIndex = new Vector2(cols, rows);

            offsetIndex = new Vector2();           

            terrainGrid = new Terrain[cols, rows];
            unitGrid = new Unit[cols, rows];
            Terrain current = new Terrain();
            current.Size = unitSize;

            defaultTex = game1.Content.Load<Texture2D>("outline");
            current.Texture = defaultTex;

            System.Random rand = new System.Random();

            for (int i = 0; i < cols; i++) {
                for (int j = 0; j < rows; j++) {
                    current.Y = j * unitSize;
                    current.X = i * unitSize;
                    terrainGrid[i, j] = new Terrain();
                    terrainGrid[i, j].Position = current.Position;
                    terrainGrid[i, j].Tag = "outline";// in case something fails and a tag cannot be generated
                    tags myTag = (tags)rand.Next(0, 5); // this is temporary code 
                    terrainGrid[i, j].Tag = myTag.ToString();// the tag of the tile needs to be known by this point!! figure out some sort of level loading 

                    terrainGrid[i, j].Texture = game1.Content.Load<Texture2D>(terrainGrid[i, j].Tag);        
                }
            }

        }
        // Public
        #region Public Properties
        public Terrain[,] TerrainGrid {
            get { return terrainGrid; }
        }

        public Vector2 OffsetIndex {
            get { return offsetIndex; }
            set { offsetIndex = value; }
        }

        public int OffsetIndexX {
            get { return (int)offsetIndex.X; }
            set { offsetIndex.X = value; }
        }

        public int OffsetIndexY {
            get { return (int)offsetIndex.Y; }
            set { offsetIndex.Y = value; }
        }

        public Vector2 UpperIndex {
            get { return upperIndex; }
            set { upperIndex = value; }
        }
        #endregion

        // Methods 
        public void Draw(SpriteBatch spriteBatch) {
            for (int i = 0; i < game.SizeIndex.X; i++) { // draw grids 
                for (int j = 0; j < game.SizeIndex.Y; j++) {
                    terrainGrid[i + (int)offsetIndex.X, j + (int)offsetIndex.Y].Draw(spriteBatch, i,j);
                }
            }

            //end draw grids 

            //draw scroll areas

        }

    }
}
