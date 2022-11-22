using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public static class Logic
    {
        public static string ConvertCost(string cost)
        {
            var outMessage = "";

            if (cost.Length == 0) outMessage = "Вы не ввели стоимость";

            if (cost.Length > 4)
            {
                outMessage = "Введено недопустимое значение.";
            }

            for (int i = 0; i < cost.Length; i++)
            {
                if (cost[i] == '-')
                {
                    outMessage = "Введено отрицательное значение";
                }
                else if (outMessage == "" && (cost[i] < '0' || cost[i] > '9'))
                {
                    outMessage = "Введено не числовое значение диапазона";
                }
            }

            int price;
            if (outMessage == "")
            {
                price = int.Parse(cost);
                outMessage = "Стоимость товара составляет ";
                if (price / 100 == 1)
                {
                    outMessage += price / 100 + " рубль ";
                }
                else if (price / 100 < 5 && price / 100 != 0)
                {
                    outMessage += price / 100 + " рубля ";
                }
                else if (price / 100 < 21)
                {
                    outMessage += price / 100 + " рублей ";
                }
                else if (price / 100 % 10 == 1)
                {
                    outMessage += price / 100 + " рубль ";
                }
                else if (price / 100 % 10 < 5 && price / 100 % 10 != 0)
                {
                    outMessage += price / 100 + " рубля ";
                }
                else
                {
                    outMessage += price / 100 + " рублей ";
                }

                if (price % 100 == 1)
                {
                    outMessage += price % 100 + " копейка";
                }
                else if (price % 100 < 5 && price % 100 != 0)
                {
                    outMessage += price % 100 + " копейки";
                }
                else if (price % 100 < 21)
                {
                    outMessage += price % 100 + " копеек";
                }
                else if (price % 100 % 10 == 1)
                {
                    outMessage += price % 100 + " копейка";
                }
                else if (price % 100 % 10 < 5 && price % 100 % 10 != 0)
                {
                    outMessage += price % 100 + " копейки";
                }
                else
                {
                    outMessage += price % 100 + " копеек";
                }

            }
            return outMessage;
        }

        public static string PercentWordInSentece(string sentence)
        {
            float percent = (0);
            float count = (0);

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] >= 'A' && sentence[i] <= 'п' || sentence[i] >= 'р' && sentence[i] <= 'ё' || sentence[i] >= 'A' && sentence[i] <= 'Z' || sentence[i] >= 'a' && sentence[i] <= 'z')
                {
                    count += 1;
                }
            }

            if (count != 0)
            {
                percent = count / sentence.Length * 100;
            }
            else
            {
                percent = 0;
            }

            var outMessage = "";
            if (percent == 0)
            {
                outMessage = "В предложении отсутствуют буквы";
            }
            else
            {
                outMessage = $"Процент букв в предложении {percent:##.##}%";
            }
            return outMessage;
        }

    }
}

