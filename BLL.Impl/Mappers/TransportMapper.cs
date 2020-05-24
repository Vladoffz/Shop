using Entities;
using Models;

namespace BLL.Impl
{
    public class TransportMapper
    {
        public TransportDTO TransportToTransportDTO(Transport Transport)
        {
            return new TransportDTO { id = Transport.id, Name = Transport.Name, MaxHeight = Transport.MaxHeight, MaxWeight = Transport.MaxWeight, MaxWidth = Transport.MaxWidth };
        }

        public Transport TransportDTOToTransport(TransportDTO TransportDTO)
        {
            return new Transport();
        }
    }
}