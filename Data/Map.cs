using System;


namespace TP1_INF1008.Data
{
    public partial class Map
    {
      
        private static int mapOperationCounter = 0;

        private int[,] arrMap;

        private int length;

        private int width;


    
        public Map(int ln, int wd)
        {
            this.length = ln;
            this.width = wd;
            if (ln <= 0 || wd <= 0)
                throw new ArgumentException("Map length and width must be greater than zero.");

            arrMap = new int[ln * wd, 2];
        }

        public int GetLength
        {
            get { return length; }
        }

        public int GetWidh
        {
            get { return width; }
        }

        public void isValideXY(int x, int y)
        {
            if (x < 0)
                throw new ArgumentException($"The x value must not be less than zero ! x = {x}");
            else if (y < 0)
                throw new ArgumentException($"The y value must not be less than zero ! y = {y}");
            else if (x >= length)
                throw new ArgumentException($"The x value must not be greater than or equal to the length ! x = {x}");
            else if (y >= width)
                throw new ArgumentException($"The y value must not be greater than or equal to the width ! y  = {y}");
        }


       
        private bool aRightNeighbour(int x, int y)
        {
            isValideXY(x, y);
            return x < length - 1;
        }

       
        private bool DownstairsNeighbor(int x, int y)
        {
            isValideXY(x, y);
            return y < width - 1;
        }


     
        public Map RandomWeights(int min, int max)
        {
            mapOperationCounter = 0;
            // x and y are map array level coordinates
            int x, y;
            Random rand = new Random();
            for (x = 0; x < length * width; x++)
            {
                for (y = 0; y < 2; y++)
                {
                    arrMap[x, y] = rand.Next(min, max) + 1;
                    mapOperationCounter += 1;
                }
            }
            return this;
        }

       
        public void AssignmentWeight(int x, int poids, bool toRight) {

            if (toRight)
                arrMap[x, 1] = poids;
            else
                arrMap[x, 0] = poids;

            mapOperationCounter += 1;
        }
     
        public int numberOfOperation
        {
            get { return mapOperationCounter; }
            set { mapOperationCounter = value; }
        }
        public int GetLinkWeight(int positionX, int positionY, bool toRightDirection)
        {
            isValideXY(positionX, positionY);

          
            if (toRightDirection && !aRightNeighbour(positionX, positionY))
                throw new ArgumentOutOfRangeException("This box has no right neighbor.");

         
            if (!toRightDirection && !DownstairsNeighbor(positionX, positionY))
                throw new ArgumentOutOfRangeException("This square has no bottom neighbor.");

            return arrMap[positionX + positionY * length, toRightDirection ? 1 : 0];
        }

        public override string ToString()
        {
            return $"The map is a size of {length} X {width}";
        }
    }
}
