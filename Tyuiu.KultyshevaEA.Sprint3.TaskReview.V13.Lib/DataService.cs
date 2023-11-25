using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KultyshevaEA.Sprint3.TaskReview.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; //обЪявляем пустой массив
            int len = (stopValue - startValue) + 1; // вычисляем длину массива
            valueArray = new double[len]; //создаём массив с указанной длиной
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + 1;
                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(3 * x + 2 - (2 * x - x) / (Math.Cos(x) + 1), 2);
                }
                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
