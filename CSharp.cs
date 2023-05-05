//Naming.CodeStyle.                                                                                                        CodeStyle.Naming.

//10 шрифт:          страница 90 символов и 60 строк, крайний символ находиться здесь. ###                                         
//7 шрифт: страница 140 символов и 90 строк, поля лев 1, прав 2, верх 3, низ 3. Print to PDF.      крайний символ находиться здесь. ## # # #
#pragma warning disable UNT0001,UNT0010,UNT0016,IDE0017,IDE0044,IDE0051,IDE0052,IDE0054,IDE0059,IDE0060,IDE0062,IDE0090,CS0649
#pragma warning disable CS0414,CS8321   // Игнорирование ошибки "Переменная назначена, но ее значение не используется" (для классов)
#pragma warning disable CS0219,CS0168   // Игнорирование ошибки "Переменная назначена, но ее значение не используется"
#pragma warning disable CS0162          // Игнорирование ошибки "Обнаружен недостижимый код"

// Раздел объявления библиотек.
using System;                           //using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;                      //using System.Linq;
using UnityEditor;                      //using UnityEditor;
using UnityEngine;                      //using UnityEngine;
using UnityEngine.SceneManagement;      //using UnityEngine.SceneManagement;
using UnityEngine.Serialization;        //using UnityEngine.Serialization;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;      // Указывает из какого модуля использовать одноименные методы.

// Раздел объявления классов.

//======================================================================================================//
//Соглашения о написании кода на C#                                                                     //
//https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/coding-conventions          //
//======================================================================================================//

// Naming
namespace PascalCase00
{
    class PascalCase01
    {
        // Длина строки строго <= 140 символов!!!
        // Метод рекомендовано <= 25 строк. (Сюда включены 3 строки (минимум) на имя и логические скобки)
        // Метод строго <=90 строк со всеми комментариями, описаниями и прочим!!! (что бы вместился на 1 печатный лист)

        //record PascalCase02 (string PascalCase03) { }     // Для любых модификаторов доступа.??? че за record, в unity не работает.???
        class PascalCase04 { }                              // Для любых модификаторов доступа.
        struct PascalCase05 { }                             // Для любых модификаторов доступа.
        interface IPascalCase06 { }                         // (префикс "I") Для любых модификаторов доступа.

        const float PascalCase07 = 1.0f;                    // Для любых модификаторов доступа.
        readonly float PascalCase08 = 1.0f;                 // Для любых модификаторов доступа.


        private float _camelCase01;                         // (префикс "_") Для private и internal.
        private protected float _camelCase02;               // (префикс "_") Для private и internal.
        protected float PascalCase09;                       // Для protected, protected internal и public.
        protected internal float PascalCase10;              // Для protected, protected internal и public.
        internal float _camelCase03;                        // (префикс "_") Для private и internal.
        public float PascalCase11;                          // Для protected, protected internal и public.

        public float PascalCase12 { get; set; }             // Для protected, protected internal и public.
        public Event PascalCase13;                          // Для protected, protected internal и public.

        private static float s_camelCase04;                 // (префикс "s_" для static) Для private и internal. 
        private protected static float s_camelCase05;       // (префикс "s_" для static) Для private и internal.
        protected static float PascalCase14;                // Для protected, protected internal и public.
        protected internal static float PascalCase15;       // Для protected, protected internal и public.
        internal static float s_camelCase06;                // (префикс "s_" для static) Для private и internal.
        public static float PascalCase16;                   // Для protected, protected internal и public.

        [ThreadStatic] private static float t_camelCase07;              // (префикс "t_") Для private и internal. 
        [ThreadStatic] private protected static float t_camelCase08;    // (префикс "t_") Для private и internal.
        [ThreadStatic] protected static float PascalCase17;             // Для protected, protected internal и public.
        [ThreadStatic] protected internal static float PascalCase18;    // Для protected, protected internal и public.
        [ThreadStatic] internal static float t_camelCase09;             // (префикс "t_") Для private и internal.
        [ThreadStatic] public static float PascalCase19;                // Для protected, protected internal и public.

        void PascalCase20(float camelCase10)                // Для любых модификаторов доступа (Методы).
        {
            int PascalCase21() => 0;                        // Локальная функция.   
            float camelCase11;
        }
    }
}











//Naming.CodeStyle.                                                                                                        CodeStyle.Naming.
//Classes[0].                                                                                                                    Classes[0].

//using Name1;                                                                                                                   

namespace Name1     // Пространство имен, указывается в using, что бы классы, принадлежащие ему были доступны. Даже в разных файлах
{                   // namespace с одинаковым именем можно использовать не указывая в using. Классы в namespace только public.
                    // namespace не может содержать модификаторы и атрибуты.

    // Для описания класса или метода введите /// и пропишется модуль summary,
    // в котором можно описать класс или метод. Это описание будет выходить в подсказке при наведении на него в IDE.
    /// <summary>
    /// Имя класса должно быть таким же как имя файла.
    /// </summary>
    public class Classes    // Класс - это свой тип данных.
    {
        // Ввести "ctor" => tab => tab  : Visual Studio напишет конструктор класса по умолчанию.
        public Classes(float b) { } // Конструктор класса. Нет возвращаемого типа, имя такое как у класса(на самом деле это тип без имени).
        public Classes(int a) : this((float)a) { }  // Перегрузка конструктора класса. :this - вызывает другую перегрузку перед выполнением.

        /// Структура метода: <возвращаемый тип> <имя> (<параметры>) тип void означает "Ничего" (как процедура).
        /// По умолчанию область видимости (контекст) у свойств и методов Private(только внутри класса).
        /// <summary>
        /// Описание метода. 
        /// </summary>
        /// <param name="j"> Описание параметра "j".</param>
        /// <param name="k"> Описание параметра "k".</param>
        /// <returns></returns>
        public void Start(int c)        // Метод объекта класса.
        {
            Classes a = new Classes();  // Создание объекта или экземпляра класса.
            Classes b = new();          // То же самое, что и выше.
        }

        //Модификаторы доступа
        private int i1;             // Виден только внутри этого объекта.
        private protected int i2;   // ???  Виден внутри и в наследующих классах только внутри сборки.             
        protected int i3;           // Виден в наследующих классах в любых сборках. Нельзя использовать в структурах, они не наследуются.
        protected internal int i4;  // ??? Виден внутри сборки, вне сборки только в классах наследниках.
        internal int i5;            // ??? Виден внутри сборки. (DLL библиотеки не дадут подгрузить такую переменную, но внутри можно)
        public int i6;              // Виден везде.

        const float PI = 3.14f;     // Константа, обязательно сразу указывать значение. Изменять нельзя. Модификатор static нельзя
                                    // подставить, константы неявно статические.

        readonly int c = 1;         // Переменная только для чтения. Может быть static. Значение указывать не обязательно, изменять
        public Classes() { c = 3; } // ее можно в конструкторе класса(static в static конструкторе), для остальных она только для чтения. 

        private int a = 2;
        private static int e = 3;
        /// Структура метода: <возвращаемый тип> <имя> (<параметры>) тип void означает "Ничего" (как процедура).
        /// По умолчанию область видимости (контекст) у свойств и методов Private(только внутри класса).
        static void Context(int c)  // Статический метод можно вызывать не создавая объект класса. Статические методы не доступны
        {                           // экземплярам(объектам) класса. Не могут взаимодействовать с нестатическими свойствами и методами.
            {
                float b = 1;        // Контекст переменных, объявленных в методах, ограничен логическими скобками
                                    // в которых их создали(объявили).
            }
            // b = 2; Этой переменной в данном контексте не существует, так как она была создана во вложенных логических скобках.
            // a = 1; Не статическая переменная не видна в статическом методе.
            Classes classes = new Classes();
            classes.a = 1;          // Так обращаемся к не статичной переменной, создав экземпляр объекта.
            e = 1;                  // Статичная переменная видна в статичном методе.
                                    //this.e = 1;           // Не работает для статичных переменных и в статичных методах.
        }

        private float f = 1f;
        // Методы могут быть с одинаковым именем (перегрузка метода), но тогда определяются разными параметрами.
        void Context(float f)       // Перегрузка метода, определяет какой запускать по передаваемым параметрам.
        {
            this.f = f;             // this.f свойство ОБЪЕКТА КЛАССА(с_Script.f), f - параметр метода Context.(только в !static). 
                                    // this - это ссылка на объект класса.
            Classes.e = 1;          // обращение к статическому свойству объекта класса. 
            float h = 1f;
            Ref(ref f,              // Передаем ссылку на переменную, а не значение. Ref не принимает не идентифицированные переменные.
            out float g,            // В out можно передать не идентифицированные переменные, out обязательно присваивают значение.
            h);                     // in не принимает не идентифицированные переменные. Ключевое слово in не обязательно при передаче.
        }
        void Ref(ref float b,       // ref В качестве параметра принимается ссылка на переменную float, а не значение.
        out float c,                // Переменной с ключевым словом out обязательно должно быть присвоено значение, работает как ref.
        in float d)                 // Переменная с ключевым словом in только для чтения (readonly), в остальном как ref.
        {
            c = f;                  // Переменной с ключевым словом out обязательно должно быть присвоено значение.
        }                           // В остальном out работает как ref.

        // Сокращенная запись метода. Выполняется только 1 строка, эту строку и возвращает, return указывать не нужно! 
        int Method(int k, int j) => 23;



        //Classes[0].                                                                                                            Classes[0].
        //Classes[1].static,partial,sealed                                                                 static,partial,sealed,Classes[1].
        void Param(int g, params float[] a)     // params принимает любое количество параметров типа float через запятую.     
        {                                       // или один массив float[]. Должен стоять последним в списке параметров.       
            Method(k: 3, j: 1);                 // Именованные параметры. Можно передавать не по порядку,                        
                                                // если указать какой параметр передаем.                                          

            Classes c_s = new Classes()         // Объявление переменных. (инициализация класса)
            {
                a = 34,
                f = 10
            };
        }
        ~Classes() { }              // Фанлайзер??? Диструктор??? Вызывается при уничтожении класса сборщиком мусора.

        //#pragma warning disable CS0465 // Введение метода Finalize может помешать вызову деструктора
        //        protected override void Finalize()  // можно так, но API говорит так не делать.
        //#pragma warning restore CS0465 // Введение метода Finalize может помешать вызову деструктора
        //        {
        //            try
        //            {
        //                // здесь идут инструкции деструктора
        //            }
        //            finally
        //            {
        //                base.Finalize();
        //            }
        //        }
    }

    public static class Statics     // Статический класс. Нельзя создать экземпляр(объект) статического класса.
    {                               // Статический класс может содержать только статические конструкторы, свойства и методы.
                                    // Не могут наследоваться, не могут интерфейсы??

        static Statics() { }    // Статический конструктор класса. Не может иметь модификаторы доступа и параметры. 
                                // Выполняется один раз при первом обращении к классу. Может использовать только статические члены класса.


        static void M1() { }    // Статический метод, для его вызова не нужно создавать объект класса (объектам недоступны). 
                                // Все созданные объекты класса ссылаются на одно статическое свойство!
                                // Не могут взаимодействовать с нестатическими свойствами и методами.

        // Extension методы (методы расширения). Служат для добавления в класс дополнительных методов.
        // Должны быть статическими и находиться в статическом классе, контекст public.
        // В параметрах первым указываем текущий экземпляр(объект) класса. this <тип_данных_для_которого_этот_метод> <имя_любое>
        // после первого параметра через запятую указываем параметры для передачи как обычно.
        public static void Mmm(this Classes aa, int b, int c = 0)
        {
            aa = new Classes();
            aa.Mmm(2);               //Обращение к расширению через экземпляр класса.
        }
    }

    partial class Partials          // (Частичный тип) Класс можно разнести по разным файлам.(namespace должен быть одинаковый)
    {
        partial void PartialMethod();       // Метод тоже можно разнести внутри partial class, но никто не знает нахуя.
    }
    partial class Partials          // Продолжение partial класса. C# видит обе части как один класс.
    {
        partial void PartialMethod() { }    // Метод тоже можно разнести внутри partial class, но никто не знает нахуя.
    }

    sealed class Sealeds { }        // Класс не может наследоваться.

    class Classes1 : Classes        // Наследование. Множественного наследования в КЛАССАХ НЕТ.
    {
        // Конструкторы классов при создании экземпляра дочернего создают сначала родительские, в которых так же срабатывает конструктор!
        public Classes1() : base(3f) { }    // Указываем параметры для конструктора родительского (базового) класса
        public new void Start(int a1)       // Скрываем одноименный метод базового класса. При вызове из объекта класса будет срабатывать
        {                                   // метод из БАЗОВОГО класса, чтобы срабатывал этот метод используют virtual и override.

            base.Start(1);                  // Указывает что берем только из базового(родительского) класса.
            this.Start(1);                  // Указывает что берем из этого (дочернего) и родительского класса.

            Classes a = new Classes1();             // В родительский класс можно присваивать класс унаследованный, с потерей данных из
                                                    // наследника.

            Classes1 b = (Classes1)new Classes();  // В дочерний класс нельзя присвоить родительский без явного преобразования типов.


        }
        protected virtual void Virtuals() { }   // Виртуальный метод можно переопределить в дочернем классе. Не может быть private.
    }
    class Classes2 : Classes1
    {
        protected override void Virtuals()      // Переопределение метода из базового класса. При вызове из объекта класса будет 
        {                                       // срабатывать этот метод.( для virtual и abstract)
            base.Virtuals();
        }
    }
    //Classes[1].static,partial,sealed                                                                     static,partial,sealed,Classes[1].
    //Classes[2].Abstracts,Interfaces,Structs,Generics                                     Abstracts,Interfaces,Structs,Generics,Classes[2].

    abstract class Abstracts            // Для абстрактного класса нельзя создать объект (экземпляр). От них можно только наследоваться.
    {                                   // Абстрактный класс - это описание шаблона, который  обязательно должен реализовать наследник.
        protected abstract int A { get; }      // Абстрактное поле.
        protected abstract void Absd(); // Абстрактный класс не может иметь тело с командами. Не может быть private. Наследные классы
                                        // должны обязательно реализовать абстрактные методы.
    }
    class Abstracts1 : Abstracts
    {
        // Обязательно переопределить абстрактный метод и поле!
        protected override int A => throw new System.NotImplementedException();
        protected override void Absd()                  // Переопределение метода из базового класса. При вызове из объекта класса будет 
        {                                               // срабатывать этот метод.( для virtual и abstract)

            throw new System.NotImplementedException(); // Вызвать ошибку, что не реализован обязательный метод) надо удалить)
        }
    }
}

interface IInterfaces       // Интерфейсы состоят только из методов, не могут иметь свойства, поддерживают множественное наследование.
{                           // (это как абстрактный класс только с абстрактными методами)

    // Не public методы нельзя реализовать в классах, что то там про 10 версию C# пишут, хуй пойми.
    public void Method(IInterfaces1 b); // Обязательно реализовать в классе!
                                        // В интерфейсах методы не могут быть private, по умолчанию public.
    protected void Method1() { }    // Реализация интерфейса по умолчанию.(сомнительная фича)
}
interface IInterfaces1
{
    public void Method1();
}
class Interfaces : IInterfaces, IInterfaces1     // Реализация интерфейсов в классе, интерфейсы поддерживают множественное наследование.
{
    // Не public методы нельзя реализовать в классах, что то там про 10 версию C# пишут, хуй пойми.
    public void Method(IInterfaces1 b)            // Для реализации интерфейсов в методах не надо указывать override.
    {
        IInterfaces a = new Interfaces();    // Переменной типа интерфейса можно присвоить классы которые этот интерфейс реализуют.
        b.Method1();                        // сработает IInterfaces1.Method1(), так как тип b - IInterfaces1.
    }
    void IInterfaces.Method1() { }  // Явная реализация интерфейса (на случай если в интерфейсах одинаковые методы).

    void IInterfaces1.Method1() { }
}
interface IInterfaces2 : IInterfaces, IInterfaces1 { } // Наследование интерфейсов.
interface IInterfaces3 { }

struct Structs : IInterfaces3   // Структура - значимый тип(Value types). Не может наследовать ничего, кроме интерфейсов. От структуры 
{                               // нельзя наследоваться.
}                               // (по сути это класс, который храниться в стеке, а не в куче) (int, bool, float... - структуры).

class Generics_<T2>             // Обобщения (Generics).
{
    void M1<T, Ta1>(T a, T b)   // Обобщения (Generics) принято именовать начиная T. Обобщения это переменные типов, когда передается
    {                           // ссылка или значение, ее тип подставляется вместо T и сразу компилируется метод с нужным классом.
                                // Компилируется этот код для каждого типа только 1 раз, в дальнейшем при повторном обращении программа
                                // обращается к уже скомпилированному методу.

        M1<int, bool>(2, 3);    // Явно указываем какие использовать типы в методе.
    }

    private T2[] _array = Array.Empty<T2>();
    public T2 this[int index]                   // ??? Индексатор ???
    {
        get { return _array[index]; }
        set { _array[index] = value; }
    }
}





















//Classes[2].Abstracts,Interfaces,Structs,Generics                                         Abstracts,Interfaces,Structs,Generics,Classes[2].
//Recursions.                                                                                                                    Recursions.

public class Recursions
{
    public int a;
    public Recursions Me;       // Можно определить свойство самого себя, в дальнейшем его обходить рекурсивно c проверкой null.
    void Recursion()            // Рекурсия это метод, вызывающий сам себя.
    {
        // Рекурсии ограничены размером стека (Stack). Каждый новый вызов занимает место в стеке.
        Recursion();
    }
}
public class RecursionsBypass
{
    // Обход рекурсивного класса.
    void Main()
    {
        Recursions r = new Recursions();
        r.a = 2;
        r.Me = new Recursions();
        r.Me.a = 4;
        r.Me.Me = new Recursions();
        r.Me.Me.a = 6;
        Bypass(r);
        BypassByLoops(r);
        Console.ReadLine();
    }
    void Bypass(Recursions re)              //Обход рекурсией
    {
        Console.WriteLine(re.a + " ");      // Выведет "2 4 6"  
        if (re.Me == null) return;
        Bypass(re.Me);
    }
    void BypassByLoops(Recursions re)       //Обход циклом.
    {
        for (Recursions i = re; i != null; i = i.Me)
        {
            Console.WriteLine(i.a + " ");  // Выведет "2 4 6"  
        }
    }
}
















































//Recursions.                                                                                                                    Recursions.
//GettersAndSetters.                                                                                                      GettersAndSetters.

//using UnityEngine;

public class GettersAndSetters
{
    // Геттеры и Сеттеры. (Аксессоры)

    // Сокращенный вариант написания, при этом переменная для записи создается сама.
    public float GetSet0 { get; set; } = 1f;

    // Геттеры сеттеры, в сокращенном варианте модификаторами доступа можно ограничить чтение или запись.
    public float GetSet1 { get; private set; } = 1f;

    // в не сокращенном виде если вносить какую то логику, то запускается бесконечный цикл и выходит ошибка переполнение стека
    // (StackOverflowException: The requested operation caused a stack overflow.)
    // поэтому создаем отдельную приватную переменную в которую все записываем,и используем ее только через метод геттера сеттера
    private float _GetSet2;
    public float GetSet2
    {
        get
        {
            return _GetSet2;
        }
        set
        {
            _GetSet2 = value;      //value  -  входные значения
        }
    }

    private float _GetSet3;
    public float GetSet3
    {
        get => _GetSet3;              //сокращенная запись
        set => _GetSet3 = value;      //value  -  входные значения
    }

    // отображение для геттеров сеттеров в inspector unity (при условии что нет логики)
    [field: SerializeField] private float N { get; set; }

    private GameObject _prefab;
    public GameObject Prefab { get => _prefab; set => _prefab = value; }
    // ////////////////////////////////////////////////////////////////////////////////////////////
    // Ввести "prop" => tab => tab  : Visual Studio напишет геттер сеттер по умолчанию.
    public int MyProperty1 { get; set; }

    // Ввести "propa" => tab => tab  : Visual Studio напишет геттер сеттер по умолчанию.
    public int MyProperty2 { get; private set; }

    // Ввести "propfull" => tab => tab  : Visual Studio напишет геттер сеттер по умолчанию.
    private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }

}






























//GettersAndSetters.                                                                                                      GettersAndSetters.
//Variables.                                                                                                                      Variables.
//using UnityEngine;
public class Variables
{
    private Variables()
    {
        // Создание переменных.

        // Stack (стек) работает по LIFO, хранит значимые типы (Value types) struct, enum (неявно унаследованы от System.ValueType).
        // Мало оперативки но быстро.
        // При копировании копируется значение.
        // Уничтожаются когда покидают свой контекст(область видимости) где были определены.

        // Heap (управляемая куча) хранит ссылочные типы(Reference types) class (производные от любого типа(кроме System.ValueType),
        // если этот тип не запечатан). Много оперативки но медленно.
        // При копировании копируется ссылка на данные в куче. Переменная со ссылкой храниться в стеке.
        // При выходе из контекста уничтожается переменная со ссылкой, но класс остается в куче(в памяти), пока сборщик мусора его
        // не удалит.

        int h1 = 10;
        int h2 = 0b101;     // бинарная форма b = 5
        int h3 = 0xFF;      // шестнадцатеричная форма c = 255
        int? b0 = null;     //int? - если присваивается null, то в переменную записывается значение по умолчанию (для int = 0)
                            // Null-совместимые значимые типы (Nullable)
        double c0 = 1.0;    // Используется по умолчанию для переменных с плавающей точкой.
        double c1 = 1.0d;   // Суффикс D не обязателен.
        float w = 1.0f;     // Суффикс f подставляется к цифре, что бы указать тип float, а не double.
        decimal de = 1.0m;  // Число с фиксированной точкой. Суффикс m подставляется, что бы указать тип decimal, а не double.
                            // Арифметическое переполнение всегда вызывает ошибку.
        bool h = true;
        char e6 = 'q';       // По умолчанию = '\0'
        string f = "Fuck";
        var g = 5;          // Неявно типизированная локальная переменная, принимает класс выражения после =. типа var не существует!
                            // В дальнейшем поменять тип переменной нельзя (это может dynamic).
        dynamic dy = 5;     // Не типизированная переменная. !!! Нахуй ее, никогда не используй.!!!

        Vector3 V3 = new Vector3(1f, 1f, 1f);   // Vector3 - тип переменной с 3мя координатами.
        Vector3 v3 = new(1f, 1f, 1f);           // Vector3 - тип переменной с 3мя координатами, упрощенное определение.
        Vector2 V2 = new Vector2(1f, 1f);       // Vector2 - тип переменной с 2мя координатами.
        Vector2 v2 = new(1f, 1f);               // Vector2 - тип переменной с 2мя координатами, упрощенное определение.

        int b9 = 4;
        ref int c9 = ref b9;        //присваивается не значение, а ссылка на переменную b9

        // Ссылка на кучу в стеке - это значение, ссылка на стек в стеке - ссылка.
        int[] a = new int[] { 1 };  //a присваивается ссылка на массив в куче(Heap).
        int[] b = a;                //в b копируется ссылка на массив в куче(Heap).
        ref int[] c = ref b;        //в c присваивается ссылка на переменную b в стеке(Stack), НЕ НА МАССИВ В КУЧЕ!
        ref int[] d = ref c;        //в d присваивается ссылка на переменную b в стеке(Stack)
        d = null;                   //в b записывается null
        int[] e = { 1, 2, 3 };      //e присваивается ссылка на другой массив в куче(Heap).    
        d = ref e;                  //в d присваивается ссылка на переменную e в стеке(Stack), остальные переменные не меняются.
        //#################################################################################################################################
        byte _byt = 1;      //new System.Byte();    Размер = 1  MIN = 0                           |Max = 255
        sbyte sby = 1;      //new System.SByte();   Размер = 1  MIN = -128                        |Max = 127

        ushort us = 1;      //new System.UInt16();  Размер = 2  MIN = 0                           |Max = 65535
        short sho = 1;      //new System.Int16();   Размер = 2  MIN = -32 768                     |Max = 32767

        uint _uin = 1u;     //new System.UInt32();  Размер = 4  MIN = 0                           |Max = 4294967295
        int __int = 1;      //new System.Int32();   Размер = 4  MIN = -2 147 483 648              |Max = 2 147 483 647

        ulong ulo = 1ul;    //new System.UInt64();  Размер = 8  MIN = 0                           |Max = 18 446 744 073 709 551 615
        long _lon = 1L;     //new System.Int64();   Размер = 8  MIN = –9 223 372 036 854 775 808  |Max = 9 223 372 036 854 775 807

        float flo = 1.0f;   //new System.Single();  Размер = 4  MIN = -3.402823E+38               |Max = 3.402823E+38   

        double db = 1.0d;   //new System.Double();  Размер = 8  MIN = -1.79769313486232E+308      |Max = 1.79769313486232E+308
                            //                                                  (MIN ±5.0*10^-324 Max ±1.7*10^308)
        double d1 = 1.0;    //Используется по умолчанию для переменных с плавающей точкой.Суффикс не обязателен.

        decimal m = 1.0m;   //new System.Decimal(); Размер = 16 MIN/MAX = ±79 228 162 514 264 337 593 543 950 335   
                            //(Если употребляется без десятичной запятой, имеет значение от ±1.0*10^-28 до ±7.9228*10^28)

        bool _boo = false;  //new System.Boolean(); Размер = 1   MIN = False (По умолчанию)       |MAX = True

        string sh = "Стр";  //new System.String();  Размер = массив символов.
        char _ch1 = 'A';    //new System.Char();    Размер = 2      (символ)
        char _ch2 = '\x5A';     //='Z'
        char _ch3 = '\u0420';   //='P'

        object ob = 23;     //new System.Object();  Размер = 4/8 Хранит значение любого типа, базовый для других типов и классов.

        dynamic y = 5;      //в System нет. Может менять тип данных прям во время выполнения программы. (Желательно не использовать)
        y = "Name";
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        string s = null;   //null - По умолчанию в ссылочных типах(Reference types) означает пустая ссылка.
                           //(объявили но не инициализировали).Нельзя присвоить значимым типам (Value types).
    }
}//Variables.                                                                                                                     Variables.
//Operators.                                                                                                                      Operators.

//using UnityEngine;    // MonoBehaviour используется для команды print().
//using System; 

public class Operators : MonoBehaviour
{
    Operators(int a, int g, bool d = true, string str = "")
    {
        // Арифметические операторы.
        a = 10 + 2;             //=12 Сложение.
        g = 10 - 2;             //=8  Вычитание.
        a = 10 * 2;             //=20 Умножение.
        a = 19 / 5;             //=3  Деление. (результат для целочисленных типов(int) откидывает дробную часть. 
        a = 10 % 2;             //=0  Остаток от деления.
        str = "a" + "b" + a;    //=ab0  Конкатенация.
        str = $"ab{a}";         //=ab0  Интерполяция.

        byte z = 0;
        z = (byte)(z - 1);  //=255;Арифметическое переполнение - если в результате арифметических действий переменной превышено максимальное
                            // или минимальное значение - остаток посчитается с противоположной стороны.
                            // Где то есть настройка, где можно включить проверку переполнения (в unity хз), тогда будет выходить ошибка.
                            // но это тормозит программу.
        z = checked((byte)(z - 1)); // Проверка переполнения, выдаст ошибку.
        checked { }         // Проверка переполнения для нескольких операторов.
        unchecked { }       // Отключение проверки переполнения.
        decimal v1 = 1;     // У типа decimal арифметическое переполнение всегда вызывает ошибку.
        float v2 = 1;       // У типов float и double не бывает арифметического переполнения, вместо этого есть проверка значения 
        double v3 = 1;      // IsNaN - значение не определено(нуль делить на нуль),PositiveInfinity NegativeInfinity. 

        // Операторы присваивания.
        a = 5;
        a += 5;         //a = a + 5
        a -= 5;         //a = a - 5
        a *= 5;         //a = a * 5
        a /= 5;         //a = a / 5
        a++;            //a = a + 1 Оператор инкремента, постфиксная форма (наиМеньший приоритет). 
        a--;            //a = a - 1 Оператор декремента, постфиксная форма (наиМеньший приоритет). 
        print(a++);     // Сначала print(a), потом a++ (выведет 5). (return a; a+=1;)
        ++a;            //a = a + 1 Оператор инкремента, префиксная форма (наиБольший приоритет). 
        --a;            //a = a - 1 Оператор декремента, префиксная форма (наиБольший приоритет). 
        print(++a);     // Сначала ++a, потом print(a) (выведет 7). (a+=1; return a;)

        // Операторы сравнения.
        if (a == g) { } // Равенство.
        if (a > g) { }  // Больше.
        if (a < g) { }  // Меньше.
        if (a >= g) { } // Больше или равно.
        if (a <= g) { } // Меньше или равно.
        if (a != g) { } // Не равно.

        // Логические операторы.
        // & и | - одинарные тоже можно использовать, но 2е более эффективны, в двойных вычисляются выражения по очереди,
        // и если по первому выражению ясен результат дальше вычисление прерывается для быстродействия.
        if (d && d) { } // Сокращённое И.
        if (d || d) { } // Сокращённое ИЛИ.
        if (!d) { }     // НЕ.

        //Преобразование или приведение примитивных типов. (конвертация)
        int m = 1;
        float n = m;    // Неявное преобразование.(implicit converting). Разрешено неявно преобразовывать в те типы данных, которые 
                        // охватывают диапазон значений преобразуемого типа.

        m = (int)n;     // Явное преобразование.(explicit converting). Если значение больше чем может хранить преобразующий тип,
                        // то данные потеряются ( после максимального значения отсчет начнётся сначала).
                        //using System;
        bool p = Convert.ToBoolean(n);          // (bool)n не работает, нужно использовать Convert.ToBoolean, 0=false, !0=true.
        float r = float.Parse("12");            // Преобразует строку в тип float (либо можно в другие).
                                                // Если не сможет преобразовать - выдаст ошибку.
        bool s = float.TryParse("12", out float q);  // Преобразует строку в тип float (либо можно в другие).
                                                     // Если не сможет преобразовать - вернет false, а в q запишет значение по умолчанию.
        object ob1 = 24;
        Operators op2 = (Operators)ob1;     // Преобразует ob1 к типу Operators, если сможет, иначе выдаст ошибку.
        op2 = ob1 as Operators;             // Преобразует ob1 к типу Operators, если сможет, иначе null.
        if (op2 is Operators op3) { }       // Проверяет у op1 можно ли неявно преобразовать в Operators, если да то op3 = op2,
                                            // иначе блок if не выполняется. (Нахуя??????) (так же сразу проверяет на null)

        // Упаковка и распаковка. (boxing and unboxing)
        int a2 = 1;
        object b2 = a2;   // Упаковываем a, скопировав значение в кучу(Heap).
        int c2 = (int)b2; // Распаковываем, скопировав из кучи(Heap).
    }
}






//Operators.                                                                                                                      Operators.
//ConditionalOperators.                                                                                                ConditionalOperators.

public class ConditionalOperators
{
    ConditionalOperators(int a = 0, int g = 1, bool d = true)
    {
        // Условные операторы.
        // if ([условие])
        if (a == g)     // НЕ СТАВИТЬ ; !!!
        {

        }
        else if (a > g) // НЕ СТАВИТЬ ; !!!
        {

        }
        else            // НЕ СТАВИТЬ ; !!!
        {

        }

        // if в одну строку можно писать без логических скобок. Не забудь символ конца строки.
        if (a > 0) g = 1;

        // Тернарный оператор.
        // [условие] ? [если_истина]:[если_ложь]
        a = d ? 1 : 2;

        string s = null;        //null - По умолчанию в ссылочных типах(Reference types) означает пустая ссылка.
                                //(объявили но не инициализировали).Нельзя присвоить значимым типам (Value types).

        s = s ?? string.Empty;  //=""; ?? - Это оператор null объединения. Проверяет s, если null то присваивает ""
        s ??= "abc";            //=""; s==null ? "" : s ; string.Empty = ""
        GameObject go = null;   //!!! для GameObject null объединения работают через раз, и unity не советует их использовать. Проверил на 
                                // практике в одном скрипте работает, в другом нет.
        if (go) go = new();     // GameObject проверять на null можно так, без дополнительных команд.
        s = null;
        int? j = s?.Length;     //?. - Оператор условного null. если s==null то дальше вычисления прекратит и вернет null вместо ошибки. 
                                //int? - если присваивается null, то в переменную записывается значение по умолчанию (для int = 0)

        bool t = j.HasValue;    //=false; Если значение null - возвращает false.
        int i = j.Value;        //=ошибка; Надо сначала проверить на null j, если j.HasValue==false, то в j.Value нет значения.
        int k = j.GetValueOrDefault(5); //=5; если j==null, вернет значение по умолчанию для данного типа,
                                        //либо указанное значение в параметре (5).

        //switch..case
        switch (a)
        {
            case 1:             // if (a == 1) 
                goto case 4;    // Выполняет операторы из выбранного case без проверки условий.
            case 3:             // else if (a == 3) Без break выполняется следующий case, без проверки значения.
            case 4:             // else if (a == 4) 
                break;          // Выход из switch. Без break будет выполняться следующий case, без проверки значения.
            case 5 when true:   // when                      ???
            default:            // else
                break;          // Выход из switch. Без break будет выполняться следующий case, без проверки значения.
        }
    }
}






























//ConditionalOperators.                                                                                                ConditionalOperators.
//Loops.                                                                                                                              Loops.

public class Loops
{
    Loops(int a, int b)
    {
        // Цикл while.
        while (b < 5)               // while ([условие_выполнения_следующей_итерации]).
        {
            break;                  // Выход из цикла.
            continue;               // Следующая итерация.
            b++;
        }

        // Цикл do..while.
        do                          // Выполняется хотя бы 1 раз, условие проверяется после.
        {
            break;                  // Выход из цикла.
            continue;               // Следующая итерация.
            b++;
        }
        while (b < 7);              // while ([условие_выполнения_следующей_итерации]).

        // Цикл for.
        // for ([действия_до_выполнения_цикла]; [условие_выполнения_следующей_итерации]; [действия_после_выполнения_каждой_итерации]).
        for (int x = 0; x < 5; x++)
        {
            // переменная х существует только внутри цикла for! После выхода из цикла она уничтожается.
            break;                  // Выход из цикла.
            continue;               // Следующая итерация.
        }

        // Цикл foreach. Обход коллекций значений (массивов).
        foreach (var i in "Tom")    // foreach ([тип_данных] [переменная] in [коллекция]).
        {
            break;                  // Выход из цикла.
            continue;               // Следующая итерация.
        }

        // LINQ  Для обхода коллекций и чего то еще? Описание в массивах (Array)
    }
}















































//Loops.                                                                                                                              Loops.
//Arrays.                                                                                                                            Arrays.
//using System;
//using System.Linq;
//using System.Collections.Generic;
public class Arrays
{
    Arrays()
    {
        float[] a = new float[3];           // Создаём пустой массив, инициализируем и присваиваем ему массив с 3 элементами.
                                            // Значение элементов заполняются значениями по умолчанию в зависимости от типа (у int это 0).
                                            // new float[3] - размер указывать обязательно, если не присваиваем значения в фигурных скобках.
        float[,] aa = new float[3, 4]       // Двумерный прямоугольный массив.
        {
            { 0f, 1f, 2f, 3f },
            { 6f, 4f, 7f, 5f },
            { 4f, 6f, 3f, 2f }
        };
        float[][] ab = new float[3][];      // Зубчатый массив (массив массивов), является одномерным массивом 
        ab[0] = new float[10];              // в котором лежат другие массивы, которые могут быть разной длины.
        ab[1] = new float[2];
        ab[2] = new float[6];

        a = new float[3] { 4f, 3f, 3f };    // Присваиваем новый массив с элементами { 4f, 3f, 3f };
        a = new float[] { 4f, 3f, 3f, 5f }; // Если не указать размер, то создастся массив с количеством элементов в фигурных скобках
                                            // (в данном примере 4).
        a = new[] { 4f, 3f, 3f, 5f };       // Тоже самое, что и выше.
        float[] a1 = { 0f, 3f, 3f, 5f };    // Тоже самое, что и выше, работает только при объявлении переменной.
        a[2] = 3f;                          // Присваиваем 2му элементу значение 3f в одномерном массиве.
        aa[2, 2] = 3f;                      // Присваиваем элементу 2,2 значение 3f в многомерном массиве.
        ab[2][2] = 3f;                      // Присваиваем элементу 2,2 значение 3f в зубчатом массиве.
        a[^2] = 3f;                         // Присваиваем предпоследнему элементу значение 3f.

        Index ind = ^2;                     // Индекс можно сохранить в переменную!
        int i1 = ind.Value;                 // = 2; Значение индекса.
        bool i2 = ind.IsFromEnd;            // = true; Отсчитывать с конца?
        a[ind] = 3f;                        // Присваиваем предпоследнему элементу значение 3f.
        float[] a2 = a[1..3];               // = { 3f, 3f }; Возвращает массив вырезанный из а2 начиная с 1 индекса по 3й
                                            // (a[3] в массив не включается).
        float[] a3 = a[..3];                // = { 0f, 3f, 3f }; Возвращает массив вырезанный из а3 начиная с 0 индекса по 3й
                                            // (a[3] в массив не включается).
        float[] a4 = a[1..];                // = { 3f, 3f, 5f }; Возвращает массив вырезанный из а4 начиная с 1 индекса по последний.

        float[] a5 = a[^3..^1];             // = { 3f, 3f }; Возвращает массив вырезанный из а5 начиная с 3 индекса по 1й с конца
                                            // (a[^1] в массив не включается).
        Range ran = ^3..ind;
        float[] a6 = a[ran];                // = { 3f }; Возвращает массив вырезанный из а6 начиная с 3 индекса по 2й с конца
                                            // (a[^2] в массив не включается).

        a = new[] { 0f, 1f, 2f, 3f };
        int b1 = a.Length;                          // = 3; Возвращает количество элементов массива (только чтение)
                                                    // (в многомерных массивах возвращает количество из всех измерений массива).
        int b2 = aa.GetLength(0);                   // = 3; Возвращает количество элементов массива в определенном измерении
                                                    // (нумерация начинается с нуля).
        Array.Reverse(a);                           // = { 3f, 2f, 1f, 0f }; Переворачивает массив, первые элементы становятся последними.
        Array.Sort(a);                              // = { 0f, 1f, 2f, 3f }; Сортирует (массив а) в порядке возрастания.
        float f08 = Array.Find(a, i => i > 0);      // = 1f; Ищет в массиве первый элемент по условию. (с начала по возрастанию).
        float f09 = Array.FindLast(a, i => i < 3);  // = 2f; Ищет в массиве последний элемент по условию.
        float[] f10 = Array.FindAll(a, i => i < 3); // = { 0f, 1f, 2f }; Возвращает массив с элементами подходящими по условию.
                                                    // (с начала по возрастанию, не сортирует).
        int f11 = Array.FindIndex(a, i => i < 3);   // = 0; Возвращает индекс первого элемента подходящего по условию.
                                                    // (с начала по возрастанию). (-1 возвращает если не нашел)
        int f12 = Array.FindLastIndex(a, i => i < 3);   // = 2; Возвращает индекс последнего элемента подходящего по условию.
                                                        // (-1 возвращает если не нашел)
        int f13 = a.Rank;                           // = 1; Возвращает количество измерений массива.

        //using System.Linq;
        a = Enumerable.Repeat(3f, 4).ToArray();     // = { 3f, 3f, 3f, 3f}; Создает массив размером 4, все элементы массива заполняются
                                                    // значением 3f.
        int[] c = Enumerable.Range(3, 4).ToArray(); // = { 3, 4, 5, 6}; Создает массив int[] размером 4, элементы массива заполняются
                                                    // значениями от 3 прибавляя по 1.
        a = new[] { 0f, 1f, 2f, 3f };
        float f01 = a.Max();                        // = 3f; Возвращает максимальное значение.                
        float f02 = a.Min();                        // = 0f; Возвращает минимальное значение. 
        float f03 = a.Sum();                        // = 6f; Возвращает сумму элементов массива.
        float f04 = a.Where(i => i % 2 != 0).Sum(); // = 4f; Where отбирает элементы по условию.
        float[] f05 = a.Distinct().ToArray();       // = { 0f, 1f, 2f, 3f }; Возвращает массив, в котором убирает повторяющиеся элементы.
        float[] f06 = a.OrderBy(i => i).ToArray();  // = { 0f, 1f, 2f, 3f }; Возвращает массив, в котором сортирует в порядке возрастания.
        float[] f07 = a.OrderByDescending(i => i).ToArray(); // = { 3f, 2f, 1f, 0f }; Возвращает массив, отсортированный в порядке убывания.

        for (int i = 0; i < a.Length; i++)      // Обход элементов массива
        {
            float d = a[i];
        }

        //using System.Collections.Generic;
        List<float> values = new List<float>();     // ??? Какой то продвинутый массив, надо загуглить про него.???
        ArrayList va = new ArrayList();             // ??? Может содержать любой тип данных ??? (сейчас не используют). То же самое, что и
                                                    // List<>, только работает с объектами вместо Generics, поэтому медленнее в сотни раз.
    }
}//Arrays.                                                                                                                           Arrays.
//Linq.                                                                                                                                Linq.
//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;

// Linq (Language-Integrated Query) - это язык запросов к источнику данных для работы с коллекциями IEnumerable или IEnumerable<T>.

// https://metanit.com/sharp/tutorial/15.1.php
// LINQ (Language-Integrated Query) представляет простой и удобный язык запросов к источнику данных. В качестве источника данных может
// выступать объект, реализующий интерфейс IEnumerable (например, стандартные коллекции, массивы), набор данных DataSet, документ XML.
// Но вне зависимости от типа источника LINQ позволяет применить ко всем один и тот же подход для выборки данных.

public class Linqs : MonoBehaviour
{
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

        //Выражение запроса — запрос, выраженный с помощью синтаксиса запроса.
        IEnumerable<int> list =         // Переменная запроса — это любая переменная, сохраняющая запрос вместо результатов запроса.
                                        // Выражение запроса должно начинаться предложением from.
            from x in array             // x - переменная диапазона, принимает тип int, потому что IEnumerable<int>
                                        // array - источник данных.

                // Внутри выражения запроса может содержаться одно или несколько необязательных предложений:
                // where, orderby, join, let и даже дополнительных предложений from, ключевое слово into.
            where x > 6                 // Условие.
            orderby x descending        // Упорядочить по убыванию.
            select x;                   // Выражение запроса должно заканчиваться предложением select или group.

        IEnumerable<int> list2 = array.Where(x => x > 6).OrderByDescending(x => x);
        int[] array1 = list.ToArray();  // Запрос выполнился только сейчас!
        print(array1); // array1 = { 7, 8 };

        int[,] arraySquire = { { 1, 2, 3 }, { 4, 5, 6 } };// Это че не IEnumerable? Linq не работает с такими?
        int maxElement =
            (from int[] y in arraySquire
             from z in y
             where z > 3
             select z).Max();
    }
}















































//Linq.                                                                                                                                Linq.
//Enums.                                                                                                                              Enums.

//using System;

public class Enums_
{
    public enum EnumKey        // Перечисления. По умолчанию int.
    {
        None,
        a = 33,
        b = 3,
        Понедельник,        // Указание значений не обязательно, нумерация подставляется автоматически начиная с 0.
        Вторник = 8,        // Если указать значение, следующие будут увеличиваться на 1.
        ЕщеКакиеТоДни
    }
    public enum Enum1 : byte    // Можно указать тип значений, но задать можно только целочисленный тип.
    {
        None = 0,
        ask
    }

    public Enums_()
    {
        EnumKey Key = EnumKey.None;
        if (Key == EnumKey.a) { }
        if ((int)Key == 3) { }
        int a = (int)Key;               // Переводим Enum в значение int.
        EnumKey b = (EnumKey)3;         // Приводим значение int в Enum
        EnumKey c = Key + 1;            // Можно проводить арифметические операции(+ или -) со значениями enum.
        Type type = System.Enum.GetUnderlyingType(typeof(EnumKey)); //=int; Получить тип значений EnumKey.
        bool d = System.Enum.IsDefined(typeof(EnumKey), 33);        //=false; проверяет, есть ли в EnumKey значение.
        System.Array e = System.Enum.GetValues(typeof(EnumKey));    // Получить список всех значений.
        EnumKey f = (EnumKey)System.Enum.Parse(typeof(EnumKey), "вторник", true);   //=EnumKey.Вторник; По строке вытащить enum.
                                                                                    // ignoreCase - игнорировать регистр или нет.
        switch (Key)
        {
            case EnumKey.None:
                break;
            case EnumKey.a:
                break;
            case EnumKey.b:
                break;
            case EnumKey.Понедельник:
                break;
            case EnumKey.Вторник:
                break;
            case EnumKey.ЕщеКакиеТоДни:
                break;
            default:
                break;
        }
    }
}




































//Enums.                                                                                                                              Enums.
//Attributes.                                                                                                                    Attributes.

//using System;
//using UnityEditor;
//using UnityEngine;
//using UnityEngine.Serialization;

// Атрибуты размещаются перед объектами, на которые они нацелены.

//using System;
[Serializable]                              // Сериализует сразу весь класс или структуру (выводит все из него в inspector unity).

//using UnityEngine;
[RequireComponent(typeof(Rigidbody))]       // Проверяет есть ли компонент на объекте, если нету то добавляет его.
[DisallowMultipleComponent]                 // Запрещает добавлять больше одного компонента данного класса на объект.
[SelectionBase]                             // выбирает объект целиком, при нажатии на любую его часть или дочерний объект.
[HelpURL("https://")]                       // справка по классу, открывается при нажатии в inspector unity на вопросик.

// объект класса можно создать из меню Create в папке assets. (Для создания ScriptableObject), order - позиция в списке?
[CreateAssetMenu(fileName = "C_script", menuName = "C_Script/New", order = 10000)]

//[DeScriptExecutionOrder(1)]               // ???Якобы назначение очереди загрузки скриптов, не работает что то.

public class Attributes : ScriptableObject  //ScriptableObject нужен для CreateAssetMenu
{
    //using System;
    [NonSerialized] public float e;         // (using System;) убирает отображение в inspector unity.???? (убирает какую то сериализацию)

    //using UnityEditor;
    [MenuItem("Tools/Initialization Project")] private static int M2() => 5;   //?? Может вызвать статический метод?

    //using UnityEngine;
    // [SerializeField] - Атрибут указывает что переменная будет отображаться в inspector unity, несмотря на то что она не публичная.
    [SerializeField] private Light lightComponent;
    [field: SerializeField] private float N { get; set; }    // Отображение для геттеров сеттеров (при условии что нет логики).
    [HideInInspector] public float f;       // = !SerializeField; Убирает отображение в inspector unity.
    [Space(3f)]                             // Добавляет отступ в inspector unity.(можно числом указать ширину отступа)
    [Header("Заголовок")]                   // Добавляет строчку текста в inspector unity.
    [Tooltip("Подсказка")] float re;        // Подсказка в inspector unity отображается при наведении мыши на поле.
    [Range(-100f, 100f)] public float we;   // Ограничение значений переменной, в inspector unity появляется ползунок.
    [Min(1f)] public float wd;              // Устанавливает минимальное значение.
    [ContextMenu(nameof(M1))] private int M1() => 5;    // Добавляет метод в режиме editor в контекстное меню свойства.
    [Multiline(5)] private string dje;      // Поле с фиксированным количеством строк inspector unity, без scroll. Ширина в пол инспектора.

    // Строка отображается полем с количеством строк от 1 до 3 в inspector unity, есть scroll. ширина поля во весь инспектор.
    [TextArea(1, 3)] private string djj;

    // Переменная изменяется после того как закончили ввод в поле inspector unity, без атрибута изменяется при вводе каждого символа.
    [Delayed] private string dd;

    // Указывает на то что код работает в редакторе, даже если не запущена отладка.(только методы Awake(),Update(),OnGUI(),OnRenderObject())
    [ExecuteInEditMode]

    // Выполняет весь код в редакторе и в режиме игры. Application.isPlaying - возвращает true если запущен игровой режим.
    [ExecuteAlways]

    private enum Enum                       // Перечисления???
    {
        // Название которое будет в выпадающем списке в inspector unity.
        [InspectorName("Name")]
        Name1 = 1, Name2 = 2
    }

    //using UnityEngine.Serialization;
    [FormerlySerializedAs("Name")] private int w;    // Сохранить старое название когда переименовываешь переменную в prefab????
}























//Attributes.                                                                                                                    Attributes.
//OrderOfMethods.                                                                                                            OrderOfMethods.

//using UnityEngine;

public class OrderOfMethods : MonoBehaviour
{
    // Очередность выполнения методов MonoBehaviour.

    void Awake() { }        // "Эта функция всегда вызывается до начала любых функций, а также сразу после инициализации prefab."
                            // Но что то нихуя, она не выполнилась до старта в другом скрипте.
    void Start() { }        // Выполняется 1 раз, перед самым первым вызовом метода Update(). FixedUpdate() может выполниться до старт!
                            // (Start is called before the first frame update).
    void Update() { }       // Метод Update вызывается 1 раз в каждом кадре.
                            // (Update is called once per frame).
    void FixedUpdate() { }  // Эта функция вызывается с частотой фиксированных кадров (fixed framerate).
                            // Используйте FixedUpdate вместо Update когда работаете с Rigidbody.
    void LateUpdate() { }   // Вызывается 1 раз в каждом кадре после выполнения во всех скриптах Update().

    // Обработка триггеров.

    void OnTriggerEnter2D(Collider2D other) { } // При входе в 2D триггер.
    void OnTriggerEnter(Collider other) { }     // При входе в триггер.

    void OnTriggerStay2D(Collider2D other) { }  // При нахождении в 2D триггере.
    void OnTriggerStay(Collider other) { }      // При нахождении в триггере.

    void OnTriggerExit2D(Collider2D other) { }  // При выходе из 2D триггера.
    void OnTriggerExit(Collider other) { }      // При выходе из триггера.

    private void OnEnable() { }                 // При включении объекта.
    private void OnDisable() { }                // При отключении объекта.
    private void OnDestroy() { }                // При уничтожении объекта.

    void OnMouseDown() { }                      // Вызывается при щелчке мышкой по объекту.

    private void OnApplicationQuit() { }        // При выходе из игры.
}




















































//OrderOfMethods.                                                                                                            OrderOfMethods.
//InputSystem.                                                                                                                  InputSystem.

//using UnityEngine;

public class OldInputSystem
{
    OldInputSystem()
    {
        // Управление Edit ⇒ Project Settings ⇒ Input Manager
        float b1 = Input.GetAxis("Horizontal");  // Возвращает значение оси.
        bool d1 = Input.GetKey(KeyCode.K);       // Проверяет нажата ли клавиша. True - все время удержания клавиши.
        bool d2 = Input.GetKeyDown(KeyCode.K);   // Проверяет нажата ли клавиша. True - только в момент нажатия клавиши.
        bool d3 = Input.GetMouseButtonDown(0);   // Проверяет нажата ли ЛЕВАЯ кнопка мыши.
        bool d4 = Input.GetMouseButtonDown(1);   // Проверяет нажата ли ПРАВАЯ кнопка мыши.
        bool d5 = Input.GetMouseButtonDown(2);   // Проверяет нажата ли СРЕДНЯЯ кнопка мыши.
        float b2 = Input.GetAxis("Mouse X");     // Возвращает каждый кадр перемещение по оси X и сбрасывается.
        float b3 = Input.GetAxis("Mouse Y");     // Возвращает каждый кадр перемещение по оси Y и сбрасывается.

        // Управление на телефоне
        float vx = Input.acceleration.x;        //
        float vy = Input.acceleration.y;        // Input.acceleration возвращает Vector3 положения телефона в пространстве 
        float vz = Input.acceleration.z;        // (поворот телефона).

        foreach (Touch touch in Input.touches)
        {
            // В коллекции Input.touches хранятся все действующие на данный момент переменные Touch,
            // Touch создается в момент прикосновения к экрану.    
        }
    }
}



/*
//using UnityEngine;
//using UnityEngine.InputSystem;       // библиотека новой системы ввода. Нужна только если используете в inspector unity.

public class NewInputSystem
{
    // Установка:
    // Windows ⇒ Package Manager ⇒ Packages: Unity Registry ⇒ Input System ⇒ Install

    // Новая система ввода по умолчанию отключена, включается тут:
    // Edit ⇒ Project Settings ⇒ Player ⇒ Other Settings ⇒
    // (Configuration) Active Input Handling* ⇒ Input System Package (New) (Both - выбрать обе системы)

    // В окне Project ⇒ (ПКМ) ⇒ Create ⇒ Input Actions

    // .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. ..
    //создаем переменную класса.(InputController - это скомпилированный Input Actions,
    //после всех настроек создается класс с именем как вы назвали.)
    private InputController _inputController;
    private void Awake()
    {
        _inputController = new();         // создаем экземпляр класса, обязательно в Awake(), что бы до OnEnable();
    }
    private void OnEnable()             //Активируем систему при включении объекта.          
    {
        _inputController.Enable();
    }
    private void OnDisable()            // Деактивируем при отключении объекта.
    {
        _inputController.Disable();
    }
    // .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. .. ..
    NewInputSystem()
    {
        // обработка нажатия (Player - Action Maps; Run - Actions), добавляем в событие метод, который будет выполняться при вводе
        _inputController.Player.Run.performed += context => MoveObject();

        // обработка отпускания кнопки.
        _inputController.Player.Run.canceled += context => MoveObject();

        // получение переменной, если возвращаемый тип выбран в Input Actions.
        Vector2 _movePlayer = _inputController.Player.Move.ReadValue<Vector2>();
    }
}
*/











//InputSystem.                                                                                                                  InputSystem.
//Vectors.                                                                                                                          Vectors.

//using UnityEngine;

public class Vectors
{
    Vectors()
    {
        float x1 = 1f, x2 = 1f, y1 = 1f, y2 = 1f;

        Vector2 v1 = new Vector2(x1, y1);
        Vector2 v2 = new(x2, y2);
        Vector2 va = Vector2.right;             // = (1,0);
        Vector2 vb = Vector2.left;              // = (-1,0);
        Vector2 vc = Vector2.up;                // = (0,1);
        Vector2 vd = Vector2.down;              // = (0,-1);
        Vector2 ve = Vector2.negativeInfinity;  // = (-Infinity,-Infinity); (float.NegativeInfinity,float.NegativeInfinity);
        Vector2 vf = Vector2.positiveInfinity;  // = (Infinity,Infinity); (float.PositiveInfinity,float.PositiveInfinity);
        Vector2 vg = Vector2.one;               // = (1,1); 
        Vector2 vh = Vector2.zero;              // = (0,0); 

        float a = v1.magnitude;         // = Mathf.Sqrt(x1^2 + y1^2); - Длина вектора. (Только чтение).
        float b = v1.sqrMagnitude;      // = x1^2 + y1^2; - Длина вектора в квадрате. (Только чтение).
        Vector2 vi = v1.normalized;     // = (x1/v1.magnitude, y1/v1.magnitude); - Возвращает вектор с тем же направлением, 
                                        // но длиной 1.(Только чтение).
        v1.Normalize();                 // = (x1/v1.magnitude, y1/v1.magnitude); - Записывает сам в себя вектор с тем же направлением,
                                        // но длиной 1.(если значения слишком маленькие возвращает (0,0)).
        float c = v1[0];                // = x1; (this[]) ([0],[1]); - Обращение по индексу.
        float d = v1.x;                 // = x1;
        float e = v1.y;                 // = y1;

        bool f = v1.Equals(v2);         // = (x1==x2 && y1==y2); - Возвращает true если x и y у векторов одинаковые.
        v1.Set(2f, 3f);                 // = (2,3); - Записывает сам в себя новые значения x и y.
        string g = v1.ToString();       // = "(2.00,3.00)"; - Возвращает строку с координатами вектора в скобках.

        v1.Set(2f, 0f);
        v2.Set(2f, 2f);
        b = 0.5f;
        float h = Vector2.Angle(v1, v2);                 // = 45; SignedAngle(v2, v1) = 45;
        /// Возвращает наименьший угол в градусах между 2 векторами (от 0f до 180f).

        Vector2 vj = Vector2.ClampMagnitude(v1, b);      // = (0.5,0);
        /// Возвращает вектор совпадающий с вектором v1, но с длиной b. Если длина b больше длины вектора v1, то возвращается v1.

        float i = Vector2.Distance(v1, v2);              // = 2;  (v2 - v1).magnitude;
        /// Возвращает расстояние между векторами (координатами точек), всегда >=0.  

        float j = Vector2.Dot(v1, v2);                   // = 4; (x1*x2)+(y1*y2); cos(угол между векторами)*v1.magnitude*v2.magnitude;
        /// Скалярное произведение векторов (=0 векторы перпендикулярны, >0 сонаправлены, <0 противоположно направлены).
        /// (при еденичных векторах возвращает cos(угол между векторами))

        Vector2 vk = Vector2.Lerp(v1, v2, b);            // = (2,1); Линейная интерполяция(Движение к объекту).
        /// Возвращает вектор который лежит на отрезке между векторами в соотношении пропорции b(от 0 до 1). 
        /// если b<=0 то вернет v1, b>=1 вернет v2, 
        /// b=0.5 вернет биссектрису между векторами которая будет лежать на прямой соединяющей векторы v1 и v2.

        Vector2 vl = Vector2.LerpUnclamped(v1, v2, b);   // = (2,1);
        /// Тоже, что и Lerp, только b может быть любой и возвращаемый вектор может уходить за пределы векторов v1 и v2.

        Vector2 vm = Vector2.MoveTowards(v1, v2, b);     // = (2,0.5);
        /// Тоже, что и Lerp, только вместо пропорции b указывается расстояние, используется для перемещения объектов друг к другу.

        Vector2 vn = Vector2.Max(new(1, 4), new(5, 3));  // = (5,4); - Возвращает вектор с наиБольшими значениями x и y.

        Vector2 vo = Vector2.Min(new(1, 4), new(5, 3));  // = (1,3); - Возвращает вектор с наиМеньшими значениями x и y.

        Vector2 vp = Vector2.Perpendicular(v1);          // = (0,2);
        /// Опускает перпендикуляр из начальной точки (0,0) к вектору v1 против часовой стрелки длиной v1.magnitude.

        Vector2 vq = Vector2.Reflect(v1, v2.normalized); // = (0,-2);
        /// Отражает вектор v1 от вектора v2, вектор v2 обязательно должен иметь длину 1 (.normalized) иначе результат будет неверный. 
        /// Длина отраженного (или возвращаемого, или результирующего) равна длине v1.

        Vector2 vr = Vector2.Scale(v1, v2);              // = (4,0); (x1*x2, y1*y2); - Перемножает вектора.

        float k = Vector2.SignedAngle(v1, v2);           // = 45; SignedAngle(v2, v1) = -45;
        /// Возвращает наименьший угол в градусах со знаком между 2 векторами (от -180f до 180f) углы против часовой стрелки положительные.

        Vector2 vs = Vector2.SmoothDamp(v1, v2, ref va, 2f, 1f, Time.deltaTime);
        /// Тоже, что и Lerp, но продвинутый с ограничением скорости, плавное движение к объекту со временем, 
        /// в переменную va записываются промежуточные данные от кадра к кадру. 2f - время движения к объекту, если будет слишком большое 
        /// то объект сначала будет уходить а потом возвращаться. 1f - максимальная скорость движения объекта.
    }
}





//Vectors.                                                                                                                          Vectors.
//RigidBody2Ds.                                                                                                                RigidBody2Ds.

//using UnityEngine;

public class RigidBody2Ds : MonoBehaviour
{
    RigidBody2Ds()
    {
        Rigidbody2D _rigidBodyThis;
        _rigidBodyThis = GetComponent<Rigidbody2D>();               // получить компонент с объекта

        //.bodyType - тип твердого тела.
        _rigidBodyThis.bodyType = RigidbodyType2D.Dynamic;
        /// (полный набор свойств) Движущийся предмет, обладает массой, сопротивлением воздуха, его могут толкать другие предметы

        _rigidBodyThis.bodyType = RigidbodyType2D.Kinematic;
        /// Игнорирует коллайдеры (проходит сквозь стены), отталкивает Dynamic объекты от себя. (неподвижный объект с бесконечной массой)

        _rigidBodyThis.bodyType = RigidbodyType2D.Static;           // Неподвижный объект, взаимодействует только с Dynamic
        /// (если не добавлять Rigidbody2D, но добавить в объект коллайдеры - 
        /// RigidbodyType2D.Static прикрепляется автоматически по умолчанию в фоновом режиме, даже если его не видно в компонентах).
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        _rigidBodyThis.sharedMaterial = new PhysicsMaterial2D();    // ??? Хз че это и зачем. какие то физические шейдеры?
        _rigidBodyThis.simulated = true;                            // Собственно включение/отключение всей физики, коллайдеров.
        /// при отключённом коллайдеры ни с чем не взаимодействуют вообще, будто их и не ставили).
        _rigidBodyThis.useFullKinematicContacts = true;             // (для RigidbodyType2D.Kinematic) Отключенный взаимодействует.
                                                                    // Только с RigidbodyType2D.Dynamic, включенный со всеми типами.
        _rigidBodyThis.useAutoMass = false;                         // Масса зависит от размера коллайдера.
        _rigidBodyThis.mass = 10f;                                  // Масса тела, недоступно если .useAutoMass = true;
        _rigidBodyThis.drag = 1f;                                   // (Linear Drag) Сопротивление внешней среды движению.
        _rigidBodyThis.angularDrag = 1f;                            // (Angular Drag) Сопротивление внешней среды повороту.
        _rigidBodyThis.gravityScale = 0f;                           // Степень воздействия гравитации на объект
        /// (ускорение свободного падения? или множитель ускорения свободного падения?).
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Collision Detection (Обнаружение столкновений)
        _rigidBodyThis.collisionDetectionMode = CollisionDetectionMode2D.Discrete;      // Обнаруживаются только положение в кадре
                                                                                        // ( при большой скорости может пролететь стену).
        _rigidBodyThis.collisionDetectionMode = CollisionDetectionMode2D.Continuous;    // Проверяет всю траекторию движения между кадрами.
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Sleeping Mode (Режим сна) типа отключает у объекта Rigidbody2D что бы не напрягать процессор, пока с объектом что либо
        // не произойдет, (на практике хуй пойми что делает - никаких изменений).
        // (в описании: когда объект не двигается, расчет физики для него игнорируется, пока не начнет движение или не заденут коллайдер).
        _rigidBodyThis.sleepMode = RigidbodySleepMode2D.NeverSleep;     // Режим никогда не спит.(рекомендуется не использовать)
        _rigidBodyThis.sleepMode = RigidbodySleepMode2D.StartAwake;     // объект появляется на сцене не спящим.
        _rigidBodyThis.sleepMode = RigidbodySleepMode2D.StartAsleep;    // объект появляется на сцене спящим.
        _rigidBodyThis.Sleep();                                         // Отправляет Rigidbody2D в сон.
        _rigidBodyThis.IsSleeping();                                    // Возвращает значение, спит объект или нет.
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Interpolate (Сглаживание движения) убирает дрожание при движении.
        _rigidBodyThis.interpolation = RigidbodyInterpolation2D.None;           // Без сглаживания.
        _rigidBodyThis.interpolation = RigidbodyInterpolation2D.Interpolate;    // Движение сглаживается на основе позиций объекта
                                                                                // в предыдущих кадрах.
        _rigidBodyThis.interpolation = RigidbodyInterpolation2D.Extrapolate;    // Движение сглаживается на основе позиций объекта
                                                                                // в следующем кадре.
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Constraints - блокирование движения/поворотов относительно осей координат.
        _rigidBodyThis.constraints = RigidbodyConstraints2D.FreezePositionX;    // Как то так.

        /////////////////////////////////////////////////////////////////////////////////////////

        Vector2 v2 = new(1f, 2f);
        _rigidBodyThis.velocity = v2;           // Задать вектор скорости, мгновенно движется в заданном направлении.
        _rigidBodyThis.MovePosition(v2);        // двигается к позиции.
        _rigidBodyThis.AddForce(v2);            // прикладывает вектор силы.
    }
}























//RigidBody2Ds.                                                                                                                RigidBody2Ds.
//ScriptableObjects.                                                                                                      ScriptableObjects.

//using UnityEditor;
//using UnityEngine;

// Атрибут CreateAssetMenu позволяет создавать экземпляр ScriptableObject из меню Create в Unity.
[CreateAssetMenu(fileName = "Weapon", menuName = "C_Script/NewSO", order = 10000)]
public class ScriptableObjects : ScriptableObject
{
    [field: SerializeField] public string N { get; set; }

    void SO()
    {

        ScriptableObjects a = ScriptableObject.CreateInstance<ScriptableObjects>(); // Программное создание экземпляра ScriptableObject.
        a.N = "a";                                                                  // Изменение параметров
        AssetDatabase.CreateAsset(a, "Assets/" + a.N + ".asset");                   // Сохранение в assets.
        a.N = "b";                                                       // Изменения будут только во время выполнения игры,
                                                                         // после перезахода они исчезнут.

        AssetDatabase.SaveAssets();                                     // НЕ записывает assets на диск.!!!
        AssetDatabase.CreateAsset(a, "Assets/" + a.N + ".asset");       //=Error; Перезаписать нельзя

        AssetDatabase.DeleteAsset("Assets/" + a.name + ".asset");       //a=null; удалили ScriptableObject насовсем.
        a = ScriptableObject.CreateInstance<ScriptableObjects>();       // создали новый.
        a.name = "asset";                                               // Это base.name - имя класса, оно же имя файла.
        AssetDatabase.CreateAsset(a, "Assets/rr.asset");                //a.name = "rr"; записали новый, имя файла перезаписалось.
                                                                        // ScriptableObject, привязанный к файлу нельзя Destroy(a).

        ScriptableObjects b = ScriptableObject.CreateInstance<ScriptableObjects>();
        b.name = "NewName";
        UnityEngine.Object.Destroy(b);                                  // ScriptableObject, не привязанный к файлу можно Destroy.

        ScriptableObject c = AssetDatabase.LoadAssetAtPath<ScriptableObjects>("Assets/" + a.name + ".asset");

    }
}




















































//ScriptableObjects.                                                                                                      ScriptableObjects.
//UnityOthers[0].                                                                                                            UnityOthers[0].

//using System;
//using UnityEngine;
//using UnityEngine.SceneManagement;

public class UnityOthers : MonoBehaviour
{
    // Другие фишки Unity.
    void ForStartMethod()
    {
        print("Hello world");       // Выводит текст в консоль и нижнюю часть экрана.

        // Получение ссылок на компоненты объектов.
        Light lightComponent = GetComponent<Light>();
        lightComponent.type = LightType.Directional;    // Изменение параметров по ссылке.

        // Поиск объекта :
        GameObject target;
        target = GameObject.Find("Cube");               // Поиск по имени на панели Hierarchy.
        target = GameObject.FindWithTag("MyNewTag");    // Поиск по тэгу объекта.
    }
    void MoveObject()
    {
        // transform вызывается без GetComponent, так как есть во всех объектах. Для других компонентов доступ только через GetComponent.
        transform.Translate(0.05f, 0f, 0f);             // ТЕЛЕПОРТИРУЕТ объект в положительном направлении оси X.
        transform.Rotate(0f, 0f, 1f);                   // Поворот (телепортация) объекта вокруг оси Z.
        transform.localScale = new Vector3(2f, 2f, 2f); // Масштабирует объект вдвое во всех направлениях.
        transform.position.Set(2f, 2f, 2f);             // Координаты относительно начала координат.
        transform.localPosition.Set(2f, 2f, 2f);        // Координаты относительно родителя.
        transform.forward.Set(2f, 2f, 2f);              // вектор направления взгляда

        // Свет                                         Window ⇒ Rendering ⇒ Lighting

        // Тэги и слои                                  Edit ⇒ Project Settings ⇒ Tags & Layers

        // Твердое тело (есть и в  Inspector объекта)   Component ⇒ Physics ⇒ Rigidbody
    }
    void Destroy(Collider other)
    {
        // разрушить объект, в данном случае который коснулся триггера
        Destroy(other.gameObject);
    }
    void Raycast()
    {
        // Рейкастинг  —  это выстрел воображаемым лучом с целью определения того, во что он попадет.
        // bool Physics.Raycast(Vector3 origin, Vector3 direction,out Raycast hit, float distance , mask);
        // origin —  это начальная точка луча.
        // direction — направление луча
        // hit - выходной параметр, список объектов которые задел луч.
        // distance - дальность действия
        // mask - какие слои задевает
        bool d = Physics.Raycast(new Vector3(1f, 1f, 1f), new Vector3(1f, 1f, 1f), 100);
    }
    void Prefabs()
    {
        UnityEngine.Object prefab = new UnityEngine.Object();
        // Prefabs, программное размещение
        // Instantiate(GameObject prefab, Vector3 position, Quaternion rotation);
        Instantiate(prefab, transform.position, transform.rotation);
    }
    void Randoms()
    {
        //using UnityEngine
        float minLimit = 0;
        float maxLimit = 1;
        // Рандом рандомный, возвращает float между цифрами.
        float random = Random.Range(minLimit, maxLimit);

        //using System.Random
        System.Random random1 = new System.Random();
        int r = random1.Next(100);              // Возвращает случайные числа от 0 до 100
        r = random1.Next(90, 100);              // Возвращает случайные числа от 90 до 100    
    }
    void Invoke()
    {
        // Запускает функцию с задержкой в секундах
        Invoke("Destroy", 3f);
        InvokeRepeating("Destroy", 3f, 1f);             // Запускает функцию с задержкой в секундах (3f) и бесконечно
                                                        // повторяет через каждые (1f) секунд. Не может вызвать метод с параметрами.
        InvokeRepeating(nameof(Destroy), 3f, 1f);       // Правильно передавать не строку, а через nameof
        bool a = IsInvoking(nameof(Destroy));           // Проверяет отложенный запуск для метода Destroy
    }






    //UnityOthers[0].                                                                                                        UnityOthers[0].
    //UnityOthers[1].                                                                                                        UnityOthers[1].

    void LoadScene()
    {
        // using UnityEngine.SceneManagement; - нужен для работы методов загрузки сцены
        // File ⇒ Build Settings ⇒ (Scenes In Build) Тут надо расположить все сцены которые мы сможем загружать по номеру оттуда или имени.

        SceneManager.LoadScene(1);          // Загрузка сцены по номеру
        SceneManager.LoadScene("Scene2");   // Загрузка сцены по имени

        DontDestroyOnLoad(this);            // Не разрушать объект при загрузке другой сцены (перенести его на следующий уровень).
                                            // this - означает этот объект, либо можно указать любой другой.

        // PlayerPrefs - объект для сохранения и загрузки данных.
        PlayerPrefs.SetInt("score", 10);    // сохранить int с названием score
        PlayerPrefs.GetInt("score");        // загрузить int с названием score

        // ??? Асинхронная загрузка сцены???

        //Edit ⇒ Project Settings ⇒ Player  //Тут настройки проигрывателя Unity, ярлык игр, режимы запуска, соотношение сторон и другое.
    }
    AudioSource audioSource;
    public AudioClip clip1;     // Взять аудиофайл извне, не привязанный к AudioSource,
                                // необязательно если в инспекторе прикреплен аудиоклип, но тогда он один будет.
    void AudioControl()
    {
        audioSource = GetComponent<AudioSource>();  // Получаем компонент источник звука.
        audioSource.clip = clip1;                   // Прикрепляем к источнику звука аудиофайл.
        audioSource.Play();                         // Запустить клип.
        audioSource.Stop();                         // Остановить клип.
        audioSource.PlayDelayed(2);                 // Запустить клип через 2 секунды (с задержкой).
        if (audioSource.isPlaying) { };             // Возвращает True если сейчас воспроизводиться этот клип.
    }
    void Draw()
    {
        Vector3 begin = Vector3.zero, end = Vector3.one;
        Debug.DrawLine(begin, end, Color.green);    // Рисует линию в глобальных координатах от begin до end.
        Debug.DrawRay(begin, end, Color.red);       // Рисует линию от begin в глобальных координатах до end в локальных относительно begin.
    }
    void ForAttack()
    {
        float x1 = 1f, x2 = 1f, y1 = 1f, y2 = 1f;

        Vector2 v1 = new Vector2(x1, y1);
        Vector2 v2 = new(x2, y2);

        //LayerMask хранит int число слоя, можно получить его двумя способами:
        LayerMask EnemyLayers = 6;
        EnemyLayers = LayerMask.GetMask("Player", "Enemy");         // Возвращает итоговый перемешанный слой из всех слоев в списке.
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(v1, x1, EnemyLayers);  // Возвращает всех врагов в радиусе действия,
                                                                                    // v1 центр, x1 радиус, EnemyLayers - слой.
    }
    void Layers()
    {
        LayerMask.NameToLayer("Player");        // Так правильно получать номер слоя по названию.
        LayerMask.GetMask("Player", "Enemy");   // Возвращает итоговый перемешанный (побитово) слой из всех слоев в списке,
                                                // этот код используется для OverlapCircleAll.
    }
    void Stopwatches()
    {
        // замер времени выполнения кода.

        //using System.Diagnostics;
        Stopwatch stopwatch = Stopwatch.StartNew();
        stopwatch.Stop();
        print(stopwatch.Elapsed);
    }
}

//  документация Unity, официальный ресурс. "документ требует технического подхода к Unity. Это скорее справочник, а не средство обучения.."
//      https://docs.unity3d.com/2023.1/Documentation/Manual/index.html     
//
//  онлайн-курсы на сайте Learn
//      https://unity.com/learn
//      
//  Сообщество unity, форум
//      https://answers.unity.com/index.html
//
//  Прочие сайты по разработке игр
//  Их тематика не ограничивается Unity, так что информация будет разносторонней и непредвзятой.
//      https://www.gamedeveloper.com/
//      https://www.gamedev.net/







//UnityOthers[1].                                                                                                            UnityOthers[1].
//UnityUnitTests.                                                                                                            UnityUnitTests.
//using System.Collections;
//using System.Collections.Generic;
//using NUnit.Framework;
//using UnityEngine;
//using UnityEngine.TestTools;

//public class NewTestScript
//{
//    // Window ⇒ General ⇒ Test Runner

//    // В папке Assets создать папку тестов в любом месте:
//    // ПКМ ⇒ Create ⇒ Testing ⇒ Tests Assembly Folder
//    // Test Runner может сам создать папку тестов ( по умолчанию "Assets/Tests/")

//    // A Test behaves as an ordinary method
//    [Test]
//    public void NewTestScriptSimplePasses()
//    {
//        // Use the Assert class to test conditions

//        // Arrange  (объявляем)
//        int a = 1;

//        // Act      (изменяем)
//        a = a + 1;

//        // Assert   (проверяем)
//        Assert.AreEqual(a, 3);
//    }

//    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
//    // `yield return null;` to skip a frame.
//    [UnityTest]
//    public IEnumerator NewTestScriptWithEnumeratorPasses()
//    {
//        // Use the Assert class to test conditions.
//        // Use yield to skip a frame.
//        yield return null;
//    }
//}
















































//UnityUnitTests.                                                                                                            UnityUnitTests.
//Git/GitHub.                                                                                                                    Git/GitHub.

//  https://github.com/

//  git commit                  // Создать commit.
//  git branch Name             // Создать новую ветку с именем Name.
//  git checkout Name           // Перейти в ветку Name.
//      // <hash> (идентификатор) - у каждого commit свой hash, выглядит примерно так "fed2da64c0efc5293610bdd892f82a58e8cbc5d8".
//  git checkout <hash>         // Перейти к commit с идентификатором <hash>. (можно не весь идентификатор писать, а только начало).
//  git merge Name              // Объединяет текущую ветку с веткой Name.
//  git rebase Name             // Переносит текущий commit в ветку Name.
//      // "HEAD" - выбранный в данный момент commit, с которым вы сейчас работаете. Всегда указывает на последний commit в дереве  
//      // "Detaching HEAD" - Когда "HEAD" указывает не на ветку, а на hash (идентификатор).
//
//      // "Относительные ссылки" - перемещают относительно положения "HEAD":
//  git checkout Name^          // Смещает "HEAD" на предпоследний commit в ветке Name.
//  git checkout Name^^         // Смещает "HEAD" на 2 commit с конца в ветке Name.
//  git checkout Name~3         // Смещает "HEAD" на 3 commit с конца в ветке Name.
//  git checkout HEAD^          // Смещает "HEAD" на предпоследний commit относительно текущего положения.
//  git branch -f Name HEAD~3   // Сместить указатель ветки Name относительно "HEAD" на 3 commit относительно текущего положения.
//
//  git reset HEAD^             // (отмена изменений) Сместит текущую ветку на 1 commit, как будто отмененного commit не было.
//          "переписывание истории".отмененный commit останется???
//
//  git revert HEAD             // (отмена изменений) Создает дополнительный commit, полная противоположность текущему. 
//          Мы внесли изменения, отменяющие прошлые изменения) это можно передать другим разработчикам.
//  git revert Name             // Создает дополнительный commit относительно HEAD, полная противоположность последнему commit в ветке Name.
//
//  git cherry-pick <Commit1> <Commit2> <...>   // Копирует commit относительно HEAD, ставит их следующими. commit писать через пробел.
//  git rebase -i HEAD~3        // Открывает окно в котором можно вручную редактировать 3 commit относительно HEAD.
//  
//

























































//Git/GitHub.                                                                                                                    Git/GitHub.
//ProgrammingPrinciples[0].OOP.SOLID.                                                                    OOP.SOLID.ProgrammingPrinciples[0].
// ООП - объектно-ориентированное программирование (Object-oriented programming).Основные принципы.

// Инкапсуляция:
//      Имеет 2 трактовки:
//          1)  Объединение в один класс данных и действий над ними.
//          2)  Сокрытие внутренней структуры класса от внешнего мира. (объект не изменяется ничем снаружи, кроме его собственных методов.)
//
//      Wiki: процесс разделения элементов абстракций, определяющих ее структуру (данные) и поведение (методы); инкапсуляция предназначена
//      для изоляции контрактных обязательств абстракции (протокол/интерфейс) от их реализации. На практике это означает, что класс должен
//      состоять из двух частей: интерфейса и реализации. В реализации большинства языков программирования (C++, C#, Java и другие)
//      обеспечивается механизм сокрытия, позволяющий разграничивать доступ к различным частям компонента.
//
//      X)  Скрытие внутреннего состояния и функций объекта и предоставление доступа только через открытый набор функций.
//
//      X)  принцип, объединяющий данные и код. манипулирующий этими данными, а так же защищающий эти данные от прямого внешнего доступа и
//      неправильного использования.
//
//  Как я понял: Создаешь класс, внутри все свойства и методы делаешь приватными. Делаешь отдельные "публичные" методы, в которых реализуешь
//      проверку входных данных, через которые будут вноситься изменения в приватные свойства и вызываться приватные методы. Даже если 
//      никакая проверка не нужна все равно реализуем "интерфейс" в виде публичных методов, на случай если поймем что проверка нужна.
//      ??? Стоит ли методы делать приватными? В них же все равно можно реализовать проверку внутри, в отличии от свойств.

// Наследование:
//      1)  Дочерний класс использует данные и действия класса родителя как свои собственные.
//           
//      Wiki:  концепция объектно-ориентированного программирования, согласно которой абстрактный тип данных может наследовать данные и
//      функциональность некоторого существующего типа, способствуя повторному использованию компонентов программного обеспечения. 
//
//  Как я понял: Наследуешься от класса. Можешь вызывать методы и использовать свойства, которых нет в текущем классе, но есть в 
//      родительском как будто они прописаны в нашем.

// Полиморфизм:
//      1)  — способность функции работать с данными разных типов.
//      Существует 2 вида полиморфизма:
//          1)  Ad-hoc - полиморфизм по запросу. Это приведение данных и перегрузка методов.
//          2)  Параметрический полиморфизм - истинный полиморфизм. Это когда одна функция может принимать в качестве параметров данные
//      разных классов.
//
//      Wiki:  — способность функции обрабатывать данные разных типов.
//          Ad-hoc-полиморфизм (в русской литературе чаще всего переводится как «специальный полиморфизм» или
//      «специализированный полиморфизм», хотя оба варианта не всегда верны[⇨]) поддерживается во многих языках посредством перегрузки
//      функций и методов, а в слабо типизированных — также посредством приведения типов.
//          Параметрический полиморфизм в языках программирования и теории типов — свойство семантики системы типов, позволяющее
//      обрабатывать значения разных типов идентичным образом, то есть исполнять физически один и тот же код для данных разных типов.
//      (Параметрический полиморфизм считается «истинной» формой полиморфизма.)
//
//  Как я понял: приведение данных и перегрузка методов - тут все ясно, хотя по факту приведение - мы преобразуем переменную в нужный тип
//      и передаем его, получается функция работает всегда с одним типом, перегрузка - вообще разные функции, у которых ничего общего нет.
//          Параметрический полиморфизм - это когда в параметр ставишь тип базового класса, а передаешь не только его экземпляры, но и
//      экземпляры наследников. Либо в параметр кидаешь интерфейс, а передаешь его реализацию.
//      (интерфейс не должен иметь внутри себя реализацию, хоть и может).
//          Generic - ???
//      # Параметрический полиморфизм -- это возможность алгоритма работать с данными "не названных" типов, которым присвоены абстрактные
//      имена. Т.е. типы являются Параметрами алгоритма, равно, как и его аргументы. Это всеми нами горячо любимые Generic-и.
//      Например: Array<T> -- это пример Параметрического полиморфизма. Tree<T>, List<T> etc. etc.

// ??? Абстракция:  (Непонятно кто то считает ее принципом ООП, кто то игнорирует)
//      Wiki:  в объектно-ориентированном программировании — это использование только тех характеристик объекта, которые с достаточной
//      точностью представляют его в данной системе. Основная идея состоит в том, чтобы представить объект минимальным набором полей
//      и методов и при этом с достаточной точностью для решаемой задачи.
//          Абстракция данных — одно из наиболее старых понятий объектно-ориентированного программирования, возникшее ещё до его появления.
//      Абстракция данных связывает лежащий в основе тип данных с набором операций над ним (см. также абстрактный тип данных).
//      Пользователь типа данных не имеет прямого доступа к его реализации, но может работать с данными через предоставленный набор
//      операций. Преимущество абстракции данных в разделении операций над данными и внутреннего представления этих данных, что позволяет
//      изменять реализацию, не затрагивая пользователей типа данных.
//
//      X) Абстрагирование - техника программирования, основная идея которой разделить данные на те, которые важны для решения задачи
//      и те, которые несущественны.

// //////////////////////////////////////////////////////////////////////////////////////////\\
// SOLID принципы: 

// SRP Принцип единственной ответственности (single responsibility principle)
// Для каждого класса должно быть определено единственное назначение. Все ресурсы, необходимые для его осуществления,
// должны быть инкапсулированы в этот класс и подчинены только этой задаче.

// OCP Принцип открытости/закрытости (open-closed principle)
// «программные сущности … должны быть открыты для расширения, но закрыты для модификации».

// LSP Принцип подстановки Лисков (Liskov substitution principle)
// «функции, которые используют базовый тип, должны иметь возможность использовать подтипы базового типа не зная об этом».

// ISP Принцип разделения интерфейса (interface segregation principle)
// «много интерфейсов, специально предназначенных для клиентов, лучше, чем один интерфейс общего назначения».

// DIP Принцип инверсии зависимостей (dependency inversion principle)
// «Зависимость на Абстракциях. Нет зависимости на что-то конкретное».
// //////////////////////////////////////////////////////////////////////////////////////////\\
//ProgrammingPrinciples[0].OOP.SOLID.                                                                    OOP.SOLID.ProgrammingPrinciples[0].
//ProgrammingPrinciples[1].                                                                                        ProgrammingPrinciples[1].

// DRY Принцип не повторяйся (don't repeat yourself) = SSOT
// Данные в системе должны иметь только одно представление. 
// SSOT Принцип единственный источник истины (single source of truth (SSOT) = DRY
// Не делать дублирование данных.
// WET — Антипринцип напиши все дважды «Write Everything Twice» или нам нравится печатать «We enjoy typing»

// KISS Принцип будь проще придурок или это коротко и просто ("keep it simple, stupid", "keep it short and simple")
// Не делай то что сейчас не нужно. Не надо на будущее реализовывать лишние функции или интерфейсы.

// YAGNI Принцип тебе это не понадобится ("You aren't gonna need it").
// Не делай то, о чем тебя не просят.












































































//ProgrammingPrinciples[1].                                                                                        ProgrammingPrinciples[1].
//VSHotKeys.                                                                                                                      VSHotKeys.



// (      ENTER)    // Edit.BreakLine           (Разрыв строки) Переносит остаток строки после курсора на новую строку, комментарии 
//                          переносит и комментирует перенесенное сохраняя табуляцию.
// (SHIFT+ENTER)    // Edit.BreakLine           (Разрыв строки) Добавляет пустую строку ниже, комментарии переносит и НЕ комментирует 
//                          (только если строка начинается с комментария, если комментарий после команды - добавляет пустую строку ниже).

// (      TAB)      //                           Добавляет табуляцию.
// (SHIFT+TAB)      // Edit.TabLeft             (На один знак табуляции влево) Убирает табуляцию.

// (CTRL+K, CTRL+C) // Edit.CommentSelection    (Закомментировать выделенный фрагмент) если нет выделения комментирует всю строку где 
//                          курсор, если выбрано несколько строк - комментирует все выбранные строки полностью, выделенный фрагмент 
//                          комментирует только если выделение внутри одной строки.
// (CTRL+K, CTRL+U) // Edit.UncommentSelection  (Раскомментировать выделенный фрагмент)

// (CTRL      +SPASE)   // Edit.CompleteWord    (Дополнить слово) Выводит список возможных вариантов дописания команды, либо сразу 
//      or (ALT+ARROWRIGHT)             дописывает если есть только 1 вариант.
//      or ( (CTRL+K, W) or (CTRL+K, CTRL+W) ) //       ??? Написано работают в [конструктор рабочих процессов], но хз.
// (CTRL+SHIFT+SPASE)   // Edit.ParameterInfo   (Сведения о параметрах) Открывает подсказку по параметрам метода (курсор должен быть внутри
//                                  скобок параметров)
// (CTRL+ALT  +SPASE)   // Edit.ToggleCompletionMode (Переключить режим завершения) Дописывать команды по нажатию TAB.
// (CTRL+J)         // Edit.ListMembers         (Показать список элементов) Открывает окно подсказок.
// (CTRL+K, CTRL+I) //                           Показать информацию о команде

// (CTRL+F)         // Edit.Find                (Поиск)
// (CTRL+H)         // Edit.Replace             (Замена)
// (CTRL+SHIFT+F)   // Edit.FindInFiles         (Поиск в файлах)
// (CTRL+SHIFT+H)   //                          (Замена в файлах)
// (CTRL+F3)        // Edit.FindNextSelected    (Найти следующий выделенный фрагмент)
// (CTRL+G)         // Edit.GoTo                (Перейти к строке)
// (     F12)       // Edit.GoToDefinition      (Перейти к определению)
// (CTRL+F12)       // Edit.GoToDeclaration     (Перейти к объявлению) ??? Чет никакой разницы нет с (F12)
// ( ALT+F12)       // Edit.PeekDefinition      (Показать определение) Открывает код тут же в небольшом окне.

// (CTRL+K, CTRL+D) // Edit.FormatDocument      (Форматировать документ)
// (CTRL+K, CTRL+E) // (Выполнить очистку кода) ??? разве не то же самое что и (CTRL+K, CTRL+D)(Форматировать документ)???
// (CTRL+K, CTRL+F) // Edit.FormatSelection     (Форматирование выделенного фрагмента)

// (CTRL+K, CTRL+S) // Edit.SurroundWith        (Окружить) Выделенный код помещается внутрь выбранного фрагмента из списка.
// (Ctrl+K, Ctrl+X) // Edit.InsertSnippet       (Вставить фрагмент) Некоторые фрагменты окружают выделенное.

// (CTRL+D)         //                           Вставить копию текущей строки выше.
// (CTRL+L)         // Edit.LineCut             (Вырезать строку)
// (CTRL+W)         // Edit.SelectCurrentWord   (Выбрать текущее слово)

// (SHIFT+ALT+(ARROWS or MOUSE))     //          Выделение несколькими курсорами.
// (ALT+(ARROWUP or ARROWDOWN))      //          Перенести строку.
// (SHIFT+ALT+.)    //                           Найти и выделить следующий текст равный выделенному.                      
// (SHIFT+ALT+;)    //                           Найти и выделить все текста во вкладке равные выделенному.                      

// (CTRL+M, CTRL+O) // Edit.CollapseToDefinitions (Свернуть в определения) Сворачивает все свойства, методы и геттеры сеттеры в открытой
//                          вкладке, не сворачивает enum, класс.
// (CTRL+M, CTRL+P) // (Прекратить показ структуры) Разворачивает полностью все что есть во вкладке и больше свернуть нельзя.
//                          (CTRL+M, CTRL+O) возвращает управление сегментами кода.
// (CTRL+M, CTRL+L) // Edit.ToggleAllOutlining  (Свернуть/развернуть все сегменты) 
// (CTRL+M, CTRL+M) // Edit.ToggleOutliningExpansion (Свернуть/развернуть сегмент)

// (CTRL+DELETE)    // Edit.WordDeleteToEnd     (Удалить до конца слова)
// (CTRL+BACKSPACE) // Edit.WordDeleteToStart   (Удалить до начала слова)

// (CTRL+R, CTRL+M) // Refactor.ExtractMethod   (Извлечение метода) Выделенный текст помещает в метод и вызывает его.

// (CTRL+R, CTRL+R) //                           Переименовать объект во всей программе.

// (CTRL+\, CTRL+E) //                           Вывести список ошибок.
// (CTRL+ALT+B)     //                           Окно точки останова.
// (CTRL+ALT+E)     //                           Параметры исключений.
//
// Средства ⇒ Импорт и экспорт параметров.      //VS сохранить или загрузить настройки программы.
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//


//VSHotKeys.                                                                                                                      VSHotKeys.

// CLR (Common Language Runtime)(Среда выполнения на общем языке) - общеязыковая среда исполнения, она основа платформы .NET.

// CIL (Common Intermediate Language)(Общий промежуточный язык) - код, поддерживаемый .NET компилируется на этот язык, это "ассемблер .NET".
//      Языки которые компилируются в CIL - C#,F#,VB.NET, диалекты других языков *.NET (Delphi.NET и др).
//      (С++ не компилируется в CIL, но использует .NET).

// JIT-компиляция (Just-In-Time) - скомпилированный код лежит в формате exe или dll на языке CIL, компилируется в машинный код только в
//      момент запуска программы и то частично, только та часть которая выполняется, скомпилированный код остается до конца работы
//      программы. После выхода из программы скомпилированный код удаляется.

// NameProject.csproj   - файл с общей конфигурацией проекта.
// *.cs                 - текст кода C#.