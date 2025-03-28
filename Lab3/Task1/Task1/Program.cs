using System.Text;
using Task1;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Logger consoleLogger = new Logger();
consoleLogger.Log("Це інформаційне повідомлення");
consoleLogger.Error("Це повідомлення про помилку");
consoleLogger.Warn("Це попередження");

FileWriter fileWriter = new FileWriter("logs.txt");
FileLoggerAdapter fileLogger = new FileLoggerAdapter(fileWriter);

fileLogger.Log("Інформаційне повідомлення");
fileLogger.Error("Помилка");
fileLogger.Warn("Попередження");

Console.WriteLine("Логи записані у файлі logs.txt");