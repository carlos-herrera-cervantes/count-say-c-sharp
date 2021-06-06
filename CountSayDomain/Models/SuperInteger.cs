using System.Text;

namespace CountSayDomain.Models
{
    public class SuperInteger
    {
        /// <summary>Returns the count to reach the number</summary>
        /// <param name="number">Integer</param>
        /// <returns>Counter</returns>
        public static string CountAndSay(int number)
        {
            if (number == 1) return "1";

            var current = new StringBuilder();
            string previous = CountAndSay(number - 1);
            var count = 0;

            for (int i  = 0; i < previous.Length; i++)
            {
                count++;

                if (i == previous.Length - 1 || previous[i] != previous[i + 1])
                {
                    current.Append(count).Append(previous[i]);
                    count = 0;
                }
            }

            return current.ToString();
        }
    }
}