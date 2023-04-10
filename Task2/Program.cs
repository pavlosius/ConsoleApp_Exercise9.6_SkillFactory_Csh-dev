using Task2;

List<string> secondNames = new List<string>() {
    "Иванов",
    "Егоров",
    "Петров",
    "Максимов",
    "Сидоров"
};

DisplayList(secondNames);

Sorter sorter = new Sorter();
sorter.SortingEvent += Sort;
sorter.OnSortingCompletedEvent += DisplayList;

while (true)
{
    try
    {
        sorter.SortList(secondNames);
    }
    catch (Exception ex)
    {
        if (ex is MyException)
            Console.Write("My exception: ");

        Console.WriteLine(ex.Message);
    }
};

static void Sort(List<string> list, int number)
{
    Console.WriteLine($"Введено значение {number}");
    switch (number)
    {
        case 1:
            Console.WriteLine("сортировка А-Я");
            list.Sort();
            break;
        case 2:
            Console.WriteLine("сортировка Я-А");
            list.Reverse();
            break;
    }
}

static void DisplayList(List<string> list)
{
    Console.WriteLine("Список фамилий:");
    foreach (string item in list)
    {
        Console.WriteLine(item);
    }
}

class MyException : Exception
{
    public MyException(string message) : base(message)
    {
    }
}