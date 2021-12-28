using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLearners
{

 
    static class ActivationFunctions
    {
       const float e = 2.7182818284590451f;


        //public float relu(float input) => input < 0: 0 : input;
       public static float relu(float input) => input < 0 ? 0 : input;

       public static float linear(float input) => input;

       public static float sigmoid(float input) => 1 / (1 + MathF.Pow(e, input));

       public static float tanh(float input) => (MathF.Pow(e, input) - MathF.Pow(e, (-1 * input))) / (MathF.Pow(e, input) + MathF.Pow(e, (-1 * input)));
    }
}
