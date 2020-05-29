namespace TreIRad
{
    partial class afterGame
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
            this.speletÖverText = new System.Windows.Forms.Label();
            this.startaOmKnapp = new System.Windows.Forms.Button();
            this.tillMenyKnapp = new System.Windows.Forms.Button();
            this.harVunnitBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // speletÖverText
            // 
            this.speletÖverText.AutoSize = true;
            this.speletÖverText.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speletÖverText.Location = new System.Drawing.Point(12, 20);
            this.speletÖverText.Name = "speletÖverText";
            this.speletÖverText.Size = new System.Drawing.Size(574, 65);
            this.speletÖverText.TabIndex = 0;
            this.speletÖverText.Text = "Spelet är över";
            // 
            // startaOmKnapp
            // 
            this.startaOmKnapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startaOmKnapp.Location = new System.Drawing.Point(147, 376);
            this.startaOmKnapp.Name = "startaOmKnapp";
            this.startaOmKnapp.Size = new System.Drawing.Size(307, 126);
            this.startaOmKnapp.TabIndex = 1;
            this.startaOmKnapp.Text = "Starta om";
            this.startaOmKnapp.UseVisualStyleBackColor = true;
            this.startaOmKnapp.Click += new System.EventHandler(this.startaOmKnapp_Click);
            // 
            // tillMenyKnapp
            // 
            this.tillMenyKnapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tillMenyKnapp.Location = new System.Drawing.Point(147, 244);
            this.tillMenyKnapp.Name = "tillMenyKnapp";
            this.tillMenyKnapp.Size = new System.Drawing.Size(307, 126);
            this.tillMenyKnapp.TabIndex = 2;
            this.tillMenyKnapp.Text = "Meny";
            this.tillMenyKnapp.UseVisualStyleBackColor = true;
            this.tillMenyKnapp.Click += new System.EventHandler(this.tillMenyKnapp_Click);
            // 
            // harVunnitBox
            // 
            this.harVunnitBox.AutoSize = true;
            this.harVunnitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harVunnitBox.Location = new System.Drawing.Point(140, 204);
            this.harVunnitBox.Name = "harVunnitBox";
            this.harVunnitBox.Size = new System.Drawing.Size(0, 37);
            this.harVunnitBox.TabIndex = 3;
            this.harVunnitBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // afterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.harVunnitBox);
            this.Controls.Add(this.tillMenyKnapp);
            this.Controls.Add(this.startaOmKnapp);
            this.Controls.Add(this.speletÖverText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "afterGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speletÖverText;
        private System.Windows.Forms.Button startaOmKnapp;
        private System.Windows.Forms.Button tillMenyKnapp;
        private System.Windows.Forms.Label harVunnitBox;
    }
}