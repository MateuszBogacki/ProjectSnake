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
            this.pkt_lbl = new System.Windows.Forms.Label();
            this.punkty_lbl = new System.Windows.Forms.Label();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.restart_lbl = new System.Windows.Forms.Label();
            this.main_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.poziom_lbl = new System.Windows.Forms.Label();
            this.poziom1_lbl = new System.Windows.Forms.Label();
            this.pkt2_lbl = new System.Windows.Forms.Label();
            this.punkty2_lbl = new System.Windows.Forms.Label();
            this.gracz2_lbl = new System.Windows.Forms.Label();
            this.gracz1_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // pkt_lbl
            // 
            this.pkt_lbl.AutoSize = true;
            this.pkt_lbl.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkt_lbl.ForeColor = System.Drawing.Color.Lime;
            this.pkt_lbl.Location = new System.Drawing.Point(6, 16);
            this.pkt_lbl.Name = "pkt_lbl";
            this.pkt_lbl.Size = new System.Drawing.Size(103, 33);
            this.pkt_lbl.TabIndex = 1;
            this.pkt_lbl.Text = "Punkty:";
            // 
            // punkty_lbl
            // 
            this.punkty_lbl.AutoSize = true;
            this.punkty_lbl.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.punkty_lbl.ForeColor = System.Drawing.Color.Lime;
            this.punkty_lbl.Location = new System.Drawing.Point(126, 16);
            this.punkty_lbl.Name = "punkty_lbl";
            this.punkty_lbl.Size = new System.Drawing.Size(29, 33);
            this.punkty_lbl.TabIndex = 2;
            this.punkty_lbl.Text = "0";
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.Location = new System.Drawing.Point(660, 9);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(51, 13);
            this.exit_lbl.TabIndex = 3;
            this.exit_lbl.Text = "Esc - Exit";
            // 
            // restart_lbl
            // 
            this.restart_lbl.AutoSize = true;
            this.restart_lbl.Location = new System.Drawing.Point(649, 31);
            this.restart_lbl.Name = "restart_lbl";
            this.restart_lbl.Size = new System.Drawing.Size(62, 13);
            this.restart_lbl.TabIndex = 4;
            this.restart_lbl.Text = "F1 - Restart";
            // 
            // main_lbl
            // 
            this.main_lbl.AutoSize = true;
            this.main_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.main_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_lbl.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.main_lbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.main_lbl.Location = new System.Drawing.Point(33, 75);
            this.main_lbl.Name = "main_lbl";
            this.main_lbl.Size = new System.Drawing.Size(429, 85);
            this.main_lbl.TabIndex = 5;
            this.main_lbl.Text = "GAME OVER";
            this.main_lbl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(177, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 47);
            this.label5.TabIndex = 6;
            this.label5.Text = "Liczba Punktów:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(483, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 47);
            this.label6.TabIndex = 7;
            this.label6.Text = "0";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(245, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 76);
            this.label7.TabIndex = 8;
            this.label7.Text = "Esc - Wyjście \r\nF1 - Restart";
            this.label7.Visible = false;
            // 
            // poziom_lbl
            // 
            this.poziom_lbl.AutoSize = true;
            this.poziom_lbl.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poziom_lbl.ForeColor = System.Drawing.Color.Red;
            this.poziom_lbl.Location = new System.Drawing.Point(222, 16);
            this.poziom_lbl.Name = "poziom_lbl";
            this.poziom_lbl.Size = new System.Drawing.Size(103, 33);
            this.poziom_lbl.TabIndex = 9;
            this.poziom_lbl.Text = "Poziom:";
            // 
            // poziom1_lbl
            // 
            this.poziom1_lbl.AutoSize = true;
            this.poziom1_lbl.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.poziom1_lbl.ForeColor = System.Drawing.Color.Red;
            this.poziom1_lbl.Location = new System.Drawing.Point(323, 16);
            this.poziom1_lbl.Name = "poziom1_lbl";
            this.poziom1_lbl.Size = new System.Drawing.Size(26, 33);
            this.poziom1_lbl.TabIndex = 10;
            this.poziom1_lbl.Text = "1";
            // 
            // pkt2_lbl
            // 
            this.pkt2_lbl.AutoSize = true;
            this.pkt2_lbl.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkt2_lbl.ForeColor = System.Drawing.Color.Gold;
            this.pkt2_lbl.Location = new System.Drawing.Point(418, 16);
            this.pkt2_lbl.Name = "pkt2_lbl";
            this.pkt2_lbl.Size = new System.Drawing.Size(103, 33);
            this.pkt2_lbl.TabIndex = 12;
            this.pkt2_lbl.Text = "Punkty:";
            // 
            // punkty2_lbl
            // 
            this.punkty2_lbl.AutoSize = true;
            this.punkty2_lbl.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold);
            this.punkty2_lbl.ForeColor = System.Drawing.Color.Gold;
            this.punkty2_lbl.Location = new System.Drawing.Point(539, 16);
            this.punkty2_lbl.Name = "punkty2_lbl";
            this.punkty2_lbl.Size = new System.Drawing.Size(29, 33);
            this.punkty2_lbl.TabIndex = 13;
            this.punkty2_lbl.Text = "0";
            // 
            // gracz2_lbl
            // 
            this.gracz2_lbl.AutoSize = true;
            this.gracz2_lbl.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gracz2_lbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.gracz2_lbl.Location = new System.Drawing.Point(445, -3);
            this.gracz2_lbl.Name = "gracz2_lbl";
            this.gracz2_lbl.Size = new System.Drawing.Size(78, 25);
            this.gracz2_lbl.TabIndex = 14;
            this.gracz2_lbl.Text = "Gracz 2";
            // 
            // gracz1_lbl
            // 
            this.gracz1_lbl.AutoSize = true;
            this.gracz1_lbl.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.gracz1_lbl.ForeColor = System.Drawing.Color.Green;
            this.gracz1_lbl.Location = new System.Drawing.Point(34, -3);
            this.gracz1_lbl.Name = "gracz1_lbl";
            this.gracz1_lbl.Size = new System.Drawing.Size(75, 25);
            this.gracz1_lbl.TabIndex = 15;
            this.gracz1_lbl.Text = "Gracz 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gracz1_lbl);
            this.Controls.Add(this.gracz2_lbl);
            this.Controls.Add(this.punkty2_lbl);
            this.Controls.Add(this.pkt2_lbl);
            this.Controls.Add(this.poziom1_lbl);
            this.Controls.Add(this.poziom_lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.main_lbl);
            this.Controls.Add(this.restart_lbl);
            this.Controls.Add(this.exit_lbl);
            this.Controls.Add(this.punkty_lbl);
            this.Controls.Add(this.pkt_lbl);
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
        private System.Windows.Forms.Label pkt_lbl;
        private System.Windows.Forms.Label punkty_lbl;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Label restart_lbl;
        private System.Windows.Forms.Label main_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label poziom_lbl;
        private System.Windows.Forms.Label poziom1_lbl;
        private System.Windows.Forms.Label pkt2_lbl;
        private System.Windows.Forms.Label punkty2_lbl;
        private System.Windows.Forms.Label gracz2_lbl;
        private System.Windows.Forms.Label gracz1_lbl;
        private System.Windows.Forms.Label label1;
    }
}

