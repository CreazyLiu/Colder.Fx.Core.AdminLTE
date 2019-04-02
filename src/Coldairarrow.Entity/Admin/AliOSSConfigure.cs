using Coldairarrow.Entity.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    public static class AliOSSConfigure
    {
        /// <summary>
        /// 获取或设置Id
        /// </summary>
        public static string AccessKeyId => "LTAIglMWRo9oNrgB";

        public static string AccessKeySecret => "CiUEwTrRyNNJSW8XbNBnsIGoBKJDtI";

        public static string EndPoint => "oss-cn-shanghai.aliyuncs.com";

        /// <summary>
        /// 获取或设置图片桶名
        /// </summary>
        public static string ImageBucketName => "mingxpic";

        ///// <summary>
        ///// 过去时间秒为单位
        ///// </summary>
        //public int UrlExpire
        //{
        //    get;
        //    set;
        //}

        public static string VoiceBucketName => "mingxvoice";
    }
}