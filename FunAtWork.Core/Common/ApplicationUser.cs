using Microsoft.AspNetCore.Identity;

namespace FunAtWork.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyCode { get; set; }
        public string DepartmentCode { get; set; }
        public string? ProfilePictureUrl { get; set; }
    }
}