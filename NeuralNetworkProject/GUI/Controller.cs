﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworkProject.DataAdapter;
using NeuralNetworkProject.GUI.GraphShapes;
using NeuralNetworkProject.Math;
using NeuralNetworkProject.NeuralNetwork;
using NeuralNetworkProject.Training;
using Telerik.WinControls.UI;
using Telerik.Windows.Diagrams.Core;
using Point = Telerik.Windows.Diagrams.Core.Point;

namespace NeuralNetworkProject.GUI
{
    static class Controller
    {
        public struct trainerParams
        {
            public NeuralNetwork.NeuralNetwork nn;
            public Tuple<Matrix<double>, Matrix<double>> Tuple;
        }

        public static trainerParams BuildNet(FlowLayoutPanel layers, FileDialog LoadData_dlg, Result r,Telerik.WinControls.UI.RadDiagram radDiagram1)
        {
            Training.Trainer trainer = new Training.Trainer();
            NeuralNetworkBuilder b = new NeuralNetworkBuilder();
            Layer_ctrl temp;
            int neuronsnumber;
            foreach (var layer in layers.Controls)
            {
                temp = layer as Layer_ctrl;
                neuronsnumber = Convert.ToInt16(temp.NN_drpdn.Value);
                //if (ActivatorFunctions.FunctionName.SIGMOID.ToString() == temp.AF_drpdn.SelectedItem.Text)
                //    applier = ActivatorFunctions.FunctionName.SIGMOID;
                b.Layer(neuronsnumber, new Math.FunctionApplier(),(double)temp.Lr_drpdn.Value);
            }
            NeuralNetwork.NeuralNetwork nn = b.Build();
            string FileName = LoadData_dlg.FileName;
            var tuples = DataReader.DataReader.Instance.ReadFromFile(FileName);

            var inputs = tuples.Item1;
            var outputs = tuples.Item2;
            DataDivider Divider = new DataDivider();
            var temp2 = Divider.Divide(inputs, outputs);
            //ActivatorFunctions.FunctionName applier ;
            
            //// test case (should belong to the second class = [0 1 0])
            //var tt = nn.ForwardInput(Vector<double>.Build.DenseOfArray(new double[] { 5.5, 2.5, 4.0, 1.3 }));
            trainerParams @params = new trainerParams();
            @params.nn = nn;
            @params.Tuple = tuples;
            NetGraph(nn,radDiagram1);

            return (@params);
        }


        public static void NetGraph(NeuralNetwork.NeuralNetwork nn, Telerik.WinControls.UI.RadDiagram radDiagram1)
        {
            List<Feature_shape> featureShapes=new List<Feature_shape>();
            List<AF_shape> afShapes=new List<AF_shape>();
            radDiagram1.AddShape(new Input_shape(),null,new Point(0,90));
            for (int i = 0; i < nn.Layers.Count; i++)
            {
                Point location = new Point(i*250 + 100, 0);
                radDiagram1.AddShape(new Layer_shape(),null, location);
                featureShapes.Add(new Feature_shape()
                {
                    Location = new Point(i * 250 + 125, 75),
                    Text = Convert.ToString(nn.Layers[i].NeuronsNumber)
                }
                  );
                afShapes.Add(new AF_shape()
                {
                    Location = new Point(i * 250 + 200, 75),
                    Text = Convert.ToString(nn.Layers[i].Applier)

                }
                );

                //(radDiagram1.Shapes[radDiagram1.Shapes.Count-1] as Layer_shape).addnodes();
            }
            radDiagram1.AddShape(new Output_shape(), null, new Point(nn.Layers.Count*250 + 100, 90));
            Weight_edge edge;
            for (int i = 1; i < radDiagram1.Shapes.Count; i++)
            {
                    radDiagram1.AddConnection((IShape) radDiagram1.Shapes[i - 1], (IShape) radDiagram1.Shapes[i]);
                    radDiagram1.Connections[i - 1].TargetCapType = CapType.Arrow2Filled;
                    radDiagram1.Connections[i - 1].AllowDelete = false;
                    radDiagram1.Connections[i - 1].IsDraggingEnabled = false;
                    radDiagram1.Connections[i - 1].IsEditable = false;
                    radDiagram1.Connections[i - 1].TargetCapSize = new SizeF(20, 25);
                    //I don't know how!!
                    RadDiagramConnection connection1 = (RadDiagramConnection) radDiagram1.Connections[i - 1];
                    connection1.BackColor = Color.LightSalmon;
                    //    radDiagram1.AddConnection(
                    //        radDiagram1,i
                    //        //new Weight_edge(
                    //        ////    (IShape)radDiagram1.Shapes[i],
                    //        ////(IShape)radDiagram1.Shapes[i - 1]
                    //)
                    //       // )

                   //        ;
                
            }
            for(int i=0;i<featureShapes.Count;i++)
            {
                radDiagram1.AddShape(featureShapes[i]);
                radDiagram1.AddShape(afShapes[i]);
                radDiagram1.AddConnection((IShape) radDiagram1.Shapes[radDiagram1.Shapes.Count - 1],
                    (IShape) radDiagram1.Shapes[radDiagram1.Shapes.Count - 2]);


            }
            
        }

        private static string Layerinfo(Layer layer)
        {
            return "\n\nNeuronsNumber :\n" +
                   layer.NeuronsNumber +
                   "\nLearningRate :\n" +
                   layer.LearningRate
               // + "AF :\n" +layer.Applier.ActivatorFunction;
                ;
        }
    }
}
