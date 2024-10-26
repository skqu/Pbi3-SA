using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        var logger = new Logger();

        var calculater = new Calc();
        logger.Info(calculater.add(2,2).ToString());
        
    }

}
