
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
            this.components = new System.ComponentModel.Container();
            this.buttonNextIter = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCityName = new System.Windows.Forms.Label();
            this.buttonPrevCity = new System.Windows.Forms.Button();
            this.buttonNextCity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNextIter
            // 
            this.buttonNextIter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextIter.Location = new System.Drawing.Point(680, 12);
            this.buttonNextIter.Name = "buttonNextIter";
            this.buttonNextIter.Size = new System.Drawing.Size(97, 23);
            this.buttonNextIter.TabIndex = 0;
            this.buttonNextIter.Text = "Siguiente día";
            this.buttonNextIter.UseVisualStyleBackColor = true;
            this.buttonNextIter.Click += new System.EventHandler(this.buttonNextIter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(440, 414);
            this.dataGridView1.TabIndex = 9;
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(213, 53);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(38, 15);
            this.labelCityName.TabIndex = 10;
            this.labelCityName.Text = "label1";
            // 
            // buttonPrevCity
            // 
            this.buttonPrevCity.Location = new System.Drawing.Point(12, 42);
            this.buttonPrevCity.Name = "buttonPrevCity";
            this.buttonPrevCity.Size = new System.Drawing.Size(28, 23);
            this.buttonPrevCity.TabIndex = 11;
            this.buttonPrevCity.Text = "<";
            this.buttonPrevCity.UseVisualStyleBackColor = true;
            this.buttonPrevCity.Click += new System.EventHandler(this.buttonPrevCity_Click);
            // 
            // buttonNextCity
            // 
            this.buttonNextCity.Location = new System.Drawing.Point(424, 42);
            this.buttonNextCity.Name = "buttonNextCity";
            this.buttonNextCity.Size = new System.Drawing.Size(28, 23);
            this.buttonNextCity.TabIndex = 12;
            this.buttonNextCity.Text = ">";
            this.buttonNextCity.UseVisualStyleBackColor = true;
            this.buttonNextCity.Click += new System.EventHandler(this.buttonNextCity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(789, 497);
            this.Controls.Add(this.buttonNextCity);
            this.Controls.Add(this.buttonPrevCity);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.buttonNextIter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Pan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNextIter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.Button buttonPrevCity;
        private System.Windows.Forms.Button buttonNextCity;
    }
}

