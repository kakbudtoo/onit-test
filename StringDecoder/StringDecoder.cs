using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDecoder
{
    public class StringDecoder
    {
        public static string Decode(string encodedString, int seed)
        {
            ushort currentValue = (ushort)seed;
            char[] decodedChars = new char[encodedString.Length / 4];

            for (int i = 0; i < encodedString.Length / 4; i++)
            {
                // Извлекаем 4 символа и преобразуем их в ushort
                ushort encodedValue = (ushort)(
                    ((encodedString[4 * i] - 'a') +
                    ((encodedString[4 * i + 1] - 'a') << 4)) +
                    ((encodedString[4 * i + 2] - 'a') << 8) +
                    ((encodedString[4 * i + 3] - 'a') << 12));

                // Вычитаем текущее значение и получаем декодированный символ
                ushort decodedChar = (ushort)(encodedValue - currentValue);
                decodedChars[i] = (char)decodedChar;

                // Обновляем текущее значение для следующей итерации
                currentValue += 1789;
            }

            return new string(decodedChars);
        }
    }
}
