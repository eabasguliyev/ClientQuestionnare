using System.Collections.Generic;
using WinformsTask2.Abstracts;

namespace WinformsTask2.Entities
{
    public class Worker:Human
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string CompanyName { get; set; }
        public string Industry { get; set; }

        public IList<string> Languages { get; set; }

        public Worker()
        {
            Languages = new List<string>();
        }
    }
}