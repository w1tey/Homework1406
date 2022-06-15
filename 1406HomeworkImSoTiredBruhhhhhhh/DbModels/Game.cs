using _1406HomeworkImSoTiredBruhhhhhhh.Enumerationz;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1406HomeworkImSoTiredBruhhhhhhh.DbModels
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public GameTypes GameType { get; set; }
        [Required]
        public string GameStudio { get; set; }

    }
}
