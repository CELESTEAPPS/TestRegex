using System.ComponentModel.DataAnnotations;

namespace TestRegex.Models
{
    public class TestViewModel
    {
        [Required]
        public string Text { get; set; }
        public int Option { get; set; }
        public bool Result { get; set; }
    }
}
