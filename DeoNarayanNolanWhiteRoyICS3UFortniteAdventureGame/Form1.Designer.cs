namespace DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.reel3 = new System.Windows.Forms.Label();
            this.reel2 = new System.Windows.Forms.Label();
            this.reel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(24, 9);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(758, 41);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Before begining, pick a skin.";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(21, 322);
            this.redLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(58, 13);
            this.redLabel.TabIndex = 1;
            this.redLabel.Text = "John Wick";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(537, 322);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(41, 13);
            this.blueLabel.TabIndex = 2;
            this.blueLabel.Text = "Default";
            // 
            // yellowLabel
            // 
            this.yellowLabel.AutoSize = true;
            this.yellowLabel.ForeColor = System.Drawing.Color.White;
            this.yellowLabel.Location = new System.Drawing.Point(266, 322);
            this.yellowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(35, 13);
            this.yellowLabel.TabIndex = 3;
            this.yellowLabel.Text = "label4";
            this.yellowLabel.Visible = false;
            // 
            // reel3
            // 
            this.reel3.ForeColor = System.Drawing.Color.White;
            this.reel3.Image = ((System.Drawing.Image)(resources.GetObject("reel3.Image")));
            this.reel3.Location = new System.Drawing.Point(266, 91);
            this.reel3.Name = "reel3";
            this.reel3.Size = new System.Drawing.Size(250, 214);
            this.reel3.TabIndex = 6;
            // 
            // reel2
            // 
            this.reel2.Image = global::DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame.Properties.Resources.defaultSkin;
            this.reel2.Location = new System.Drawing.Point(537, 91);
            this.reel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reel2.Name = "reel2";
            this.reel2.Size = new System.Drawing.Size(254, 214);
            this.reel2.TabIndex = 5;
            // 
            // reel1
            // 
            this.reel1.Image = ((System.Drawing.Image)(resources.GetObject("reel1.Image")));
            this.reel1.Location = new System.Drawing.Point(11, 91);
            this.reel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reel1.Name = "reel1";
            this.reel1.Size = new System.Drawing.Size(250, 214);
            this.reel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(802, 389);
            this.Controls.Add(this.reel3);
            this.Controls.Add(this.reel2);
            this.Controls.Add(this.reel1);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Fortnite Simulator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label reel1;
        private System.Windows.Forms.Label reel2;
        private System.Windows.Forms.Label reel3;
    }
}

