namespace A2NestedClass
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCreateRandomPlayer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pboxBackground2 = new System.Windows.Forms.PictureBox();
            this.btnSortPlayers = new System.Windows.Forms.Button();
            this.lstboxPlayers = new System.Windows.Forms.ListBox();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblFileDrop = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateRandomPlayer
            // 
            this.btnCreateRandomPlayer.BackColor = System.Drawing.Color.White;
            this.btnCreateRandomPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateRandomPlayer.Font = new System.Drawing.Font("Menlo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRandomPlayer.ForeColor = System.Drawing.Color.Black;
            this.btnCreateRandomPlayer.Location = new System.Drawing.Point(9, 149);
            this.btnCreateRandomPlayer.Name = "btnCreateRandomPlayer";
            this.btnCreateRandomPlayer.Size = new System.Drawing.Size(181, 47);
            this.btnCreateRandomPlayer.TabIndex = 2;
            this.btnCreateRandomPlayer.Text = "Create random player";
            this.btnCreateRandomPlayer.UseVisualStyleBackColor = false;
            this.btnCreateRandomPlayer.Click += new System.EventHandler(this.btnCreateRandomPlayer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Felix Titling", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 48);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Player Stats";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxBackground2
            // 
            this.pboxBackground2.BackColor = System.Drawing.Color.Transparent;
            this.pboxBackground2.Image = ((System.Drawing.Image)(resources.GetObject("pboxBackground2.Image")));
            this.pboxBackground2.Location = new System.Drawing.Point(-6, -5);
            this.pboxBackground2.Name = "pboxBackground2";
            this.pboxBackground2.Size = new System.Drawing.Size(524, 502);
            this.pboxBackground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBackground2.TabIndex = 7;
            this.pboxBackground2.TabStop = false;
            // 
            // btnSortPlayers
            // 
            this.btnSortPlayers.BackColor = System.Drawing.Color.White;
            this.btnSortPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSortPlayers.Font = new System.Drawing.Font("Menlo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortPlayers.ForeColor = System.Drawing.Color.Black;
            this.btnSortPlayers.Location = new System.Drawing.Point(324, 149);
            this.btnSortPlayers.Name = "btnSortPlayers";
            this.btnSortPlayers.Size = new System.Drawing.Size(181, 47);
            this.btnSortPlayers.TabIndex = 8;
            this.btnSortPlayers.Text = "Sort players";
            this.btnSortPlayers.UseVisualStyleBackColor = false;
            this.btnSortPlayers.Click += new System.EventHandler(this.btnSortPlayers_Click);
            // 
            // lstboxPlayers
            // 
            this.lstboxPlayers.BackColor = System.Drawing.Color.White;
            this.lstboxPlayers.Font = new System.Drawing.Font("Menlo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxPlayers.ForeColor = System.Drawing.Color.Black;
            this.lstboxPlayers.FormattingEnabled = true;
            this.lstboxPlayers.ItemHeight = 18;
            this.lstboxPlayers.Location = new System.Drawing.Point(9, 202);
            this.lstboxPlayers.Name = "lstboxPlayers";
            this.lstboxPlayers.Size = new System.Drawing.Size(496, 274);
            this.lstboxPlayers.TabIndex = 9;
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Felix Titling", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.Black;
            this.lblTitle2.Location = new System.Drawing.Point(543, 9);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(449, 48);
            this.lblTitle2.TabIndex = 10;
            this.lblTitle2.Text = "File Drop";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileDrop
            // 
            this.lblFileDrop.BackColor = System.Drawing.Color.Transparent;
            this.lblFileDrop.Font = new System.Drawing.Font("Menlo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileDrop.ForeColor = System.Drawing.Color.Black;
            this.lblFileDrop.Location = new System.Drawing.Point(543, 68);
            this.lblFileDrop.Name = "lblFileDrop";
            this.lblFileDrop.Size = new System.Drawing.Size(449, 208);
            this.lblFileDrop.TabIndex = 11;
            this.lblFileDrop.Text = "(Drop file here)";
            this.lblFileDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Menlo", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(811, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 47);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 488);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFileDrop);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lstboxPlayers);
            this.Controls.Add(this.btnSortPlayers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreateRandomPlayer);
            this.Controls.Add(this.pboxBackground2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nested Class";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateRandomPlayer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pboxBackground2;
        private System.Windows.Forms.Button btnSortPlayers;
        private System.Windows.Forms.ListBox lstboxPlayers;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblFileDrop;
        private System.Windows.Forms.Button btnExit;
    }
}

