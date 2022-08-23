using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Note
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int noteId { get; set; }
        public string notName { get; set; }
        public string noteContent { get; set; }
    }
}
