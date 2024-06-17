using DiscountManagement.Framework;

namespace DiscountManagement.Core.Domain.ColleagueDiscountAgg
{
    public class ColleagueDiscount : AggregateRoot
    {
        public long ProductId { get; private set; }
        public int DiscountRate { get; private set; }
        public bool IsRemved { get; private set; }

        public ColleagueDiscount(long productId, int discountRate)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            IsRemved = false;
        }

        public void Edit(long productId, int discountRate)
        {
            ProductId = productId;
            DiscountRate = discountRate;
        }

        public void Remove()
        {
            IsRemved = true;
        }

        public void Restore()
        {
            IsRemved = false;
        }
    }

}
