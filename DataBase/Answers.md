# Ответ на Задание №5

## Структура БД

### Табл.1 Employees_Sell

|        FullName |ExpYears  |Qualification |
|-----------------|----------|--------------|
|Иван Иванов      |      2   | Ст. Менеджер |
|Петр Петров      |      5   | Ср. Менеджер |
|Иван Степанович  |      8   | Мл. Менеджер |

|     FullName    |PersonalTransport|
|-----------------|-----------------|
|Иван Иванов      | есть            |
|Петр Петров      | нет             |
|Иван Степанович  | есть            |

### Табл.2 Employees_HR

|     FullName    |ExpYears|
|-----------------|--------|
|Иван Фомич       | 1      |
|Владимир Петрович| 7      |

|     FullName    |PhoneNumber   |
|-----------------|--------------|
|Иван Фомич       | 8800553535   |
|Владимир Петрович| 8800458521   |

## Запросы для каждой из исходных таблиц 

SELECT 
    Employees_Sell.FullName AS [ФИО],
    Employees_Sell.ExpYears AS [Стаж],
    Employees_Sell.Qualification AS [Квалификация],
    Employees_Sell.PersonalTransport AS [Личный_транспорт],
FROM Employees_Sell

SELECT 
    Employees_HR.FullName AS [ФИО],
    Employees_HR.ExpYears AS [Стаж],
    Employees_HR.PhoneNumber AS [Номер_телефона],
FROM Employees_HR

## Использование даты рождения

SELECT 
    Employees.FullName AS [ФИО сотрудника],
    Employees.DateValue AS [Дата рождения сотрудника]
FROM Employees