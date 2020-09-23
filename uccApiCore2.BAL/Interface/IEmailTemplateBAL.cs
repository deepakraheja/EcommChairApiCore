﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using uccApiCore2.Entities;

namespace uccApiCore2.BAL.Interface
{
    public interface IEmailTemplateBAL
    {
        Task<int> SaveEmailTemplate(EmailTemplate obj);
        Task<List<EmailTemplate>> GetEmailTemplate(EmailTemplate obj);
    }
}
