using NLog;
using System;
namespace NLogProject
{
    class Program
    {
        
        static void Main(string[] args)
        {   NLogProject nLog = new NLogProject();
            AddNumbers numbers = new AddNumbers();
            numbers.Sum(10, 40);
        }
    }  
}
