using System; 
class methodOverloading { 
  
    public void swap(ref int a, ref int b) 
    { 
       a=a+b;
       b=a-b;
       a=a-b;
        
    } 
  
    public void swap(ref float a, ref float b) 
    { 
       a=a+b;
       b=a-b;
       a=a-b;
       
    } 
  
    // Main Method 
    public static void Main(String[] args) 
    { 
  
        // Creating Object 
        methodOverloading ob = new methodOverloading(); 
       
        int a = 1;
        int b = 2;
        
        Console.WriteLine("Before swaping :"+a+", "+b); 
        ob.swap(ref a, ref b); 
        Console.WriteLine("After swaping :"+a+", "+b); 
        
        float n1= 1.5f;
        float n2= 2.6f;

        Console.WriteLine("Before swaping :"+n1+", "+n2); 
        ob.swap(ref n1, ref n2); 
        Console.WriteLine("After swaping :"+n1+", "+n2); 

  
      
    } 
} 