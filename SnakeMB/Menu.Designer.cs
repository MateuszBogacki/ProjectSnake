namespace SnakeMB
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.onePlayer_button = new System.Windows.Forms.Button();
            this.twoPlayers_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 375);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // onePlayer_button
            // 
            this.onePlayer_button.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.onePlayer_button.Location = new System.Drawing.Point(82, 135);
            this.onePlayer_button.Name = "onePlayer_button";
            this.onePlayer_button.Size = new System.Drawing.Size(167, 45);
            this.onePlayer_button.TabIndex = 1;
            this.onePlayer_button.Text = "Jeden gracz";
            this.onePlayer_button.UseVisualStyleBackColor = true;
            this.onePlayer_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // twoPlayers_button
            // 
            this.twoPlayers_button.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twoPlayers_button.Location = new System.Drawing.Point(331, 135);
            this.twoPlayers_button.Name = "twoPlayers_button";
            this.twoPlayers_button.Size = new System.Drawing.Size(180, 45);
            this.twoPlayers_button.TabIndex = 2;
            this.twoPlayers_button.Text = "Dwóch graczy";
            this.twoPlayers_button.UseVisualStyleBackColor = true;
            this.twoPlayers_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.exit_button.Location = new System.Drawing.Point(82, 239);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(167, 39);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Wyjście";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 375);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.twoPlayers_button);
            this.Controls.Add(this.onePlayer_button);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button onePlayer_button;
        private System.Windows.Forms.Button twoPlayers_button;
        private System.Windows.Forms.Button exit_button;
    }
}