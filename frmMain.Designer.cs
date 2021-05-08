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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateRandomPlayer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            this.pboxBackground2 = new System.Windows.Forms.PictureBox();
            this.btnSortPlayers = new System.Windows.Forms.Button();
            this.lstboxPlayers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(643, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 93);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateRandomPlayer
            // 
            this.btnCreateRandomPlayer.Font = new System.Drawing.Font("Menlo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRandomPlayer.Location = new System.Drawing.Point(9, 142);
            this.btnCreateRandomPlayer.Name = "btnCreateRandomPlayer";
            this.btnCreateRandomPlayer.Size = new System.Drawing.Size(181, 47);
            this.btnCreateRandomPlayer.TabIndex = 2;
            this.btnCreateRandomPlayer.Text = "Create random player";
            this.btnCreateRandomPlayer.UseVisualStyleBackColor = true;
            this.btnCreateRandomPlayer.Click += new System.EventHandler(this.btnCreateRandomPlayer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Felix Titling", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(9, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(366, 47);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "< ASSESSMENT 2 >";
            // 
            // pboxBackground
            // 
            this.pboxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pboxBackground.Image")));
            this.pboxBackground.Location = new System.Drawing.Point(-66, -5);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(1403, 469);
            this.pboxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBackground.TabIndex = 5;
            this.pboxBackground.TabStop = false;
            // 
            // pboxBackground2
            // 
            this.pboxBackground2.BackColor = System.Drawing.Color.Transparent;
            this.pboxBackground2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxBackground2.Image = ((System.Drawing.Image)(resources.GetObject("pboxBackground2.Image")));
            this.pboxBackground2.Location = new System.Drawing.Point(-6, -5);
            this.pboxBackground2.Name = "pboxBackground2";
            this.pboxBackground2.Size = new System.Drawing.Size(492, 469);
            this.pboxBackground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBackground2.TabIndex = 7;
            this.pboxBackground2.TabStop = false;
            // 
            // btnSortPlayers
            // 
            this.btnSortPlayers.Font = new System.Drawing.Font("Menlo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortPlayers.Location = new System.Drawing.Point(292, 143);
            this.btnSortPlayers.Name = "btnSortPlayers";
            this.btnSortPlayers.Size = new System.Drawing.Size(181, 47);
            this.btnSortPlayers.TabIndex = 8;
            this.btnSortPlayers.Text = "Sort players";
            this.btnSortPlayers.UseVisualStyleBackColor = true;
            this.btnSortPlayers.Click += new System.EventHandler(this.btnSortPlayers_Click);
            // 
            // lstboxPlayers
            // 
            this.lstboxPlayers.BackColor = System.Drawing.SystemColors.Control;
            this.lstboxPlayers.Font = new System.Drawing.Font("Menlo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxPlayers.FormattingEnabled = true;
            this.lstboxPlayers.ItemHeight = 15;
            this.lstboxPlayers.Location = new System.Drawing.Point(9, 196);
            this.lstboxPlayers.Name = "lstboxPlayers";
            this.lstboxPlayers.Size = new System.Drawing.Size(464, 199);
            this.lstboxPlayers.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstboxPlayers);
            this.Controls.Add(this.btnSortPlayers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreateRandomPlayer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pboxBackground2);
            this.Controls.Add(this.pboxBackground);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nested Class";
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateRandomPlayer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pboxBackground;
        private System.Windows.Forms.PictureBox pboxBackground2;
        private System.Windows.Forms.Button btnSortPlayers;
        private System.Windows.Forms.ListBox lstboxPlayers;
    }
}

