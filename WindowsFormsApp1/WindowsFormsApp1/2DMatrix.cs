using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class _2DMatrix
    {

        private int row;
        private int column;
        private double[,] matrix;

        private int mean = 0;
        private int stdDev = 1;
        public _2DMatrix(int row, int col)
        {
            this.row = row;
            this.column = col;
            matrix = new double[row, col];
        }

        public void generateRand()
        {

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    matrix[i, j] = nextGauss();
                }
            }
        }

        public double nextGauss()
        {
            Random rand = new Random(); //reuse this if you are generating many
            double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            double randNormal =
                         mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)

            return randNormal;
        }
    }
}
