using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLearners
{
    class Network
    {

        public List<Layer> layers { get; set; }

        public Network()
        {
        }

        public void Add(int size, Func<float, float> activationFunction, bool staticLayer)
        {
            layers.Add(new Layer(size, activationFunction, staticLayer));
        }


        public float[] feedNetwork(float[] input)
        {
            var lastTensor = input;

            float[] currentLayerTensor = null;

            if(layers.Count == 0)
            {
                throw new Exception("Network must have at least one to activate!");
            }

            for (int i = 0; i < layers.Count; i++)
            {
                currentLayerTensor = new float[layers[i].neurons.Length-1];

                for (int j = 0; j < layers[i].neurons.Length; j++)
                {
                    currentLayerTensor[j] = layers[i].neurons[j].Activate(lastTensor);
                }

                lastTensor = currentLayerTensor;
            }
            return currentLayerTensor;
        }

    }
}
