using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Assignment1.Models
{
    public class EFUResponseRepository : IContactsRepo
    {
        private ApplicationDbContext context;

        public EFUResponseRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<UResponse> uResponses => context.uResponses;

        public UResponse DeleteProduct(int uResponsesID)
        {
            UResponse dbEntry = context.uResponses.FirstOrDefault(p => p.UResponsesID == uResponsesID);

            if (dbEntry != null)
            {
                context.uResponses.Remove(dbEntry);
                context.SaveChanges();
            }

            return dbEntry;
        }

        public void SaveProduct(UResponse uResponse)
        {
            if (uResponse.UResponsesID == 0)
            {
                context.uResponses.Add(uResponse);
            }
            else
            {
                UResponse dbEntry = context.uResponses.FirstOrDefault(p => p.UResponsesID == uResponse.UResponsesID);
                if (dbEntry != null)
                {
                    dbEntry.Name = uResponse.Name;
                    dbEntry.Message = uResponse.Message;
                    dbEntry.EmailID = uResponse.EmailID;
                    dbEntry.PhoneNumber = uResponse.PhoneNumber;
                }
            }

            context.SaveChanges();
        }
    }
}
