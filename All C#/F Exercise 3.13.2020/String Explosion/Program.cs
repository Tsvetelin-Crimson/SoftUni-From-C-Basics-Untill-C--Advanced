using System;
using System.Text;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(Console.ReadLine());

            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[i] == '>')
                {

                    for (int j = int.Parse(sb[i + 1].ToString()); j > 0; j--)
                    {
                        if (j >= sb.Length - i)
                        {
                            j = sb.Length - i;
                            
                        }
                        else if (sb[i + 1] == '>')
                        {
                            j += int.Parse(sb[i + 2].ToString());
                            i++;
                            sb.Remove(i + 1, 1);
                        }
                        else
                        {
                            sb.Remove(i + 1, 1);
                        }
                    }
                }


            }

            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
