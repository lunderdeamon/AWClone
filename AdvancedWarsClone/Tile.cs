using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AdvancedWarsClone {
    class Tile {
        // Private 
        private Point position;
        private string tag;
        private Texture2D texture;
        private int size = 32;

        // Constructors
        public Tile() {

        }

        public Tile(Point point, string tag) {
            Position = point;
            Tag = tag;
        }

        // Public
        public Point Position {
            get {
                return position;
            }
            set {
                position = value;
            }
        }

        public int Y {
            get {
                return position.Y;
            }
            set {
                position.Y = value;
            }
        }

        public int X {
            get {
                return position.X;
            }
            set {
                position.X = value;
            }
        }

        public string Tag { get; set; }

        public Texture2D Texture {
            get {
                return texture;
            }
            set {
                texture = value;
            }
        }

        public int Size {
            get { return size; }
            set { size = value; }
        }

        // Methods 
        public void Draw(SpriteBatch spriteBatch, int xPos, int yPos) {
            Point SizePoint = new Point(size);
            position.X = (xPos * 32) + 20;
            position.Y = (yPos * 32) + 20;
            Rectangle destinationRect = new Rectangle(Position,SizePoint);

            spriteBatch.Begin();

            spriteBatch.Draw(texture, destinationRect, Color.White );

            spriteBatch.End();
        }
    }
}
