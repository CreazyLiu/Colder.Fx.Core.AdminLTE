using Aliyun.OSS;
using Aliyun.OSS.Common;
using Coldairarrow.Entity.Admin;
using Coldairarrow.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coldairarrow.Business.Common
{
    public class AttachmentBusiness : BaseBusiness<Attachment>
    {
        private static OssClient client;
        static AttachmentBusiness()
        {
            client = new OssClient(AliOSSConfigure.EndPoint, AliOSSConfigure.AccessKeyId, AliOSSConfigure.AccessKeySecret);
        }

        public AttachmentBusiness()
        {
        }

        public  Dictionary<string, List<Attachment>> GetAttachmentsAsync(List<string> groupKeys)
        {
            if(groupKeys.Count == 0)
            {
                return new Dictionary<string, List<Attachment>>(0);
            }
            var attachments = new Dictionary<string, List<Attachment>>();
            var attachs = GetListBySql<Attachment>($"SELECT * FROM tb_attachment WEHRE groupKey in ('{string.Join("','", groupKeys)}')");
            foreach (var attach in attachs)
            {
                if (!attachments.ContainsKey(attach.GroupKey))
                {
                    attachments[attach.GroupKey] = new List<Attachment>();
                }
                attachments[attach.GroupKey].Add(attach);
            }

            return attachments;
        }

        public string GetImageUrl(string key, ImageSize imgSize)
        {
            if (!string.IsNullOrEmpty(key) && (key.StartsWith("http:") || key.StartsWith("https:")))
            {
                return key; // 不是存储在阿里的Oss上的图片
            }

            try
            {
                var now = DateTime.Now;
                var expire = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddYears(1);
                var bucket = GetBucketName(AttachmentType.Picture);
                switch (imgSize)
                {
                    case ImageSize.Small:
                        {
                            var request = new GeneratePresignedUriRequest(bucket, key);
                            request.Expiration = expire;
                            request.Process = "image/resize,p_60";
                            return client.GeneratePresignedUri(request)?.AbsoluteUri;
                        }
                    case ImageSize.Mid:
                        {
                            var request = new GeneratePresignedUriRequest(bucket, key);
                            request.Expiration = expire;
                            request.Process = "image/resize,p_50";
                            return client.GeneratePresignedUri(request)?.AbsoluteUri;
                        }
                    default:
                        return client.GeneratePresignedUri(bucket, key, expire)?.AbsoluteUri;
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        public string GetVoiceUrl(string key)
        {
            var now = DateTime.Now;
            var expire = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddYears(1);
            var bucket = GetBucketName(AttachmentType.Voice);
            return client.GeneratePresignedUri(bucket, key, expire)?.AbsoluteUri;
        }

        private string GetAttachmentKeyPrefix(AttachmentType attachmentType)
        {
            switch (attachmentType)
            {
                case AttachmentType.Picture:
                    return "PIC";
                case AttachmentType.Voice:
                    return "VOC";
                default:
                    return "PIC";
            }
        }

        private string GetBucketName(AttachmentType attachmentType)
        {
            switch (attachmentType)
            {
                case AttachmentType.Avatar:
                case AttachmentType.Picture:
                    return AliOSSConfigure.ImageBucketName;
                case AttachmentType.Voice:
                    return AliOSSConfigure.VoiceBucketName;
                default:
                    return AliOSSConfigure.ImageBucketName;
            }
        }

        private bool ExistObject(string key, string bucketName)
        {
            try
            {
                return client.GetObject(bucketName, key) != null;
            }
            catch (OssException)
            {
                return false;
            }
        }
    }
}
