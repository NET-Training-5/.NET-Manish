class Person
{
    // members: methods, fields
    public string fullName;
    public DateTime dob;
    public string address;
    public char gender;
    public float height, weight;
    public double GetAge()
    {
        var ageSpan = DateTime.Now - dob;
        var ageYears = ageSpan.TotalDays / 365;
        return ageYears;
    }

    //public double FindBMI() => weight / (height * height); // Expression Bodied Member
    public double FindBMI()
    {
        double heightInMtrs = height / 39.37;
        return weight / (heightInMtrs * heightInMtrs);
    }
}