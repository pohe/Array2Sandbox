using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int[] intArray = new int[4];
            intArray[0] = 20;
            intArray[1] = 30;
            intArray[2] = 40;
            intArray[3] = 50;
            Console.WriteLine($"På index plads 0 i intArray ligger {intArray[0]}");
            Console.WriteLine($"På index plads 1 i intArray ligger {intArray[1]}");

            //intArray[2] = intArray[3] + 10;
            //intArray[2]++;
            //Console.WriteLine($"På index plads 2 i intArray ligger {intArray[2]}");

            //int [] intArray2 =new int[]{80, 50, 71, 89};

            //intArray2[2] = intArray[2] + 40;
            //Console.WriteLine($"På index plads 2 i intArray2 ligger {intArray2[2]}");

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine($"På index plads {i} i intArray ligger {intArray[i]}");
            //}

            //Console.WriteLine("Loop af intArray bagfra med for loop");
            //for (int i = intArray.Length; i > 0; i--)
            //{
            //    Console.WriteLine($"På index plads {i-1} i intArray ligger {intArray[i-1]}");
            //}
            Console.WriteLine("Loop af intArray med for loop fra index 1");
            for (int i = 1; i < intArray.Length; i++)
            {
                Console.WriteLine($"På index plads {i} i intArray ligger {intArray[i ]}");
            }

            Console.WriteLine("While loop fra index 1");

            int counter = 1;
            while ( counter<intArray.Length )
            {
                Console.WriteLine($"På index plads {counter} i intArray ligger {intArray[counter]}");
                counter++;
            }


            Console.WriteLine("Loop med foreach");
            int h = 0;
            foreach (int x in intArray)
            {
                Console.WriteLine($"På index plads {h++} i intArray ligger {x}");
                //h++;
            }


            string [] names = new string[]{"Sebastian", "Victor", "Tristan", "Nicolai"};

            names[0] = "Magnus";

            Student [] studentArray = new Student[4];
            studentArray[0]= new Student();
            studentArray[1]= new Student("Peter", "2323232");
            studentArray[2] = new Student("Jens", "343434");
            studentArray[3] = new Student("Vibeke", "32323");
            Console.WriteLine("Object array med for loop");
            for (int i = 0; i < studentArray.Length; i++)
            {
                Console.WriteLine($"Navn { studentArray[i].Name } mobile { studentArray[i].Mobile }");
            }
            Console.WriteLine("Object array med for each");
            foreach (Student student in studentArray)
            {
                Console.WriteLine($"Navn { student.Name } mobile { student.Mobile }");
            }

            Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }
}
