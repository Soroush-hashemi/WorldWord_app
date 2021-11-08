using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using WorldWord_DataLayer.Repository;

namespace WorldWord_DataLayer.Services
{
    public class LearnedRepository : ILeanedInterface
    {
        private WorldWordEntities db;

        public LearnedRepository(WorldWordEntities context)
        {
            db = context;
        }

        public List<learned> GetAllWords()
        {
            return db.learned.ToList();
        }

        public IEnumerable<learned> SearchWords(string Parameter)
        {
            return db.learned.Where(S => S.Translation.Contains(Parameter) || S.Word.Contains(Parameter)).ToList();
        }

        public bool DeleteWords(learned words)
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

        public learned GetWordsbyID(int IDWord)
        {
            return db.learned.Find(IDWord);
        }

        public bool InsertWordstolearn(learned learned)
        {
            try
            {
                db.learned.Add(learned);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateWords(learned words)
        {
            var loca = db.Set<learned>().Local.FirstOrDefault(E => E.IDWord == words.IDWord);
            if (loca != null)
            {
                db.Entry(loca).State = EntityState.Deleted;
            }
            db.Entry(words).State = EntityState.Modified;
            return true;
        }
    }
}
