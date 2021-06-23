﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.LightGbm;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace TaxiFarePrediction
{
    public partial class MLModel
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(new []{new InputOutputColumnPair(@"vendor_id", @"vendor_id"),new InputOutputColumnPair(@"payment_type", @"payment_type")})      
                                    .Append(mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"rate_code", @"rate_code"),new InputOutputColumnPair(@"passenger_count", @"passenger_count"),new InputOutputColumnPair(@"trip_distance", @"trip_distance")}))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"vendor_id",@"payment_type",@"rate_code",@"passenger_count",@"trip_distance"}))      
                                    .Append(mlContext.Regression.Trainers.LightGbm(new LightGbmRegressionTrainer.Options(){NumberOfLeaves=468,MinimumExampleCountPerLeaf=4,NumberOfIterations=10,MaximumBinCountPerFeature=114,LearningRate=0.0504490915379616F,LabelColumnName=@"fare_amount",FeatureColumnName=@"Features",Booster=new GradientBooster.Options(){SubsampleFraction=1F,FeatureFraction=0.986199781336897F,L1Regularization=0.000550677934028019F,L2Regularization=4.1805939308242F}}));

            return pipeline;
        }
    }
}
