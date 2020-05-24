using Entities;
using Models;

namespace BLL.Impl
{
    public class DestinationMapper
    {
        public DestinationDTO DestinationToDestinationDTO(Destination destination)
        {
            return new DestinationDTO { Distance = destination.Distance, id = destination.id, Name = destination.Name };
        }

        public Destination DestinationDTOToDestination(DestinationDTO destinationDTO)
        {
            return new Destination();
        }
    }
}