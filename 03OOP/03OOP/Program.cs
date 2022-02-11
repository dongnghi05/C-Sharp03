using System;

/*
 * TEST YOUR KNOWLEDGE
 * 
 * 1.What are the six combinations of access modifierkeywords and what do they do?
 * - Get and Set
 * - Public: accessible everywhere
 * - Protected: accesuble in the same class or derived class
 * - Internal: accessible in the same assemnly
 * - Private: accessible in current class
 * Use to hide data implementation (encapsulation)
 * 
 * 2.What is the difference between the static, const, and readonly keywords when applied  toa type member?
 * - Static
 * - Const
 * - Readonly
 * 
 * 3.What does a constructor do?
 * - Special method which shares the same name of the class 
 * - Does not have any return type, not even void
 * - Is used to create an object of the class and intialize class members
 * 
 * 4.Why is the partial keyword useful?
 * 
 * 5.What is a tuple?
 * 
 * 6.What does the C# record keyword do?
 * 
 * 7.What does overloading and overriding mean?
 * 
 * 8.What is the difference between a field and a property?
 * 
 * 9.How do you make a method parameter optional?
 * 
 * 10.What is an interface and how is it different fromabstract class?
 * 
 * 11.What accessibility level are members of an interface?
 * 
 * 12.True. Polymorphism allows derived classesto provide different implementationsof the same method.
 * 13.True. The override keyword is used to indicatethat a method in a derived class isproviding its own implementation of a method.
 * 
 * 14.True/False. The new keyword is used to indicatethat a method in a derived class isproviding its own implementation of a method.
 * 15.False. Abstract methods can be used in anormal (non-abstract) class.
 * 16.True. Normal (non-abstract) methods can be used in an abstract class.
 * 17.True/False.Derived classes can override methods that were virtual in the base class.
 * - Overriding in derived classes is optional
 * 18.True/False.Derived classes can override methods that were abstract in the base class.
 * - Must be overridden in derived classes
 * 19.True/False.In a derived class, you can override a method that was neither virtual non  abstract in thebase class.
 * 20.True/False. A class that implements an interfacedoes not have to provide animplementation for all of the members of the interface.
 * 21.True/False. A class that implements an interfaceis allowed to have other members thataren’t defined in the interface.
 * 22.False. A class can have more than one baseclass.
 * 23.False. A class can implement more than one interface.
 */


namespace OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("---- Question 1 ----");
            //int[] numbers = GenerateNumbers();
            //Console.WriteLine(numbers[4]);
            //Reverse(ref numbers);
            //PrintNumbers(numbers);

            Console.WriteLine("---- Question 2 ----");
            Console.WriteLine(Fibonacci(8));
            

        }

        private static int Fibonacci(int a)
        {
            if (a == 0) return 0;
            else if (a == 1) return 1;
            else
            {
                return Fibonacci(a - 1) + Fibonacci(a - 2);
            }
        }

        private static void Reverse(ref int[] numbers)
        {
            int temp;
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1 ];
                numbers[numbers.Length - i - 1] = temp;
            }

            //Array.Reverse(numbers);
        }

        private static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        private static int[] GenerateNumbers()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return arr;
        }
    }
}
