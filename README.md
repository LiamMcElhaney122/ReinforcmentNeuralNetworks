# Reinforcment Neural Networks

This is a c# implementation of using neural networks with reinforment learning. Instead of the traditional, gradient optimized DNN's, RL neural networks use evolving networks that breed and muttate their weights, biases, activation functions, and layer counts and sizes to create ever evolving networks.


Start by writing a function to create networks.
```csharp

  const int inputLayerSize = 3; 
  const int outputLayerSize = 6;
  
  
  Network[] spawnNetworks(int count, int minLength, int maxLength, int minHiddenLayers, int maxHiddenLayers){
    var networks = new Network[count]
    //spawn n networks
    for(int n = 0; n < count n++){
      network = networks[n].add(inputLayerSize, ActivationFunctions.Relu, true)
      //create l hidden layers for network
      for(int l = 0; l < rnd.Next(minHiddenLayers, maxHiddenLayers); l++){
        //lets use a static activation function for now
        network.add(rnd.next(minLength, maxLength, ActivationFunctions.linear, false)
    }
      network.add(outputLayerSizem ActivationFunctions.Sigmoid, false)
  }
    return networks 
  }
  ```
  Once created, networks can run in a loop. Every iteration, they should be evaluated, and a selection method chosen.
  
  
  ```csharp
  
  foreach(var n in Networks){
    //many fitness functions exist, none are provided, although you can create them easily
    fitness_func(n.feedNetwork(input_array))
  }
  ```
  
  After killing the worst networks, the new best networks can be bred and/or mutated
  
  
  ```csharp
    //mutation function
    float mutate(float input){
      return input += rnd.next_float(-1, 1);
    }
  
    foreach(Network n in surviving_networks){
      //1 in 6 chance to mutate
      if(rnd.next(0, 5) == 1){
        n.layers[rnd.next(1, n.layers.count-1)].MutateWeights(mutate)
        n.layers[rnd.next(1, n.layers.count-1)].MutateBiases(mutate)
    }
 ```
  
        
