using Coldairarrow.Business.Admin;
using Coldairarrow.Entity.Admin;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Coldairarrow.Web
{
    [Area("Admin")]
    public class SchoolsController : BaseMvcController
    {
        SchoolsBusiness _schoolsBusiness = new SchoolsBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int? id)
        {
            var theData = id.IsNullOrEmpty() ? new Schools() : _schoolsBusiness.GetTheData(id);

            return View(theData);
        }

        #endregion

        #region 获取数据

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public ActionResult GetDataList(string condition, string keyword, Pagination pagination)
        {
            var dataList = _schoolsBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Schools theData)
        {
            if(theData.Id.IsNullOrEmpty() || theData.Id == 0)
            {
                //theData.Id = Guid.NewGuid().ToSequentialGuid();
                theData.Id = _schoolsBusiness.GetIQueryable().Max(q => q.Id) + 1;
                _schoolsBusiness.AddData(theData);
            }
            else
            {
                _schoolsBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _schoolsBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        #endregion
    }
}