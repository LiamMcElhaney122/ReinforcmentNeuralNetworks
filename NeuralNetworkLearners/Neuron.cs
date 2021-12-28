using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLearners
{
    class Neuron
    {
        public float weight { get; set; } = 0;
        public float bias { get; set; } = 0;

        Func<float, float> activationFunction;

        public Neuron(Func<float, float> activationFunction)
        {
            this.activationFunction = activationFunction;
        }
        public float Activate(float[] input)
        {
            float sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return activationFunction(sum);
        }
    }
}
