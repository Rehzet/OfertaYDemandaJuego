
namespace OfertaYDemandaJuego
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNextIter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPan = new System.Windows.Forms.Label();
            this.labelFruta = new System.Windows.Forms.Label();
            this.labelCerveza = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNextIter
            // 
            this.buttonNextIter.Location = new System.Drawing.Point(680, 12);
            this.buttonNextIter.Name = "buttonNextIter";
            this.buttonNextIter.Size = new System.Drawing.Size(97, 23);
            this.buttonNextIter.TabIndex = 0;
            this.buttonNextIter.Text = "Siguiente día";
            this.buttonNextIter.UseVisualStyleBackColor = true;
            this.buttonNextIter.Click += new System.EventHandler(this.buttonNextIter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pan:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fruta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cerveza:";
            // 
            // labelPan
            // 
            this.labelPan.AutoSize = true;
            this.labelPan.Location = new System.Drawing.Point(49, 16);
            this.labelPan.Name = "labelPan";
            this.labelPan.Size = new System.Drawing.Size(38, 15);
            this.labelPan.TabIndex = 4;
            this.labelPan.Text = "label4";
            // 
            // labelFruta
            // 
            this.labelFruta.AutoSize = true;
            this.labelFruta.Location = new System.Drawing.Point(56, 52);
            this.labelFruta.Name = "labelFruta";
            this.labelFruta.Size = new System.Drawing.Size(38, 15);
            this.labelFruta.TabIndex = 5;
            this.labelFruta.Text = "label5";
            // 
            // labelCerveza
            // 
            this.labelCerveza.AutoSize = true;
            this.labelCerveza.Location = new System.Drawing.Point(70, 91);
            this.labelCerveza.Name = "labelCerveza";
            this.labelCerveza.Size = new System.Drawing.Size(38, 15);
            this.labelCerveza.TabIndex = 6;
            this.labelCerveza.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ciudadano 1:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(491, 76);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(38, 15);
            this.labelMoney.TabIndex = 8;
            this.labelMoney.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 454);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCerveza);
            this.Controls.Add(this.labelFruta);
            this.Controls.Add(this.labelPan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNextIter);
            this.Name = "Form1";
            this.Text = "Pan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNextIter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPan;
        private System.Windows.Forms.Label labelFruta;
        private System.Windows.Forms.Label labelCerveza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMoney;
    }
}

