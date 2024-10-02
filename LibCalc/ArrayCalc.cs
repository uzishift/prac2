
namespace LibCalc
{
    public class LibCalculator
    {
        /// <summary>
        /// Считает сумму чисел > 15
        /// </summary>
        /// <param name="array">Массив, в котором нужно посчитать сумму</param>
        /// <returns>Возвращает сумму числе > 15</returns>
        public static int SumOver15(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] > 15)
                    {
                        sum += array[i, j];
                    }
            }
            return sum;
        }
    }
}
