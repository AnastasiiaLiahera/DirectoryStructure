using System.ComponentModel.DataAnnotations;

namespace DirectoryStructure.Models
{
    public class Directory
    {
        [Key]
        public string? DirId { get; set; }
        [Required]
        public string? DirName { get; set; }
    }
}
