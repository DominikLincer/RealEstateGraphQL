using System;
using System.Collections.Generic;
using System.Text;
using RealEstate.Database.Models;

namespace RealEstate.DataAccess.Repositories.Contracts
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> GetAllForProperty(int propertyId);
        IEnumerable<Payment> GetAllForProperty(int propertyId, int lastAmount);

    }
}
