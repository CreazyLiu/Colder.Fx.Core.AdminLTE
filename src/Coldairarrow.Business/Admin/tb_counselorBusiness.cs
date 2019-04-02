using Coldairarrow.Business.Common;
using Coldairarrow.Business.DTO;
using Coldairarrow.Entity.Admin;
using Coldairarrow.Entity.Enum;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace Coldairarrow.Business.Admin
{
    public class tb_counselorBusiness : BaseBusiness<tb_counselor>
    {
        #region 外部接口
        private AttachmentBusiness attachmentsBusiness = new AttachmentBusiness();
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public List<tb_counselorDTO> GetDataList(string condition, string keyword, Pagination pagination)
        {
            var where = LinqHelper.True<tb_counselorDTO>();
            Expression<Func<tb_counselor, tb_counselorDTO>> select = a => new tb_counselorDTO
            {
            };
            select = select.BuildExtendSelectExpre();
            var q = from a in GetIQueryable().AsExpandable()
                    select @select.Invoke(a);
            //模糊查询
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            var list = q.Where(where).GetPagination(pagination).ToList();

            var counselorList = list.Select(o => o.Id).ToList();
            var categoryList = (from a in Service.GetIQueryable<tb_counselor_category>()
                                join b in Service.GetIQueryable<tb_category>() on a.categoryid equals b.Id
                                where counselorList.Contains(a.counselorid)
                                select new
                                {
                                    a.counselorid,
                                    a.categoryid,
                                    b.name
                                }).ToList();
            list.ForEach(o =>
            {
                o.categorys = string.Join("<br>", categoryList.Where(x => x.counselorid == o.Id).Select(x => x.name));
                if (string.IsNullOrEmpty(o?.avatar))
                {
                    o.CounselorAvatar = AdminConfigure.DefaultCounselorAvatar;
                }
                else
                {
                    o.CounselorAvatar = attachmentsBusiness.GetImageUrl(o?.avatar, ImageSize.Small);
                }
            });

           
            return list;
        }

        /// <summary>
        /// 获取指定的单条数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public tb_counselor GetTheData(int id)
        {
            return GetEntity(id);
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="newData">数据</param>
        public void AddData(tb_counselor newData)
        {
            Insert(newData);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public void UpdateData(tb_counselor theData)
        {
            Update(theData);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public void DeleteData(List<string> ids)
        {
            Delete(ids);
        }

        #endregion

        #region 私有成员

        #endregion

        #region 数据模型

        #endregion
    }
}