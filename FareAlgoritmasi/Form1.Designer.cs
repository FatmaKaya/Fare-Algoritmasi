namespace FareAlgoritmasi
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
            this.panelLabirent = new System.Windows.Forms.Panel();
            this.panelLabirentBilgileri = new System.Windows.Forms.Panel();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.btnPeynir = new System.Windows.Forms.Button();
            this.btnFare = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.buttonCiz = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.panelLabirentBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLabirent
            // 
            this.panelLabirent.Location = new System.Drawing.Point(172, 1);
            this.panelLabirent.Name = "panelLabirent";
            this.panelLabirent.Size = new System.Drawing.Size(604, 493);
            this.panelLabirent.TabIndex = 0;
            // 
            // panelLabirentBilgileri
            // 
            this.panelLabirentBilgileri.Controls.Add(this.lblMesaj);
            this.panelLabirentBilgileri.Controls.Add(this.lblY);
            this.panelLabirentBilgileri.Controls.Add(this.lblX);
            this.panelLabirentBilgileri.Controls.Add(this.btnPeynir);
            this.panelLabirentBilgileri.Controls.Add(this.btnFare);
            this.panelLabirentBilgileri.Controls.Add(this.btnBasla);
            this.panelLabirentBilgileri.Controls.Add(this.buttonCiz);
            this.panelLabirentBilgileri.Controls.Add(this.txtY);
            this.panelLabirentBilgileri.Controls.Add(this.txtX);
            this.panelLabirentBilgileri.Location = new System.Drawing.Point(2, 1);
            this.panelLabirentBilgileri.Name = "panelLabirentBilgileri";
            this.panelLabirentBilgileri.Size = new System.Drawing.Size(168, 493);
            this.panelLabirentBilgileri.TabIndex = 2;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(21, 209);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 8;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(80, 27);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(28, 13);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Boy:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(14, 27);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 13);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "En:";
            // 
            // btnPeynir
            // 
            this.btnPeynir.Location = new System.Drawing.Point(83, 163);
            this.btnPeynir.Name = "btnPeynir";
            this.btnPeynir.Size = new System.Drawing.Size(60, 23);
            this.btnPeynir.TabIndex = 5;
            this.btnPeynir.Text = "Peynir";
            this.btnPeynir.UseVisualStyleBackColor = true;
            this.btnPeynir.Click += new System.EventHandler(this.btnPeynir_Click);
            // 
            // btnFare
            // 
            this.btnFare.Location = new System.Drawing.Point(17, 163);
            this.btnFare.Name = "btnFare";
            this.btnFare.Size = new System.Drawing.Size(60, 23);
            this.btnFare.TabIndex = 4;
            this.btnFare.Text = "Fare";
            this.btnFare.UseVisualStyleBackColor = true;
            this.btnFare.Click += new System.EventHandler(this.btnFare_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(17, 123);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(126, 23);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // buttonCiz
            // 
            this.buttonCiz.Location = new System.Drawing.Point(17, 82);
            this.buttonCiz.Name = "buttonCiz";
            this.buttonCiz.Size = new System.Drawing.Size(126, 23);
            this.buttonCiz.TabIndex = 2;
            this.buttonCiz.Text = "Duvar Oluştur";
            this.buttonCiz.UseVisualStyleBackColor = true;
            this.buttonCiz.Click += new System.EventHandler(this.buttonCiz_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(83, 43);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(60, 20);
            this.txtY.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(17, 43);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(60, 20);
            this.txtX.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 496);
            this.Controls.Add(this.panelLabirentBilgileri);
            this.Controls.Add(this.panelLabirent);
            this.Name = "Form1";
            this.Text = "Labirent Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLabirentBilgileri.ResumeLayout(false);
            this.panelLabirentBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLabirent;
        private System.Windows.Forms.Panel panelLabirentBilgileri;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button buttonCiz;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnPeynir;
        private System.Windows.Forms.Button btnFare;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
    }
}

