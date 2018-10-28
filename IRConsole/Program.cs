using IRCalculator;
using IRConsole.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Taxpayer> list = new List<Taxpayer>();

            double _minumimWage;
            while (true)
            {
                Taxpayer taxpayer = new Taxpayer();

                Console.Write("Digite o CPF: ");
                taxpayer.CPF = Console.ReadLine();
                if (taxpayer.CPF.Equals("0"))
                {
                    Console.Clear();
                    if (list.Count > 0)
                        break;
                    else
                        continue;
                }

                Console.Write("Digite o nome completo: ");
                taxpayer.Name = Console.ReadLine();

                Console.Write("Número de dependentes: ");
                taxpayer.NumberOfDependents = WriteOnlyNumbersMaxValueInteger();

                Console.Write("Renda bruta mensal: R$ ");
                taxpayer.GrossIncome = WriteOnlyCoin();

                Console.Clear();

                list.Add(taxpayer);
            }

            Console.Write("Valor salário mínimo: R$ ");
            _minumimWage = WriteOnlyCoin();

            Console.Clear();

            CalculateIncomeTax incomeTax = new CalculateIncomeTax(_minumimWage);

            foreach (Taxpayer taxpayer in list)
            {
                taxpayer.AmountToPay = incomeTax.AmountToPay(taxpayer.GrossIncome, taxpayer.NumberOfDependents);
            }

            foreach (Taxpayer taxpayer in list.OrderBy(x => x.AmountToPay).ThenBy(y => y.Name))
            {
                Console.WriteLine(taxpayer.ToString());
            }

            Console.ReadKey();
        }

        private static double WriteOnlyCoin()
        {
            string text = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool isDouble = double.TryParse(key.KeyChar.ToString(), out val);
                    if ((isDouble && Convert.ToDouble(text + key.KeyChar) <= Double.MaxValue))
                    {
                        text += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                    else if ((key.KeyChar == ',' || key.KeyChar == '.') && !text.Contains("."))
                    {
                        text += '.';
                        Console.Write(',');
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && text.Length > 0)
                    {
                       text = text.Substring(0, (text.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter || string.IsNullOrEmpty(text));
            Console.WriteLine();
           return double.Parse(text, CultureInfo.GetCultureInfo("en-US"));
        }

        private static int WriteOnlyNumbersMaxValueInteger()
        {
            string text = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool isDouble = double.TryParse(key.KeyChar.ToString(), out val);
                    if (isDouble && Convert.ToDouble(text + key.KeyChar) <= Int32.MaxValue)
                    {
                        text += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && text.Length > 0)
                    {
                        text = text.Substring(0, (text.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter || string.IsNullOrEmpty(text));
            Console.WriteLine();
            return Convert.ToInt32(text);
        }

        private static int ValidateCPF()
        {
            string text = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool isDouble = double.TryParse(key.KeyChar.ToString(), out val);
                    if (isDouble && Convert.ToDouble(text + key.KeyChar) <= Int32.MaxValue)
                    {
                        text += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && text.Length > 0)
                    {
                        text = text.Substring(0, (text.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter || string.IsNullOrEmpty(text));
            Console.WriteLine();
            return Convert.ToInt32(text);
        }
    }
}
