using System;



namespace TP1_INF1008.Model
{
    public partial class Liaison : IComparable<Liaison>
    {
       
        private Node nodeDepart;
        private Node nodeArrive;
        private int poids;

        public Liaison(Node nodeDepart, Node nodeArrive, int poids)
        {
         
            if (nodeDepart.Equals(nodeArrive))
                throw new Exception("\nThese squares have the same position on the Labyrinth");

            this.poids = poids;

           
            if (nodeDepart.CompareTo(nodeArrive) < 0)
            {
                this.nodeDepart = nodeDepart;
                this.nodeArrive = nodeArrive;
            }
            else
            {
                this.nodeDepart = nodeArrive;
                this.nodeArrive = nodeDepart;
            }
        }

        public Node NodeDepart
        {
            get { return nodeDepart; }
            set { nodeDepart = value; }
        }

        public Node NodeArrive
        {
            get { return nodeArrive; }
            set { nodeArrive = value; }
        }

        public int Poids
        {
            get { return poids; }
            set { poids = value; }
        }


        public override bool Equals(object obj)
        {
            
            if (!(obj is Liaison))
                return false;

            Liaison link = (Liaison)obj;

            return this.nodeDepart.Equals(link.nodeDepart) &&
                this.nodeArrive.Equals(link.nodeArrive) &&
                this.poids == link.poids;
        }


        public int CompareTo(Liaison other)
        {
            int tempo;

      
            if (this.poids == other.poids)
            {
                tempo = this.nodeArrive.CompareTo(other.nodeArrive);
                if (tempo != 0)
                    return tempo;
                else
                    return this.nodeDepart.CompareTo(other.nodeDepart);
            }

            return (this.poids < other.poids) ? -1 : 1;
        }

        public override int GetHashCode()
        {
            int hash = nodeDepart.PosX * 31 + nodeArrive.PosY;
            hash = hash * 31 + nodeArrive.PosX;
            hash = hash * 31 + nodeArrive.PosX;
            hash = hash * 31 + poids;

            return hash;
        }

        
        public int GetCoordX()
        {
            return NodeDepart.PosX*2 + (NodeArrive.PosX - NodeDepart.PosX);
        }

      
        public int getCoordY()
        {
            return NodeDepart.PosY * 2 + (NodeArrive.PosY - NodeDepart.PosY);
        }

        public override string ToString()
        {
            return $"NodeDepart: {nodeDepart}, NodeArrive: {NodeArrive}, Poids: {poids}";
        }
    }
}
