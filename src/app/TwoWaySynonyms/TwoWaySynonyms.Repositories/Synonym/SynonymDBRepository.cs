using System;
using System.Collections.Generic;
using System.Text;
using TwoWaySynonyms.Models.Synonym;
using System.Linq;

namespace TwoWaySynonyms.Repositories.Synonym
{
    public class SynonymDBRepository : ISynonymRepository
    {
        private SynonymContext synonyContext;

        public SynonymDBRepository(SynonymContext synonyContext)
        {
            this.synonyContext = synonyContext;
        }

        public IEnumerable<Models.Synonym.Synonym> GetAll()
        {
            return synonyContext.Synonyms.ToList();
        }

        public void SaveSyonyms(Models.Synonym.Synonym synonym)
        {
            synonyContext.Synonyms.Add(synonym);
            synonyContext.SaveChanges();
        }
    }
}
