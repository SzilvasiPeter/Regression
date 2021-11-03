using DataProvider;
using MLModel;
using MLContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExerciseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataProvider.DataProvider dp = new DataProvider.DataProvider();
            MLModel.MLModel model = new MLModel.MLModel();
            MLContext.MLContext context = new MLContext.MLContext();

            context.Init(dp, model);
            context.Train();

            Console.Write("Enter a data point: ");
            int dataPoint = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Prediction for the data point ({dataPoint}): {context.Predict(dataPoint)}");
        }
    }
}
