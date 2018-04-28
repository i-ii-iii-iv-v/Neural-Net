using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class HiddenLayer : Layer
    {
        private double[] synapsisInput;
        public HiddenLayer(int size, int numNeuronsNext, double[] values) : base(size, numNeuronsNext)
        {
            synapsisInput = values;
            createNeurons();
            applyActivation();
            forwardSum();
        }

        public override void createNeurons()
        {
            neurons = new HiddenNeuron[numNeurons];
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i] = new HiddenNeuron(numNeuronsNextLayer, synapsisInput[i]);
            }
        }

        public void applyActivation()
        {
            for(int i = 0; i < numNeurons; i++)
            {
                ((HiddenNeuron)(neurons[i])).activateNeuron();
            }
        }
        public void forwardSum()
        {
            sums = new double[numNeuronsNextLayer];

            for (int i = 0; i < numNeuronsNextLayer; i++)
            {
                for (int j = 0; j < numNeurons; j++)
                {
                    sums[i] += ((HiddenNeuron)(neurons[j])).getResult() * ((HiddenNeuron)(neurons[j])).getWeight(i);
                }

            }
        }

        public void adjustWeights(double[] deltaOutputSum)
        {
            for (int i = 0; i < numNeurons; i++)
            {
                for (int j = 0; j < numNeuronsNextLayer; j++)
                {
                    double deltaWeight = deltaOutputSum[j] / ((HiddenNeuron)(neurons[i])).getResult();
                    double newWeight = ((HiddenNeuron)(neurons[i])).getWeight(j) + deltaWeight;
                    ((HiddenNeuron)(neurons[i])).setWeight(newWeight, j);
                }
            }
        }

        public double[] getSums()
        {
            return sums;
        }
    }
}
