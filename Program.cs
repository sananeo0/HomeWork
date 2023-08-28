namespace HomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string input = "CodeAcademy is a good place to study ";
            string[] inputNew=input.Split(' ');

             foreach (string s in inputNew)
             {
                if (!string.IsNullOrWhiteSpace(s))  
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}