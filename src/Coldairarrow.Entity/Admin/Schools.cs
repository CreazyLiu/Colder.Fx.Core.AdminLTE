using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    /// <summary>
    /// Schools
    /// </summary>
    [Table("Schools")]
    public class Schools
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// ParentId
        /// </summary>
        public Int32? ParentId { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public Int32? Type { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public String Name { get; set; }

    }
}