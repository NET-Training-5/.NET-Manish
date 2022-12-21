// Parallel Programming - Multithreading, Task-based (TPL-Task Parallel Library)
// Asynchronous Programing - async/awit

class ParallelAndAsync
{
    public void WriteParallelCode()
    {
        // Sequential Loop
        for (byte i = 1; i < 11; i++)
        {

            DoTask(i);
        }

        // Parallel loop
        Console.WriteLine("Parallel: ");
        Parallel.For(1, 11, i => DoTask(i));
    }

    void DoTask(int counter)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Doone with task {counter}");
    }

    // CW - Create Collection of 20 large enough integrals, write an implementation to find 
    // out if those numbers are prime or not.

    //Assign values to an array
    // int[] nums = { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41 };

    long[] nums = { 34567893, 908765435, 32456787, 0987659, 32456789011, 98765432456713, 56789765415, 89765435678917, 3456789765419, 27865467891, 56789765423, 9876543567825, 456789765427, 9876578978629, 3456789765431, 9876578933, 786546789035, 876546789037, 765435678939, 876543245678941 };
    public void PrimalityTest()
    {
        Console.WriteLine("Sequential: ");
        foreach (var item in nums)
        {
            var p = isPrime(item) ? "Prime" : "Composite";
            Console.WriteLine($"{item} is {p}");
        }

        Console.WriteLine("Parallel: ");
        Parallel.ForEach(nums, (item) =>
        {
            var p = isPrime(item) ? "Prime" : "Composite";
            Console.WriteLine($"{item} is {p}");
        });
    }


    bool isPrime(long n) //Method to check prime numbers
    {
        Thread.Sleep(500);
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }


    // public void IterateInArray()
    // {
    //     Console.WriteLine("*********Pick prime numbers from the given array *********************\n");
    //     int j;
    //     //Iterate through the items of array
    //     for (int i = 0; i < nums.Length; i++)
    //     {

    //         // see if num is evenly divisible
    //         for (j = 2; j < nums[i]; j++)
    //             if ((nums[i] % j == 0))
    //             {
    //                 // num is evenly divisible -- not prime
    //                 Console.WriteLine("{0} : Is NOT a primenumber", +nums[i]);
    //                 break;
    //             }
    //         if (j == nums[i])
    //         {
    //             Console.WriteLine("{0} : Is a primenumber", +nums[i]);

    //         }

    //     }

    public async Task<string> WriteAsyncCode()
    {
        // Non Blocking code
        await Download();
        return "Success";
    }

    async Task Download()
    {
        await Task.Delay(1000);
    }

}




