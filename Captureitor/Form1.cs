using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace Captureitor
{
    public partial class Form1 : Form
    {
        private int TelaLargura = 0;
        private int TelaAltura = 0;
        private Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int keyCode);

        private void timer1_Tick(object sender, EventArgs e)
        {
            const short Vlr = -32768;
            bool KShift = (GetAsyncKeyState(160) == Vlr); // VK_LSHIFT 0xA0
            bool KControl = (GetAsyncKeyState(162) == Vlr); // VK_LCONTROL  0xA2
            bool KA = (GetAsyncKeyState(65) == Vlr); // A
            bool KQ = (GetAsyncKeyState(81) == Vlr); // Q
            if (KControl & KShift)
            {
                if (KA)
                {
                    Console.WriteLine("Ligar");
                    tmPS.Interval = 1000;
                    tmPS.Enabled = true;
                } else
                {
                    if (KQ)
                    {
                        Console.WriteLine("Desligar");
                        tmPS.Enabled = false;
                    }
                }
            }
        }
        private void tmPS_Tick(object sender, EventArgs e)
        {
            tmPS.Enabled = false;
            Bitmap b = new Bitmap(this.TelaLargura, this.TelaAltura);
            this.g = Graphics.FromImage(b);
            Point p1 = new Point(1700, -125);
            Point p2 = new Point(0, 0);
            Size S = new Size(1800, 1200); // Original
            this.g.CopyFromScreen(p1, p2, S);
            picTela.Image = b;
            string sData = DateTime.Now.ToShortDateString().Replace(@"/", "-");
            string sHora = DateTime.Now.ToLongTimeString().Replace(@":", "");
            string nmArq = "Cap_" + sData + sHora+".jpg";
            picTela.Image.Save(nmArq, System.Drawing.Imaging.ImageFormat.Jpeg);
            tmPS.Interval = tmPS.Interval+3;
            tmPS.Enabled = true;
            Console.WriteLine("Capturou");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TelaLargura = Screen.PrimaryScreen.Bounds.Width;
            this.TelaAltura = Screen.PrimaryScreen.Bounds.Height;
        }
    }
}

// Comentário do Luiz Henrique sobre otimização no código

//Sendo widows, você pode fazer isso usando API e pode literalmente pegar a tela e não um trecho da imagem global do Windows.
//Dá pra saber tudo sobre ela com a função da api "getdevicecaps".
//E você pode usar a função "bitblt" pra fazer uma cópia em memória da imagem que um monitor específico está mostrando.