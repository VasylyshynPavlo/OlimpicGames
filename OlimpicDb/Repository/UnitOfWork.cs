using OlimpicDb.Data;
using OlimpicDb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicDb.Repository
{
    public interface IUoW
    {
        IRepository<Country> CountryRepo { get; }
        IRepository<OlimpicGame> OlimpicGameRepo { get; }
        IRepository<Place> PlaceRepo { get; }
        IRepository<Player> PlayerRepo { get; }
        IRepository<Sport> SportRepo { get; }
        IRepository<Statistic> StatisticRepo { get; }
        void Save();
    }

    public class UnitOfWork : IUoW, IDisposable
    {
        private static OlimpicDbContext context = new OlimpicDbContext();
        private IRepository<Country>? countryRepo = null;
        private IRepository<OlimpicGame>? olimpicGame = null;
        private IRepository<Place>? placeRepo = null;
        private IRepository<Player>? playerRepo = null;
        private IRepository<Sport>? sportRepo = null;
        private IRepository<Statistic>? statisticRepo = null;
        // ...others repositories

        public IRepository<Country> CountryRepo
        {
            get
            {

                if (this.countryRepo == null)
                {
                    this.countryRepo = new Repository<Country>(context);
                }
                return countryRepo;
            }
        }
        public IRepository<OlimpicGame> OlimpicGameRepo
        {
            get
            {

                if (this.olimpicGame == null)
                {
                    this.olimpicGame = new Repository<OlimpicGame>(context);
                }
                return olimpicGame;
            }
        }
        public IRepository<Place> PlaceRepo
        {
            get
            {

                if (this.placeRepo == null)
                {
                    this.placeRepo = new Repository<Place>(context);
                }
                return placeRepo;
            }
        }
        public IRepository<Player> PlayerRepo
        {
            get
            {

                if (this.playerRepo == null)
                {
                    this.playerRepo = new Repository<Player>(context);
                }
                return playerRepo;
            }
        }
        public IRepository<Sport> SportRepo
        {
            get
            {

                if (this.sportRepo == null)
                {
                    this.sportRepo = new Repository<Sport>(context);
                }
                return sportRepo;
            }
        }
        public IRepository<Statistic> StatisticRepo
        {
            get
            {

                if (this.statisticRepo == null)
                {
                    this.statisticRepo = new Repository<Statistic>(context);
                }
                return statisticRepo;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
