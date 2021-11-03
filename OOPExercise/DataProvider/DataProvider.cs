using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataProvider
{
    public class DataProvider : IDataProvider
    {

        private int[] data;

        public int[] Read(string filePath)
        {
            List<int> data = new List<int>();

            foreach (string line in File.ReadLines(filePath))
            {
                data.Add(Int32.Parse(line));
            }

            data.Sort();
            this.data = data.ToArray();

            return this.data;
        }

        public double Mean()
        {
            return (double) data.Sum() / data.Length;
        }

        public double Median()
        {
            int n = data.Length;

            if (n % 2 == 0)
            {
                return (double) (data[n / 2 - 1] + data[n / 2]) / 2;
            } else
            {
                return data[n / 2];
            }
        }

        public double StandardDeviation()
        {
            return Math.Sqrt(Variance());
        }

        public double Variance()
        {
            return data.Select(num => (num - Mean()) * (num - Mean())).Sum() / data.Length;
        }

    }
}
