using Coldairarrow.Business.DTO;
using Coldairarrow.Entity.ProjectManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace Coldairarrow.Business.ProjectManage
{
    public class Dev_ProjectBusiness : BaseBusiness<Dev_Project>
    {
        #region 外部接口

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public List<Dev_ProjectDTO> GetDataList(string condition, string keyword, Pagination pagination)
        {
            var where = LinqHelper.True<Dev_ProjectDTO>();
            Expression<Func<Dev_Project, Dev_ProjectType, Dev_ProjectDTO>> select = (a, b) => new Dev_ProjectDTO
            {
                ProjectTypeName = b.ProjectTypeName
            };
            select = select.BuildExtendSelectExpre();
            var q = from a in GetIQueryable().AsExpandable()
                    join b in Service.GetIQueryable<Dev_ProjectType>() on a.ProjectTypeId equals b.ProjectTypeId into ab
                    from b in ab.DefaultIfEmpty()
                    select @select.Invoke(a, b);

            //var q = from a in GetIQueryable()
            //        join b in Service.GetIQueryable<Dev_ProjectType>() on a.ProjectTypeId equals b.ProjectTypeId into ab
            //        from b in ab.DefaultIfEmpty()
            //        select new Dev_ProjectDTO
            //        {
            //            Id = a.Id,
            //            ProjectId = a.ProjectId,
            //            ProjectTypeId = a.ProjectTypeId,
            //            ProjectTypeName = b == null ? string.Empty : b.ProjectTypeName,
            //            ProjectName = a.ProjectName,
            //            ProjectManagerId = a.ProjectManagerId
            //        };
            //模糊查询
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.Where(where).GetPagination(pagination).ToList();

        }

        /// <summary>
        /// 获取指定的单条数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public Dev_Project GetTheData(string id)
        {
            return GetEntity(id);
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="newData">数据</param>
        public void AddData(Dev_Project newData)
        {
            Insert(newData);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public void UpdateData(Dev_Project theData)
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