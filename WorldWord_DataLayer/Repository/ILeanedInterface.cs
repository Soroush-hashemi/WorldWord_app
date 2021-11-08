using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWord_DataLayer.Repository
{
    public interface ILeanedInterface
    {
        List<learned> GetAllWords();
        IEnumerable<learned> SearchWords(string Parameter);
        learned GetWordsbyID(int IDWord);
        bool InsertWordstolearn(learned IDWord);
        bool UpdateWords(learned words);
        bool DeleteWords(learned words);
        bool DeleteWords(int IDWord);
    }
}
