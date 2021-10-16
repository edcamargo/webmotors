using WebMotors.Domain.Core.Interfaces.Repositories;
using WebMotors.Domain.Entities;
using WebMotors.InfraStructure.Data.Context;

namespace WebMotors.InfraStructure.Data.Repositories
{
    public class AnnouncementWebMotorsRepository : RepositoryBase<AnnouncementWebmotors>, IAnnouncementWebMotorsRepository
    {
        public AnnouncementWebMotorsRepository(DataContext dataContext) : base(dataContext)
        { }
    }
}