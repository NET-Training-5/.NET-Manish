using System;

interface IShape
{
    public float GetArea();

    public float GetPerimeter();
}
class Reactangle : IShape
{
    public Reactangle(float l, float b)
    {
        length = l;
        width = b;
    }
    float length;
    float width;

    public float GetArea() => length * width;

    public float GetPerimeter() => 2 * (length + width);
}

class Square : Reactangle
{
    float side;

    public Square(float s) : base(s, s)
    {

    }
}

class Circle : IShape
{
    float radius;

    public Circle(float r) => radius = r;

    public float GetArea() => 3.14f * radius * radius;

    public float GetPerimeter() => 2 * 3.14f * radius;
}