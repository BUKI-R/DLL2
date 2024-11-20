namespace pictureLib
{
    public class Picture
    {
        string name;
        public Picture(string name)
        {
            this.name = name;
        }
        public void Print() => Console.WriteLine($"Имя художника: {name}");

        public void Time()
        {
                Console.WriteLine($"Сколько время дано:");
                double time = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Сколько частей картины всего:");
                double Max = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Сколько частей картины нарисовано:");
                double Min = Convert.ToDouble(Console.ReadLine());
            if (Min == 0)
            {
                Console.WriteLine($"Сколько времи осталось: {time}");
            }
            else if (Min > Max || Max == 0)
            {
                Console.WriteLine($"Ошибка");
                
            }
            else if (Min == Max)
            {
                Console.WriteLine($"Работа успешна завершена");
            }
            else
            {
                double a = (time / Max) * Min;
                Console.WriteLine($"Сколько времи осталось: {a}");
            }
        }

    }
}
