namespace Exam1;


public class Q1_Add
{
    public static int Add(int a,int b)
    {
        return a+b;
    }
}

public class Basics
{
    public static void  Q2MultiplyAndReset(ref int  a ,ref int b)
    {
       a *= b;
       b = 1;
    }

    public static void Q5TryCatchFinally(bool s ,  List<string>? log ,bool n=true)
    {
       if (s== false){
        try{
            
        }
        catch(Exception e)
        {
            throw new System.InvalidOperationException();
        }
        finally
        {

        }}
        
    }
}


public struct Type1
{
    public int Count=0;

    public Type1()
    {

    }
}


public class Type2
{
    public int Count=0;
    
}


public class Q4Person
{
    public string Name{get;set;}
    public int Age{get;set;}
    public Q4Person(string name,int age)
    {
        Name= name;
        Age= age;
    }


    public string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old.";
    }
}


public class Q6Temperature
{
    private double c;
    public double Celsius
    {
        get{return c;}
        set
        {
            c= value;
            f = (value*9/5)+32;
        }
    }
    private double f;
    public double Fahrenheit
    {
        get{return f;}
        set
        {
            f= value;
            c = (value-32)*5/9;

        }
    }
    public Q6Temperature()
    {
        
    }


}


public interface IShape
{
    public double GetArea()
    {
        return 2;
    }
    public double GetPerimeter()
    {
        return 2;
    }

}


public class Q7Circle :IShape
{
    public double r;

    public double GetArea()
    {
        return r*r*Math.PI;
    }
    public double GetPerimeter()
    {
        return r*2*Math.PI;
    }
    public Q7Circle(double a)
    {
        r=a;
    }

}


public class Q7Rectangle:IShape
{
    public double w;
    public double h;

    public double GetArea()
    {
        return w*h;
    }
    public double GetPerimeter()
    {
        return 2*(w+h);
    }
    public Q7Rectangle(double w1,double h2)
    {
        w= w1;
        h= h2;
    }

}

public class ShapeUtils
{
    public IShape[] shapes;

    public ShapeUtils( IShape[] shape)
    {
        shapes= shape;
    }
    public  static double Q7TotalArea(IShape[] sha)
    {
        double total =0;
        foreach(var sh in sha)
        {
            total+= sh.GetArea();
        }
        return total;
    }
}