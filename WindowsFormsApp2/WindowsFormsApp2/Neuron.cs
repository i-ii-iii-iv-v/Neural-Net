using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Neuron
    {
        public static int count;
        public static double[] testWeights = { 0.8, 0.4, 0.3, 0.2, 0.9, 0.5, 0.3, 0.5, 0.9 };

        public static double[] input1 = { 0, 0, 1, 1 };
        public static double[] input2 = { 0, 1, 0, 1 };
        public static double[] target = { 0, 1, 1, 0 };
        /*
         * activation function for forward propagation
         */
        public double sigmoid(double value)
        {
            return 1.0 / (1.0 + Math.Exp(-value));
        }


        /*
         * derevative of activation function for backward propagation
         */
        public double sigmoidPrime(double value)
        {
            return (1.0 / (1.0 + Math.Exp(-value))) * (1 - (1.0 / (1.0 + Math.Exp(-value))));
        }

        /*
        * initialize weights and bias on first run randomly
        */
        public void setRandom(double[] vector)
        {
            Random rnd = new Random();

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.NextDouble();
            }
        }
    }
}
