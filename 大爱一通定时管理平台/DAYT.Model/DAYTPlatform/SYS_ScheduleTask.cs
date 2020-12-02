namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_ScheduleTask
    {
        public int Id { get; set; }
        /// <summary>
        /// 计划任务的名称
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 任务间隔时长（秒）
        /// </summary>
        public int Seconds { get; set; }
        /// <summary>
        /// 执行任务的类所对应的程序集和命名空间的字符串，用于反射创建类
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Type { get; set; }
        /// <summary>
        /// 是否启用任务
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// 开关
        /// </summary>
        public bool Switch { get; set; }
        
        /// <summary>
        /// 发送错误是否停止执行
        /// </summary>
        public bool StopOnError { get; set; }
        /// <summary>
        /// 计算机的名称，这个好像是多网站（分布式）的时候有用 （具体的使用暂不清楚）
        /// </summary>
        [StringLength(255)]
        public string LeasedByMachineName { get; set; }
        /// <summary>
        /// 实例上执行的时间
        /// </summary>
        public DateTime? LeasedUntilUtc { get; set; }
        /// <summary>
        /// 最后开始执行任务的开始时间
        /// </summary>
        public DateTime? LastStartUtc { get; set; }
        /// <summary>
        /// 后开始执行任务的结束时间
        /// </summary>
        public DateTime? LastEndUtc { get; set; }
        /// <summary>
        /// 最后一次执行成功的时间
        /// </summary>
        public DateTime? LastSuccessUtc { get; set; }
    }
}
