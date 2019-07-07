using System;
using System.Collections.Generic;
using System.Text;

namespace TwoWaySynonyms.Repositories.Synonym
{
    public interface ISynonymRepository
    {
        IEnumerable<TwoWaySynonyms.Models.Synonym.Synonym> GetAll();
        void SaveSyonyms(TwoWaySynonyms.Models.Synonym.Synonym synonym);
    }
}
