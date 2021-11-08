using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using WorldWord_DataLayer.Repository;

namespace WorldWord_DataLayer.Services
{
    public class WordRepository : IWordRepository
    {
        private WorldWordEntities db;
        public WordRepository(WorldWordEntities context)
        {
            db = context;
        }

        public List<Words> GetAllWords()
        {
            return db.Words.ToList();
        }

        public IEnumerable<Words> SearchWords(string Parameter)
        {
            return db.Words.Where(S => S.Word.Contains(Parameter) || S.Translation.Contains(Parameter)).ToList();
        }

        public Words GetWordsbyID(int IDWord)
        {
            return db.Words.Find(IDWord);
        }

        public bool InsertWords(Words words)
        {
            try
            {
                db.Words.Add(words);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateWords(Words words)
        {
            var loca = db.Set<Words>().Local.FirstOrDefault(E => E.IDWord == words.IDWord);
            if (loca != null)
            {
                db.Entry(loca).State = EntityState.Deleted;
            }
            db.Entry(words).State = EntityState.Modified;
            return true;
        }

        public bool DeleteWords(Words words)
        {
            try
            {
                db.Entry(words).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteWords(int IDWord)
        {
            try
            {
                var word = GetWordsbyID(IDWord);
                DeleteWords(word);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
