using System.ComponentModel.DataAnnotations;

namespace WebAppMVC_Nilesh.Models
{
    public class CurdModel
    {
        [Key]
        public int Id { get; set; }  // pk and auto incement
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public DateTime DoB { get; set; }
        public string gender { get; set; }
        public string Dept { get; set; }
        public decimal Salary { get; set; }
        public bool Status { get; set; }
        public string Address { get; set; }

    }
}
