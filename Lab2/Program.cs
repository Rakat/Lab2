using System;

// Абстрактний базовий клас "Тварина"
public abstract class Animal
{
    // Поля
    public string Name { get; set; }
    public int Age { get; set; }

    // Конструктор з параметрами
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Абстрактні віртуальні методи
    public abstract void MakeSound();
    public abstract void DisplayInfo();
}

// Похідний клас "Кішка"
public class Cat : Animal
{
    // Нові властивості класу "Кішка"
    public string Breed { get; set; }
    public string Illness { get; set; }

    // Конструктор з параметрами
    public Cat(string name, int age, string breed, string illness)
        : base(name, age)
    {
        Breed = breed;
        Illness = illness;
    }

    // Реалізація віртуального методу з базового класу
    public override void MakeSound()
    {
        Console.WriteLine("Мяу!");
    }

    // Реалізація віртуального методу з базового класу
    public override void DisplayInfo()
    {
        Console.WriteLine($"Це кішка породи {Breed}. Її звуть {Name}.");
    }

    // Метод для виведення породи і імені
    public void ShowBreedAndName()
    {
        Console.WriteLine($"Ця кішка {Breed}. Її звуть {Name}.");
    }

    // Метод для аналізу хвороби
    public void AnalyzeIllness(string severity)
    {
        switch (severity.ToLower())
        {
            case "тяжка":
                Console.WriteLine("Хвороба тяжка. Потрібна операція.");
                break;
            case "середня":
                Console.WriteLine("Хвороба середня. Потрібно лікування у клініці.");
                break;
            case "легка":
                Console.WriteLine("Хвороба легка. Лікуйте кішку дома.");
                break;
            default:
                Console.WriteLine("Помилка. Введіть правильно ступінь хвороби.");
                break;
        }
    }
}

// Похідний клас "Собака"
public class Dog : Animal
{
    // Нові властивості класу "Собака"
    public string Illness { get; set; }
    public string Severity { get; set; }

    // Конструктор з параметрами
    public Dog(string name, int age, string illness, string severity)
        : base(name, age)
    {
        Illness = illness;
        Severity = severity;
    }

    // Реалізація віртуального методу з базового класу
    public override void MakeSound()
    {
        Console.WriteLine("Гав!");
    }

    // Реалізація віртуального методу з базового класу
    public override void DisplayInfo()
    {
        Console.WriteLine($"Це собака на ім'я {Name}. Йому {Age} років.");
    }

    // Метод для аналізу хвороби у собаки
    public void AnalyzeIllness()
    {
        switch (Severity.ToLower())
        {
            case "тяжка":
                Console.WriteLine("Хвороба тяжка. Потрібна операція.");
                break;
            case "середня":
                Console.WriteLine("Хвороба середня. Потрібно лікування у клініці.");
                break;
            case "легка":
                Console.WriteLine("Хвороба легка. Лікуйте собаку дома.");
                break;
            default:
                Console.WriteLine("Помилка. Введіть правильно ступінь хвороби.");
                break;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта класу "Кішка"
        Cat cat = new Cat("Мурка", 3, "Сіамська", "Вірус");
        cat.MakeSound();            // Виведе: Мяу!
        cat.DisplayInfo();          // Виведе: Це кішка породи Сіамська. Її звуть Мурка.
        cat.ShowBreedAndName();     // Виведе: Ця кішка Сіамська. Її звуть Мурка.
        cat.AnalyzeIllness("легка"); // Виведе: Хвороба легка. Лікуйте кішку дома.

        // Створення об'єкта класу "Собака"
        Dog dog = new Dog("Бобик", 5, "Гастрит", "середня");
        dog.MakeSound();            // Виведе: Гав!
        dog.DisplayInfo();          // Виведе: Це собака на ім'я Бобик. Йому 5 років.
        dog.AnalyzeIllness();       // Виведе: Хвороба середня. Потрібно лікування у клініці.
    }
}
