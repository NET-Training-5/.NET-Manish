class A
{
    public int x;
}

// Single Inheritance
class B : A // B inherits from A... B is of type A... A is parent of B
{
    public int y;
}

// Multilevel inheritance
class C : B
{
    public int z;
}

// Multiple Inheritance which is not supported in C#
// class D
// {

// }

// class E : B, D
// {

// }

// Multiple Inheritance in C# is achieved through Interface
interface Id
{

}

interface If
{

}

class E : B, Id, If
{

}
