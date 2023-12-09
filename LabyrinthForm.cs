using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP1_INF1008.Data;
using TP1_INF1008.Model;
using static TP1_INF1008.Model.clsNode;
using static TP1_INF1008.Utils.clsUtils;



namespace TP1_INF1008
{
    public partial class LabyrinthForm : Form
    {

        private clsMap map;
        private int width;
        private int length;
        private static readonly int MIN = 1;
        private int max;
        public static LabyrinthForm UserInterface;
        private static int nbOperationLabyrinthe;
        private HashSet<clsLiaison> finalLiaisons = null;
        private int brushstroke = 0;
        
        public LabyrinthForm()
        {
            InitializeComponent();
            UserInterface = this;
        }


       
        public HashSet<clsLiaison> LiaisonFinale
        {
            get { return finalLiaisons; }
        }

     
        public int BrushStroke
        {
            get { return brushstroke; }
            set { brushstroke = 0; }
        }


      
        public clsNode GetNoeud(int posX, int posY)
        {
            map.isValideXY(posX, posY);
            return new clsNode(this, posX, posY);
        }


        public clsMap GetMap()
        {
            return map;
        }

        public void SetMap(clsMap newMap)
        {
            this.map = newMap;
        }

       
        private void SaveToFile()
        {
            
            File.WriteAllText(labyrinthAddress,
                $"\n\t\tLabyrinth\n\t\t----------\n" +
                $"\n{AffichageLabyrinthe()}");

         
            File.WriteAllText(addressCalculation,
                $"{lbl_infoDimension.Text}\n" +
                $"{lbl_operation_init.Text}\n" +
                $"{lbl_operation_prim.Text}\n" +
                $"{lbl_coup_pinceau.Text}\n" +
                $"{lbl_operation_total.Text}");
        }


    
        private void btn_generer_Click(object sender, EventArgs e)
        {


            length = Convert.ToInt32(txtLength.Text.ToString());
            Console.WriteLine(" Here is the Labyrinth generated with PRIM:");
            length = Convert.ToInt32(txtLength.Text.ToString());
            width = Convert.ToInt32(txtWidth.Text.ToString());
            max = Convert.ToInt32(txtBox_max.Text.ToString());

          
            map = new clsMap(length, width);

         
            map.numberOfOperation = 0;

         
            map.RandomWeights(MIN, max);

            int nbOperationInitialisation = map.numberOfOperation;

          
            Prim();

          
            brushstroke = 0;

           
            Console.WriteLine(AffichageLabyrinthe());

        
            lbl_operation_init.Text = $"Number of Initialization operations : {nbOperationInitialisation}";
            lbl_operation_prim.Text = $"Prim Operation Number : {nbOperationLabyrinthe}";
            lbl_operation_total.Text = $"Total number of operations : {nbOperationLabyrinthe + nbOperationInitialisation + brushstroke}";
            lbl_coup_pinceau.Text = $"Brushstroke : {brushstroke}";
            lbl_infoDimension.Text = $"Information Dimension : {map}";

            SaveToFile();
        }


    
        public HashSet<clsLiaison> Prim()
        {
            nbOperationLabyrinthe = 0;

            HashSet<clsLiaison> liaisionDechues = new HashSet<clsLiaison>();
            HashSet<clsLiaison> liaisonPossible = new HashSet<clsLiaison>();
            finalLiaisons = new HashSet<clsLiaison>();
            HashSet<clsNode> finalNode = new HashSet<clsNode>();

            clsNode nodeToAdd = GetNoeud(0, 0);

          
            while (finalNode.Count < GetMap().GetWidh * GetMap().GetLength)
            {
                finalNode.Add(nodeToAdd);

                var values = EnumDirection.GetValues<Direction>();

                clsLiaison liaisonTime;
                foreach (Direction direction in values)
                {
         
                    try
                    {
                        liaisonTime = nodeToAdd.getLiaison(direction);

                     
                        if (liaisonPossible.Contains(liaisonTime))
                        {
                           
                            liaisonPossible.Remove(liaisonTime);
                            liaisionDechues.Add(liaisonTime);
                        }
                        else if (!liaisionDechues.Contains(liaisonTime) && !finalLiaisons.Contains(liaisonTime))
                        {
                        
                            liaisonPossible.Add(liaisonTime);
                        }

                    }
                    catch (Exception)
                    {
                       
                    }

                    nbOperationLabyrinthe += 1;
                }


               
                if (liaisonPossible.Count != 0)
                {
                   
                    liaisonTime = liaisonPossible.Min();

                  
                    if (!finalNode.Contains(liaisonTime.NodeDepart))
                        nodeToAdd = liaisonTime.NodeDepart;
                    else
                        nodeToAdd = liaisonTime.NodeArrive;

                   
                    liaisonPossible.Remove(liaisonTime);
                    finalLiaisons.Add(liaisonTime);
                }
            }

            return finalLiaisons;
        }


        public string AffichageLabyrinthe()
        {
           
            if (finalLiaisons == null)
            {
                MessageBox.Show("Start by Launching the PRIM algorithm !");
                return null;
            }


            StringBuilder str = new StringBuilder();

            clsLiaison[][] screen = new clsLiaison[GetMap().GetWidh * 2 - 1][];
            for (int y = 0; y < (GetMap().GetWidh * 2) - 1; y++)
            {
                screen[y] = new clsLiaison[(GetMap().GetLength * 2) - 1];
            }

        
            clsLiaison tmp;
            foreach (clsLiaison item in finalLiaisons)
            {
                tmp = item;
                int tmp_y = tmp.getCoordY();
                int tmp_x = tmp.GetCoordX();
                screen[tmp_y][tmp_x] = tmp;
            }

            for (int y = 0; y < GetMap().GetWidh * 2 - 1; y++)
            {
                for (int x = 0; x < GetMap().GetLength * 2 - 1; x++)
                {

                   
                    if (x == 0 && y == 0)
                        str.Append("E");
                    else if (x == GetMap().GetLength * 2 - 2 && y == GetMap().GetWidh * 2 - 2)
                        str.Append("S");
                    else if (x % 2 == 0 && y % 2 == 0)
                    {
                        str.Append(ProduceDirectionLink(
                            ElementExist(x, y - 1, screen),
                            ElementExist(x + 1, y, screen),
                            ElementExist(x, y + 1, screen),
                            ElementExist(x - 1, y, screen)
                            ));
                    }
                    else if (x % 2 == 1 && y % 2 == 0)
                    {
                        
                        if (ElementExist(x, y, screen))
                            str.Append("═");
                        else
                            str.Append("■");
                    }
                    else if (x % 2 == 0)
                    {
                      
                        if (ElementExist(x, y, screen))
                            str.Append("║"); 
                        else
                            str.Append("■");
                    }
                    else
                    {
                        str.Append("■");
                    }
                    str.Append(" ");

                    brushstroke++;
                }
                str.Append("\n");
            }

            return str.ToString();
        }


      
        private bool ElementExist(int x, int y, Object[][] table)
        {
            try
            {
                return table[y][x] != null;
            }
            catch (Exception)
            {
           
            }
            return false;
        }


      
        private string ProduceDirectionLink(bool haut, bool droite, bool bas, bool gauche)
        {
           
            if (haut)
            {
                return
                    droite ?
                #region 11__
                            (bas ?

                #region 111_
                                    (gauche ?
                                        "╬" : // 1111 (Alt + 206)
                                        "╠" // 1110 (Alt + 204)
                                    ) :
                #endregion

                #region 110_
                                    (gauche ?
                                        "╩" : // 1101 (Alt + 202)
                                        "╚" // 1100 (Alt + 200)
                                    )
                #endregion
                            ) :
                #endregion

                #region 10__
                            (bas ?

                #region 101_
                                    (gauche ?
                                        "╣" : // 1011(Alt + 185)
                                        "║" // 1010(Alt + 186)
                                    ) :
                #endregion

                #region 100_
                                    (gauche ?
                                        "╝" : // 1001 (Alt + 188)
                                        "║" // 1000 (Alt + 186)
                                    )
                #endregion

                            );
                #endregion
            }
            else
            {
                return
                    droite ?
                #region 01__
                            (bas ?

                #region 011_
                                    (gauche ?
                                        "╦" : // 0111 (Alt + 203)
                                        "╔" // 0110 (Alt + 201)
                                    ) :
                #endregion

                #region 010_
                                    (gauche ?
                                        "═" : // 0101 (Alt + 205)
                                        "═" // 0100 (Alt + 205) //TODO : doute
                                    )
                #endregion
                            ) :
                #endregion

                #region 00__
                            (bas ?

                #region 001_
                                    (gauche ?
                                        "╗" : // 0011(Alt + 187)
                                        "║" // 0010(Alt + 186)
                                    ) :
                #endregion

                #region 000_
                                    (gauche ?
                                        "═" : // 0001 (Alt + 205)
                                        "?" // Impossible
                                    )
                #endregion

                            );
                #endregion
            }
        }

    

        private void PannelDraggable_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            DragMe(Handle);
        }

        public int GetNbreOperationPrim()
        {
            return nbOperationLabyrinthe;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
