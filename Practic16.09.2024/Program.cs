using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic16._09._2024
{
    internal class Program
    {
        /*Пользователь вводит в строку с клавиатуры логическое
        выражение. Например, 3>2 или 7<3. Программа должна
        посчитать результат введенного выражения 
        и дать результат true или false. В строке могут быть
        только целые числа
        и операторы: <, >, <=, >=, ==, !=. Для обработки ошибок
        ввода используйте механизм исключений.*/
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите что-то");
            string str = Console.ReadLine();
            try
            {
                Console.WriteLine(IsComparison(str));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            /*Console.WriteLine("Ввдеите 2 числа");
            int num1, num2, result = 0;

            try
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                result = num1 / num2;
                if (result % 2 == 1) throw new MyException();
            }
            catch (DivideByZeroException ex) { Console.WriteLine(ex.Message); }
            catch (OverflowException ex) { Console.WriteLine(ex.Message); }
            catch (FormatException ex) {  Console.WriteLine(ex.Message); }
            catch (MyException ex) { Console.WriteLine(ex.Message + " " + ex.TimeException); }
*/
            /*try
            {
                int num = int.MaxValue;
                Console.WriteLine(num);
                checked
                {
                    int res = num + 1;
                    Console.WriteLine(res);
                }
                int res = checked(num + 1);
                Console.WriteLine(res);
                checked
                {
                    short num2 = checked((short)num);
                    Console.WriteLine(num2);
                }
            }
            catch
            {
                Console.WriteLine("Exception");
            }*/


            /*try
            {

            }
            catch (тип_исключения) when (условие){
            
            }
            finally
            {

            }*/

            /*int num1, num2, res = 0;
            try
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                res = DivisionNumbers(num1, num2);
                Console.WriteLine(res);
            }
            catch (Exception ex) when (ex.InnerException != null)
            {
                Console.WriteLine("Исключение на 0" + ex.Message + "\n" + 
                    ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            /*try
            {
                ExampleProperty exProp = new ExampleProperty(null);
                Console.WriteLine(exProp.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/


            /*
             Пользователь вводит в строку с клавиатуры 
            математическое выражение. 
            Например, 3*2*1*4. Программа должна
            посчитать результат введенного выражения. 
            В строке могут быть только целые числа и оператор *. 
            Для обработки
            ошибок ввода используйте механизм исключений.
             */
            string str = Console.ReadLine(); // 3*2*1*4
            string[] arStr = str.Split('*'); // {"3", "2", "1", "4"}
                                             
            try
            {
                checked
                {
                    int res = 1;
                    foreach (string s in arStr)
                    {
                        res *= int.Parse(s);
                    }
                    Console.WriteLine(res);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static int DivisionNumbers(int n1, int n2)
        {
            int res = 0;

            try
            {
                res = n1 / n2;
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("Проверка фильтра исключения", ex);
            }
            return res;
        }
        public static bool IsComparison(string str)
        {
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (str == "1")
                    return num1 < num2;
                else if (str == "2")
                {
                    return num1 > num2;
                }
                else
                {
                    return num1 == num2;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
