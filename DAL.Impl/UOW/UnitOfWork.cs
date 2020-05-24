using Entities;

namespace DAL.Impl
{
    public class UnitOfWork
    {
        Context context = new Context();
        private GoodRepository goodRepository;
        private TransportRepository transportRepository;
        private DestinationRepository destinationRepository;

        public GoodRepository GoodRepository
        {
            get
            {
                if (goodRepository == null)
                {
                    goodRepository = new GoodRepository(context);
                }

                return goodRepository;
            }
        }

        public TransportRepository TransportRepository
        {
            get
            {
                if (transportRepository == null)
                {
                    transportRepository = new TransportRepository(context);
                }

                return transportRepository;
            }
        }

        public DestinationRepository DestinationRepository
        {
            get
            {
                if (destinationRepository == null)
                {
                    destinationRepository = new DestinationRepository(context);
                }

                return destinationRepository;
            }
        }



        public void Save()
        {
            context.SaveChanges();
        }
    }
}