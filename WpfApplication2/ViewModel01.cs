using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WpfApplication2
{
    public class ViewModel01
    {
        public PointCollection Data { get; set; }

        public ViewModel01()
        {
            double pi = Math.PI;
            int n = 100;
            double a = 1;
            double b = 3;
            int cycles = 4;
            var t = Enumerable.Range(0, n).Select(p => p * cycles * 2 * pi / n).ToArray();
            var x = t.Select(p => a * p - b * Math.Sin(p)).ToArray();
            var y = t.Select(p => a - b * Math.Cos(p)).ToArray();

            Data = new PointCollection();

            for (int i = 0; i < n; i++)
                Data.Add(new Point(x[i], y[i]));
        }
    }
}
