
public class Rectangle
{
   public int Width;
   public int Height;
   public string Color;
   public Rectangle()
    {
        
    }
    public Rectangle(int width,int height,string color)
    {
        Width=width;
        Height=height;
        Color = color;
    }
    public int GetArea()
    {
        return Width*Height;
    }
    public int GetPerimetr()
    {
        return Width+Height;
    }

}