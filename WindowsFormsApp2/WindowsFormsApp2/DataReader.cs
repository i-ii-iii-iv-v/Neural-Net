using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    
    /// <summary>
    /// Class for reading MNIST dataset 
    /// </summary>
    class DataReader
    {
        BinaryReader labelReader;
        BinaryReader imageReader;
        FileStream ifsImage;
        FileStream ifsLabel;
        int dataSize;
        public TrainingData[] trainData;
        bool isTrainData;

        /// <summary>
        /// Sets input stream and file path
        /// </summary>
        private void setStream()
        {
            ifsImage = new FileStream("emnist-letters-train-images-idx3-ubyte", FileMode.Open);
            ifsLabel = new FileStream("emnist-letters-train-labels-idx1-ubyte", FileMode.Open);
            isTrainData = true;
            imageReader = new BinaryReader(ifsImage);
            labelReader = new BinaryReader(ifsLabel);

            
        }
        
        /// <summary>
        /// close input stream
        /// </summary>
        private void closeStream()
        {
            labelReader.Close();
            imageReader.Close();
            ifsImage.Close();
            ifsLabel.Close();
        }

        /// <summary>
        /// Reads from stream and stores it into array of TrainingData objects
        /// </summary>
        public void read()
        {
            try
            {
                setStream();
                if (isTrainData)
                {
                    dataSize = 60000;
                }
                else
                {
                    dataSize = 20000;
                }

                //discard headers
                imageReader.ReadInt32();
                imageReader.ReadInt32();
                imageReader.ReadInt32();
                imageReader.ReadInt32();

                labelReader.ReadInt32();
                labelReader.ReadInt32();

                byte[][] pixels = new byte[28][];
                for (int i = 0; i < pixels.Length; i++)
                {
                    pixels[i] = new byte[28];
                }

                byte label;
                trainData = new TrainingData[dataSize];
                for (int i = 0; i < dataSize; i++)
                {
                    label = labelReader.ReadByte();
                    for (int j = 0; j < 28; j++)
                    {
                        for (int k = 0; k < 28; k++)
                        {
                            pixels[j][k] = imageReader.ReadByte();
                        }
                    }

                    trainData[i] = new TrainingData(pixels, label);
                }

                closeStream();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
