using System;
namespace TP1_INF1008.Model
{
    public partial class clsLiaison : IComparable<clsLiaison>
    {
       
        private clsNode removeNode;
        private clsNode addNode;
        private int weigth;

        public clsLiaison(clsNode nodeDepart, clsNode nodeArrive, int poids)
        {      
            if (nodeDepart.Equals(nodeArrive))
                throw new Exception("\nThese squares have the same position on the Labyrinth");
            this.weigth = poids;
            if (nodeDepart.CompareTo(nodeArrive) < 0)
            {
                this.removeNode = nodeDepart;
                this.addNode = nodeArrive;
            }
            else
            {
                this.removeNode = nodeArrive;
                this.addNode = nodeDepart;
            }
        }

        public clsNode NodeDepart
        {
            get { return removeNode; }
            set { removeNode = value; }
        }

        public clsNode NodeArrive
        {
            get { return addNode; }
            set { addNode = value; }
        }

        public int Poids
        {
            get { return weigth; }
            set { weigth = value; }
        }
        public override bool Equals(object obj)
        {
            if (!(obj is clsLiaison))
                return false;
            clsLiaison link = (clsLiaison)obj;
            return this.removeNode.Equals(link.removeNode) &&
                this.addNode.Equals(link.addNode) &&
                this.weigth == link.weigth;
        }
        public int CompareTo(clsLiaison other)
        {
            int tempo;    
            if (this.weigth == other.weigth)
            {
                tempo = this.addNode.CompareTo(other.addNode);
                if (tempo != 0)
                    return tempo;
                else
                    return this.removeNode.CompareTo(other.removeNode);
            }

            return (this.weigth < other.weigth) ? -1 : 1;
        }

        public override int GetHashCode()
        {
            int hash = removeNode.PosX * 31 + addNode.PosY;
            hash = hash * 31 + addNode.PosX;
            hash = hash * 31 + addNode.PosX;
            hash = hash * 31 + weigth;

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
            return $"NodeDepart: {removeNode}, NodeArrive: {NodeArrive}, Poids: {weigth}";
        }
    }
}
