
namespace Enums.ExerciceOne
{
    partial class FrmMain
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
            this.nudCode1 = new System.Windows.Forms.NumericUpDown();
            this.numCode4 = new System.Windows.Forms.NumericUpDown();
            this.nudCode3 = new System.Windows.Forms.NumericUpDown();
            this.nudCode2 = new System.Windows.Forms.NumericUpDown();
            this.nudCode5 = new System.Windows.Forms.NumericUpDown();
            this.btnCodesToFruits = new System.Windows.Forms.Button();
            this.lstFruitCodes = new System.Windows.Forms.ListBox();
            this.btnFruitsToCodes = new System.Windows.Forms.Button();
            this.rtxFruits = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCode4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode5)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCode1
            // 
            this.nudCode1.Location = new System.Drawing.Point(34, 44);
            this.nudCode1.Name = "nudCode1";
            this.nudCode1.Size = new System.Drawing.Size(120, 20);
            this.nudCode1.TabIndex = 0;
            // 
            // numCode4
            // 
            this.numCode4.Location = new System.Drawing.Point(34, 158);
            this.numCode4.Name = "numCode4";
            this.numCode4.Size = new System.Drawing.Size(120, 20);
            this.numCode4.TabIndex = 2;
            // 
            // nudCode3
            // 
            this.nudCode3.Location = new System.Drawing.Point(34, 119);
            this.nudCode3.Name = "nudCode3";
            this.nudCode3.Size = new System.Drawing.Size(120, 20);
            this.nudCode3.TabIndex = 3;
            // 
            // nudCode2
            // 
            this.nudCode2.Location = new System.Drawing.Point(34, 80);
            this.nudCode2.Name = "nudCode2";
            this.nudCode2.Size = new System.Drawing.Size(120, 20);
            this.nudCode2.TabIndex = 4;
            // 
            // nudCode5
            // 
            this.nudCode5.Location = new System.Drawing.Point(34, 197);
            this.nudCode5.Name = "nudCode5";
            this.nudCode5.Size = new System.Drawing.Size(120, 20);
            this.nudCode5.TabIndex = 5;
            // 
            // btnCodesToFruits
            // 
            this.btnCodesToFruits.Location = new System.Drawing.Point(33, 252);
            this.btnCodesToFruits.Name = "btnCodesToFruits";
            this.btnCodesToFruits.Size = new System.Drawing.Size(120, 30);
            this.btnCodesToFruits.TabIndex = 6;
            this.btnCodesToFruits.Text = "button1";
            this.btnCodesToFruits.UseVisualStyleBackColor = true;
            // 
            // lstFruitCodes
            // 
            this.lstFruitCodes.FormattingEnabled = true;
            this.lstFruitCodes.Location = new System.Drawing.Point(409, 44);
            this.lstFruitCodes.Name = "lstFruitCodes";
            this.lstFruitCodes.Size = new System.Drawing.Size(190, 238);
            this.lstFruitCodes.TabIndex = 7;
            // 
            // btnFruitsToCodes
            // 
            this.btnFruitsToCodes.Location = new System.Drawing.Point(179, 252);
            this.btnFruitsToCodes.Name = "btnFruitsToCodes";
            this.btnFruitsToCodes.Size = new System.Drawing.Size(179, 30);
            this.btnFruitsToCodes.TabIndex = 8;
            this.btnFruitsToCodes.Text = "button2";
            this.btnFruitsToCodes.UseVisualStyleBackColor = true;
            // 
            // rtxFruits
            // 
            this.rtxFruits.Location = new System.Drawing.Point(179, 44);
            this.rtxFruits.Name = "rtxFruits";
            this.rtxFruits.Size = new System.Drawing.Size(179, 173);
            this.rtxFruits.TabIndex = 9;
            this.rtxFruits.Text = "";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 319);
            this.Controls.Add(this.rtxFruits);
            this.Controls.Add(this.btnFruitsToCodes);
            this.Controls.Add(this.lstFruitCodes);
            this.Controls.Add(this.btnCodesToFruits);
            this.Controls.Add(this.nudCode5);
            this.Controls.Add(this.nudCode2);
            this.Controls.Add(this.nudCode3);
            this.Controls.Add(this.numCode4);
            this.Controls.Add(this.nudCode1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCode1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCode4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCode1;
        private System.Windows.Forms.NumericUpDown numCode4;
        private System.Windows.Forms.NumericUpDown nudCode3;
        private System.Windows.Forms.NumericUpDown nudCode2;
        private System.Windows.Forms.NumericUpDown nudCode5;
        private System.Windows.Forms.Button btnCodesToFruits;
        private System.Windows.Forms.ListBox lstFruitCodes;
        private System.Windows.Forms.Button btnFruitsToCodes;
        private System.Windows.Forms.RichTextBox rtxFruits;
    }
}

