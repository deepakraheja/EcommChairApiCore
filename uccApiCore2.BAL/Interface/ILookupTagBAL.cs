﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using uccApiCore2.Entities;

namespace uccApiCore2.BAL.Interface
{
    public interface ILookupTagBAL
    {
        Task<List<LookupTag>> GetTag(LookupTag obj);
        Task<List<LookupTag>> GetAllTag(LookupTag obj);
        Task<int> SaveTag(LookupTag obj);
    }
}
