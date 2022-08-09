
namespace Captureitor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmPS = new System.Windows.Forms.Timer(this.components);
            this.picTela = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTela)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmPS
            // 
            this.tmPS.Enabled = true;
            this.tmPS.Interval = 1000;
            this.tmPS.Tick += new System.EventHandler(this.tmPS_Tick);
            // 
            // picTela
            // 
            this.picTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTela.Location = new System.Drawing.Point(0, 0);
            this.picTela.Name = "picTela";
            this.picTela.Size = new System.Drawing.Size(303, 243);
            this.picTela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTela.TabIndex = 0;
            this.picTela.TabStop = false;
            this.picTela.Click += new System.EventHandler(this.picTela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 243);
            this.Controls.Add(this.picTela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1285, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Captureitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picTela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmPS;
        private System.Windows.Forms.PictureBox picTela;
    }
}

