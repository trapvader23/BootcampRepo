﻿using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Abstract
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        IQueryable OrderReport(int orderID);
    }
}