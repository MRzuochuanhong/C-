using DAYT.BLL;
using DAYT.Model;
using DAYT.Model.DAYTPlatform;
using DAYT.Model.SqlHelp;
using DAYT.ScheduleTask.Tasks;
using DAYT.WebCommon;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;

namespace DAYT.ScheduleTask.TaskManagement
{
    public class Heartbeat : ITask
    {
        public readonly string ScheduleTaskInterface = ConfigHelper.GetConfigString("ScheduleTaskInterface");
        public void Execute(IRepository _repository)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var result = client.GetStringAsync(ScheduleTaskInterface + "Home/Heartbeat").Result;
                    //if (result == "ok")
                    //{
                    //    Expression<Func<SYS_ScheduleTask, bool>> exp = a => a.Name== "心跳唤醒";
                    //    var model = _repository.GetAllQuery(exp).FirstOrDefault();
                    //    model.LeasedByMachineName = "执行成功";
                    //    _repository.Update<SYS_ScheduleTask>(model);
                    //}
                    //else
                    //{
                    //    Expression<Func<SYS_ScheduleTask, bool>> exp = a => a.Name == "心跳唤醒";
                    //    var model = _repository.GetAllQuery(exp).FirstOrDefault();
                    //    model.LeasedByMachineName = "执行失败";
                    //    _repository.Update<SYS_ScheduleTask>(model);
                    //}
                }
                catch(Exception e)
                {
                    Expression<Func<SYS_ScheduleTask, bool>> exp = a => a.Name == "心跳唤醒";
                    var model = _repository.GetAllQuery(exp).FirstOrDefault();
                    model.LeasedByMachineName = e.Message;
                    _repository.Update<SYS_ScheduleTask>(model);
                }
                
                //client.GetAsync(ScheduleTaskInterface+"Home/Heartbeat").Result.Content.ReadAsStringAsync();
            }
        }
    }
}