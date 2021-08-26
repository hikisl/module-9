using System;



namespace task1
{
    class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var exception = new Exception[]
            {
                new IndexOutOfRangeException(),
                 new InvalidOperationException(),
                  new ArgumentOutOfRangeException(),
                   new ArgumentNullException(),
                    new MyException("Упс, что-то пошло не так!")

            };

            foreach (var item in exception)
            {
                try
                {
                    throw item;
                }

                catch (Exception ex) when (ex is IndexOutOfRangeException)
                {
                    Console.WriteLine("Индекс находится за пределами границ массива или коллекции");
                    Console.WriteLine(ex.Message);
                }

                catch(Exception ex) when (ex is InvalidOperationException)
                {
                    Console.WriteLine("Вызов метода недопустим в текущем состоянии объекта");
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex)  when (ex is ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Аргумент находится за пределами диапазона допустимых значений.");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex) when (ex is ArgumentNullException)
                {
                    Console.WriteLine("	Аргумент, передаваемый в метод — null.");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex) when (ex is MyException)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
