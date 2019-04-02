using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    /// <summary>
    /// tb_counselor_category
    /// </summary>
    [Table("tb_counselor_category")]
    public class tb_counselor_category
    {

        /// <summary>
        /// 咨询师类别id
        /// </summary>
        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 id { get; set; }

        /// <summary>
        /// 类别id
        /// </summary>
        public Int32 categoryid { get; set; }

        /// <summary>
        /// 咨询师id
        /// </summary>
        public Int32 counselorid { get; set; }

    }
}