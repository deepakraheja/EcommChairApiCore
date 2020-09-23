﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using uccApiCore2.Entities;

namespace uccApiCore2.BAL.Interface
{
    public interface IFabricBAL
    {
        Task<List<Fabric>> GetFabric(Fabric obj);
        Task<List<Fabric>> GetAllFabric(Fabric obj);
        Task<int> SaveFabric(Fabric obj);
        Task<List<LookupFabricType>> GetFabricType(LookupFabricType obj);
        Task<List<LookupFabricType>> GetAllFabricType(LookupFabricType obj);
        Task<int> SaveFabricType(LookupFabricType obj);
    }
}
