using DAYT.Model.DAYTPlatform;
using DAYT.Model.SqlHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace DAYT.ScheduleTask.Tasks
{
    public partial class ScheduleTaskService : IScheduleTaskService
    {
        #region Fields

        private readonly JobContext _taskRepository = new JobContext();
        private readonly IRepository _repository;
        public ScheduleTaskService()
        {
            _repository = new Repository();
        }

        #endregion

        #region Ctor


        #endregion

        #region Methods

        /// <summary>
        /// Deletes a task
        /// </summary>
        /// <param name="task">Task</param>
        public virtual void DeleteTask(SYS_ScheduleTask task)
        {
            if (task == null)
                throw new ArgumentNullException("task");
            _repository.Delete(task);
        }

        /// <summary>
        /// Gets a task
        /// </summary>
        /// <param name="taskId">Task identifier</param>
        /// <returns>Task</returns>
        public virtual SYS_ScheduleTask GetTaskById(int taskId)
        {
            if (taskId == 0)
                return null;
            Expression<Func<SYS_ScheduleTask, bool>> exp = a => a.Id == taskId;
            return _repository.GetFristDefault(exp);
        }

        /// <summary>
        /// Gets a task by its type
        /// </summary>
        /// <param name="type">Task type</param>
        /// <returns>Task</returns>
        public virtual SYS_ScheduleTask GetTaskByType(string type)
        {
            if (String.IsNullOrWhiteSpace(type))
                return null;
            
            var query = _repository.GetAll<SYS_ScheduleTask>();
            query = query.Where(st => st.Type == type).ToList();
            query = query.OrderByDescending(t => t.Id).ToList();

            var task = query.FirstOrDefault();
            return task;
        }

        /// <summary>
        /// Gets all tasks
        /// </summary>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <returns>Tasks</returns>
        public virtual IList<SYS_ScheduleTask> GetAllTasks(bool showHidden = false)
        {
            var query = _repository.GetAll<SYS_ScheduleTask>();
            if (!showHidden)
            {
                query = query.Where(t => t.Enabled).ToList();
            }
            query = query.OrderByDescending(t => t.Seconds).ToList();

            var tasks = query.ToList();
            return tasks;
        }

        /// <summary>
        /// Inserts a task
        /// </summary>
        /// <param name="task">Task</param>
        public virtual void InsertTask(SYS_ScheduleTask task)
        {
            if (task == null)
                throw new ArgumentNullException("task");

            _repository.Add(task);
        }

        /// <summary>
        /// Updates the task
        /// </summary>
        /// <param name="task">Task</param>
        public virtual void UpdateTask(SYS_ScheduleTask task)
        {
            if (task == null)
                throw new ArgumentNullException("task");

            _repository.Update(task);
        }

        #endregion
    }
}