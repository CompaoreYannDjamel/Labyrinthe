using System;
using System.Windows.Forms;


namespace TP1_INF1008
{
    static class Program
    {
        
        
       
        // Partie principale de notre programme
        
        
      
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
           
        }
       
    }
    
}
