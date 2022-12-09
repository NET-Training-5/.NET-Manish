class Vehicle
{
    // KISS - Keep It Simple Stupid

    //string model;
    public string Model { get; set; } // Auto-implemented Property
    public string color { get; } = "Red";
    public long serialNumber;

    string brand;

    public string Brand // Full property definition
    {
        get
        {
            return brand;
        }

        set
        {
            if (value.Length > 2)
            {
                brand = value;
            }

        }
    }

    public void PrintDetails()
    {
        var details = $"Brand: {brand}, Model: {Model}, Color Code: {color}, Serial Number: {serialNumber}";
        Console.WriteLine(details);
    }
}