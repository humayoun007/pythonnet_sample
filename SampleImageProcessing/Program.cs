using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleImageProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                //dynamic np = Py.Import("numpy");
                //Console.WriteLine(np.cos(np.pi * 2));

                //dynamic sin = np.sin;
                //Console.WriteLine(sin(5));

                //double c = np.cos(5) + sin(5);
                //Console.WriteLine(c);

                //dynamic a = np.array(new List<float> { 1, 2, 3 });
                //Console.WriteLine(a.dtype);

                //dynamic b = np.array(new List<float> { 6, 5, 4 }, dtype: np.int32);
                //Console.WriteLine(b.dtype);

                //Console.WriteLine(a * b);
                //Console.ReadKey();

                //dynamic Python_predict = Py.Import("Prediction");
                //Python_predict.__init__(modelpath);


                //List<float> imagelist = GetNormalizedFloatBGRImage(image).Data.Cast<float>().ToList();
                //DateTime t1 = System.DateTime.Now;
                //Predicted_Type = Python_predict.Findtype(imagelist);
                //DateTime t2 = System.DateTime.Now;
                //Console.WriteLine("Predict timing from c# {0} seconds", (t2.Second + ((float)t2.Millisecond / 1000)) - (t1.Second + ((float)t1.Millisecond / 1000)));

               dynamic s =  Py.Import("sample");
                Console.WriteLine(s.sample.Test01());
                Console.WriteLine(s.sample().Test02());
                Console.ReadKey();
            }
        }
    }
}
