using System;
using System.Collections.Generic;
using System.Linq;
using RealEstate.Database.Models;

namespace RealEstate.Database
{
    public static class RealEstateSeedData
    {
        public static void EnsureSeedData(this RealEstateContext db)
        {
            if (!db.Properties.Any() || !db.Payments.Any())
            {
                var properties = new List<Property>
                {
                    new Property
                    {
                        City = "Katowice",
                        Family = "Smith",
                        Name = "Big house",
                        Street = "Sokolska",
                        Value = 100000,
                        Payments = new List<Payment>
                        {
                            new Payment
                            {
                                DateCreated = new DateTime(2019, 07, 01),
                                DateOverdue = new DateTime(2019, 07, 15),
                                Paid = true,
                                Value = 1500
                            },
                            new Payment
                            {
                                DateCreated = new DateTime(2019, 08, 01),
                                DateOverdue = new DateTime(2019, 08, 15),
                                Paid = true,
                                Value = 1500
                            },
                            new Payment
                            {
                                DateCreated = new DateTime(2019, 09, 01),
                                DateOverdue = new DateTime(2019, 09, 15),
                                Paid = false,
                                Value = 1500
                            }
                        }
                    },
                    new Property
                    {
                        City = "Warszawa",
                        Family = "Nowak",
                        Name = "White house",
                        Street = "Wiejska",
                        Value = 300500,
                        Payments = new List<Payment>
                        {
                            new Payment
                            {
                                DateCreated = new DateTime(2019, 07, 01),
                                DateOverdue = new DateTime(2019, 07, 15),
                                Paid = true,
                                Value = 3000
                            },
                            new Payment
                            {
                                DateCreated = new DateTime(2019, 08, 01),
                                DateOverdue = new DateTime(2019, 08, 15),
                                Paid = true,
                                Value = 3000
                            },
                            new Payment
                            {
                                DateCreated = new DateTime(2019, 09, 01),
                                DateOverdue = new DateTime(2019, 09, 15),
                                Paid = false,
                                Value = 3000
                            }
                        }
                    },
                    new Property
                    {
                        City = "Gdańska",
                        Family = "Pomorscy",
                        Name = "Sea house",
                        Street = "Gdańska",
                        Value = 51000,
                        Payments = new List<Payment>
                        {
                            new Payment
                            {
                                DateCreated = new DateTime(2019, 07, 01),
                                DateOverdue = new DateTime(2019, 07, 15),
                                Paid = true,
                                Value = 800
                            },
                            new Payment
                            {
                                DateCreated = new DateTime(2019, 08, 01),
                                DateOverdue = new DateTime(2019, 08, 15),
                                Paid = true,
                                Value = 800
                            },
                            new Payment
                            {
                                DateCreated = new DateTime(2019, 09, 01),
                                DateOverdue = new DateTime(2019, 09, 15),
                                Paid = true,
                                Value = 800
                            }
                        }
                    }
                };

                db.Properties.AddRange(properties);
                db.SaveChanges();
            }
        }
    }
}
