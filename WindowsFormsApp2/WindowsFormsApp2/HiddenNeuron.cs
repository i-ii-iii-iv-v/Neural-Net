using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

    class HiddenNeuron : Neuron
    {
        private double sum;

        private double result;

        private double[] weight;

        private double[] bias;

        /*
         * 
         */
        public HiddenNeuron(int numNextLayerNeuron, double sum)
        {
            this.sum = sum;
            weight = new double[numNextLayerNeuron];
            bias = new double[numNextLayerNeuron];

            // use test data for debugging purposes
            //setRandom(weight);

            for (int i = 0; i < weight.Length; i++)
            {
                weight[i] = Neuron.testWeights[count++];
            }
        }

        public double getWeight(int index)
        {
            return weight[index];
        }

        public void setWeight(double value, int index)
        {
            weight[index] = value;
        }
        public double getResult()
        {
            return result;
        }
        
        public double getSum()
        {
            return sum;
        }

        public void activateNeuron()
        {
            result = sigmoid(sum);
        }
        
    }
}
