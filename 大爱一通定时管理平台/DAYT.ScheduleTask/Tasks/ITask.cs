using DAYT.Model.SqlHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAYT.ScheduleTask.Tasks
{
    public partial interface ITask
    {
        /// <summary>
        /// Execute task
        /// </summary>
        void Execute(IRepository _repository);
    }
}