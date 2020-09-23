﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using uccApiCore2.Entities;

namespace uccApiCore2.BAL.Interface
{
    public interface IAgentBAL
    {
        Task<int> AgentRegistration(Agents obj);
        Task<int> UpdateAgent(Agents obj);
        Task<List<Users>> GetAgentInfo(Users obj);
        Task<int> SaveAgentCustomer(Agents obj);
        Task<List<Users>> ValidAgentLogin(Users obj);
    }
}
