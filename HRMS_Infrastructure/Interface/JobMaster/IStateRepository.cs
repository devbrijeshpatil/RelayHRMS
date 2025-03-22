﻿using HRMS_Core.Master.JobMaster;
using HRMS_Core.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_Infrastructure.Interface.JobMaster
{
    public interface IStateRepository : IRepository<State>
    {
        Task<bool> UpdateState(State state);
        Task<State> SoftDelete(DeleteRecordVM DeleteRecord);
    }
}
