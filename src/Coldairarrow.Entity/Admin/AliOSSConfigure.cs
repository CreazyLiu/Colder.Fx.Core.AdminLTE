using Coldairarrow.Entity.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    public static class AliOSSConfigure
    {
        /// <summary>
        /// ��ȡ������Id
        /// </summary>
        public static string AccessKeyId => "LTAIglMWRo9oNrgB";

        public static string AccessKeySecret => "CiUEwTrRyNNJSW8XbNBnsIGoBKJDtI";

        public static string EndPoint => "oss-cn-shanghai.aliyuncs.com";

        /// <summary>
        /// ��ȡ������ͼƬͰ��
        /// </summary>
        public static string ImageBucketName => "mingxpic";

        ///// <summary>
        ///// ��ȥʱ����Ϊ��λ
        ///// </summary>
        //public int UrlExpire
        //{
        //    get;
        //    set;
        //}

        public static string VoiceBucketName => "mingxvoice";
    }
}