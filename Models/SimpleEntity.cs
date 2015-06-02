using System.ComponentModel.DataAnnotations;
using Sitecore.EntityServiceBoilerplate.Attributes;
using Sitecore.Services.Core.Model;

namespace Sitecore.EntityServiceBoilerplate.Models
{
    public class SimpleEntity : EntityIdentity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        //Enable this if needed

        //[RandomResult(ErrorMessage = "Randomly retuned an error")]
        public int SomeInt { get; set; }
    }
}