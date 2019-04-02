using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    /// <summary>
    /// tb_counselor_questionprice
    /// </summary>
    [Table("tb_counselor_questionprice")]
    public class tb_counselor_questionprice
    {

        /// <summary>
        /// 咨询问题价格设置
        /// </summary>
        [Key, Column("id",Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        /// <summary>
        /// 咨询师id
        /// </summary>
        public Int32 counselorid { get; set; }

        /// <summary>
        /// 咨询问题价格
        /// </summary>
        public Decimal price { get; set; }

        /// <summary>
        /// 最大追问次数(0表示无限追问)
        /// </summary>
        public Int32 maxquestion { get; set; }

        /// <summary>
        /// createtime
        /// </summary>
        public DateTime createtime { get; set; }

        /// <summary>
        /// updatetime
        /// </summary>
        public DateTime updatetime { get; set; }

        /// <summary>
        /// 急速问答价格
        /// </summary>
        public Decimal quickprice { get; set; }

    }
}