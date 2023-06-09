namespace TicTacToe
{
    partial class Developers
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
            this.label_Developer = new System.Windows.Forms.Label();
            this.label_Theo = new System.Windows.Forms.Label();
            this.label_Aaron = new System.Windows.Forms.Label();
            this.label_Chester = new System.Windows.Forms.Label();
            this.label_Yanik = new System.Windows.Forms.Label();
            this.button_mainmenu = new System.Windows.Forms.Button();
            this.label_Thanks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Developer
            // 
            this.label_Developer.AutoSize = true;
            this.label_Developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Developer.Location = new System.Drawing.Point(127, 42);
            this.label_Developer.Name = "label_Developer";
            this.label_Developer.Size = new System.Drawing.Size(392, 46);
            this.label_Developer.TabIndex = 0;
            this.label_Developer.Text = "Game developed by";
            // 
            // label_Theo
            // 
            this.label_Theo.AutoSize = true;
            this.label_Theo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Theo.Location = new System.Drawing.Point(47, 138);
            this.label_Theo.Name = "label_Theo";
            this.label_Theo.Size = new System.Drawing.Size(242, 37);
            this.label_Theo.TabIndex = 1;
            this.label_Theo.Text = "Theo Schneider";
            this.label_Theo.Visible = false;
            // 
            // label_Aaron
            // 
            this.label_Aaron.AutoSize = true;
            this.label_Aaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Aaron.Location = new System.Drawing.Point(366, 203);
            this.label_Aaron.Name = "label_Aaron";
            this.label_Aaron.Size = new System.Drawing.Size(213, 37);
            this.label_Aaron.TabIndex = 2;
            this.label_Aaron.Text = "Aaron Seiffert";
            this.label_Aaron.Visible = false;
            // 
            // label_Chester
            // 
            this.label_Chester.AutoSize = true;
            this.label_Chester.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Chester.Location = new System.Drawing.Point(47, 203);
            this.label_Chester.Name = "label_Chester";
            this.label_Chester.Size = new System.Drawing.Size(266, 37);
            this.label_Chester.TabIndex = 3;
            this.label_Chester.Text = "Chester Neuhaus";
            this.label_Chester.Visible = false;
            // 
            // label_Yanik
            // 
            this.label_Yanik.AutoSize = true;
            this.label_Yanik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Yanik.Location = new System.Drawing.Point(366, 138);
            this.label_Yanik.Name = "label_Yanik";
            this.label_Yanik.Size = new System.Drawing.Size(214, 37);
            this.label_Yanik.TabIndex = 4;
            this.label_Yanik.Text = "Yanik Howald";
            this.label_Yanik.Visible = false;
            // 
            // button_mainmenu
            // 
            this.button_mainmenu.Location = new System.Drawing.Point(169, 342);
            this.button_mainmenu.Name = "button_mainmenu";
            this.button_mainmenu.Size = new System.Drawing.Size(314, 46);
            this.button_mainmenu.TabIndex = 5;
            this.button_mainmenu.Text = "Hauptmenü";
            this.button_mainmenu.UseVisualStyleBackColor = true;
            this.button_mainmenu.Visible = false;
            this.button_mainmenu.Click += new System.EventHandler(this.button_mainmenu_Click);
            // 
            // label_Thanks
            // 
            this.label_Thanks.AutoSize = true;
            this.label_Thanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Thanks.Location = new System.Drawing.Point(162, 270);
            this.label_Thanks.Name = "label_Thanks";
            this.label_Thanks.Size = new System.Drawing.Size(321, 40);
            this.label_Thanks.TabIndex = 6;
            this.label_Thanks.Text = "Thanks for playing!";
            this.label_Thanks.Visible = false;
            // 
            // Developers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 418);
            this.Controls.Add(this.label_Thanks);
            this.Controls.Add(this.button_mainmenu);
            this.Controls.Add(this.label_Yanik);
            this.Controls.Add(this.label_Chester);
            this.Controls.Add(this.label_Aaron);
            this.Controls.Add(this.label_Theo);
            this.Controls.Add(this.label_Developer);
            this.Name = "Developers";
            this.Text = "Developers";
            this.Load += new System.EventHandler(this.Developers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Developer;
        private System.Windows.Forms.Label label_Theo;
        private System.Windows.Forms.Label label_Aaron;
        private System.Windows.Forms.Label label_Chester;
        private System.Windows.Forms.Label label_Yanik;
        private System.Windows.Forms.Button button_mainmenu;
        private System.Windows.Forms.Label label_Thanks;
    }
}