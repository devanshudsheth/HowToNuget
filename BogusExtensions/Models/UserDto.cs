using System;
using static BogusExtensions.Models.Enums;

namespace BogusExtensions.Models
{
    public class UserDto
    {
        public UserDto(int userId, string ssn)
        {
            this.Id = userId;
            this.SSN = ssn;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string SomethingUnique { get; set; }
        public Guid uuid { get; set; }

        public string Avatar { get; set; }
        public string SSN { get; set; }
        public Gender Gender { get; set; }

    }
}
