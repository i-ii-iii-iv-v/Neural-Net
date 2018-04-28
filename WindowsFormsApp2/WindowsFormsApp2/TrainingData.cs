using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    /// <summary>
    /// MNIST datasets: consist of 28*28 pixel of the image and its label
    /// </summary>
    class TrainingData
    {
        /*
         * label number of pixels
         */
        private byte label;

        /*
         * 28 by 28 image in bytes (greyscale)
         */
        private byte[][] pixels;
        private byte[] serialPixels;

        public TrainingData(byte[][] data, byte label)
        {
            this.label = label;
            pixels = data;

        }

        /// <summary>
        /// serializes double array of pixels into single array
        /// </summary>
        /// <returns></returns>
        public float[] toSerialPixel()
        {
            float[] serialP = new float[784];
            int count = 0;
            for(int i = 0; i < 28; i++)
            {
                for(int j = 0; j <28; j++)
                {
                    serialP[count++] = (float)pixels[i][j]/255;
                }
            }

            return serialP;
        }
        
        public byte getLabel()
        {
            return label;
        }
    }
}
