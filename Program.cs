namespace LiskobSubstitution
{
    public class Document
    {
        private string data;
        private string fileName;
        public void Open()
        {
            throw new NotImplementedException();
        }
    }
    public class Project
    {
        private List<Document> allDocs;
        private List<WritableDocument> writableDocuments;
        public void OpenAll()
        {
            foreach (Document document in allDocs)
            {
                document.Open();
            }
        }
        
        public void SaveAll()
        {
            foreach (WritableDocument document in writableDocuments)
            {
                document.Save();
            }
        }

    }
    public class WritableDocument : Document
    {
        public void Save()
        {
            throw new Exception("Unable to save read-only file.");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Worlds");
        }
    }
    
}
