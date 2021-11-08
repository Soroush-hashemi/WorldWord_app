using System;
using WorldWord_DataLayer.Repository;
using WorldWord_DataLayer.Services;

namespace WorldWord_DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        WorldWordEntities DB = new WorldWordEntities();

        private IWordRepository _wordRepository;

        public IWordRepository WordRepository
        {
            get
            {
                if (_wordRepository == null)
                {
                    _wordRepository = new WordRepository(DB);
                }   
                return _wordRepository;
            }
        }

        private ILeanedInterface _learnrepository;
        public ILeanedInterface Learnrepository
        {
            get
            {
                if (_learnrepository == null)
                {
                    _learnrepository = new LearnedRepository(DB);
                }
                return _learnrepository;
            }
        }

        public void Save()
        {
            DB.SaveChanges();
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
