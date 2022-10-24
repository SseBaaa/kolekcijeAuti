namespace kolekcijeAuti
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
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxGodina = new System.Windows.Forms.TextBox();
            this.textBoxKotaci = new System.Windows.Forms.TextBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.buttonObradi = new System.Windows.Forms.Button();
            this.buttonispisi = new System.Windows.Forms.Button();
            this.textBoxIspis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(22, 40);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(121, 20);
            this.textBoxModel.TabIndex = 0;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxGodina
            // 
            this.textBoxGodina.Location = new System.Drawing.Point(22, 98);
            this.textBoxGodina.Name = "textBoxGodina";
            this.textBoxGodina.Size = new System.Drawing.Size(121, 20);
            this.textBoxGodina.TabIndex = 1;
            // 
            // textBoxKotaci
            // 
            this.textBoxKotaci.Location = new System.Drawing.Point(25, 155);
            this.textBoxKotaci.Name = "textBoxKotaci";
            this.textBoxKotaci.Size = new System.Drawing.Size(121, 20);
            this.textBoxKotaci.TabIndex = 2;
            this.textBoxKotaci.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(165, 40);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(204, 135);
            this.buttonUnesi.TabIndex = 4;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // buttonObradi
            // 
            this.buttonObradi.Location = new System.Drawing.Point(375, 40);
            this.buttonObradi.Name = "buttonObradi";
            this.buttonObradi.Size = new System.Drawing.Size(195, 135);
            this.buttonObradi.TabIndex = 5;
            this.buttonObradi.Text = "Obradi";
            this.buttonObradi.UseVisualStyleBackColor = true;
            this.buttonObradi.Click += new System.EventHandler(this.buttonObradi_Click);
            // 
            // buttonispisi
            // 
            this.buttonispisi.Location = new System.Drawing.Point(576, 40);
            this.buttonispisi.Name = "buttonispisi";
            this.buttonispisi.Size = new System.Drawing.Size(202, 135);
            this.buttonispisi.TabIndex = 6;
            this.buttonispisi.Text = "Ispisi";
            this.buttonispisi.UseVisualStyleBackColor = true;
            this.buttonispisi.Click += new System.EventHandler(this.buttonispisi_Click);
            // 
            // textBoxIspis
            // 
            this.textBoxIspis.Location = new System.Drawing.Point(22, 197);
            this.textBoxIspis.Multiline = true;
            this.textBoxIspis.Name = "textBoxIspis";
            this.textBoxIspis.Size = new System.Drawing.Size(756, 241);
            this.textBoxIspis.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Godina proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Broj kotača";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIspis);
            this.Controls.Add(this.buttonispisi);
            this.Controls.Add(this.buttonObradi);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.textBoxKotaci);
            this.Controls.Add(this.textBoxGodina);
            this.Controls.Add(this.textBoxModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxGodina;
        private System.Windows.Forms.TextBox textBoxKotaci;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.Button buttonObradi;
        private System.Windows.Forms.Button buttonispisi;
        private System.Windows.Forms.TextBox textBoxIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

