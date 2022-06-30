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
            this.g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.Bounds.Size);
            picTela.Image = b;
            picTela.Image.Save("svdTela.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            tmPS.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TelaLargura = Screen.PrimaryScreen.Bounds.Width;
            this.TelaAltura = Screen.PrimaryScreen.Bounds.Height;
        }
    }
}
