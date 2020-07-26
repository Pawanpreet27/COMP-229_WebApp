﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Assignment1.Models
{
    public interface IContactsRepo
    {
        IQueryable<UResponse> uResponses { get; }

        void SaveProduct(UResponse uResponses);

        UResponse DeleteProduct(int uResponsesID);
    }
}
