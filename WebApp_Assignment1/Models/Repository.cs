using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Assignment1.Models
{
    public static class Repository
    {
        private static List<UResponse> uResponseList = new List<UResponse>();

        public static void AddResponse(UResponse response)
        {
            uResponseList.Add(response);
        }

        public static List<UResponse> GetResponses()
        {
            return uResponseList;
        }

    }
}
