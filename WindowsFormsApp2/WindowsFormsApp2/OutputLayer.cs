using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class OutputLayer : Layer
    {
        private double[] synapsisInput;
        public OutputLayer(int size, double[] values) : base(size, 0)
        {
            synapsisInput = values;
            createNeurons();
            applyActivation();
            
        }

        public void applyActivation()
        {
            for (int i = 0; i < numNeurons; i++)
            {
                ((OutputNeuron)(neurons[i])).activateNeuron();
            }
        }


        public override void createNeurons()
        {
            neurons = new OutputNeuron[numNeurons];
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i] = new OutputNeuron(synapsisInput[i]);
            }
        }

        public double[] makeDeltaOutputSumArray()
        {
            double[] deltaOutputSum = new double[numNeurons];
            for(int i = 0; i < numNeurons; i++)
            {
                ((OutputNeuron)(neurons[i])).calculateDeltaOutputSum();
                deltaOutputSum[i] = ((OutputNeuron)(neurons[i])).getDeltaOutputSum();
            }

            return deltaOutputSum;
        }

    }
}
