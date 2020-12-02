using DAYT.Model.DAYTPlatform;
using DAYT.Model.SqlHelp;
using DAYT.ScheduleTask.TaskManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAYT.ScheduleTask.Tasks
{
    public partial class Task
    {
        private static IRepository _repository = new Repository();
        private readonly IScheduleTaskService taskService = new ScheduleTaskService();
        /// <summary>
        /// Ctor for Task
        /// </summary>
        private Task()
        {
            this.Enabled = true;
        }

        /// <summary>
        /// Ctor for Task
        /// </summary>
        /// <param name="task">Task </param>
        public Task(SYS_ScheduleTask task)
        {
            this.Type = task.Type;
            this.Enabled = task.Enabled;
            this.StopOnError = task.StopOnError;
            this.Name = task.Name;
        }

        private ITask CreateTask(string type)
        {
            ITask task = null;
            if (this.Enabled)
            {
                object instance = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(Type, false);

                task = instance as ITask;
            }
            return task;
        }

        /// <summary>
        /// Executes the task
        /// </summary>
        /// <param name="throwException">A value indicating whether exception should be thrown if some error happens</param>
        /// <param name="dispose">A value indicating whether all instances hsould be disposed after task run</param>
        public void Execute(bool throwException = false, bool dispose = true)
        {
            this.IsRunning = true;

            //background tasks has an issue with Autofac
            //because scope is generated each time it's requested
            //that's why we get one single scope here
            //this way we can also dispose resources once a task is completed
            var scheduleTaskService = this.taskService;
            var scheduleTask = scheduleTaskService.GetTaskByType(this.Type);

            try
            {
                var task = this.CreateTask(scheduleTask.Type);
                if (task != null)
                {
                    this.LastStartUtc = DateTime.Now;
                    if (scheduleTask != null)
                    {
                        //update appropriate datetime properties
                        scheduleTask.LastStartUtc = this.LastStartUtc;
                        scheduleTaskService.UpdateTask(scheduleTask);
                    }

                    //execute task
                    task.Execute(_repository);
                    this.LastEndUtc = this.LastSuccessUtc = DateTime.Now;
                }
                
            }
            catch (Exception)
            {
                this.Enabled = !this.StopOnError;
                this.LastEndUtc = DateTime.Now;

                throw;
            }
            try
            {
                if (scheduleTask != null)
                {
                    //update appropriate datetime properties
                    scheduleTask.LastEndUtc = this.LastEndUtc;
                    scheduleTask.LastSuccessUtc = this.LastSuccessUtc;
                    string num = "";
                    if (scheduleTask.LeasedByMachineName == null)
                    {
                        num = "0";
                    }
                    else
                    {
                        num = scheduleTask.LeasedByMachineName;
                    }
                    int count = 0;
                    if (int.TryParse(num, out count))
                    {
                        scheduleTask.LeasedByMachineName = (count + 1).ToString();
                        scheduleTaskService.UpdateTask(scheduleTask);
                    }
                }
            }
            catch (Exception)
            {
                this.Enabled = !this.StopOnError;
                this.LastEndUtc = DateTime.Now;

                throw;
            }
            

            //dispose all resources
            if (dispose)
            {

            }

            this.IsRunning = false;
        }

        /// <summary>
        /// A value indicating whether a task is running
        /// </summary>
        public bool IsRunning { get; private set; }

        /// <summary>
        /// Datetime of the last start
        /// </summary>
        public DateTime? LastStartUtc { get; private set; }

        /// <summary>
        /// Datetime of the last end
        /// </summary>
        public DateTime? LastEndUtc { get; private set; }

        /// <summary>
        /// Datetime of the last success
        /// </summary>
        public DateTime? LastSuccessUtc { get; private set; }

        /// <summary>
        /// A value indicating type of the task
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// A value indicating whether to stop task on error
        /// </summary>
        public bool StopOnError { get; private set; }

        /// <summary>
        /// A value indicating whether to stop task on error
        /// </summary>
        public bool Stop { get; private set; }


        /// <summary>
        /// Get the task name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// A value indicating whether the task is enabled
        /// </summary>
        public bool Enabled { get; set; }
    }
}