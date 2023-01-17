namespace CSharpFundamentals

{

    class Arrays

    {

        static void Main(string[] args)

        {

            var numbers = new int[] {3, 7, 9, 2, 14, 6};



            // Length

            Console.WriteLine("Length: " + numbers.Length);



            // IndexOf()

            var index = Array.IndexOf(numbers, 9); //(array_name , element )

            Console.WriteLine("Index of 9: " + index);



            // Clear()



            Array.Clear(numbers, 2, 3); //(array_name,index_num,num_of_elements you want to delete after this position)



            Console.WriteLine("Effect of Clear()");

            foreach(var n in numbers)

                Console.WriteLine(n);



            // Copy()

            int[] another = new int[3];

            Array.Copy(numbers, another, 3); //(source array, destination array, num of elements you want to copy)



            Console.WriteLine("Effect of Copy()");

            foreach(var n in another)

                Console.WriteLine(n);    



            // Sort()

            Array.Sort(numbers);



            Console.WriteLine("Effect of Sort()");

            foreach(var n in numbers)

                Console.WriteLine(n);



            // Reverse()

            Array.Reverse(numbers);



            Console.WriteLine("Effect of Reverse()");

            foreach(var n in numbers)

                Console.WriteLine(n);  

        }

    }

}