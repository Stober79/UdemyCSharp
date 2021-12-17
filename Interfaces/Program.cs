using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Interfaces
{
    class Program
    {
        public static ILogger GetLogger() => new ConsolLogger();
        public static void Main(string[] args)
        {
            var logger = GetLogger(); 
            logger.LogMessage("wiadamość");
            logger.LogMessage("wiadomość Krytyczna", LogLevel.Critical);
            //Poniżej Dependency Injection
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<ILogger, FileLogger>();
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsetings.json", true);
            var configuration = configurationBuilder.Build();
            serviceCollection.AddSingleton<IConfiguration>(configuration);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var logger2 = serviceProvider.GetService<ILogger>();    
        }
    }
    

    public interface ILogger//wszystkie metody i zmienne w interfejsie się publiczne dlatego nie wstawiamy już public
    {
        LogLevel LogLevel { get; set; }
        void LogMessage(string message, LogLevel logLevel = LogLevel.Verbose);//nie podajemy ciała funkcji ponieważ klasa która to będzie implementować musi to zapewnić
    }
    public class ConsolLogger : ILogger
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Debug;

        public void LogMessage(string message, LogLevel logLevel = LogLevel.Verbose)
        {
            if (LogLevel > logLevel)
            {
                return;
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
    public class FileLogger : ILogger
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Verbose;

        public void LogMessage(string message, LogLevel logLevel = LogLevel.Debug)
        {
            if (LogLevel > logLevel)
                return;
            File.AppendAllText("logs.txt", message+Environment.NewLine);//Environment.NewLine powoduje że tekst zostanie dodany od nowej linii
        }
    }
    public  enum LogLevel
    {
        Verbose=0,
        Debug=1,
        Critical=2
    }
}
