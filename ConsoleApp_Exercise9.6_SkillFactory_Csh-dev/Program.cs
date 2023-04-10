Console.WriteLine("Сообщения массива исключени:");

Exception[] exceptions = new Exception[]
{
    new ArgumentException(),            //"Аргумент не попадает в ожидаемый диапазон"
    new ArgumentNullException(),        //"Аргумент не может быть null"
    new DivideByZeroException(),        //"Деление на ноль"
    new IndexOutOfRangeException(),     //"Индекс выходит за границы массива"
    new ArgumentOutOfRangeException(),  //"Аргумент находится за пределами допустимых значений"
    new FormatException(),              //"Один из определенных элементов имел неверный формат"
    new IOException(),                  //"Ошибка ввода-вывода"
    new OutOfMemoryException(),         //"Недостаточно памяти для продолжения выполнения операции"
    new MyException("Моё исключение")
};

foreach(Exception exeption in exceptions)
{
    try
    {
        throw exeption;
    }
    catch (Exception ex)
    {
        
        Console.WriteLine(ex.Message);
    }
}
Console.ReadKey();

class MyException : Exception
{
    public MyException(string message) : base(message)
    {
    }
}