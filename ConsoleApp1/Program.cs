using System;

class Roslyna
{
    // Поля базового класу
    public string Name { get; set; } // Назва рослини
    public string Color { get; set; } // Колір рослини

    // Конструктор з параметрами для базового класу
    public Roslyna(string name, string color)
    {
        Name = name;
        Color = color;
    }

    // Віртуальний метод 1
    public virtual void Grow()
    {
        Console.WriteLine($"{Name} росте.");
    }

    // Віртуальний метод 2
    public virtual void Bloom()
    {
        Console.WriteLine($"{Name} цвіте.");
    }
}

class Derevo : Roslyna
{
    // Додаткові властивості для класу Дерево
    public string Breed { get; set; } // Порода дерева
    public int Age { get; set; } // Вік дерева

    // Конструктор з параметрами для класу Дерево
    public Derevo(string name, string color, string breed, int age) : base(name, color)
    {
        Breed = breed;
        Age = age;
    }

    // Перевизначення віртуального методу 1
    public override void Grow()
    {
        Console.WriteLine($"{Breed} дерево росте. Його вік: {Age} років.");
    }

    // Перевизначення віртуального методу 2
    public override void Bloom()
    {
        Console.WriteLine($"{Breed} дерево цвіте красивими {Color} квітами.");
    }

    // Метод 1. Приймає 2 параметри: Порода і Вік
    public void CheckTree(string breed, int age)
    {
        if (breed == Breed && age == Age)
        {
            Console.WriteLine($"Дерево: {Name}, Колір: {Color}, Порода: {Breed}, Вік: {Age} років.");
        }
        else
        {
            Console.WriteLine($"Такого дерева у нас немає: {breed}, {age} років.");
        }
    }

    // Метод 2. Приклад простого методу, що виводить інформацію про дерево
    public void PrintTreeInfo()
    {
        Console.WriteLine($"Це {Breed} дерево, йому {Age} років. Воно має {Color} листя.");
    }
}

class Kvity : Roslyna
{
    // Конструктор з параметрами для класу Квіти
    public Kvity(string name, string color) : base(name, color)
    {
    }

    // Перевизначення віртуального методу 1
    public override void Grow()
    {
        Console.WriteLine($"Квітка {Name} росте. Її колір: {Color}.");
    }

    // Перевизначення віртуального методу 2
    public override void Bloom()
    {
        Console.WriteLine($"Квітка {Name} цвіте гарними {Color} квітами.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкту дерева
        Derevo derevo = new Derevo("Дерево", "Зелене", "Груша", 10);
        derevo.Grow();        // Викликаємо метод росту дерева
        derevo.Bloom();       // Викликаємо метод цвітіння дерева
        derevo.CheckTree("Груша", 10);  // Перевірка дерева за породою і віком
        derevo.CheckTree("Яблуня", 5);  // Перевірка дерева з помилковими даними
        derevo.PrintTreeInfo();         // Виведення інформації про дерево

        // Створення об'єкту квітки
        Kvity kvitka = new Kvity("Троянда", "Червона");
        kvitka.Grow();        // Викликаємо метод росту квітки
        kvitka.Bloom();       // Викликаємо метод цвітіння квітки
    }
}
