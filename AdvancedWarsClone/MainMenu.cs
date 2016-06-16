using System;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

namespace AdvancedWarsClone {
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
        }

        private void PlaceTroops_Click(object sender, EventArgs e) {

        }
        public void Update(Vector2 position, String tag, Vector2 offset, Rectangle playArea, Vector2 totalSize, Vector2 playIndex) {
            lblCursorPos.Text = "Cursor Pos: " + position.ToString();
            Vector2 tilePos = position;

            int x, y;
            x = (int)tilePos.X / 32;
            y = (int)tilePos.Y / 32;

            tilePos.X = x;
            tilePos.Y = y;

            Vector2 tileIndex = new Vector2(tilePos.X + offset.X, tilePos.Y + offset.Y);
            lblTilePos.Text = "Tile Pos: " + tilePos.ToString();


            lblTileType.Text = "Tile Tag: " + tag;

            lblTileOffset.Text = "Tile Offset: " + offset.ToString();
            lblTileIndex.Text = "Tile Index: " + tileIndex.ToString();

            lblPlayArea.Text = "Play Area: " + playArea.ToString();
            lblTotalSize.Text = "Total Size: " + totalSize.ToString();

            lblPlayIndexSize.Text = "Play Index Size: " + playIndex.ToString();
        }    
    }
}
