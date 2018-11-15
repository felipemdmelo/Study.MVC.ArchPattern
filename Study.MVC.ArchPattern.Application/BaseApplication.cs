using System;

namespace Study.MVC.ArchPattern.Application
{
    public abstract class BaseApplication
    {
        public void Notify()
        {
            Console.WriteLine("Enviando email");
        }

        public void Log()
        {
            Console.WriteLine("Escrevendo log");
        }
    }
}
