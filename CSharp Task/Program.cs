using System;

namespace CSharp_Task;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Key: ");
        string? key = Console.ReadLine();

        DocumentProgram? document = null;

        switch (key.ToLower())
        {
            case "basic":
                document = new DocumentProgram();
                break;
            case "pro":
                document = new ProDocumentProgram();
                break;
            case "expert":
                document = new ExpertDocument();
                break;
            default:
                throw new InvalidDataException();
        }


        document.OpenDocument();
        document.EditDocument();
        document.SaveDocument();
    }
} 
