namespace SampleMinimal.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
