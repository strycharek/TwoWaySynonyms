using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TwoWaySynonyms.Repositories.Synonym;
using TwoWaySynonyms.Services.Synonym;
using TwoWaySynonyms.ViewModels.Synonym;
using System.Linq;


namespace TwoWaySynonyms.Services.Test.Synonym
{
    [TestFixture]
    public class SynonymTest
    {
        [Test]
        public void GetAllTest()
        {
            Mock<ISynonymRepository> mock = new Mock<ISynonymRepository>();
            mock.Setup(m => m.GetAll()).Returns(new List<Models.Synonym.Synonym>()
            {
                new Models.Synonym.Synonym()
                {
                     Term="computer",
                      Synonyms="laptop,notebook"
                },
                new Models.Synonym.Synonym()
                {
                     Term="computer",
                      Synonyms="workstation"
                },
                new Models.Synonym.Synonym()
                {
                     Term="computer",
                      Synonyms="notebook,pc"
                },
                new Models.Synonym.Synonym()
                {
                     Term="notebook",
                     Synonyms="computer,portable-computer"
                }
            });
            SynonymService synonymService = new SynonymService(mock.Object);


            List<SynonymItemViewModel> result = synonymService.GetAllSynonyms().ToList();


            CollectionAssert.AreEquivalent(result.Where(x => x.Term == "computer").Single().Synonyms.ToList(),
                new List<string>()
                {
                    "laptop",
                    "notebook",
                    "workstation",
                    "pc"
                });
            CollectionAssert.AreEquivalent(result.Where(x => x.Term == "laptop").Single().Synonyms.ToList(),
                new List<string>()
                {
                    "computer"
                });
            CollectionAssert.AreEquivalent(result.Where(x => x.Term == "notebook").Single().Synonyms.ToList(),
                new List<string>()
                {
                    "portable-computer",
                    "computer"
                });
            CollectionAssert.AreEquivalent(result.Where(x => x.Term == "workstation").Single().Synonyms.ToList(),
               new List<string>()
               {
                    "computer"
               });
            CollectionAssert.AreEquivalent(result.Where(x => x.Term == "pc").Single().Synonyms.ToList(),
               new List<string>()
               {
                    "computer"
               });
            CollectionAssert.AreEquivalent(result.Where(x => x.Term == "portable-computer").Single().Synonyms.ToList(),
               new List<string>()
               {
                    "notebook"
               });
        }
    }
}
