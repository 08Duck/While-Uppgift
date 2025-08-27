using System.Threading.Channels;

namespace While_Uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fianl Version
            bool running = true;
            char[] allInputs = new char[100];
            int[] theAmount = new int[100];
            for(int i = 0; i <= 99; i++)
            {
                theAmount[i] = 1;
            }
            while (running)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    running = false;
                    break;
                }

                char inputs = keyInfo.KeyChar;
                Console.Clear();

                
                for(int i = 0; i <= 99; i++)
                {
                    if(inputs == allInputs[i])
                    {
                        theAmount[i]++;
                        break;
                    }
                    else
                    {
                        if (allInputs[i] == '\0')
                        {
                            allInputs[i] = inputs;
                            break;
                        }   
                        
                    }
                }

               for(int i = 0; i <= 99; i++)
                {
                    if (allInputs[i] == '\0')
                    {
                      
                    }
                    else
                    {
                        Console.WriteLine(allInputs[i] + ": " + theAmount[i]);
                        
                    }
                }

            }
        }
    }
}
