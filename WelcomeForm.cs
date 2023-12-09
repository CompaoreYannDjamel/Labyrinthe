using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TP1_INF1008.Data;
using static TP1_INF1008.Utils.clsUtils;



namespace TP1_INF1008
{
    public partial class WelcomeForm : Form
    {

        private clsMap map;
        private LabyrinthForm labyrinthe = new LabyrinthForm();
        private int MIN = 1;
        private int length;
        private int width;
        private int max;

        public WelcomeForm()
        {
            InitializeComponent();
        }

      

   

       
        void Menus()
        {
            this.Hide();
            bool var = true;
            int menu;

            while (var)
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(

                    "\n\t\t\t*****MENU PRINCIPAL*****" );
                Console.ResetColor();

                Console.WriteLine("\n the available Options:" +
                  "\n\t1. Generate Random Labyrinth" +
                  "\n\t2. Generating the Labyrinth Manually" +
                  "\n\t3. Generate the Labyrinth With the data from the Statement" +
                  "\n\t4. Run Prim's algorithm" +
                   "\n\t5. Display the Labyrinth at the Console" +
                   "\n\t6. Exit\n");
                Console.Write("Select Option : ");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        map = CreationMapAleatoire();
                        labyrinthe.SetMap(map);
                        Console.WriteLine($"Number of Initialization Operations : {map.numberOfOperation}");
                        Console.WriteLine($"Information Dimension : {map}");
                        break;

                    case 2:
                        map = CreationMap();
                        labyrinthe.SetMap(map);
                        Console.WriteLine($"Number of operation : {map.numberOfOperation}");
                        Console.WriteLine($"Information Dimension : {map}");
                        break;

                    case 3:
                        map = PreRemplissage();
                        labyrinthe.SetMap(map);
                        Console.WriteLine($"Number of operation : {map.numberOfOperation}");
                        Console.WriteLine($"Information Dimension : {map}");
                        break;

                    case 4:
                        RunAlgoPrim();
                        break;

                    case 5:
                        RunAffichageLabyrinthe();
                        ReinitialisationCompteur(); 
                        break;

                    case 6:
                        
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        var = false;
                        Console.WriteLine("\n\t\t\tEnd of program\n\t\t\t\t\t\t");
                        
                        Thread.Sleep(5000);
                        Application.Exit();
                        break;

                    default:
                        Console.WriteLine("Please enter something correct");
                        break;
                }
            }

        }


       
        private void ReinitialisationCompteur()
        {
            map.numberOfOperation = 0;
            labyrinthe.BrushStroke = 0;
        }


      
        private void RunAffichageLabyrinthe()
        {
            if (map != null && labyrinthe.LiaisonFinale != null)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n\t\t\t     Display the Labyrinth at the Console     ");
                Console.ResetColor();
                Console.WriteLine(labyrinthe.AffichageLabyrinthe());
                SaveToFile();
            }
            else if (map != null && labyrinthe.LiaisonFinale == null)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tStart by Launching the PRIM algorithm !");
                Console.ResetColor();
                Console.WriteLine("\n");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tCommencer par Initialiser votre Labyrinthe (option 1, 2 ou 3)");
                Console.ResetColor();
                Console.WriteLine("\n");
            }

        }


  
        private void RunAlgoPrim()
        {
            if(map != null)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n\t\t\t  \t\nRun Prim's Algorithm       ");
                Console.WriteLine("\n\t\t\t\tPrim running...");
                Console.ResetColor();
         
                labyrinthe.Prim();
                Thread.Sleep(500);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\t\t     Successfully launched Prim's algorithm    ");
                Console.WriteLine($"\n\t\t\t   \tNumber Operation Prim : {labyrinthe.GetNbreOperationPrim()}\t   ");
                Console.ResetColor();
                Console.WriteLine("\n");
                
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\tStart by Initializing your Labyrinth (option 1, 2 ou 3)");
                Console.ResetColor();
                Console.WriteLine("\n");
            }
           
        }

        
        private void SaveToFile()
        {
            // Écrire dans le fichier "LabyrintheDessin.txt"
            File.WriteAllText(labyrinthAddress,
                $"\n\t\tLabyrinth\n\t\t        \n" +
                $"\n{labyrinthe.AffichageLabyrinthe()}");

          
            File.WriteAllText(addressCalculation,
                $"Information Dimension : {map}\n" +
                $"Number of Initialization operations : {map.numberOfOperation}\n" +
                $"Prim Operation Number : {labyrinthe.GetNbreOperationPrim()}\n" +
                $"Brushstroke : {labyrinthe.BrushStroke}\n"+
                $"Total number of operations : {labyrinthe.GetNbreOperationPrim() + map.numberOfOperation + labyrinthe.BrushStroke}");
        }


       
        private clsMap CreationMapAleatoire()
        {

            AskInfoMap();

            Console.WriteLine(" Enter the maximum weight");
            max = Convert.ToInt32(Console.ReadLine());
            map = new clsMap(length, width);

            if (max <= MIN)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a positive weight");
                Console.ResetColor();
                return null;
            }

            return map.RandomWeights(MIN, max);
        }

      
        private clsMap CreationMap()
        {
            int poids_Droite;
            int poids_Bas;
            AskInfoMap();

            for (int i = 0; i < length * width; i++)
            {
                do
                {
                    Console.WriteLine("Enter weight for map[{0}]- right : ", i);
                    poids_Droite = Convert.ToInt32(Console.ReadLine());

                    if (poids_Droite <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a positive weight (greater than 0)");
                        Console.ResetColor();
                    }
                } while (poids_Droite <= 0);

                do
                {
                    Console.WriteLine("\nEnter weight for map[{0}] - down: ", i);
                    poids_Bas = Convert.ToInt32(Console.ReadLine());
                    if (poids_Bas <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a positive weight (greater than 0)");
                        Console.ResetColor();
                    }
                } while (poids_Bas <= 0);

                map.AssignmentWeight(i, poids_Droite, true);
                map.AssignmentWeight(i, poids_Bas, false);
            }

            return map;
        }


      
        private void AskInfoMap()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\t\t\t***  Labyrinth Generation  ***");
            Console.ResetColor();

            Console.WriteLine(" Enter Labyrinth Length (Horizontal)");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter the width of the Labyrinth (Vertical)");
            width = Convert.ToInt32(Console.ReadLine());
        }


        public clsMap PreRemplissage() {

          
            map = new clsMap(6, 4);

            map.AssignmentWeight(0, 5, true);
            map.AssignmentWeight(0, 2, false);
            map.AssignmentWeight(1, 4, true);
            map.AssignmentWeight(1, 3, false);
            map.AssignmentWeight(2, 5, true);
            map.AssignmentWeight(2, 8, false);
            map.AssignmentWeight(3, 10, true);
            map.AssignmentWeight(3, 1, false);
            map.AssignmentWeight(4, 7, true);
            map.AssignmentWeight(4, 3, false);
            map.AssignmentWeight(5, 0, true);
            map.AssignmentWeight(5, 4, false);

            map.AssignmentWeight(6, 3, true);
            map.AssignmentWeight(6, 4, false);
            map.AssignmentWeight(7, 8, true);
            map.AssignmentWeight(7, 9, false);
            map.AssignmentWeight(8, 2, true);
            map.AssignmentWeight(8, 4, false);
            map.AssignmentWeight(9, 1, true);
            map.AssignmentWeight(9, 7, false);
            map.AssignmentWeight(10, 5, true);
            map.AssignmentWeight(10, 2, false);
            map.AssignmentWeight(11, 0, true);
            map.AssignmentWeight(11, 3, false);

            map.AssignmentWeight(12, 2, true);
            map.AssignmentWeight(12, 2, false);
            map.AssignmentWeight(13, 8, true);
            map.AssignmentWeight(13, 1, false);
            map.AssignmentWeight(14, 6, true);
            map.AssignmentWeight(14, 9, false);
            map.AssignmentWeight(15, 2, true);
            map.AssignmentWeight(15, 10, false);
            map.AssignmentWeight(16, 3, true);
            map.AssignmentWeight(16, 6, false);
            map.AssignmentWeight(17, 0, true);
            map.AssignmentWeight(17, 7, false);

            map.AssignmentWeight(18, 8, true);
            map.AssignmentWeight(18, 0, false);
            map.AssignmentWeight(19, 9, true);
            map.AssignmentWeight(19, 0, false);
            map.AssignmentWeight(20, 3, true);
            map.AssignmentWeight(20, 0, false);
            map.AssignmentWeight(21, 4, true);
            map.AssignmentWeight(21, 0, false);
            map.AssignmentWeight(22, 5, true);
            map.AssignmentWeight(22, 0, false);
            map.AssignmentWeight(23, 0, true);
            map.AssignmentWeight(23, 0, false);

            return map;
        }


     

       
        private void PannelDraggable_MouseDown(object sender, MouseEventArgs e)
        {
            DragMe(Handle);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DragMe(Handle);
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menus();
        }

        private void interfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LabyrinthForm().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
