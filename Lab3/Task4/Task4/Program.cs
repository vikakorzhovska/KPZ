using Task4.Proxy;
using Task4;
using System.IO;

IService reader = new SmartTextReader();

IService checker = new SmartTextChecker(reader);

IService locker = new SmartTextReaderLocker(checker, @"^.*\.txt$");

locker.ReadText("test.txt");  
locker.ReadText("restricted_file.pdf"); 