using FunAtWork.Core.Common;

namespace FunAtWork.Core.Entities
{
    public class Report : BaseEntity
    {
        public string Type { get; set; } // Rapor Türü
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; } 
        public string ContestType { get; set; } 
        public string ParticipantGroup { get; set; } 
        public string Format { get; set; } // Rapor Formatı
        public string Content { get; set; } // Rapor İçeriği
    }
}