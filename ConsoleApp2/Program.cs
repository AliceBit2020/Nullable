
// See https://aka.ms/new-console-template for more information




// //The default value of a nullable value type represents null, that is,
// //it's an instance whose Nullable<T>.HasValue property returns false.


namespace Prog
{
    record Person (string Name,string Surname);

    class Program
    {




        static void Main()
        {

            //object obj = null;
            //obj.ToString();


            // //// 1.  Значимі типи можуть nullable/////////////////////////////////////////////////////////////////////////////////////

            //int? a1 = 5;
            //int? a = null;/////  постаэ питання : що у змінній  null or value
            //if (a is int val)
            //{
            //    Console.WriteLine($"a is {val}");
            //}
            //else
            //{
            //    Console.WriteLine("a does not have a value");
            //}

            //// // //// Nullable<T>.HasValue indicates whether an instance of a nullable value type has a value of its underlying type.


            //if (a.HasValue)//////////  только для значимых типов !!!   Nullable<int>a; a.HasValue;
            //{
            //    Console.WriteLine($"a is {a}");
            //}
            //else
            //{
            //    Console.WriteLine("a does not have a value");
            //}


            // //Если необходимо присвоить значение типа, допускающего значение NULL, переменной типа значения, не допускающего значения NULL, может потребоваться указать значение, назначаемое вместо null.Для этого используйте


            // /////////////     оператор объединения со значением NULL ??    //////////////////////////////////////////////////////
            // // Распаковка  T?  --->  T

            // int? vs  int

            // int d0 = a;/// error int?---->int
            //int d1 = Convert.ToInt32(a);

            //int d = a ?? -1;  ///если имеет значение то выдаст его, если было значение null то выдаст -1;
            //Console.WriteLine($"d= {d1}");

            ////// Упаковка в nullable   T  --->  T?

            //int? c= d;

            //Console.WriteLine($"c= {c}");


            // //// 2. Типи посилань  /////////////////////////////////////////////////////////////////////////////////////////////////////
            //object ob = null;
            //ob?.ToString();//// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //Person? obj = new("Oleg", "Olegov");
            //Person obj1 = new("Oleg", "Olegov");

            //Person? obj2 = null;

            ////// //////////////////////////////////////  Оператор доступа   ?.   к методам и свойствам типов допускающих null
            //Console.WriteLine(obj?.Name );/////  "Oleg"  берет свойства если не null
            //Console.WriteLine(obj2?.Name==null);/// true
            //Console.WriteLine(obj2.Name);


            // int? aa = 17;
            // Type typeOfA = aa.GetType();
            // Console.WriteLine(typeOfA.FullName);
            // Output:
            // System.Int32


            ////////////////  оператор ?? , ??=
            ///
            int[]? numbers = null;
            int? vr = null;

            //Console.WriteLine((numbers is null)); // expected: true
            //                                      // if numbers is null, initialize it. Then, add 5 to numbers

            //Console.WriteLine(string.Join("/", numbers));  
           // Console.WriteLine((numbers is null));

            //vr = 5;
            //Console.WriteLine((vr is null)); // false
            //Console.WriteLine((vr ?? 333)); // 5

            //vr = null;
            //Console.WriteLine((vr ?? 333)); // 333

            //////////////////////////////////////////////////////////////////////////////
            ///

            //numbers = null;
            //numbers = numbers?.Concat(new int[] { 1, 2, 3 }).ToArray();// null

            //foreach (var number in numbers ?? new int[] { 0,2,99 })
            //{
            //    Console.WriteLine(number);
            //}
            /////////////////////////////////////////////////////////////////////////

            numbers ??= new int[5] { 1, 2, 3, 4, 5 };

            numbers = numbers?.Concat(new int[] { 999,888 }).ToArray();

            foreach (var number in numbers ?? new int[] { 0 })
            {
                Console.WriteLine(number);
            }

            ////////////////////////////////////////////////////////////////////////////
            // numbers= null; 
            //numbers = numbers?.Append(999)?.ToArray();
            //    Console.WriteLine("Array:");
            //foreach (var number in numbers ?? new int[] { 0 })
            //{
            //    Console.WriteLine(number);
            //}


            //numbers = new int[3] { 1, 2, 3 };
            //numbers = numbers?.Append(999)?.ToArray();
            //Console.WriteLine("Array:");
            //foreach (var number in numbers ?? new int[] { 0 })
            //{
            //    Console.WriteLine(number);
            //}

            //////////////////////////////////////////////////////////
            ///розширення масиву вручну
            //int[] test = new int[4];
            //for (int i = 0; i < test.Length-1; i++)
            //{
            //    if(numbers is not null)
            //    {
            //        test[i] = numbers[i];
            //    }

            //}
            //test[3] = 999;
            //numbers = test;

            //foreach (var number in numbers ?? new int[] { 0 })
            //{
            //    Console.WriteLine(number);
            //}

        }
    }

}


