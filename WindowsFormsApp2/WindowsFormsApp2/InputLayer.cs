using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class InputLayer : Layer
    {
        public InputLayer(int size, int numNeuronsNext) : base(size, numNeuronsNext)
        {
            createNeurons();
            forwardSum();
        }

        public override void createNeurons()
        {
            neurons = new InputNeuron[numNeurons];
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i] = new InputNeuron(numNeuronsNextLayer, 1);
            }
        }

        public void forwardSum()
        {
            sums = new double[numNeuronsNextLayer];

            for(int i = 0; i < numNeuronsNextLayer; i++)
            {
                for(int j = 0; j < numNeurons; j++)
                {
                    sums[i] += ((InputNeuron)(neurons[j])).getInputValue() * ((InputNeuron)(neurons[j])).getWeight(i);
                }

            }
        }

        public double[] getSums()
        {
            return sums;
        }

    }
}
