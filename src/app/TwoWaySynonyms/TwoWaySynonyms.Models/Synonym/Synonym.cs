using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TwoWaySynonyms.Models.Synonym
{
    [Table("Synonym")]
    public class Synonym
    {
        [Key]
        public int Id { get; set; }
        public string Term { get; set; }
        public string Synonyms { get; set; }
    }
}
