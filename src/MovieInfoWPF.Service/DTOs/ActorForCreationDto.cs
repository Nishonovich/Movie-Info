using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfo.Service.DTOs
{
    public class ActorForCreationDto
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Hobby { get; set; } = String.Empty;
        public bool Gender { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
