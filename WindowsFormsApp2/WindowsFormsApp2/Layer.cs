using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    abstract class Layer
    {
        protected int numNeurons;
        protected int numNeuronsNextLayer;

        protected double[] sums;
        protected Neuron[] neurons;

        public Layer(int size, int numNeuronsNext)
        {
            numNeurons = size;
            numNeuronsNextLayer = numNeuronsNext;
        }

        public abstract void createNeurons();
    }
}
