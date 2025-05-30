using System.ComponentModel.DataAnnotations;

namespace MyProject.Model
{
    public class Trainer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Pokemon Companion { get; set; }
    }
}