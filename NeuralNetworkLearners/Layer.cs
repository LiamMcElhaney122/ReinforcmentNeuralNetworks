using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLearners
{
    class Layer
    {
        public Neuron[] neurons;


        public Layer(int size, Func<float, float> activationFunction, bool staticLayer)
        {
            neurons = new Neuron[size].Select(h => new Neuron(activationFunction)).ToArray();
        }

        public void MutateWeights(Func<float, float> mutate)
        {
            for (int i = 0; i < neurons.Length; i++)    
            {
                neurons[i].weight = mutate(neurons[i].weight);
            }
        }

        public void MutateBiases(Func<float, float> mutate)
        {
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i].bias = mutate(neurons[i].bias);
            }
        }
    }
}
