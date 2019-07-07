using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TwoWaySynonyms.ViewModels.Synonym
{
    public class SynonymViewModel
    {
        [Required]
        public string Term { get; set; }
        [Required]
        public string Synonyms { get; set; }
    }
}
