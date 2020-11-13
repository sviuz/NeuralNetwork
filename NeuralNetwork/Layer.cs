using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks
{
    public class Layer
    {
        public List<Neuron> Neurons { get; }
        public int Count => Neurons?.Count ?? 0;

        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            //TODO: проверка все входные нейроны на соответствие типу
            Neurons = neurons;
        }

        public List<double> GetSignals() 
        {
            return Neurons.Select(neuron => neuron.Output).ToList();
        }

    }
}
