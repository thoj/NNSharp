﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NNSharp.DataTypes;
using NNSharp.KernelDescriptors;
using NNSharp.SequentialBased.SequentialLayers;

namespace NNSharp.SequentialBased.SequentialExecutors
{
    public class DeafultAbstractLayerFactory : IAbstractLayerFactory
    {

        public DeafultAbstractLayerFactory()
        {
            factories = new List<ILayerFactory>();

            factories.Add(new AvgPool1DLayerFactory());
            factories.Add(new AvgPool2DLayerFactory());
            factories.Add(new BatchNormLayerFactory());
            factories.Add(new Bias2DLayerFactory());
            factories.Add(new Conv1DLayerFactory());
            factories.Add(new Conv2DLayerFactory());
            factories.Add(new Cropping1DLayerFactory());
            factories.Add(new Cropping2DLayerFactory());
            factories.Add(new Dense2DLayerFactory());
            factories.Add(new DropoutLayerFactory());
            factories.Add(new ELuLayerFactory());
            factories.Add(new GlobalAvgPool1DLayerFactory());
            factories.Add(new GlobalAvgPool2DLayerFactory());
            factories.Add(new GlobalMaxPool1DLayerFactory());
            factories.Add(new GlobalMaxPool2DLayerFactory());
            factories.Add(new GRULayerFactory());
            factories.Add(new HardSigmoidLayerFactory());
            factories.Add(new Input2DLayerFactory());
            factories.Add(new LSTMLayerFactory());
            factories.Add(new MaxPool1DLayerFactory());
            factories.Add(new MaxPool2DLayerFactory());
            factories.Add(new MinPool2DLayerFactory());
            factories.Add(new PermuteLayerFactory());
            factories.Add(new ReLuLayerFactory());
            factories.Add(new RepeatVectorLayerFactory());
            factories.Add(new Reshape2DLayerFactory());
            factories.Add(new SigmoidLayerFactory());
            factories.Add(new SimpleRNNLayerFactory());
            factories.Add(new SoftmaxLayerFactory());
            factories.Add(new SoftPlusLayerFactory());
            factories.Add(new SoftsignLayerFactory());
            factories.Add(new TanHLayerFactory());
            factories.Add(new FlattenLayerFactory());
        }

        public ILayer CreateProduct(IKernelDescriptor descriptor)
        {
            ILayer layer = null;
            foreach(var fac in factories)
            {
                layer = fac.CreateProduct(descriptor);

                if (layer != null)
                    return layer;
            }

            throw new Exception("Layer type does not exist!");
        }

        private List<ILayerFactory> factories;
    }
}
