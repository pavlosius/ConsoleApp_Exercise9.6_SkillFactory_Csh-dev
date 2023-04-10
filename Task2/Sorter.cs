namespace Task2
{
    class Sorter
    {
        public delegate void SortingDelegate(List<string> itemsList, int number);
        public event SortingDelegate SortingEvent;

        public delegate void OnSortingCompletedDelegate(List<string> itemsList);
        public event OnSortingCompletedDelegate OnSortingCompletedEvent;

        public void SortList(List<string> itemsList)
        {
            Console.WriteLine("\nДля сортировки введите число:");
            Console.WriteLine("1 - сортировка А-Я");
            Console.WriteLine("2 - сортировка Я-А");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2) throw new MyException("Ошибка. Введено невереное значение.");

            OnSortingCompleted(itemsList);
        }
        protected void Sorting(List<string> itemsList, int number)
        {
            SortingEvent?.Invoke(itemsList, number);
        }
        protected void OnSortingCompleted(List<string> itemsList)
        {
            OnSortingCompletedEvent?.Invoke(itemsList);
        }

    }
}
