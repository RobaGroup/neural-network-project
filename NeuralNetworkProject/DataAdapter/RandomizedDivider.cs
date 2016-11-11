﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkProject.DataAdapter
{
    public class RandomizedDivider : IDataDivider
    {
        internal RandomizedDivider() {}
        public Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>> Divide(Matrix<double> inputs, Matrix<double> outputs, params object[] parameters)
        {
            var temp = inputs.EnumerateRows().Zip(outputs.EnumerateRows(), (f, s) => new Tuple<Vector<double>, Vector<double>>(f, s)).Shuffle();
            var t1 = temp.Take(inputs.RowCount * 7 / 10);
            var t2 = temp.Skip(inputs.RowCount * 7 / 10);
            return new Tuple<Matrix<double>, Matrix<double>, Matrix<double>, Matrix<double>>(Matrix<double>.Build.DenseOfRowVectors(t1.Select(r => r.Item1)), Matrix<double>.Build.DenseOfRowVectors(t1.Select(r => r.Item2)).Transpose(), Matrix<double>.Build.DenseOfRowVectors(t2.Select(r => r.Item1)), Matrix<double>.Build.DenseOfRowVectors(t2.Select(r => r.Item2)).Transpose());
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.Shuffle(new Random());
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random rng)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (rng == null) throw new ArgumentNullException("rng");

            return source.ShuffleIterator(rng);
        }

        private static IEnumerable<T> ShuffleIterator<T>(
            this IEnumerable<T> source, Random rng)
        {
            var buffer = source.ToList();
            for (int i = 0; i < buffer.Count; i++)
            {
                int j = rng.Next(i, buffer.Count);
                yield return buffer[j];

                buffer[j] = buffer[i];
            }
        }
    }
}