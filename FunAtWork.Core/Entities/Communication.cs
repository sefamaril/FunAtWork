using FunAtWork.Core.Common;
using FunAtWork.Infrastructure.Identity;

namespace FunAtWork.Core.Entities
{
    public class Communication : BaseEntity
    {
        public string Subject { get; set; } // Konu
        public string Message { get; set; } // Mesaj
        public List<ApplicationUser> Recipients { get; set; } // Alıcılar
    }
}