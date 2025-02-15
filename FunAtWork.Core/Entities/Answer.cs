using FunAtWork.Core.Common;

namespace FunAtWork.Core.Entities
{
    public class Answer : BaseEntity
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public Guid QuestionId { get; set; }

        // Navigation property
        public Question Question { get; set; }
    }
}