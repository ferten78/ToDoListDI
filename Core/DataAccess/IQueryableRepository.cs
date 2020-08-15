﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IQueryableRepository<T> where T:IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}
