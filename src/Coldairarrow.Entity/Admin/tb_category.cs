using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    /// <summary>
    /// tb_category
    /// </summary>
    [Table("tb_category")]
    public class tb_category
    {

        /// <summary>
        /// id
        /// </summary>
        [Key, Column("id",Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        /// <summary>
        /// 分类编码
        /// </summary>
        public String code { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public Int32 order { get; set; }

        /// <summary>
        /// 父节点名称
        /// </summary>
        public Int32 pid { get; set; }

        /// <summary>
        /// 提问模板信息
        /// </summary>
        public String template { get; set; }

    }
}