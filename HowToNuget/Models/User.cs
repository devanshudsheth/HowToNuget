using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BogusExtensions.Models.Enums;

namespace HowToNuget.Models
{
    /// <summary>
    /// View model for the User. 
    /// Do not show sensitive fields from DtoObject.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public Guid uuid { get; set; }
        public string Avatar { get; set; } 
        public string Gender { get; set; }
    }
}
