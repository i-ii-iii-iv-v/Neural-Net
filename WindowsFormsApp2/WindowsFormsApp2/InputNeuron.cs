using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class InputNeuron : Neuron
    {
        /*
         *input value, in this case greyscale values of each pixel 
         */
        private double inputValue;

        /*
         * vector of weights to next layer of neurons
         */
        private double[] weight;

        /*
         * vector of weights to next layers of neurons
         */
        private double[] bias;

        public InputNeuron(int numNeuronsNextLayer, double value)
        {
            inputValue = value;
            weight = new double[numNeuronsNextLayer];
            bias = new double[numNeuronsNextLayer];

            //for testing purposes use set weights 
            //setRandom(weight);
            for(int i = 0; i < weight.Length; i++)
            {
                weight[i] = Neuron.testWeights[count++];
            }
        }

        public double getInputValue()
        {
            return inputValue;
        }

        public double getWeight(int index)
        {
            return weight[index];
        }
    }
}
