using Microsoft.AspNetCore.Components.Forms;
using System.Data;

namespace AspNet.MVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DOB { get; set; }
    }
}
