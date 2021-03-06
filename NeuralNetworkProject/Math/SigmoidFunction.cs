﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkProject.Math
{
    internal class SigmoidFunction : IActivatorFunction
    {
        internal SigmoidFunction() { }
        public Vector<double> Apply(Vector<double> value) => value.Map(element => SpecialFunctions.Logistic(element));
        public Vector<double> Gradient(Vector<double> value)
        {

            var applyResult = Apply(value);
            return applyResult.PointwiseMultiply(1 - applyResult);
        }

        public Vector<double> Hessian(Vector<double> value)
        {

            var applyResult = Apply(value);
            var temp = applyResult.PointwiseMultiply(applyResult);
            return 1 - 2 * temp - 2 * temp.PointwiseMultiply(applyResult);
        }

    }
}
