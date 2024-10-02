
namespace LibCalc
{
    public class LibCalculator
    {
        /// <summary>
        /// ������� ����� ����� > 15
        /// </summary>
        /// <param name="array">������, � ������� ����� ��������� �����</param>
        /// <returns>���������� ����� ����� > 15</returns>
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
