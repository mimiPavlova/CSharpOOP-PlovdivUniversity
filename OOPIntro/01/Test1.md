

🧪 Теоретичен тест по ООП с C#
📘 Раздел 1: Въпроси с избираем отговор (само един верен)


1. Кое твърдение е вярно за abstract клас?
a) Може да се инстанцира директно
b) Не може да съдържа имплементирани методи
c) Може да съдържа както абстрактни, така и напълно дефинирани методи
d) Всички методи в него трябва да са static
 
 Отговор-b;

2. Какво прави ключовата дума override в C#?
a) Забранява наследяване
b) Скрива метод от базовия клас
c) Презаписва virtual или abstract метод
d) Създава нов метод в наследника

Отговор-c;

3. Какво ще отпечата този код?


class Animal {
    public virtual void Speak() {
        Console.WriteLine("Animal");
    }
}

class Dog : Animal {
    public override void Speak() {
        Console.WriteLine("Dog");
    }
}

Animal a = new Dog();
a.Speak();
a) Animal
b) Dog
c) Грешка при компилация
d) Нищо

 
 Отговор-b;


4. Кое от следните НЕ е характерно за static клас?
a) Не може да се наследява
b) Може да има конструктори
c) Може да съдържа само static членове
d) Може да бъде инстанциран
Отговор-d;
5. Какъв достъп има private поле по подразбиране?
a) Само в текущия клас
b) В целия проект
c) В рамките на пространството от имена
d) В наследници на класа
Отговор-a;
📙 Раздел 2: Вярно или Грешно
6. Един метод може да бъде едновременно static и virtual.
Отговор-грешно
7. Свойство (property) може да има само get или само set.
Отговор-вярно,
 8. Интерфейсите могат да съдържат полета със стойности.
 Отговор-вярно
9. Полиморфизмът позволява извикване на метод според реалния тип на обекта.
Отговор-вярно,
 10. Един клас може да наследява повече от един базов клас в C#.
Отговор-грешно
📗 Раздел 3: Допълване
11. Допиши кода така, че методът Drive() да може да бъде презаписан в наследници:

class Vehicle {
    public _______ void Drive() {
        Console.WriteLine("Driving");
    }
}

Отговор-virtual;
12. Допиши кода така, че Cat да бъде валиден наследник на абстрактния клас и да имплементира метода:

abstract class Animal {
    public abstract void Speak();
}

class Cat : _______ {
    public override void Speak() {
        Console.WriteLine("Meow");
    }
}
Отговор-Animal;
📕 Раздел 4: Анализ на код (Какво ще изведе?)
13.


class Base {
    public void Print() {
        Console.WriteLine("Base");
    }
}

class Derived : Base {
    public new void Print() {
        Console.WriteLine("Derived");
    }
}

Base b = new Derived();
b.Print();

а) Base
б) Derived
в) Грешка
г) Нищо
Отговор-b;
14.

class Counter {
    public static int Count = 0;

    public Counter() {
        Count++;
    }
}

Counter c1 = new Counter();
Counter c2 = new Counter();
Console.WriteLine(Counter.Count);
а) 0
б) 1
в) 2
г) Грешка

15.


namespace First {
    class MyClass {
        public void Show() {
            Console.WriteLine("First");
        }
    }
}

namespace Second {
    class MyClass {
        public void Show() {
            Console.WriteLine("Second");
        }
    }
}
Допиши така, че и двата класа да се използват в Main() без конфликт.

using First;
using Second;

class Program {
    static void Main() {
        First.MyClass obj1 = new First.MyClass();
        Second.MyClass obj2 = new Second.MyClass();

        obj1.Show(); // First
        obj2.Show(); // Second
    }
}

