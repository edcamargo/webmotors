using WebMotors.Domain.Core.Interfaces.Repositories;
using WebMotors.Domain.Core.Interfaces.Services;
using WebMotors.Domain.Entities;

namespace WebMotors.Domain.Services.Services
{
    public class AnnouncementWebMotorsService : ServiceBase<AnnouncementWebMotors>, IAnnouncementWebMotorsService
    {
        public readonly IAnnouncementWebMotorsRepository _announcementWebmotorsRepository;

        public AnnouncementWebMotorsService(IAnnouncementWebMotorsRepository announcementWebmotorsRepository) : base(announcementWebmotorsRepository)
        {
            _announcementWebmotorsRepository = announcementWebmotorsRepository;
        }
    }
}