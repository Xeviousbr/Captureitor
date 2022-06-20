using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;

namespace Captureitor
{
    public partial class Form1 : Form
    {
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
                } else
                {
                    if (KQ)
                    {
                        Console.WriteLine("Desligar");
                    }
                }
            }
        }
    }
}
