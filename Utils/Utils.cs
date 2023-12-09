using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1_INF1008.Utils
{
    static class Utils
    {
       
        public static readonly string labyrinthAddress = "..\\..\\LabyrintheDessin.txt";
        public static readonly string addressCalculation = "..\\..\\LabyrintheCalcul.txt";
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

      
        public static void DragMe(IntPtr Handle)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

    }
}
