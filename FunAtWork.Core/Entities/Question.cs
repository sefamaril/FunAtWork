using FunAtWork.Core.Common;

namespace FunAtWork.Core.Entities
{
    public class Question : BaseEntity
    {
        public string Text { get; set; } // Soru Metni
        public List<Answer> Answers { get; set; } // Cevap Seçenekleri
        public int Points { get; set; } // Puan
        public string DifficultyLevel { get; set; } // Zorluk Düzeyi
        public string Category { get; set; } // Kategori
    }
}