using Coldairarrow.Business.Admin;
using Coldairarrow.Entity.Admin;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coldairarrow.Web
{
    [Area("Admin")]
    public class tb_counselorController : BaseMvcController
    {
        tb_counselorBusiness _tb_counselorBusiness = new tb_counselorBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int? id)
        {
            var theData = id.IsNullOrEmpty() ? new tb_counselor() : _tb_counselorBusiness.GetTheData(id.Value);

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
            var dataList = _tb_counselorBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(tb_counselor theData)
        {
            if(theData.Id.IsNullOrEmpty())
            {
                //theData.Id = Guid.NewGuid().ToSequentialGuid();

                _tb_counselorBusiness.AddData(theData);
            }
            else
            {
                _tb_counselorBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _tb_counselorBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        #endregion
    }
}