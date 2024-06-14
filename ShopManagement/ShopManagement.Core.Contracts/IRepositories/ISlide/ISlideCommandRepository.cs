using ShopManagement.Core.Domain.SlideAgg.Entities;

namespace ShopManagement.Core.Contracts.IRepositories.ISlide
{
    public interface ISlideCommandRepository
    {
        Task<long> Command(Slide slide);

    }
}
