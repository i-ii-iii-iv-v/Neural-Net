using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Network
    {
        //number of layers in the neural network
        private int num_layers;

        //containis the number of neurons int he respective layers
        private int[] sizes;

        
        private _1DMatrix[] biases;
        private _2DMatrix[] weights;

        public Network(int[] sizes)
        {
            num_layers = sizes.Length;
            this.sizes = sizes;
            //biases = new double[num_layers];
            biases = new _1DMatrix[num_layers];

            //the first layer is input layer so it does not contain any biases
            for (int i = 1; i < num_layers; i++)
            {
                biases[i] = new _1DMatrix(sizes[i]);
                biases[i].generateRand();
                weights[i] = new _2DMatrix(sizes[i - 1], sizes[i]);
                weights[i].generateRand();
            }

        }

        public double sigmoid(double z)
        {
            return 1.0 / (1.0 + Math.Exp(-z));
        }

        public _1DMatrix feedForward(_1DMatrix a)
        {
            for(int i = 1; i < num_layers; i++)
            {
               
            }
            return null;
        }
    }
}
