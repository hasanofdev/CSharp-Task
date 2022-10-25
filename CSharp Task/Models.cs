using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task
{
    public class DocumentProgram
    {
        public void OpenDocument() { Console.WriteLine("Document Opened"); }
        public virtual void EditDocument() => Console.WriteLine("Can Edit in Pro and Expert versions");
        public virtual void SaveDocument() => Console.WriteLine("Can Save in Pro and Expert versions");
    }

    public class ProDocumentProgram:DocumentProgram
    {
        public sealed override void EditDocument() => Console.WriteLine("Document Edited");
        public override void SaveDocument() => Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
    }

    public class ExpertDocument: ProDocumentProgram
    {
        public override void SaveDocument() => Console.WriteLine("Document Saved in pdf format");
    }
}
