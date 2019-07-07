using System.Collections.Generic;
using TwoWaySynonyms.ViewModels.Synonym;

namespace TwoWaySynonyms.Services.Synonym
{
    public interface ISynonymService
    {
        IEnumerable<SynonymItemViewModel> GetAllSynonyms();
        void SaveSyonyms(SynonymViewModel synonym);
    }
}
