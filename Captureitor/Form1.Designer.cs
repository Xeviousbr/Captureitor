
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 243);
            this.Controls.Add(this.picTela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmPS;
        private System.Windows.Forms.PictureBox picTela;
    }
}

