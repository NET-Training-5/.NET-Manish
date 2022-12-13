class Generic
{
    // public void PrintDetails(string message)
    // {
    //     Console.WriteLine(message);
    // }

    // public void PrintDetails(char message)
    // {
    //     Console.WriteLine(message);
    // }

    public void PrintDetails<T>(T message) // This is called Generic.. Which means not only arguments but data type can also be user defined, which solves excess requirement of method oveloading.
    {
        Console.WriteLine(message);
    }
}