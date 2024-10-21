public class Program {
    static void Main(string[] args) {
  
        float num1 = float.Parse(Console.ReadLine());


        switch (num1) {
            case 0:
            Console.WriteLine("zero");            
            break;
            case 1:
            Console.WriteLine("one");            
            break;
            case 2:
            Console.WriteLine("two");            
            break;
            case 3:
            Console.WriteLine("three");            
            break;
            case 4:
            Console.WriteLine("four");            
            break;
            case 5:
            Console.WriteLine("five");           
            break;
            case 6:
            Console.WriteLine("six");           
            break;
            case 7:
            Console.WriteLine("seven");            
            break;
            case 8:
            Console.WriteLine("eight");            
            break;
            case 9:
            Console.WriteLine("nine");
            break;
            case 10:
            Console.WriteLine("ten");
            break;
            default:
            Console.WriteLine("your number is not 0-10 or it is a decimal.");
            break;
        }

    }
}
