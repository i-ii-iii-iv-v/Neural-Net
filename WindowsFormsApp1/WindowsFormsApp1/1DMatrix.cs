using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class _1DMatrix
    {
        private double[,] matrix;
        private int mean = 0;
        private int stdDev = 1;
        public _1DMatrix(int row)
        {
            matrix = new double[row,1];
        }

        public void generateRand()
        {
            
            for(int i = 0; i < matrix.Length; i++)
            {
                matrix[i, 1] = nextGauss();
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
