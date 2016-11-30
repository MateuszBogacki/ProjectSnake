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
            this.label1 = new System.Windows.Forms.Label();
            this.punkty_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playground)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playground.Location = new System.Drawing.Point(11, 52);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(700, 360);
            this.playground.TabIndex = 0;
            this.playground.TabStop = false;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Punkty:";
            // 
            // punkty_lbl
            // 
            this.punkty_lbl.AutoSize = true;
            this.punkty_lbl.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.punkty_lbl.ForeColor = System.Drawing.Color.Lime;
            this.punkty_lbl.Location = new System.Drawing.Point(115, 16);
            this.punkty_lbl.Name = "punkty_lbl";
            this.punkty_lbl.Size = new System.Drawing.Size(29, 33);
            this.punkty_lbl.TabIndex = 2;
            this.punkty_lbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Esc - Exit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "F1 - Restart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.punkty_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.playground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label punkty_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

