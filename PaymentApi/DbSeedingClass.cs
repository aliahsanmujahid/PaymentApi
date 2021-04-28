using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PaymentApi.Models;

namespace PaymentApi
{
    public static class DbSeedingClass
    {
        public static void SeedDataContext(this PaymentDetailContext context)
        {
            var paymentSeed = new List<PaymentDetail>()
            {
                new PaymentDetail()
                {
                    
                    CardOwnerName = "poipoi  poi",  
                    CardNumber = "2348912348912348",
                    ExpirationDate = "11/23",
                    SecurityCode = "026"


                },
                
              
            };
            foreach (var user in paymentSeed)
            {


                context.PaymentDetails.Add(user);

            }


            context.SaveChangesAsync();
        }
    }
}
