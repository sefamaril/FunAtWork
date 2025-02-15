namespace FunAtWork.Core.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}