using DataProvider;
using MLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLContext
{
    public class MLContext : IMLContext
    {

        private IDataProvider dataProvider;
        private IMLModel model;

        public void Init(IDataProvider dataProvider, IMLModel model)
        {
            this.dataProvider = dataProvider;
            this.model = model;
        }

        public void Train()
        {
            model.Train(dataProvider.Read("../../../../OOPExerciseApp/data.txt"));
        }

        public int Predict(int dataPoint)
        {
            return model.Predict(dataPoint);
        }

    }
}
