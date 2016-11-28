namespace SnakeMB
{
    partial class Form1
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
            this.playground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playground)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playground.Location = new System.Drawing.Point(12, 52);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(529, 331);
            this.playground.TabIndex = 0;
            this.playground.TabStop = false;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 395);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.playground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playground;
    }
}

