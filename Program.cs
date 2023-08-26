namespace HomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 1;           
            string input = "CodeAcademy is a good place to study";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}