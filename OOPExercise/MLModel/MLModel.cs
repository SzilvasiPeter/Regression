using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLModel
{
    public class MLModel : IMLModel
    {

        private double model;

        public void Train(int[] data)
        {
            model = data.Select(dataPoint => Math.Sqrt(dataPoint)).Sum();
        }

        public int Predict(int dataPoint)
        {
            return (int) Math.Round(dataPoint - model);
        }

        public double Evaluation()
        {
            return model - 100;
        }

    }
}
