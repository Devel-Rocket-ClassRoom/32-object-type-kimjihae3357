using System;
using System.Drawing;

// 1
/*
object obj1 = 42;
object obj2 = 3.14;
object obj3 = "Hello";
object obj4 = true;
object obj5 = new int[] {1, 2, 3 };

Console.WriteLine(obj1);
Console.WriteLine(obj2);
Console.WriteLine(obj3);
Console.WriteLine(obj4);

// 2

Stack stack = new Stack();

stack.Push("sausage");
string s = (string)stack.Pop();
Console.WriteLine(s);

stack.Push(3);
int three = (int)stack.Pop();
Console.WriteLine(three);

class Stack
{
    private int _position;
    private object[] _data = new object[10];

    public void Push(object obj)
    {
        _data[_position++] = obj;
    }

    public object Pop()
    {
        return _data[--_position]; 
    }
}

// 3-1

int i = 1234;
object o = i;
Console.WriteLine(o);

// 3-2

object o = 1234;
int i = (int)o;
Console.WriteLine(i);

// 4-1

int i = 42;
object boxed = i;
Console.WriteLine(boxed);

// 4-2

Point p = new Point {  X = 10, Y = 20 };
IDisplayable d = p;
Console.WriteLine(d.GetType().Name);

interface IDisplayable
{
}

struct Point : IDisplayable
{
    public int X;
    public int Y;
}

// 5

int i = 3;
object boxed = i;
i = 5;

Console.WriteLine($"원본: {i}");
Console.WriteLine($"박싱된 값: {boxed}");

// 6

object boxed = 42;

int i = (int)boxed;
Console.WriteLine($"언박싱 성공: {i}");

try
{
    long l = (long)boxed;
}

catch (InvalidCastException)
{
    Console.WriteLine("잘못된 타입으로 언박싱 시도");
}

int temp = (int)boxed;
long correct = temp;
Console.WriteLine($"올바른 변환: {correct}");

// 7-1

int sum1 = 0;
for (int i = 0; i < 1000; i++)
{
    object boxed = i;
    sum1 += (int)boxed;
}
Console.WriteLine($"박싱 사용: {sum1}");

int sum2 = 0;
for (int i = 0; i < 1000; i++)
{
    sum2 += i;
}
Console.WriteLine($"직접 처리: {sum2}");

// 7-2

GenericStack<int> intStack = new GenericStack<int>();
intStack.Push(42);
int value = intStack.Pop();
Console.WriteLine(value);

class GenericStack<T>
{
    private T[] _items = new T[100];
    private int _top = 0;

    public void Push(T item)
    {
        _items[_top++] = item;
    }
    public T Pop()
    {
        return _items[--_top];
    }
}

// 8-1

int i = 1234;
string s = "안녕하세요";
char c = 'A';
double d = 3.14;
object o = new object();

Console.WriteLine(i.GetType());
Console.WriteLine(s.GetType());
Console.WriteLine(c.GetType());
Console.WriteLine(d.GetType());
Console.WriteLine(o.GetType());

// 8-2

Console.WriteLine(typeof(int));
Console.WriteLine(typeof(string));
Console.WriteLine(typeof(double));

// 8-3

Point p = new Point { X = 10, Y = 20 };

Console.WriteLine(p.GetType().Name);
Console.WriteLine(typeof(Point).Name);
Console.WriteLine(p.GetType() == typeof(Point));
Console.WriteLine(p.X.GetType().Name);
Console.WriteLine(p.Y.GetType().FullName);
class Point
{
    public int X;
    public int Y;
}

// 9-1

int number = 42;
double pi = 3.14;
bool flag = true;

Console.WriteLine(number.ToString());
Console.WriteLine(pi.ToString());
Console.WriteLine(flag.ToString());

// 9-2

Panda p = new Panda { Name = "Petey" };
Console.WriteLine(p);
Console.WriteLine(p.ToString());
class Panda
{
    public string Name;

    public override string ToString()
    {
        return Name;
    }
}

// 9-3

Player player = new Player { Name = "Hero", Level = 10, Health = 100 };
Console.WriteLine(player);
class Player
{
    public string Name;
    public int Level;
    public int Health;

    public override string ToString()
    {
        return $"Player {{ Name = {Name}, Level = {Level}, Health = {Health} }}";
    }
}
*/
// 10

string s1 = "Hello";
string s2 = "Hello";
string s3 = s1;

Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");
Console.WriteLine($"ReferenceEquals(s1, s2): {object.ReferenceEquals(s1, s2)}");
Console.WriteLine($"ReferenceEquals(s1, s3): {object.ReferenceEquals(s1, s3)}");

object obj1 = new object();
object obj2 = new object();
object obj3 = obj1;

Console.WriteLine($"obj1.Equals(obj2): {obj1.Equals(obj2)}");
Console.WriteLine($"ReferenceEquals(obj1, obj2): {object.ReferenceEquals(obj1, obj2)}");
Console.WriteLine($"ReferenceEquals(obj1, obj3): {object.ReferenceEquals(obj1, obj3)}");