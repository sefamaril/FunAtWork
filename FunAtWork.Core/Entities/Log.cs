using FunAtWork.Core.Common;
using FunAtWork.Infrastructure.Identity;

namespace FunAtWork.Core.Entities
{
    public class Log : BaseEntity
    {
        public string Action { get; set; } // İşlem
        public ApplicationUser User { get; set; } // Kullanıcı
        public DateTime Timestamp { get; set; } // Zaman Damgası
    }
}