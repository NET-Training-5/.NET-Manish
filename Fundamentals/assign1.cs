class assign1
{
    public void AssignObj1()
    {
        details det1 = new();
        det1.name = "Manish Kumar Tamang";
        det1.adress = "Balkumari";
        det1.age = 23;
        long ph1 = det1.phone();
        Console.WriteLine("--------FIRST ASSIGNMENT STARTED--------");
        Console.WriteLine("---Initialization and Visualization of First Object---");
        det1.detail(det1.name, det1.adress, det1.age, ph1);
        Console.WriteLine("----------------------------------------------------------");
    }

    public void AssignObj2()
    {
        Console.WriteLine("---Initialization and Visualization of Second Object---");
        details det2 = new();
        det2.name = "Sabita Manandhar";
        det2.adress = "Banasthali";
        det2.age = 25;
        long ph2 = det2.phone() + 12345678;
        det2.detail(det2.name, det2.adress, det2.age, ph2);
        Console.WriteLine("--------FIRST ASSIGNMENT COMPLETED--------");
    }
}