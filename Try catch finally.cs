using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число для деления 100:");

        try
        {
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput); // Попытка преобразовать ввод в целое число
            int result = 100 / number; 
            Console.WriteLine($"Результат деления 100 на {number} равен {result}.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Ошибка: Деление на ноль недопустимо.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, введите целое число.");
        }
        catch (Exception ex) // Обработка всех остальных исключений
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Завершение программы. Спасибо за использование!");
        }
    }
}