using FunAtWork.Core.Common;

namespace FunAtWork.Core.Entities
{
    public class Contest : BaseEntity
    {
        public string Name { get; set; }
        public string Organizer { get; set; } // Düzenleyen (Department/Company)
        public string Description { get; set; }
        public Guid ContestTypeId { get; set; } // Yarışma Türü ID
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ContestDate { get; set; }
        public string Location { get; set; }
        public string ParticipationCriteria { get; set; } // Katılım Şartları
        public int ParticipantCount { get; set; } // Katılımcı Sayısı
        public decimal ParticipationFee { get; set; } // Katılım Ücreti
        public string EvaluationCriteria { get; set; } // Değerlendirme Kriterleri
        public string ScoringSystem { get; set; }
        public string Awards { get; set; }
        public string ContactInfo { get; set; }

        // Navigation property
        public ContestType ContestType { get; set; }
    }
}