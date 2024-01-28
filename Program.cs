using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_netolog
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };
           
            string[] array2 = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
           
            int[][] array3 = new int[3][] {
             new int [] {2, 3, 4},
             new int [] {(int) Math.Pow (2,2), (int) Math.Pow (3,2),(int) Math.Pow (4,2)},
             new int [] {(int) Math.Pow (2,3), (int) Math.Pow (3,3),(int) Math.Pow (4,3)}};
            
            double[][] array4 = new double[3][]{
              new double [] {1,2,3,4,5},
              new double [] { Math.E,Math.PI},
              new double [] { Math.Log(1,10),Math.Log(10,10),Math.Log(100,10),Math.Log(1000,10) } };

            int[] array51 =  { 1, 2, 3, 4, 5 };
            int[] array52 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array51, array52, 3);
           array52.ToList().ForEach(Console.WriteLine);


            string[] sample = { "", "" };
            Array.Resize(ref sample, sample.Length*2 );
            sample.ToList().ForEach(Console.WriteLine);
            Console.ReadKey();



        }
    }
}
