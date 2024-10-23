namespace GiveStarModels
{
    public class Document
    {
        public int Id { get; set; }
        public string DocumentTypeName { get; set; }
        public bool IsRequired { get; set; }
        public int RequiredParts { get; set; }
        public string Comments { get; set; }

    }
}
