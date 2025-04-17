# Как работает декодер:
1. Входная строка делится на группы по 4 символа
2. Каждая группа преобразуется в 16-битное число (ushort) путем:
 - Вычитания 'a' из каждого символа
 - Сдвига битов каждого последующего символа на 4, 8 и 12 бит соответственно
 - Суммирования всех компонентов
3. Из полученного значения вычитается текущее значение (начинается с seed)
4. Результат преобразуется в символ
5. Текущее значение увеличивается на 1789 для следующей итерации

Этот алгоритм представляет собой простую форму обратимого преобразования строк с использованием ключа (seed).

## Результат декодирования сообщения:

Your 30-day trial and the 5 day grace period has ended. This About Box will always be shown AND there will be a delay of 3 seconds at startup.
You must purchase licenses to disable the trial engine and continue using the controls in your development projects.
Use the links below to get license pricing and ordering information. If you want an extension for evaluation, please contact us using the links below.