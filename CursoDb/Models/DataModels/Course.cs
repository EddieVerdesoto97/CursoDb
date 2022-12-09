using System.ComponentModel.DataAnnotations;

namespace CursoDb.Models.DataModels
{

    public enum Level
    {
        Basic,
        Intermediate,
        Advanced
    }
    public class Course: BaseEntity
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]

        public string Description { get; set; } = string.Empty;

        [Required]
        public string fullDescription { get; set; } = string.Empty;

        [Required]
        public string targetAudience { get; set; } = string.Empty;

        [Required]
        public string objectives { get; set; } = string.Empty;

        [Required]
        public string requirements { get; set; } = string.Empty;
        
        [Required]
        public Level level { get; set; } = Level.Basic;

    }
}
