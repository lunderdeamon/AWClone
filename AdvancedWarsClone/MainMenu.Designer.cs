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
            this.lblCursorPos = new System.Windows.Forms.Label();
            this.lblTilePos = new System.Windows.Forms.Label();
            this.lblTileType = new System.Windows.Forms.Label();
            this.lblTileOffset = new System.Windows.Forms.Label();
            this.lblTileIndex = new System.Windows.Forms.Label();
            this.lblPlayArea = new System.Windows.Forms.Label();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.lblPlayIndexSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCursorPos
            // 
            this.lblCursorPos.AutoSize = true;
            this.lblCursorPos.Location = new System.Drawing.Point(3, 2);
            this.lblCursorPos.Name = "lblCursorPos";
            this.lblCursorPos.Size = new System.Drawing.Size(64, 13);
            this.lblCursorPos.TabIndex = 1;
            this.lblCursorPos.Text = "Cursor Pos: ";
            // 
            // lblTilePos
            // 
            this.lblTilePos.AutoSize = true;
            this.lblTilePos.Location = new System.Drawing.Point(3, 15);
            this.lblTilePos.Name = "lblTilePos";
            this.lblTilePos.Size = new System.Drawing.Size(51, 13);
            this.lblTilePos.TabIndex = 2;
            this.lblTilePos.Text = "Tile Pos: ";
            // 
            // lblTileType
            // 
            this.lblTileType.AutoSize = true;
            this.lblTileType.Location = new System.Drawing.Point(3, 28);
            this.lblTileType.Name = "lblTileType";
            this.lblTileType.Size = new System.Drawing.Size(54, 13);
            this.lblTileType.TabIndex = 3;
            this.lblTileType.Text = "Tile Type:";
            // 
            // lblTileOffset
            // 
            this.lblTileOffset.AutoSize = true;
            this.lblTileOffset.Location = new System.Drawing.Point(3, 41);
            this.lblTileOffset.Name = "lblTileOffset";
            this.lblTileOffset.Size = new System.Drawing.Size(58, 13);
            this.lblTileOffset.TabIndex = 4;
            this.lblTileOffset.Text = "Tile Offset:";
            // 
            // lblTileIndex
            // 
            this.lblTileIndex.AutoSize = true;
            this.lblTileIndex.Location = new System.Drawing.Point(3, 54);
            this.lblTileIndex.Name = "lblTileIndex";
            this.lblTileIndex.Size = new System.Drawing.Size(56, 13);
            this.lblTileIndex.TabIndex = 5;
            this.lblTileIndex.Text = "Tile Index:";
            // 
            // lblPlayArea
            // 
            this.lblPlayArea.AutoSize = true;
            this.lblPlayArea.Location = new System.Drawing.Point(3, 98);
            this.lblPlayArea.Name = "lblPlayArea";
            this.lblPlayArea.Size = new System.Drawing.Size(58, 13);
            this.lblPlayArea.TabIndex = 6;
            this.lblPlayArea.Text = "Play Area: ";
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Location = new System.Drawing.Point(3, 111);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(51, 13);
            this.lblTotalSize.TabIndex = 7;
            this.lblTotalSize.Text = "TotalSize";
            // 
            // lblPlayIndexSize
            // 
            this.lblPlayIndexSize.AutoSize = true;
            this.lblPlayIndexSize.Location = new System.Drawing.Point(3, 124);
            this.lblPlayIndexSize.Name = "lblPlayIndexSize";
            this.lblPlayIndexSize.Size = new System.Drawing.Size(82, 13);
            this.lblPlayIndexSize.TabIndex = 8;
            this.lblPlayIndexSize.Text = "Play Index Size:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 461);
            this.Controls.Add(this.lblPlayIndexSize);
            this.Controls.Add(this.lblTotalSize);
            this.Controls.Add(this.lblPlayArea);
            this.Controls.Add(this.lblTileIndex);
            this.Controls.Add(this.lblTileOffset);
            this.Controls.Add(this.lblTileType);
            this.Controls.Add(this.lblTilePos);
            this.Controls.Add(this.lblCursorPos);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCursorPos;
        private System.Windows.Forms.Label lblTilePos;
        private System.Windows.Forms.Label lblTileType;
        private System.Windows.Forms.Label lblTileOffset;
        private System.Windows.Forms.Label lblTileIndex;
        private System.Windows.Forms.Label lblPlayArea;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Label lblPlayIndexSize;
    }
}