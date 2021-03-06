﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkProject.NeuralNetwork
{
    public class HyperParameters
    {
        public int MaxEpochs { get; set; }
        public double MaxError { get; set; }
        public double Momentum { get; set; }
        public double Lr { get; set; }
    }
}
