
📘 Раздел 1: Избор (един верен отговор)
1. Кое от следните описва най-добре енкапсулацията?
a) Създаване на обекти от класове
b) Наследяване на методи от базов клас
c) Скриване на вътрешното състояние на обектите чрез достъп само чрез свойства
d) Позволяване на обект да има няколко форми

2. Какво прави ключовата дума virtual?
a) Превръща метод в статичен
b) Създава интерфейс
c) Позволява методът да бъде override-нат в наследник
d) Скрива метод от базовия клас

3. Кой от следните оператори показва, че даден обект може да бъде третиран като даден тип?
a) ==
b) is
c) as
d) typeof

4. Кое твърдение за интерфейсите в C# е вярно?
a) Интерфейсите могат да имат имплементация на методи
b) Един клас може да наследява само един интерфейс
c) Интерфейсите могат да съдържат полета
d) Интерфейсът може да съдържа само декларации на методи и свойства

5. Какво ще се отпечата:


class A {
    public virtual void Print() {
        Console.Write("A ");
    }
}

class B : A {
    public override void Print() {
        Console.Write("B ");
    }
}

class C : B {
    public override void Print() {
        base.Print();
        Console.Write("C ");
    }
}

A obj = new C();
obj.Print();
a) A B C
b) B C
c) C B
d) A C

📙 Раздел 2: Вярно или Грешно
6. Конструктор може да бъде private.
7. Свойство (property) може да извиква метод в get блока.
8. Ключовата дума new се използва само при създаване на обект.
9. Абстрактен метод задължително трябва да бъде override-нат в наследника.
10. Можеш да използваш base за достъп до методи от базов клас.

📗 Раздел 3: Допълване на код
11. Напиши липсващата ключова дума така, че методът Fly() да може да бъде override-нат:


class Bird {
    public _______ void Fly() {
        Console.WriteLine("Flap");
    }
}
12. Допиши класа така, че да имплементира интерфейс IMovable с метод Move():

interface IMovable {
    void Move();
}

class Car : _______ {
    public void Move() {
        Console.WriteLine("Car is moving");
    }
}
📕 Раздел 4: Какво ще отпечата кодът?
13.

class Shape {
    public void Draw() {
        Console.WriteLine("Shape");
    }
}

class Circle : Shape {
    public new void Draw() {
        Console.WriteLine("Circle");
    }
}

Shape s = new Circle();
s.Draw();
а) Circle
б) Shape
в) Нищо
г) Error

14.

class Base {
    public Base() {
        Console.Write("Base ");
    }
}

class Derived : Base {
    public Derived() {
        Console.Write("Derived ");
    }
}

Derived d = new Derived();
а) Derived
б) Base
в) Base Derived
г) Error

15. Какво ще отпечата следният код?

class Test {
    public static int x = 0;

    static Test() {
        x = 10;
    }

    public Test() {
        x += 5;
    }
}

Test t1 = new Test();
Test t2 = new Test();
Console.WriteLine(Test.x);
а) 10
б) 15
в) 20
г) 25

