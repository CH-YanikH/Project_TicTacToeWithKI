namespace TicTacToe
{
    partial class Mainmenu
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
            this.label_Hauptmenü = new System.Windows.Forms.Label();
            this.button_1vs1 = new System.Windows.Forms.Button();
            this.button_1vsAI = new System.Windows.Forms.Button();
            this.button_CloseApplication = new System.Windows.Forms.Button();
            this.button_Developers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Hauptmenü
            // 
            this.label_Hauptmenü.AutoSize = true;
            this.label_Hauptmenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hauptmenü.Location = new System.Drawing.Point(139, 20);
            this.label_Hauptmenü.Name = "label_Hauptmenü";
            this.label_Hauptmenü.Size = new System.Drawing.Size(225, 46);
            this.label_Hauptmenü.TabIndex = 0;
            this.label_Hauptmenü.Text = "Hauptmenü";
            // 
            // button_1vs1
            // 
            this.button_1vs1.Location = new System.Drawing.Point(20, 86);
            this.button_1vs1.Name = "button_1vs1";
            this.button_1vs1.Size = new System.Drawing.Size(217, 62);
            this.button_1vs1.TabIndex = 1;
            this.button_1vs1.Text = "1 vs 1";
            this.button_1vs1.UseVisualStyleBackColor = true;
            this.button_1vs1.Click += new System.EventHandler(this.button_1vs1_Click);
            // 
            // button_1vsAI
            // 
            this.button_1vsAI.Location = new System.Drawing.Point(258, 86);
            this.button_1vsAI.Name = "button_1vsAI";
            this.button_1vsAI.Size = new System.Drawing.Size(217, 62);
            this.button_1vsAI.TabIndex = 2;
            this.button_1vsAI.Text = "gegen KI";
            this.button_1vsAI.UseVisualStyleBackColor = true;
            this.button_1vsAI.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_CloseApplication
            // 
            this.button_CloseApplication.Location = new System.Drawing.Point(258, 169);
            this.button_CloseApplication.Name = "button_CloseApplication";
            this.button_CloseApplication.Size = new System.Drawing.Size(217, 62);
            this.button_CloseApplication.TabIndex = 3;
            this.button_CloseApplication.Text = "Spiel beenden";
            this.button_CloseApplication.UseVisualStyleBackColor = true;
            this.button_CloseApplication.Click += new System.EventHandler(this.button_CloseApplication_Click);
            // 
            // button_Developers
            // 
            this.button_Developers.Location = new System.Drawing.Point(20, 169);
            this.button_Developers.Name = "button_Developers";
            this.button_Developers.Size = new System.Drawing.Size(217, 62);
            this.button_Developers.TabIndex = 4;
            this.button_Developers.Text = "Entwickler";
            this.button_Developers.UseVisualStyleBackColor = true;
            this.button_Developers.Click += new System.EventHandler(this.button_Developers_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 279);
            this.Controls.Add(this.button_Developers);
            this.Controls.Add(this.button_CloseApplication);
            this.Controls.Add(this.button_1vsAI);
            this.Controls.Add(this.button_1vs1);
            this.Controls.Add(this.label_Hauptmenü);
            this.Name = "Mainmenu";
            this.Text = "Mainmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Hauptmenü;
        private System.Windows.Forms.Button button_1vs1;
        private System.Windows.Forms.Button button_1vsAI;
        private System.Windows.Forms.Button button_CloseApplication;
        private System.Windows.Forms.Button button_Developers;
    }
}