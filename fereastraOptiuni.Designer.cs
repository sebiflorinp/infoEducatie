namespace infoEducatie
{
    partial class fereastraOptiuni
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
            this.optiuniBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rezolutiiDisponibile = new System.Windows.Forms.ComboBox();
            this.rezolutieNouAleasa = new System.Windows.Forms.Label();
            this.rezolutieCurenta = new System.Windows.Forms.Label();
            this.valoareaRezolutieCurenta = new System.Windows.Forms.Label();
            this.rezolutieSelectata = new System.Windows.Forms.Label();
            this.valoareRezolutieSelectata = new System.Windows.Forms.Label();
            this.butonAplica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optiuniBack
            // 
            this.optiuniBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.optiuniBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optiuniBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiuniBack.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.optiuniBack.Location = new System.Drawing.Point(12, 28);
            this.optiuniBack.Name = "optiuniBack";
            this.optiuniBack.Size = new System.Drawing.Size(76, 28);
            this.optiuniBack.TabIndex = 6;
            this.optiuniBack.Text = "<-";
            this.optiuniBack.UseVisualStyleBackColor = false;
            this.optiuniBack.Click += new System.EventHandler(this.optiuniBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(312, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "OPTIUNI";
            // 
            // rezolutiiDisponibile
            // 
            this.rezolutiiDisponibile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.rezolutiiDisponibile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rezolutiiDisponibile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rezolutiiDisponibile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezolutiiDisponibile.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rezolutiiDisponibile.FormattingEnabled = true;
            this.rezolutiiDisponibile.Items.AddRange(new object[] {
            "640 x 480",
            "800 x 600",
            "832 x 624",
            "1024 x 768",
            "1280 x 720",
            "1280 x 1024",
            "1360 x 768",
            "1366 x 768",
            "1600 x 900",
            "1680 x 1050",
            "1920 x 1080",
            "2560 x 1440",
            "2048 x 1080",
            "3840 x 2160"});
            this.rezolutiiDisponibile.Location = new System.Drawing.Point(624, 130);
            this.rezolutiiDisponibile.Name = "rezolutiiDisponibile";
            this.rezolutiiDisponibile.Size = new System.Drawing.Size(114, 21);
            this.rezolutiiDisponibile.TabIndex = 8;
            this.rezolutiiDisponibile.SelectedIndexChanged += new System.EventHandler(this.rezolutiiDisponibile_SelectedIndexChanged);
            // 
            // rezolutieNouAleasa
            // 
            this.rezolutieNouAleasa.AutoSize = true;
            this.rezolutieNouAleasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezolutieNouAleasa.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rezolutieNouAleasa.Location = new System.Drawing.Point(548, 131);
            this.rezolutieNouAleasa.Name = "rezolutieNouAleasa";
            this.rezolutieNouAleasa.Size = new System.Drawing.Size(71, 17);
            this.rezolutieNouAleasa.TabIndex = 9;
            this.rezolutieNouAleasa.Text = "Rezolutie:";
            // 
            // rezolutieCurenta
            // 
            this.rezolutieCurenta.AutoSize = true;
            this.rezolutieCurenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezolutieCurenta.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rezolutieCurenta.Location = new System.Drawing.Point(548, 75);
            this.rezolutieCurenta.Name = "rezolutieCurenta";
            this.rezolutieCurenta.Size = new System.Drawing.Size(123, 17);
            this.rezolutieCurenta.TabIndex = 10;
            this.rezolutieCurenta.Text = "Rezolutie curenta:";
            // 
            // valoareaRezolutieCurenta
            // 
            this.valoareaRezolutieCurenta.AutoSize = true;
            this.valoareaRezolutieCurenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valoareaRezolutieCurenta.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.valoareaRezolutieCurenta.Location = new System.Drawing.Point(677, 75);
            this.valoareaRezolutieCurenta.Name = "valoareaRezolutieCurenta";
            this.valoareaRezolutieCurenta.Size = new System.Drawing.Size(123, 17);
            this.valoareaRezolutieCurenta.TabIndex = 11;
            this.valoareaRezolutieCurenta.Text = "Rezolutie curenta:";
            // 
            // rezolutieSelectata
            // 
            this.rezolutieSelectata.AutoSize = true;
            this.rezolutieSelectata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezolutieSelectata.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rezolutieSelectata.Location = new System.Drawing.Point(548, 103);
            this.rezolutieSelectata.Name = "rezolutieSelectata";
            this.rezolutieSelectata.Size = new System.Drawing.Size(132, 17);
            this.rezolutieSelectata.TabIndex = 12;
            this.rezolutieSelectata.Text = "Rezolutie selectata:";
            // 
            // valoareRezolutieSelectata
            // 
            this.valoareRezolutieSelectata.AutoSize = true;
            this.valoareRezolutieSelectata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valoareRezolutieSelectata.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.valoareRezolutieSelectata.Location = new System.Drawing.Point(677, 103);
            this.valoareRezolutieSelectata.Name = "valoareRezolutieSelectata";
            this.valoareRezolutieSelectata.Size = new System.Drawing.Size(20, 17);
            this.valoareRezolutieSelectata.TabIndex = 13;
            this.valoareRezolutieSelectata.Text = "...";
            // 
            // butonAplica
            // 
            this.butonAplica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.butonAplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonAplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonAplica.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.butonAplica.Location = new System.Drawing.Point(337, 397);
            this.butonAplica.Name = "butonAplica";
            this.butonAplica.Size = new System.Drawing.Size(123, 25);
            this.butonAplica.TabIndex = 14;
            this.butonAplica.Text = "Aplica";
            this.butonAplica.UseVisualStyleBackColor = false;
            this.butonAplica.Click += new System.EventHandler(this.butonAplica_Click);
            // 
            // fereastraOptiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butonAplica);
            this.Controls.Add(this.valoareRezolutieSelectata);
            this.Controls.Add(this.rezolutieSelectata);
            this.Controls.Add(this.valoareaRezolutieCurenta);
            this.Controls.Add(this.rezolutieCurenta);
            this.Controls.Add(this.rezolutieNouAleasa);
            this.Controls.Add(this.rezolutiiDisponibile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optiuniBack);
            this.Name = "fereastraOptiuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fereastraOptiuni_Load);
            this.Controls.SetChildIndex(this.optiuniBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.rezolutiiDisponibile, 0);
            this.Controls.SetChildIndex(this.rezolutieNouAleasa, 0);
            this.Controls.SetChildIndex(this.rezolutieCurenta, 0);
            this.Controls.SetChildIndex(this.valoareaRezolutieCurenta, 0);
            this.Controls.SetChildIndex(this.rezolutieSelectata, 0);
            this.Controls.SetChildIndex(this.valoareRezolutieSelectata, 0);
            this.Controls.SetChildIndex(this.butonAplica, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optiuniBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rezolutiiDisponibile;
        private System.Windows.Forms.Label rezolutieNouAleasa;
        private System.Windows.Forms.Label rezolutieCurenta;
        private System.Windows.Forms.Label valoareaRezolutieCurenta;
        private System.Windows.Forms.Label rezolutieSelectata;
        private System.Windows.Forms.Label valoareRezolutieSelectata;
        private System.Windows.Forms.Button butonAplica;
    }
}