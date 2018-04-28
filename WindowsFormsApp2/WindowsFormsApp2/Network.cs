using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    /// <summary>
    /// Main Network for managing all the layers
    /// </summary>
    class Network
    {
        public static int testCase;
        InputLayer inputLayer;
        HiddenLayer[] hiddenLayer;
        OutputLayer outputLayer;

        Network(int numHiddenLayer)
        {
            hiddenLayer = new HiddenLayer[numHiddenLayer];
        }

        //start Network
        public void setNetwork()
        {
            testCase = 0;
            inputLayer = new InputLayer(2, 3);
            hiddenLayer[0] = new HiddenLayer(3, 1, inputLayer.getSums());
            outputLayer = new OutputLayer(1, hiddenLayer[0].getSums());
            
        }

    }
}
