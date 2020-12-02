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
        /// �ƻ����������
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// ������ʱ�����룩
        /// </summary>
        public int Seconds { get; set; }
        /// <summary>
        /// ִ�������������Ӧ�ĳ��򼯺������ռ���ַ��������ڷ��䴴����
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Type { get; set; }
        /// <summary>
        /// �Ƿ���������
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public bool Switch { get; set; }
        
        /// <summary>
        /// ���ʹ����Ƿ�ִֹͣ��
        /// </summary>
        public bool StopOnError { get; set; }
        /// <summary>
        /// ����������ƣ���������Ƕ���վ���ֲ�ʽ����ʱ������ �������ʹ���ݲ������
        /// </summary>
        [StringLength(255)]
        public string LeasedByMachineName { get; set; }
        /// <summary>
        /// ʵ����ִ�е�ʱ��
        /// </summary>
        public DateTime? LeasedUntilUtc { get; set; }
        /// <summary>
        /// ���ʼִ������Ŀ�ʼʱ��
        /// </summary>
        public DateTime? LastStartUtc { get; set; }
        /// <summary>
        /// ��ʼִ������Ľ���ʱ��
        /// </summary>
        public DateTime? LastEndUtc { get; set; }
        /// <summary>
        /// ���һ��ִ�гɹ���ʱ��
        /// </summary>
        public DateTime? LastSuccessUtc { get; set; }
    }
}
