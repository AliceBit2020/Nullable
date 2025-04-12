
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
            // //// 1.  Значимі типи можуть nullable/////////////////////////////////////////////////////////////////////////////////////
            //int? a=null ;
            // if (a is int val)
            // {
            //     Console.WriteLine($"a is {val}");
            // }
            // else
            // {
            //     Console.WriteLine("a does not have a value");
            // }

            // // //// Nullable<T>.HasValue indicates whether an instance of a nullable value type has a value of its underlying type.


            // if (a.HasValue)//////////  только для значимых типов !!!   Nullable<int>a; a.HasValue;
            // {
            //     Console.WriteLine($"a is {a}");
            // }
            // else
            // {
            //     Console.WriteLine("a does not have a value");
            // }


            // //Если необходимо присвоить значение типа, допускающего значение NULL, переменной типа значения, не допускающего значения NULL, может потребоваться указать значение, назначаемое вместо null.Для этого используйте


            // /////////////     оператор объединения со значением NULL ??    //////////////////////////////////////////////////////
            // // Распаковка  T?  --->  T

            // int d = a ?? -1;  ///если имеет значение то выдаст его, если было значение null то выдаст -1;


            //// Упаковка в nullable   T  --->  T?

            // int? c= (int?)d;




            // //// 2. Типи посилань  /////////////////////////////////////////////////////////////////////////////////////////////////////


            //Person? obj = new("Oleg", "Olegov");
            //Person obj1 = new("Oleg", "Olegov");

            //Person? obj2 = null;

            //// //////////////////////////////////////  Оператор доступа   ?.   к методам и свойствам типов допускающих null
            //Console.WriteLine(obj?.Name );/////  "Oleg"  берет свойства если не null
            //Console.WriteLine(obj2?.Name==null);/// true
            //Console.WriteLine(obj1.Name);


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

            //Console.WriteLine(string.Join("/", numbers));  // output: 1 2 3 4 5
            //Console.WriteLine((numbers is null)); // expected: false        

            //vr = 5;
            //Console.WriteLine((vr is null)); // expected: true
            //Console.WriteLine((vr ?? 333)); // expected: 3 since a is still null 
            ////                                // if a is null then assign 0 to a and add a to the list

            //////////////////////////////////////////////////////////////////////////////
            ///

            //numbers = null;
            //numbers = numbers?.Concat(new int[] { 1, 2, 3 }).ToArray();

            //foreach (var number in numbers ?? new int[] { 0 })
            //{
            //    Console.WriteLine(number);
            //}
            /////////////////////////////////////////////////////////////////////////

            //numbers ??= new int[5] { 1, 2, 3, 4, 5 };

            //numbers=numbers?.Concat(new int[] { 999 }).ToArray();

            //foreach (var number in numbers ?? new int[] { 0 })
            //{
            //    Console.WriteLine(number);
            //}

            ////////////////////////////////////////////////////////////////////////////
            // numbers= null; 
            //numbers = numbers?.Append(999)?.ToArray();
            //    Console.WriteLine("Array:");
            //foreach (var number in numbers ?? new int[] { 0 })
            //{
            //    Console.WriteLine(number);
            //}


            numbers = new int[3] { 1, 2, 3 };
            numbers = numbers?.Append(999)?.ToArray();
            Console.WriteLine("Array:");
            foreach (var number in numbers ?? new int[] { 0 })
            {
                Console.WriteLine(number);
            }

            //////////////////////////////////////////////////////////
            ///розширення масиву вручну
            int[] test = new int[4];
            for (int i = 0; i < test.Length-1; i++)
            {
                if(numbers is not null)
                {
                    test[i] = numbers[i];
                }
               
            }
            test[3] = 999;
            numbers = test;

            foreach (var number in numbers ?? new int[] { 0 })
            {
                Console.WriteLine(number);
            }

        }
    }

}


