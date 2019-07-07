using System;
using System.Collections.Generic;
using TwoWaySynonyms.Repositories.Synonym;
using TwoWaySynonyms.ViewModels.Synonym;
using System.Linq;

namespace TwoWaySynonyms.Services.Synonym
{
    public class SynonymService : ISynonymService
    {
        private readonly ISynonymRepository synonymRepository;

        public SynonymService(ISynonymRepository synonymRepository)
        {
            this.synonymRepository = synonymRepository;
        }

        public IEnumerable<SynonymItemViewModel> GetAllSynonyms()
        {
            List<SynonymItemViewModel> resultViewModel = new List<SynonymItemViewModel>();
            List<TwoWaySynonyms.Models.Synonym.Synonym> resultModel = this.synonymRepository.GetAll().ToList();

            //Take all words without duplicate
            List<string> allWords = resultModel.Select(x => x.Term).Distinct()
                .Union(resultModel.Select(x => x.Synonyms.Split(",")).SelectMany(x => x).Distinct()).ToList();
            
            allWords.ForEach(x =>
            {
                string term = x;

                //Find all synonyms without duplicate for term
                List<string> synonyms = resultModel.Where(y => y.Term == term)
                    .Select(y => y.Synonyms.Split(",")).SelectMany(y=>y).Distinct()
                    .Union(resultModel.Where(y => y.Synonyms.Split(",").Contains(term)).Select(y => y.Term).Distinct()).ToList();

                resultViewModel.Add(new SynonymItemViewModel()
                {
                    Term = term,
                    Synonyms = synonyms
                });
            });

            return resultViewModel;
        }

       
        public void SaveSyonyms(SynonymViewModel synonym)
        {
            TwoWaySynonyms.Models.Synonym.Synonym model = new Models.Synonym.Synonym()
            {
                Synonyms = synonym.Synonyms,
                Term = synonym.Term
            };
            synonymRepository.SaveSyonyms(model);
        }
    }
}
