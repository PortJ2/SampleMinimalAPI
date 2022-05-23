namespace SampleMinimal.Core.Entities
{
    public class Todo : BaseEntity
    {
        public string Item { get; set; }
        public bool Checked { get; set; }
    }
}
