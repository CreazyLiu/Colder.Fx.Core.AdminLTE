using Coldairarrow.Entity.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Admin
{
    public static class AdminConfigure
    {
        public static string DefaultUserAvatar => "https://img.in985.com/wenwenda/onlineteacheruser_default_photo.png";
        public static string DefaultCounselorAvatar => "https://img.in985.com/wenwenda/onlineteachercounselor_default_photo.png";
    }
}