using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AdvancedWarsClone {
    public class Tile {
        // Private 
        private Point position;
        private string tag;
        private Texture2D texture;
        private int size = 32;

        PlaytimeUI uiRef;

        // Constructors
        public Tile() {

        }

        public Tile(Point point, string tag, PlaytimeUI uireference) {
            uiRef = uireference;
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

        public string Tag {
            get { return tag; }
            set { tag = value; }
        }

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

        public PlaytimeUI UIRef {
            get { return uiRef; }
            set { uiRef = value; }
        }

        // Methods 
        public void Draw(SpriteBatch spriteBatch, int xPos, int yPos) {
            Point SizePoint = new Point(size);
            position.X = (xPos * size) + uiRef.ScrollSize / 2;
            position.Y = (yPos * size) + uiRef.ScrollSize / 2 + uiRef.MenuBarSize + 32;
            Rectangle destinationRect = new Rectangle(Position,SizePoint);

            spriteBatch.Begin();

            spriteBatch.Draw(texture, destinationRect, Color.White );

            spriteBatch.End();
        }
    }
}
