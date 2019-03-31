namespace Pexeso
{
    partial class PexesoForm
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
            this.bStart = new System.Windows.Forms.Button();
            this.bNaStart = new System.Windows.Forms.Button();
            this.bZahratJeste = new System.Windows.Forms.Button();
            this.lVysledek = new System.Windows.Forms.Label();
            this.bKonec = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.Label();
            this.Cutter = new System.Windows.Forms.Button();
            this.lNavod = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.Black;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.ForeColor = System.Drawing.Color.Green;
            this.bStart.Location = new System.Drawing.Point(242, 218);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(100, 30);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bNaStart
            // 
            this.bNaStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNaStart.BackColor = System.Drawing.Color.Black;
            this.bNaStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNaStart.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNaStart.ForeColor = System.Drawing.Color.Green;
            this.bNaStart.Location = new System.Drawing.Point(12, 438);
            this.bNaStart.Name = "bNaStart";
            this.bNaStart.Size = new System.Drawing.Size(100, 30);
            this.bNaStart.TabIndex = 1;
            this.bNaStart.Text = "Na Start";
            this.bNaStart.UseVisualStyleBackColor = false;
            this.bNaStart.Click += new System.EventHandler(this.bNaStart_Click);
            // 
            // bZahratJeste
            // 
            this.bZahratJeste.BackColor = System.Drawing.Color.Black;
            this.bZahratJeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZahratJeste.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZahratJeste.ForeColor = System.Drawing.Color.Green;
            this.bZahratJeste.Location = new System.Drawing.Point(242, 257);
            this.bZahratJeste.Name = "bZahratJeste";
            this.bZahratJeste.Size = new System.Drawing.Size(143, 30);
            this.bZahratJeste.TabIndex = 2;
            this.bZahratJeste.Text = "Zhrát Ještě";
            this.bZahratJeste.UseVisualStyleBackColor = false;
            this.bZahratJeste.Click += new System.EventHandler(this.bZahratJeste_Click);
            // 
            // lVysledek
            // 
            this.lVysledek.AutoSize = true;
            this.lVysledek.BackColor = System.Drawing.Color.Black;
            this.lVysledek.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVysledek.ForeColor = System.Drawing.Color.Green;
            this.lVysledek.Location = new System.Drawing.Point(254, 226);
            this.lVysledek.Name = "lVysledek";
            this.lVysledek.Size = new System.Drawing.Size(110, 22);
            this.lVysledek.TabIndex = 4;
            this.lVysledek.Text = "Skore: 173";
            // 
            // bKonec
            // 
            this.bKonec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bKonec.BackColor = System.Drawing.Color.Black;
            this.bKonec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKonec.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKonec.ForeColor = System.Drawing.Color.Green;
            this.bKonec.Location = new System.Drawing.Point(709, 438);
            this.bKonec.Name = "bKonec";
            this.bKonec.Size = new System.Drawing.Size(100, 30);
            this.bKonec.TabIndex = 5;
            this.bKonec.Text = "Konec";
            this.bKonec.UseVisualStyleBackColor = false;
            this.bKonec.Click += new System.EventHandler(this.bKonec_Click);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.BackColor = System.Drawing.Color.Black;
            this.debug.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug.ForeColor = System.Drawing.Color.Green;
            this.debug.Location = new System.Drawing.Point(674, 178);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(80, 22);
            this.debug.TabIndex = 6;
            this.debug.Text = "console";
            this.debug.Visible = false;
            // 
            // Cutter
            // 
            this.Cutter.BackColor = System.Drawing.Color.Black;
            this.Cutter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cutter.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cutter.ForeColor = System.Drawing.Color.Green;
            this.Cutter.Location = new System.Drawing.Point(654, 216);
            this.Cutter.Name = "Cutter";
            this.Cutter.Size = new System.Drawing.Size(100, 30);
            this.Cutter.TabIndex = 7;
            this.Cutter.Text = "Cut";
            this.Cutter.UseVisualStyleBackColor = false;
            this.Cutter.Visible = false;
            this.Cutter.Click += new System.EventHandler(this.Cutter_Click);
            // 
            // lNavod
            // 
            this.lNavod.BackColor = System.Drawing.Color.Black;
            this.lNavod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lNavod.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.lNavod.ForeColor = System.Drawing.Color.Green;
            this.lNavod.Location = new System.Drawing.Point(52, 48);
            this.lNavod.Name = "lNavod";
            this.lNavod.ReadOnly = true;
            this.lNavod.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lNavod.Size = new System.Drawing.Size(664, 96);
            this.lNavod.TabIndex = 8;
            this.lNavod.Text = "Vítej ve hře PEXESO\nNajdi skryté dvojice kartiček a získej co největší úspěšnost." +
    "\nHodně štěstí.";
            // 
            // PexesoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(821, 480);
            this.Controls.Add(this.lNavod);
            this.Controls.Add(this.Cutter);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.bKonec);
            this.Controls.Add(this.lVysledek);
            this.Controls.Add(this.bZahratJeste);
            this.Controls.Add(this.bNaStart);
            this.Controls.Add(this.bStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PexesoForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.ClickOnButton);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bNaStart;
        private System.Windows.Forms.Button bZahratJeste;
        private System.Windows.Forms.Label lVysledek;
        private System.Windows.Forms.Button bKonec;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Button Cutter;
        private System.Windows.Forms.RichTextBox lNavod;
    }
}

