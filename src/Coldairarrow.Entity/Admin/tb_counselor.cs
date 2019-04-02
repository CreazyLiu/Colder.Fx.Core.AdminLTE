using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    /// <summary>
    /// tb_counselor
    /// </summary>
    [Table("tb_counselor")]
    public class tb_counselor
    {

        /// <summary>
        /// 咨询师id
        /// </summary>
        [Key, Column("id",Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public Int32 sex { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public String avatar { get; set; }

        /// <summary>
        /// 擅长技能简介
        /// </summary>
        public String profession { get; set; }

        /// <summary>
        /// 工作经验
        /// </summary>
        public String experience { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public Int32 level { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public String loginname { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public String password { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        public Boolean isactivated { get; set; }

        /// <summary>
        /// 总结
        /// </summary>
        public String summary { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime? lastlogintime { get; set; }

        /// <summary>
        /// 最后登录ip
        /// </summary>
        public String lastloginip { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        public Boolean isonline { get; set; }

        /// <summary>
        /// 微信公众号openid(目前存储友盟的DeviceToken)
        /// </summary>
        public String wx_pub_openid { get; set; }

    }
}