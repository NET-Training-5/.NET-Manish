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


}

