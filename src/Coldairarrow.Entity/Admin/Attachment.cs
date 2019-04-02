using Coldairarrow.Entity.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    /// <summary>
    /// ����ʵ��
    /// </summary>
    [Table("tb_attachment")]
    public class Attachment
    {
        /// <summary>
        /// ��ȡ�����ø���id(Ψһid)
        /// </summary>
        [Key, Column("id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ô洢����
        /// </summary>
        [Column("store")]
        public StoreType Store
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ø���Դ��
        /// </summary>
        [Column("origin")]
        public string Origin
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ø����洢key
        /// </summary>
        [Column("key")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ø�����չ��
        /// </summary>
        [Column("ext")]
        public string Ext
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ø�������
        /// </summary>
        [Column("type")]
        public AttachmentType Type
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ø�������key
        /// </summary>
        [Column("groupkey")]
        public string GroupKey
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ø���hashֵ
        /// </summary>
        [Column("hash")]
        public string Hash
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ø�������ʱ��
        /// </summary>
        [Column("createtime")]
        public DateTime CreateTime
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ø�����С
        /// </summary>
        [Column("length")]
        public long Length
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ø���ʱ��
        /// </summary>
        [Column("timelen")]
        public int TimeLen
        {
            get;
            set;
        }
    }
}