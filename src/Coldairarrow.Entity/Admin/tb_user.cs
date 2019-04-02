using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    /// <summary>
    /// tb_user
    /// </summary>
    [Table("tb_user")]
    public class tb_user
    {

        /// <summary>
        /// id
        /// </summary>
        [Key, Column("id",Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        /// <summary>
        /// 账号ID
        /// </summary>
        public Int32 accountid { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public String loginname { get; set; }

        /// <summary>
        /// 1.普通,2.艺术
        /// </summary>
        public Int32 usertype { get; set; }

        /// <summary>
        /// graduateyear
        /// </summary>
        public String graduateyear { get; set; }

        /// <summary>
        /// realname
        /// </summary>
        public String realname { get; set; }

        /// <summary>
        /// 1男2女
        /// </summary>
        public Int32 sexy { get; set; }

        /// <summary>
        /// 艺术类别(对应金榜路)
        /// </summary>
        public Int32 artcategoryid { get; set; }

        /// <summary>
        /// 科类1问2理
        /// </summary>
        public Int32 subjectid { get; set; }

        /// <summary>
        /// 语言类型
        /// </summary>
        public Int32 examlanguage { get; set; }

        /// <summary>
        /// area
        /// </summary>
        public String area { get; set; }

        /// <summary>
        /// school
        /// </summary>
        public String school { get; set; }

        /// <summary>
        /// linkphone
        /// </summary>
        public String linkphone { get; set; }

        /// <summary>
        /// qqnumber
        /// </summary>
        public String qqnumber { get; set; }

        /// <summary>
        /// email
        /// </summary>
        public String email { get; set; }

        /// <summary>
        /// userlevel
        /// </summary>
        public Int32? userlevel { get; set; }

        /// <summary>
        /// usercardnumber
        /// </summary>
        public String usercardnumber { get; set; }

        /// <summary>
        /// city
        /// </summary>
        public String city { get; set; }

        /// <summary>
        /// clazz
        /// </summary>
        public String clazz { get; set; }

        /// <summary>
        /// createtime
        /// </summary>
        public DateTime createtime { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public String avatar { get; set; }

        /// <summary>
        /// 微信小程序openid
        /// </summary>
        public String wx_openid { get; set; }

    }
}