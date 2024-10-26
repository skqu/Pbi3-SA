class Program
{
    static void Main(string[] args)
    {
        var logger = new Logger();

        logger.Info("This is an info message.");
        logger.Warning("This is a warning message.");
        logger.Error("This is an error message.");
    }
}
