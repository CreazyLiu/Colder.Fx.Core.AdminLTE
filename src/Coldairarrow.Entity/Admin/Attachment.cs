using Coldairarrow.Entity.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    /// <summary>
    /// 附件实体
    /// </summary>
    [Table("tb_attachment")]
    public class Attachment
    {
        /// <summary>
        /// 获取或设置附件id(唯一id)
        /// </summary>
        [Key, Column("id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置存储类型
        /// </summary>
        [Column("store")]
        public StoreType Store
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置附件源名
        /// </summary>
        [Column("origin")]
        public string Origin
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置附件存储key
        /// </summary>
        [Column("key")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置附件扩展名
        /// </summary>
        [Column("ext")]
        public string Ext
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置附件类型
        /// </summary>
        [Column("type")]
        public AttachmentType Type
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置附件分组key
        /// </summary>
        [Column("groupkey")]
        public string GroupKey
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置附件hash值
        /// </summary>
        [Column("hash")]
        public string Hash
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置附件创建时间
        /// </summary>
        [Column("createtime")]
        public DateTime CreateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置附件大小
        /// </summary>
        [Column("length")]
        public long Length
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置附件时长
        /// </summary>
        [Column("timelen")]
        public int TimeLen
        {
            get;
            set;
        }
    }
}