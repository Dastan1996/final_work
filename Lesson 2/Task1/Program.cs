int Prompt(string message)
{
    System.Console.Write(value: message); //Вывести сообщение
    string readValue = Console.ReadLine(); //Ситывает с консоли строку
    int result = int.Parse(s: readValue); //Преобразует строку в целое число
    return result; //Возвращает результат
}

int userNum = Prompt(message: "Введите 3-х значное число > ");

int result = userNum / 10 % 10;
Console.WriteLine(value: result);