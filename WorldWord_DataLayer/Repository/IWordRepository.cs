using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWord_DataLayer.Repository
{
    public interface IWordRepository
    {
        List<Words> GetAllWords();
        IEnumerable<Words> SearchWords(string Parameter);
        Words GetWordsbyID(int IDWord);
        bool InsertWords(Words words);
        bool UpdateWords(Words words);
        bool DeleteWords(Words words);
        bool DeleteWords(int IDWord);
    }
}
