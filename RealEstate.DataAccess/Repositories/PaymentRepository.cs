using System.Collections.Generic;
using System.Linq;
using RealEstate.DataAccess.Repositories.Contracts;
using RealEstate.Database;
using RealEstate.Database.Models;

namespace RealEstate.DataAccess.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly RealEstateContext _db;

        public PaymentRepository(RealEstateContext db)
        {
            _db = db;
        }

        public IEnumerable<Payment> GetAllForProperty(int propertyId)
        {
            return _db.Payments.Where(x => x.PropertyId == propertyId);
        }
        public IEnumerable<Payment> GetAllForProperty(int propertyId, int lastAmount)
        {
            return _db.Payments.Where(x => x.PropertyId == propertyId)
                .OrderByDescending(x => x.DateCreated)
                .Take(lastAmount);
        }
    }
}
