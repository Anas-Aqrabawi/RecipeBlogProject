namespace RecipeBlogProject.Models
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public  string ModifiedBy { get; set; }

        public Boolean IsDeleted { get; set; } = false;

        public int id { get; set; }
        
    }
}
