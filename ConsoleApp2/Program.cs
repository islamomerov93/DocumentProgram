using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter keyword (basic,pro,expert) for program mode  :  ");
                var keyWord = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(keyWord)) throw new ArgumentNullException();
                ProgramMode(keyWord);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static public void ProgramMode(string keyWord)
        {
            DocumentProgram DP;
            switch (keyWord)
            {
                case "basic":
                    DP = new DocumentProgram();
                    DP.OpenDOcument();
                    DP.EditDocument();
                    DP.SaveDocument();
                    break;
                case "pro":
                    DP = new ProDocumentProgram();
                    DP.OpenDOcument();
                    DP.EditDocument();
                    DP.SaveDocument();
                    break;
                case "expert":
                    DP = new ExpertDocumentProgram();
                    DP.OpenDOcument();
                    DP.EditDocument();
                    DP.SaveDocument();
                    break;
                default:
                    Console.WriteLine("Invalid choice !");
                    break;
            }
        }
    }
    class DocumentProgram
    {
        public void OpenDOcument()
        {
            Console.WriteLine("Document opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
    class ProDocumentProgram : DocumentProgram
    {
        public void OpenDOcument()
        {
            Console.WriteLine("Document opened");
        }
        public sealed override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format (For pdf format buy Expert pack)");
        }
    }
    class ExpertDocumentProgram : ProDocumentProgram
    {
        public void OpenDOcument()
        {
            Console.WriteLine("Document opened");
        }
        public void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
