namespace AdvancedWarsClone {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BttnPlaceTroops = new System.Windows.Forms.Button();
            this.lblCursorPos = new System.Windows.Forms.Label();
            this.lblTilePos = new System.Windows.Forms.Label();
            this.lblTileType = new System.Windows.Forms.Label();
            this.lblTileOffset = new System.Windows.Forms.Label();
            this.lblTileIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BttnPlaceTroops
            // 
            this.BttnPlaceTroops.Location = new System.Drawing.Point(4, 4);
            this.BttnPlaceTroops.Name = "BttnPlaceTroops";
            this.BttnPlaceTroops.Size = new System.Drawing.Size(286, 75);
            this.BttnPlaceTroops.TabIndex = 0;
            this.BttnPlaceTroops.Text = "Place Troops";
            this.BttnPlaceTroops.UseVisualStyleBackColor = true;
            this.BttnPlaceTroops.Click += new System.EventHandler(this.PlaceTroops_Click);
            // 
            // lblCursorPos
            // 
            this.lblCursorPos.AutoSize = true;
            this.lblCursorPos.Location = new System.Drawing.Point(1, 109);
            this.lblCursorPos.Name = "lblCursorPos";
            this.lblCursorPos.Size = new System.Drawing.Size(64, 13);
            this.lblCursorPos.TabIndex = 1;
            this.lblCursorPos.Text = "Cursor Pos: ";
            // 
            // lblTilePos
            // 
            this.lblTilePos.AutoSize = true;
            this.lblTilePos.Location = new System.Drawing.Point(1, 122);
            this.lblTilePos.Name = "lblTilePos";
            this.lblTilePos.Size = new System.Drawing.Size(51, 13);
            this.lblTilePos.TabIndex = 2;
            this.lblTilePos.Text = "Tile Pos: ";
            // 
            // lblTileType
            // 
            this.lblTileType.AutoSize = true;
            this.lblTileType.Location = new System.Drawing.Point(1, 135);
            this.lblTileType.Name = "lblTileType";
            this.lblTileType.Size = new System.Drawing.Size(54, 13);
            this.lblTileType.TabIndex = 3;
            this.lblTileType.Text = "Tile Type:";
            // 
            // lblTileOffset
            // 
            this.lblTileOffset.AutoSize = true;
            this.lblTileOffset.Location = new System.Drawing.Point(1, 148);
            this.lblTileOffset.Name = "lblTileOffset";
            this.lblTileOffset.Size = new System.Drawing.Size(58, 13);
            this.lblTileOffset.TabIndex = 4;
            this.lblTileOffset.Text = "Tile Offset:";
            // 
            // lblTileIndex
            // 
            this.lblTileIndex.AutoSize = true;
            this.lblTileIndex.Location = new System.Drawing.Point(1, 161);
            this.lblTileIndex.Name = "lblTileIndex";
            this.lblTileIndex.Size = new System.Drawing.Size(56, 13);
            this.lblTileIndex.TabIndex = 5;
            this.lblTileIndex.Text = "Tile Index:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 461);
            this.Controls.Add(this.lblTileIndex);
            this.Controls.Add(this.lblTileOffset);
            this.Controls.Add(this.lblTileType);
            this.Controls.Add(this.lblTilePos);
            this.Controls.Add(this.lblCursorPos);
            this.Controls.Add(this.BttnPlaceTroops);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnPlaceTroops;
        private System.Windows.Forms.Label lblCursorPos;
        private System.Windows.Forms.Label lblTilePos;
        private System.Windows.Forms.Label lblTileType;
        private System.Windows.Forms.Label lblTileOffset;
        private System.Windows.Forms.Label lblTileIndex;
    }
}