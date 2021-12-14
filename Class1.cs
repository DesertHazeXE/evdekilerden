using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class homework16
    {
        public void L1()
        {
            Console.WriteLine("Qiymetin uzerinde hesablama aparin");
            double result = 0;
            Console.Write("Ededi daxil edin: ");
            double y = int.Parse(Console.ReadLine());

            Console.Write("riyazi isareleri daxil edin: ");
            char exe = char.Parse(Console.ReadLine());

            Console.Write("Ededi daxil edin: ");
            double z = int.Parse(Console.ReadLine());



            switch (exe)

            {

                case '*':
                    result = y + z;
                    Console.WriteLine($"Answer:{y}*{z}=" + result);break;
                case '/':
                    result = y - z;
                    Console.WriteLine($"Answer:{y}/{z}=" + result);break;
                case '+':
                    result = y * z;
                    Console.WriteLine($"Answer:{y}+{z}=" + result);break;
                case '-':
                    result = y / z;
                    Console.WriteLine($"Answer:{y}-{z}=" + result);break;

                default:
                    Console.WriteLine("Emeliyyat duzgun yerine yetirilmeyib.");
                    break;

            }
            Console.ReadLine();

        }
    }
}     
