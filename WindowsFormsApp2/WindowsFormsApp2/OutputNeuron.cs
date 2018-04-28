using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class OutputNeuron : Neuron
    {

        private double sum;

        private double output;

        private double bias;

        private double deltaOutputSum;

        public OutputNeuron(double sum)
        {
            this.sum = sum;
        }

        public void activateNeuron()
        {
            output = sigmoid(sum);
        }

        public double getSum()
        {
            return sum;
        }

        public void calculateDeltaOutputSum()
        {
            deltaOutputSum = sigmoidPrime(sum) * (Neuron.target[Network.testCase] - output);
        }
        public double getOutput()
        {
            return output;
        }

        public double getDeltaOutputSum()
        {
            return deltaOutputSum;
        }
    }


}
