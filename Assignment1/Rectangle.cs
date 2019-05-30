using System;

public class Rectangle
{
    private int length;
    private int width;
	public Rectangle()
	{
        length = 1;
        width = 1;
	}
    //set value to properties based on user input
    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }
    //return length
    public int GetLength()
    {
        return length;
    }
    //set value of length
    public int SetLength(int length)
    {
        this.length = length;
        return this.length;
    }
    //return width
    public int GetWidth()
    {
        return width;
    }
    //set value of width
    public int SetWidth(int width)
    {
        this.width = width;
        return this.width;
    }
    //calculate perimeter of the rectangle
    public int GetPerimeter()
    {
        return 2 * (length + width);
    }
    //calculate area of the rectangle
    public int GetArea()
    {
        return length * width;
    }
}