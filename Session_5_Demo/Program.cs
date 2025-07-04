namespace Session_5_Demo
{
    class Data
    {
        public int Sum { get; set; }
        public int Multiply { get; set; }

    }
    internal class Program
    {
        #region Functions 1 [PrintShape]
        // static function
        //static void PrintShape()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("*_*");
        //    }
        //}

        // daynamic function
        //static void PrintShapeeee(int Counter = 5 /* default value*/ , string Pattern = "(*_*)" /* default value*/)
        //{
        //    for (int i = 0; i < Counter; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}

        // make error becuase should make default value in last parameter
        // even if you don't need to set default paramter for 1st parameter
        // but should make default value for last parameter if we use default value
        //static void PrintShapeeee3333(int Counter = 5 /* default value*/ , string Pattern)
        //{
        //    for (int i = 0; i < Counter; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}

        //to solve error happend above when use default value we should make default value for last paramter
        //this true not make error becuase but default value for last parameter even 
        // not set default value for 1st paramtere
        //static void PrintShapeeee44444(int Counter , string Pattern = "(*_*)" /* default value*/)
        //{
        //    for (int i = 0; i < Counter; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}
        #endregion

        #region Functions 2 [Swap]
        // Parameters will pass by --> Passing by value --> mean copy of data of paramtere that will send 
        // and if any thing happen in this copy data this will not effect in value in real paramtere
        // and real paramteres still have same value before and after calling fucntion

        //static void Swap1(int x , int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        // Parameters will pass by --> Passing by reference  --> mean real data of paramter that will send not copy
        // and if any thing happen in this data this will effect in value in real paramtere
        // and real paramteres don't have same value before and after calling fucntion
        // becuase calling function and update data will effect on data on real paramteres
        // and value will change

        //static void Swap2(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #region Functions 3 [SumArray change element]

        // passing by value
        //static int SumArray2(int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        // passing by value

        // we deal with reference type so should check first if arr is null or not
        // then make every thing on array when you checked that array is not null
        //static int SumArray3(int[] arr)
        //{
        //    int sum = 0;
        //    if (arr is not null /*or arr != null*/)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}
        // passing by value

        // make access on 1st element in array that will be 100
        // and then will effect in array numbers mean numbers[0] = 100 also not 1 
        // becuase when call function give for function give array numbers that mean 
        // i give address of values that stored in heap and this say call by refernce but passing by value
        // when make arr in stack make it pointer to the same place to place that numbers pointer on it
        // that mean 2 arrays pointer in same place in heap have sam address that pointer on it
        // then when update on any value will effect in 2 arrays but this is call by value not call by refernce
        //static int SumArray4(int[] arr)
        //{
        //    int sum = 0;
        //    if (arr is not null /*or arr != null*/)
        //    {
        //        arr[0] = 100;
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}

        // passing by reference

        //static int SumArray5(ref int[] arr)
        //{
        //    int sum = 0;
        //    if (arr is not null /*or arr != null*/)
        //    {
        //        arr[0] = 100;
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}
        #endregion

        #region Functions 4 [SumArray change reference]
        // Passing by value
        //static int SumArray( int[] arr)
        //{
        //    int sum = 0;
        //    if (arr is not null /*or arr != null*/)
        //    {
        //        arr = new int[3] { 100, 200, 300 };
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}

        //Passing by Ref
        //static int SumArrayref(ref int[] arr)
        //{
        //    int sum = 0;
        //    if (arr is not null /*or arr != null*/)
        //    {
        //        arr = new int[3] { 100, 200, 300 };
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}
        #endregion

        #region Functions 5 [MultiplySum]
        //static void MutliplySum (int x , int y)
        //{
        //    return x * y;
        //    return x + y; // unreachable code me4 ha3rf 23ml return marten
        //                  // l2n 2wl return hat5rgn 3altol mn el function
        //                  // azay b2a ha3ml el return el tanya
        //}
        // 1st solution we will make work around --> make function return array
        // but this is not good solution
        // good solution make passing by out --> el hwa kona ben3mlo fe el data base bab3tloh tba2en fadyen we ba2loh 7otly fehom el values
        //static int[] MutliplySum1(int x, int y)
        //{
        //    return new int[] { x * y, x + y };
        //}

        //2nd solution we will make work around --> make class that has name --> Data 
        // Class data have 2 properties or atributes 
        //then make function will return datatype mn no3 data
        // but this is not good solution
        // good solution make passing by out --> el hwa kona ben3mlo fe el data base bab3tloh tba2en fadyen we ba2loh 7otly fehom el values
        //static Data MutliplySum2(int x, int y)
        //{
        //    Data data = new Data() { Multiply = x*y , Sum = x+y };
        //    return data;
        //}
        //good solution make passing by out --> el hwa kona ben3mlo fe el data base
        //bab3tloh tba2en fadyen we ba2loh 7otly fehom el values
        // fa kdah ma3 el x we el y hab3t 2 parameters tanyen el homa sum we mul dol fadyen t7otly fehom el result
        // we kdah el function deh hateb2a void l2nha me4 hatrag3 7aga 2sln  
        // hya hat7otlk el values fe el tab2en el fadyen we hyrg3olk  fehom nafs el values
        //static void MutliplySum3(int x, int y , out int Sum , out int Multiplay)
        //{
        //    Sum = x + y;
        //    Multiplay = x * y;

        //}

        //static void MutliplySum4ref(int x, int y, ref int Sum, ref int Multiplay)
        //{
        //    Sum = x + y;
        //    Multiplay = x * y;

        //}
        #endregion

        #region Functions 6 [SumArr Params]
        //static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //    if (arr != null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}

        ////params
        //static int SumArrayparams(params int[] arr)
        //{
        //    int sum = 0;
        //    if (arr != null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}
        #endregion

        #region Functions 7 [DoSomeCode - DoSomeCleanCode]
        // inside this faunction make some things can make exception 
        //static void DoSomeCode()
        //{
        //    int x = int.Parse(Console.ReadLine());
        //    int y = int.Parse(Console.ReadLine());
        //    int Division = x / y;
        //    Console.WriteLine(Division);
        //    int[] Arr = { 1, 2, 3 };
        //    Arr[100] = 10; 
        //}

        //// make function have clean code to handle all exception
        //static void DoSomeProtictiveCode()
        //{
        //    int x;
        //    bool isParsed;
        //    do
        //    {
        //        Console.WriteLine("Please enter x");
        //         isParsed = int.TryParse(Console.ReadLine() , out x);
        //    } while (!isParsed);
        //    int y;
         
        //    do
        //    {
        //        Console.WriteLine("Please enter y");
        //        isParsed = int.TryParse(Console.ReadLine(), out y);
        //    } while (!isParsed || y <= 0);

        //    int Division = x / y;
        //    Console.WriteLine(Division); 

        //    int[] Arr = { 1, 2, 3 };
        //    if (Arr is not null)
        //    { 
        //        try 
        //        {
        //            Arr[100] = 10;
        //        }
        //        catch(Exception Ex)
        //        {
        //            Console.WriteLine(Ex.Message);
        //        }
        //        finally
        //        {
        //            // Relase , Remove , Deallocate UnManged resources [DB , Files]
        //            Console.WriteLine("Hello from finally");
        //        }
            
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Arrays [2D Array - Judged array - Marks]
            //int[][] Marks = new int[3][]; // size 3 mean have 3 student and
            //                              // another bracket cannot put size
            //                              // becuase i don't have any information
            //                              // about how many of array i have for each student
            //                              // because this size varity from student to another
            //Marks[0] = new int[3] { 10, 20, 30 }; // 1st student have 3 subject's this grade for subject's in array
            //                                      // we can put size of array or not this optional
            //                                      // he will know from enterd data the size of 1d Array
            //Marks[1] = new int[] { 10, 20 }; //// 2nd student have 2 subject's this grade for subject's in array
            //Marks[2] = new int[] { 10 };

            ////another way to entered data 
            //int[][] Data = [new int[3] { 10, 20, 30 }, new int[2] { 10, 20 }, new int[1] { 10 }];

            //// to make loop to show data 
            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++) // becuase we have more varity in 1d array
            //                                              // that have grade for each user and need to loop on it
            //                                              // So we should make that MArks[i].length
            //                                              // when i = 0 this is first student and j < 3 
            //                                              // becuase size of 1D Array that 1st student referenced on it
            //                                              // have size 3 and so on on other students
            //    {
            //        Console.Write(Marks[i][j] + " ");
            //    }
            //    Console.WriteLine($"End data for student number {i+1}");
            //}
            #endregion

            #region Array Methods
            // 1- Class member method [static method]

            //int[] numbers = { 1, 23, 5, 6, 0 };
            //int[] numbers2 = new int[5];

            ////1.Sort --> Take Array and sort it in ascending order from low to high
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} // o/p will be --> 0 1 5 6 23

            ////2.Reverse --> Take Array and reverse from end to start it will be 0 6 5 23 1
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} o/p will be --> 0 6 5 23 1

            //// making sort then reverse like making sort in descending order from high to low 
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} // o/p will be --> 23 6 5 1 0

            ////3.Copy --> Take 1st parameter the SourceArray that is array have data and will take copy of this data from it
            ////       --> Take 2nd parameter the DestinationArray that is array i will put on it data that will copy from SourceArray
            ////       --> Take 3rd Parameter the Lenght that mean enta 3ayez te3ml copy l7ad fen hal ly kol el array wla l7ad index mo3yen
            //Array.Copy(numbers, numbers2 , 3);
            //// kdah hwa 5ad 2wl 3 elements mn 2wl array we kdah ba2y el array el numbers2 dah hwa be size
            //// 5 ma3na kdh ba2y el element hykono bel default el hwa 0
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //} // o/p will be 1 23 5 0 0

            ////4.ConstrainedCopy --> Take 5 paramters
            //// 1st parameter SourceArray --> that is array have data and will take copy of this data from it
            //// 2nd Parameter Source index --> that mean where is the place  or index that need to start from it to start copy from it 
            //// 3rd Parameter DestinationArray --> that is array i will put on it data that will copy from SourceArray
            //// 4th Parameter Destination Index --> that mean where is the place or index that need to start to put copied data on it 
            //// 5th Paramter Length --> that mean enta 3ayez te3ml copy l7ad fen hal ly kol el array wla l7ad index mo3yen
            //Array.ConstrainedCopy(numbers, 1, numbers2, 1, 3);
            //// kdah hwa hybd2 y3ml copy mn index rakm 1 fr 2wl array we hy7ot el data fe tany array
            //// mn 2wl index rkm 1 we hytb3 mn 2wl array 3 2makn 2w 3 2rkm l2n dah el length el ana m7dedoh
            //// we kdah el b2ay el size bta3 el array el tany ay 7aga ba2ya hatkon bel defualt el hya 0
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //} // o/p will be 0 23 5 6 0

            ////5.IndexOf --> Take 2 Parameter
            ////1st Paramtere --> take Array
            ////2nd Paramtere --> Take value that you need to know index for it
            //int index = Array.IndexOf(numbers, 23);
            //Console.WriteLine(index); // o/p will be --> index 1
            //// if enterd value not in array will return -1
            //int index2 = Array.IndexOf(numbers, 20);
            //Console.WriteLine(index2); // o/p will be --> index -1 becuase this value 20 not in array
            //// if we have duplicate in data in array like have 2 number = 23 
            //// then it will return index for first one he will see it like that 
            //int[] numbers3 = { 1, 23, 5, 6, 0 , 23 };
            //int index3 = Array.IndexOf(numbers, 23);
            //Console.WriteLine(index3); // o/p will be --> index 1 not 5 becuase he saw 23 at index 1 first 

            ////6.LastIndexOf
            ////1st Paramtere --> take Array
            ////2nd Paramtere --> Take value that you need to know index for it
            //int index4 = Array.LastIndexOf(numbers, 23);
            //Console.WriteLine(index4); // o/p will be --> index 1
            //// if enterd value not in array will return -1
            //int index5 = Array.LastIndexOf(numbers, 20);
            //Console.WriteLine(index5); // o/p will be --> index -1 becuase this value 20 not in array
            //// if we have duplicate in data in array like have 2 number = 23 
            //// and need to return last index not first index for duplicate data 
            //int[] numbers4 = { 1, 23, 5, 6, 0, 23 };
            //int index6 = Array.LastIndexOf(numbers, 23);
            //Console.WriteLine(index6); // o/p will be --> index 5 not 1 becuase he saw 23 for last one 
            //                           // see all array and search if we have duplicate data search about last one

            ////7.CreateInstance  --> Take 2 Paramter
            //// --> Create new array without need to use this method --> int[] numbers3 = new int [5];
            ////1st Paramter --> ElementType --> that mean type of array that you need to create 
            //// but write first --> typeof() --> then put inside brackets type of array
            ////2nd paramter --> length or size of Array
            ////that is not enough , you need to revicve the returned in array and need to make implicit Casting
            //// need make this casting becuase it return array and array have alot of types 
            //// then need to determine which type will return by using inplicit casting
            //// and need to determin also dimension of array becuase we can make alot of dimesnions
            //// 1D Array
            //int[] Arr = (int[]) Array.CreateInstance(typeof(int), 5);
            //Console.WriteLine(Arr.Length); // == 5 
            //Console.WriteLine(Arr.Rank); // == 1D 
            //// 2D Array
            //int[,] Arr1 = (int[,])Array.CreateInstance(typeof(int), 2 , 5);
            //Console.WriteLine(Arr1.Length); // == row * column = 2 * 5 = 10
            //Console.WriteLine(Arr1.GetLength(0)); // == size row = 2
            //Console.WriteLine(Arr1.GetLength(1)); // == size column = 5
            //Console.WriteLine(Arr1.Rank); // == 2D



            // 2- object member method [non static method]

            //int[] data = { 1, 2, 3, 4, 5 };
            //int[] data2 = new int[5];

            ////1.CopyTo --> Like Copy method that explain above in static method --> Take 2 Parameter
            ////1st Parameter --> Array --> that will copy data on it
            ////2nd Parameter --> Index --> from which index to start to copy
            //data.CopyTo(data2, 0);
            //for (int i = 0; i < data2.Length; i++)
            //{
            //    Console.WriteLine(data2[i]);
            //}

            ////2.SetValue --> Take value that you need to sit in array --> Take 2 Paramters
            ////1st Parameter --> Value --> that i need to sit it
            ////2nd Parameter --> index --> the place i need to sit or insert new value on it
            //data.SetValue(22, 0); // ==> Like data[0]=10; 
            //// this update only in this line not save change and remove 1 forever no when 
            //// reomve this data.SetValue(22, 0); that value 1 will return again
            //for (int i = 0; i < data.Length; i++)
            //{
            //    Console.WriteLine(data[i]);
            //}

            //3.GetValue --> Get value that you need to search about it in array --> Take 1 Parameter
            //Parameter --> index --> the place i need to serach about value on it
            //Console.WriteLine(data.GetValue(2)); // like Console.WriteLine(data[2])

            #endregion

            #region Boxing & UnBoxing
            // Boxing --> Casting from value type to reference type

            //object obj = new object(); //==> not have any value and this is refernece type
            //                           //==> then it will refere to null

            //obj = "Mariam"; // --> We know that string is Refernece Type then we assign Refernece type to
            //                // --> Refernece type too so this is not boxing and not unboxing

            //obj = 10; // --> we know that 10 is int mean value type and obj is Referenece type
            //          // --> it will happen Boxing 
            //          // --> Becuase you try to assign value type to refernece type
            //          // --> this mean also implicit casting --> it will cast from int to obj [safe casting]

            //obj = true; // --> we know that true is bool mean value type and obj is Referenece type
            //            // --> it will happen Boxing 
            //            // --> Becuase you try to assign value type to refernece type
            //            // --> this mean also implicit casting --> it will cast from bool to obj [safe casting]

            //obj = 13.5; // --> we know that 13.5 is float or double mean value type and obj is Referenece type
            //            // --> it will happen Boxing 
            //            // --> Becuase you try to assign value type to refernece type
            //            // --> this mean also implicit casting --> it will cast from int to obj [safe casting]

            //obj = new DateTime();// --> we know that DateTime() is class implemented by using Struct
            //                     // mean value type and obj is Referenece type
            //                     // --> it will happen Boxing 
            //                     // --> Becuase you try to assign struct to class
            //                     // --> value type to refernece type




            // UnBoxing --> Casting from reference type to value type

            //int x = 15;
            //object obj = 10;

            //x = obj; // --> Have error becuase x is int and obj is object can be any data type 
            //         // --> mean obj can have anu value from any another data type 
            //         // --> so he need from you to make implicit casting to sure for him
            //         // --> that value inside object it will be from datatype int 
            //         // --> we should make this x = (int) obj;

            //x = (int)obj;// --> we know that x is int mean value type and obj is Referenece type
            ////          // --> it will happen UnBoxing 
            ////          // --> Becuase you try to assign refernece type to value type
            ////          // --> this mean also Explicit casting --> it will cast from obj to int [unsafe casting]

            //obj = "Mariam";
            //x = (int)obj;// --> we know that x is int mean value type and obj is Referenece type
            ////          // --> it will happen UnBoxing 
            ////          // --> Becuase you try to assign refernece type to value type
            ////          // --> this mean also Explicit casting --> it will cast from obj to int [unsafe casting]
            //            // --> we have exeption or error becuase obj have value string and you make cast to int
            //            // --> and thos is not availble to turn from string to int so error will happen 
            #endregion

            #region Nullable Types --> ? && Null coalescing operator --> ??
            // Nullable types ==> value types allow null as a valid value
            // Nullable ==> Allow its type or Null


            #region Examples

            //string name = null; // --> true becuase string is reference type and refere to null becuase it allow null

            //int x = null; // --> false and make error becuase int is value type and don't allow null

            //int[] numbers;
            //numbers = null; // --> true becuase array is reference type also and refere to null becuase it allow null

            //int? num = 10; // --> ? --> mean Nullable type ==> that mean num can save value from type int or null
            //              // --> becuase ? allow null for num and if make thsi num = null ; this true for now 
            //              // --> becuase i use ? that is nullable type mean allow null for type int
            //num = null; // --> is true becuase i use ? above that mean nullable type allow null  

            //double? salary = 100.5; // --> ? --> mean Nullable type ==> that mean num can save value from type int or null
            //               // --> becuase ? allow null for num and if make thsi num = null ; this true for now 
            //               // --> becuase i use ? that is nullable type mean allow null for type double
            //salary = null; // --> is true becuase i use ? above that mean nullable type allow null  

            //string? name2 = null; // --> true becuase string is reference type and refere to null becuase it allow null
            //                     // --> and if use ? nullable type still true becuase not anything cahnge
            //                     //--> becuse string is still refernece typr mean allow null 

            #endregion

            #region Casting between nullable type and value type

            //int x = 5; //--> this is value type only don't allow null
            //int? y = 10; //--> this is nullable type mean allow value type and allow null

            //y = x; //--> try to put value from value type to nullable type this true 
            // --> becuase nullable type allow value type and allow null

            //x = y; //--> try to put value from nullable type to value type this flase and make error
            // --> becuase nullable type allow value type and allow null but value type don't allow null
            // --> so error will happend becuase we can not put value from nullable to value type

            //int? z = null;
            //x = (int)z; // //--> try cast from nullable type to value type this flase and make error and unsafe
            // --> becuase nullable type allow value type and allow null but value type don't allow null
            // --> so error will happend becuase we can not cast from nullable to value type
            // and value in z is null 
            // but if value in z anything not null then it will be true like that ==>
            //z = 10;
            //x =(int)z; // this true becuase value in z not null but it's value integer

            // to handle error happen if z have value null 
            //if (z != null) 
            //{
            //x = (int)z; //you can only make like that (int)z but can not make that z we explain it above
            //Console.WriteLine(x);
            //}
            //else
            //{
            //    x = 0;
            //    Console.WriteLine(x);

            //}

            //// another way to handle error happen if z have value null 
            //if (z is not null)
            //{
            //    x = (int)z; //you can only make like that (int)z but can not make that z we explain it above
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    x = 0;
            //    Console.WriteLine(x);

            //}

            //// another way using ternery operator to handle error happen if z have value null 
            //x = z is not null ? (int)z : 0; // you can only make like that (int)z but can not make that z we explain it above
            //Console.WriteLine(x);

            //// another way to handle error happen if z have value null 
            //if (z.HasValue)   // HasValue --> Property that exist in nullable datatype mean if make
            //                  // nullable int then have property HasValue
            //                  // and this proberty returned Boolean
            //                  // return true if z != null mean have value
            //                  // return false if z == null mean don't have value and have null
            //{
            //    x = (int)z;
            //}
            //else
            //{
            //    x = 0;
            //}


            //    // Null coalescing operator

            //    // --> that mean replace null to be value
            //    // --> don't need to cast 

            //    x = z ?? 0; // --> this mean if Z returned value != null set z in x normally 
            //            // --> but if Z returned value == null set 0 in x
            #endregion

            #endregion

            #region Null Propagation operator --> ?.

            //double salary = default; // will be --> 0
            //Console.WriteLine(salary);

            //int[] arr;
            //arr = default;
            //for (int i = 0; i < arr.Length; i++) // make error or execption becuase it loop for empty array
            //                                     // not refere to any value but refer to null
            //                                     // becuase array is refernece type then refer to null
            //                                     // what can we do to solve this error or exception ?
            //{
            //    Console.WriteLine(arr[i] + " ");
            //}

            // to handle error or exception that happend above -- > 1st
            // check first if array return null or not becuase array is refernce type
            // Not ==> if you have any refernce typr first make check if it null or value then make code

            // this solution not very good but good becuase if array have values like {1,2,3,4} 
            // we will make check 4 times and we need only to check only 1 time
            // mean make poor performance becuase we do more steps don't need to make it 
            //for (int i = 0; (arr is not null) && (i < arr.Length) ; i++)
            //{
            //    Console.WriteLine(arr[i] + " ");
            //}

            // another solution to handle error or exception that happend above --> 2nd

            //Null Propagation operator 
            // --> is used when know that this line will execute only 1 time 

            //this solution not very good but good becuase if array have values like { 1,2,3,4}
            // we will make check 4 times and we need only to check only 1 time
            // mean make poor performance becuase we do more steps don't need to make it
            //for (int i = 0; i < arr?.Length ; i++) // --> arr?.Length --> this mean if array have values
            //                                  // --> then get length of array and make the loop
            //                                  // --> if array don't have value this mean it is null 
            //                                  // --> and it will return null mean empty in console
            //{
            //    Console.WriteLine(arr[i] + " ");
            //}

            // to make 1st solution very good not goog we will make this 
            // we only check 1 time before loop and then make loop right if reuslt of condition if ture
            // and improve performance becuase we removed steps that we don't need to do it
            //if (arr != null /* or  arr is not null*/ )
            //{
            //    for (int i = 0;i < arr.Length ; i++)
            //    {  Console.WriteLine(arr[i] ); }
            //}

            // to make 1st solution very good not goog we will make this
            // we only check 1 time before loop and then make loop right if reuslt of condition if ture
            // and improve performance becuase we removed steps that we don't need to do it
            //if (arr?.Length > 0 )
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    { Console.WriteLine(arr[i]); }
            //}

            //string[] numbers = { "1", "2", "3"};
            //numbers = null;
            //Console.WriteLine(numbers?.Length ?? 0); // make first --> Null Propagation operator
            // to check if array numbers have value or null 
            // so we use Null Propagation operator becuase
            // if have value then return length but if don't have value
            // return null mean empty in console but if you don't need to retuen null then 
            // second --> we use Null coalescing operator with Null Propagation operator
            // to check if have null then return 0 but if have value 
            // return this value
            // o/p will be 2 zeros 
            // 1st zero for --> Null Propagation operator
            // 2nd zero fro --> Null coalescing operator checked value
            // and get it null then choose 0
            // for Null coalescing operator we can but any value
            // like 100 instead of 0 becuase Null coalescing operator
            // his function is to relace null by value after ?? like 0
            // we can make this (numbers?.Length ?? 100)
            #endregion

            #region Null forgeviness operator --> !

            // deh ta5tlf tmaman 3an el Null coalescing operator we 3an el Null Propagtion operator
            // malha4 3elka bel 2blha 5als

            string name = null; // --> make warning that tell you if you use null it will make problem 
                                // --> if you can not handle all cases

            // To remove this warning --> use Null forgeviness operator 
            // this mean --> malk4 da3wa ana ha handle kol el cases we me4 ha5ly el null te3ml ay mo4kela
            string name2 = null ! ;

            #endregion

           
            #region Functions 1 [PrintShape]
            //Program.PrintShape();
            // or 
            //PrintShape();

            //Program.PrintShapeeee(10, "*_-");
            //or
            //PrintShapeeee(10, "*_-");

            //PrintShapeeee("-_-" , 10); // Invalide becuase first paramter is counter and 2nd is pattern
                                        // we can't change place for each parameter 
                                       // if you need to make this then use or make Passing by name
            
            //Passing by Name
            //PrintShapeeee(Pattern: "-_-" , Counter: 10);

            // we put above on function default value 
            // then we can call function and don't need to put value for parameter
            //PrintShapeeee();

            // if have defualt value can not use it by sending value in parameter when calling 
            // like that 
            //PrintShapeeee(6);

            // or
            //PrintShapeeee(Pattern: "*_-_*");

            // we can't make this
            // becuase 1st paramter is counter not pattern 
            // if you don't send data in arrangment then use passing by name like above

            //PrintShapeeee("o_o");

            // we have \ this mean he wait for me to make operation like \\ or \n or \t
            // if write 1 \ this make error becuase it wait another sign [\,n,t] to make opeartion
            // to skip this error and print this shape set @ and this will solve error 
            //PrintShapeeee(20 , @"/*\");
            #endregion
            

            #region \ @

            //Console.WriteLine("Ahmed \n Basha"); // \n --> banzl line 
            //Console.WriteLine("Ahmed \t Basha"); // \t --> ba3ml space like 4 steps space
            //Console.WriteLine("Ahmed \\ Basha"); // \\ --> ba7ot dah law feh 3and filepath
                                                 // 3al4n el complier yfhm 2n dah path we ba3d kdah
                                                 // hwa hy4el el \\ we hy7ot wa7da bs \ l2n el path fe \
                                                 // bs we hwa 2sln by7ot  mn el \\ 3l4an yfar2 benha
                                                 // we ben ay 2mr tany l2n maynfa34 y7ot \ bs l2n \ bs
                                                 // deh begy warha 7agat kter zay \n we \t
                                                 // fa law 7atet \ zay kdah hwa mstny ba3deh 7aga 3l4n
                                                 // yfar2 fe fe el filepath ben7ot \\
            //Console.WriteLine();
             
            // set @ --> to skip operation of \ that mean \ will be string not have any function to do 
            // when set @ 
            //Console.WriteLine(@"Ahmed \n Basha"); // o/p --> Ahmed \n Basha
            //Console.WriteLine(@"Ahmed \t Basha"); // o/p --> Ahmed \t Basha
            //Console.WriteLine(@"Ahmed \\ Basha"); // o/p --> Ahmed \\ Basha

            string filePath = "E:\\Full_Stack_diplom\\Videos\\Back_End\\Mariam_Shindii\\Week_8_C#\\Session_1";


            #endregion

            #region Function[Value type Parameters] [Passing by value , Passing by reference]

            // Passing by value

            //int a = 10, b = 5;
            //Console.WriteLine($"a and be before swap1 {a} , {b}"); o/p --> a = 10 , b = 5
            //Swap1(a, b); /*or program.Swap1(a,b)*/ //--> send copy of variables not it self 
            // a and b after swap have the same answer befor swap mean a = 10 and b = 5 why ?
            // becuase this swap happen only inside function and function when finish all thing return normally
            // becuase when finish stack frame will remove then value a and b remain it sef a = 10 and b = 5
            // and the main reson is he take copy from values a and b not real value but copy
            // becuase we passing these values use Passing by value not Pssing by refernce
            //Console.WriteLine($"a and be after swap1 {a} , {b}"); // o/p --> a = 10 , b = 5

            // Passing by reference

            //int a = 10, b = 5;
            //Console.WriteLine($"a and be before swap2 {a} , {b}"); // o / p -- > a = 10 , b = 5
            //Swap2(ref a, ref b); /*or program.Swap2(ref a, ref b)*/ // --> send variables it self
            //Console.WriteLine($"a and be after swap2 {a} , {b}"); // o / p -- > a = 5 , b = 10

            #endregion

            #region Function[Reference type Parameters] [Passing by value , Passing by reference]

            #region Example 1
            // Passing by Value

            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //int result;
            //result = SumArray2 (Numbers);
            //Console.WriteLine (result);
            // make this array = null to prevent the error happen
            // we make if condition before making anything on array on function SumArray3
            // becuase if array is null then return null 
            //Numbers = null;
            //result = SumArray3 (Numbers);
            //Console.WriteLine (result); // o/p will be --> 0 becuase sum is returned and it = 0 

            // we make in SumArray4 access on first element to be 100 then sum result will be 120
            //result = SumArray4 (Numbers);
            //Console.WriteLine (result);// o/p --> 120
            //Console.WriteLine(Numbers[0]); // o/p --> 100 not 1 
            // // make access on 1st element in array that will be 100
            // and then will effect in array numbers mean numbers[0] = 100 also not 1 
            // becuase when call function give for function give array numbers that mean 
            // i give address of values that stored in heap and
            // this say call by refernce but passing by value
            // when make arr in stack make it pointer to the same place
            // to place that numbers pointer on it
            // that mean 2 arrays pointer in same place in heap
            // have sam address that pointer on it
            // then when update on any value will effect in 2 arrays
            // but this is call by value not call by refernce

            //Passing by Reference 
            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //int result;
            //result = SumArray5 (ref Numbers);
            //Console.WriteLine (result);  // o/p will be 120
            //Console.WriteLine(Numbers[0]); // o/p will be 100 --> explain it in notebook


            #endregion

            #region Example 2
            // Passing by Value
            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //int result;
            //result = SumArray(Numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(Numbers[0]);// o/p --> will be 1 not 100

            //Passing by ref
            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //int result;
            //result = SumArrayref(ref Numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(Numbers[0]);// o/p --> will be 100 not 1
            #endregion

            #endregion

            #region Function [Passing by out ] [SumMultiply]
            //int A = 10, B = 5;
            //int Sum, Multiply; // --> Dool el tab2en el fadyen el 3andy el hast2bl fehom el data 
            //MutliplySum3(A, B , out Sum , out Multiply);
            //// or MutliplySum3(A, B , out int Sum , out int Multiply);
            //Console.WriteLine(Sum); // o/p --> 15
            //Console.WriteLine(Multiply); // o/p --> 50

            ////if you need to not send 2nd parameter use discard 
            //MutliplySum3(A, B, out Sum, out _);
            ////if you need to not send 2 parameters use discard 
            //MutliplySum3(A, B, out _, out _);


            //// ma2dr4 23ml passing by ref l2n el sum we el multipy dol fadyen mafhom4 data or value asl2n
            //// 3l4an 23ml el passing by ref lazem 2b3t value fe el tab2en el fadyen we kdah kdah hyt2sro
            //// bel ta3del el hytm fo2
            //int Sum2 = 0, Multiply2 = 0; // --> Dool el tab2en el fadyen el 3andy el hast2bl fehom el data 
            //MutliplySum4ref(A, B, ref Sum2, ref Multiply2);
            //Console.WriteLine(Sum2);
            //Console.WriteLine(Multiply2);



            /*Note : --> */

            // fa bast5dm el passing by reference law 3ayez 23ml input output el hwa 3ayez
            // 23ml value mo3yena 2nfez beha logic mo3yen we 2st2bl el values we 2rg3ha 

            // lakn bast5dm el passing by out bab3t el variable el variable dah tab2 fady
            // beya5od el value we byrg3 beha 3altol 
            #endregion

            #region Function [Params]
            // fa ana 27tagt 2ro7 27gz mkan fe el stack 4 byte el hwa el reference 25leh y
            // refer 3al mkan fe el heap 4ayel feh el values deh 10 20 30
            // fa ana kdah ro7t 7agzt mkan fe el stack we makn fe el heap 7atet feh el values deh
            // we ba3d kdah ba3tha k parameter

            //int[] Numbers = { 10, 20, 30 };
            //int result = SumArray(Numbers);
            //Console.WriteLine(result);

            // bs ana me4 3ayez 23ml dah me4 3ayez 27gz 2makn 3al el fady 
            // ana me7tag 2ro7 2b3t fe el function deh 2b3tlha 3altol el aaray
            // mn 8er ma 2ro7 27gz mkan we 2ro7 2a create instance we 2b3tloh el instance 
            // we 3l4an 23ml kdah lazem 2tl3 fo2 fe el function 23rfoh 2noh hyst2bl meny params 
            // params --> el hwa hab3tlk el paramteres monfasela be , kdah like that --> 10 , 20 , 30
            // we lma 2b3tha monfsela kdah enta hat5odha t7otha gwa el array el 3andk fe el scope
            // bta3k anta el hya 2smha arr
            // we kdah ka2ny ba3t el number mn 8er ma 2ro7 2a create mkan fe el stack gwa el stack fram bt3a el main
            // el hwa 4 bytes we 25leh y refer 3al mkan f el heap 4ayel el values we ba3d kdah 2b3tloh el values deh l2a 
            // ana ro7t 3altol ba3tloh el values it self
            // fa ha3nl kdah 

            //int result = SumArrayparams(10 , 20 , 30 );
            //Console.WriteLine(result);

            // --> Notes :- 

            // Params have many conditions 
            // 1. we can not send alot of params is only one can send 
            // can not make this --> static int SumArrayparams(params int[] arr , params int[] arr2)
            // only send one param
            // 2. params should be last parameter not in first or middle should be in last parameter 
            // ya3ny maynfa34 yegy ba3dha 7aga 
            // can not make this --> static int SumArrayparams(params int[] arr , int size)
            // but can make this --> static int SumArrayparams(int size , params int[] arr)
            // and if call last functione above int result = SumArrayparams(10 , 20 , 30 , 40 , 50 );
            // size will be 10 and params take 20 , 30 , 40 ,50 
            #endregion

            #region Exception handling
            // call function
            //DoSomeCode();

            //DoSomeProtictiveCode();

            /* Exception : 
            //// 1- SystemException 
            /////////////// 1- FormatException
            //////////////  2- IndexOutOfRangeException
            /////////////   3- NullReferenceException
            ////////////    5- ArithmeticException
            //////////////////// 5.1- DivideByZeroException
            ///////////////////  5.2- OverFlowException 
            //// 2- ApplicationException  
            */



            #endregion
        }
    }
}
