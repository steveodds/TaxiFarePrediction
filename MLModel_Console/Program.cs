﻿
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace MLModel_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            MLModel.ModelInput sampleData = new MLModel.ModelInput()
            {
                Vendor_id = @"CMT",
                Rate_code = 1F,
                Passenger_count = 1F,
                Trip_distance = 3.8F,
                Payment_type = @"CRD",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = MLModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Fare_amount with predicted Fare_amount from sample data...\n\n");


            Console.WriteLine($"Vendor_id: {sampleData.Vendor_id}");
            Console.WriteLine($"Rate_code: {sampleData.Rate_code}");
            Console.WriteLine($"Passenger_count: {sampleData.Passenger_count}");
            Console.WriteLine($"Trip_distance: {sampleData.Trip_distance}");
            Console.WriteLine($"Payment_type: {sampleData.Payment_type}");


            Console.WriteLine($"\n\nPredicted Fare_amount: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
