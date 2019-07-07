using System;
using System.Collections.Generic;
using System.Text;

namespace TwoWaySynonyms.ViewModels.Synonym
{
    public class SynonymItemViewModel
    {
        public string Term { get; set; }
        public IEnumerable<string> Synonyms { get; set; }
    }
}
