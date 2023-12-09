using System;
using System.Collections.Generic;
using System.Linq;
using TP1_INF1008.Data;


namespace TP1_INF1008.Model
{
    public partial class Node : IComparable<Node>
    {
        private int posX;
        private int posY;
        private Labyrinthe labyrinth;

        
        public Node(Labyrinthe labyrinthe, int posX, int posY)
        {
            this.labyrinth = labyrinthe;
            this.posX = posX;
            this.posY = posY;
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public override string ToString()
        {
            return $"(posX: {posX}, posY:{posY})";
        }


      
        public override bool Equals(object obj)
        {
          
            if (!(obj is Node))
                return false;

            Node node = (Node)obj;

           
            return this.posX == node.posX && this.posY == node.posY;
        }


        public int CompareTo(Node other)
        {
            if (this.Equals(other))
                return 0;
            else if (this.posY < other.posY ||
                (this.posY == other.posY && this.posX < other.posX))
            {
                return -1;
            }
            return 1;
        }


        public override int GetHashCode()
        {
            int hash = labyrinth.GetHashCode() * 31 + posX;
            hash = hash * 31 + posY;
            return hash;
        }

    
        public enum Direction
        {
            HAUT = 0,
            DROITE = 1,
            BAS = 2,
            GAUCHE = 3,
        }

      
        public static class EnumDirection
        {
            public static IEnumerable<Direction> GetValues<Direction>()
            {
                return Enum.GetValues(typeof(Direction)).Cast<Direction>();
            }
        }

      
        public void ifNeighborExists(Direction direction)
        {
            switch (direction)
            {
                case Direction.HAUT:
                    if (posY == 0)
                        throw new ArgumentNullException("\r\nThis square has no neighbor at the TOP");
                    break;
                case Direction.DROITE:
                    if (posX == labyrinth.GetMap().GetLength - 1)
                        throw new ArgumentNullException("This square has no neighbor on the RIGHT");
                    break;
                case Direction.BAS:
                    if (posY == labyrinth.GetMap().GetWidh - 1)
                        throw new ArgumentNullException("This square has no neighbor at the BOTTOM");
                    break;
                case Direction.GAUCHE:
                    if (posX == 0)
                        throw new ArgumentNullException("This square has no neighbor on the LEFT");
                    break;
            }
        }


       
        public Liaison getLiaison(Direction direction)
        {
            ifNeighborExists(direction);
          
            return new Liaison(this, GetNoeudVoisin(direction), GetPoidsLiaison(direction));
        }


    
        public int GetPoidsLiaison(Direction direction)
        {
            ifNeighborExists(direction);
            Map map = labyrinth.GetMap();

            switch (direction)
            {
                case Direction.HAUT:
                    return map.GetLinkWeight(posX, posY - 1, false);
                case Direction.DROITE:
                    return map.GetLinkWeight(posX, posY, true);
                case Direction.BAS:
                    return map.GetLinkWeight(posX, posY, false);
                case Direction.GAUCHE:
                    return map.GetLinkWeight(posX - 1, posY, true);
                default:
                    throw new ArgumentException("Steering not correct");
            }
        }

      
        public Node GetNoeudVoisin(Direction direction)
        {
            ifNeighborExists(direction);

            switch (direction)
            {
                case Direction.HAUT:
                    return labyrinth.GetNoeud(posX, posY - 1);
                case Direction.DROITE:
                    return labyrinth.GetNoeud(posX + 1, posY);
                case Direction.BAS:
                    return labyrinth.GetNoeud(posX, posY + 1);
                case Direction.GAUCHE:
                    return labyrinth.GetNoeud(posX - 1, posY);
                default:
                    throw new ArgumentException("direction unknown.");
            }
        }
    }
}
