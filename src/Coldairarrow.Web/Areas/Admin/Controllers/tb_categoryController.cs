using Coldairarrow.Business.Admin;
using Coldairarrow.Entity.Admin;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Coldairarrow.Web
{
    [Area("Admin")]
    public class tb_categoryController : BaseMvcController
    {
        tb_categoryBusiness _tb_categoryBusiness = new tb_categoryBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(int? id)
        {
            var theData = id.IsNullOrEmpty() ? new tb_category() : _tb_categoryBusiness.GetTheData(id.Value);

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
            //var dataList = _tb_categoryBusiness.GetDataList(condition, keyword, pagination);
            //return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
            var dataList = _tb_categoryBusiness.GetList();
            return Content(dataList.ToJson());
        }

        /// <summary>
        /// 获取所有分数
        /// </summary>
        /// <returns></returns>
        public ActionResult GetAllData(int? id)
        {
            var dataList = _tb_categoryBusiness.GetIQueryable().Where(q => q.pid == 0
            && (id > 0 && q.Id != id)).ToList();
            dataList.Insert(0, new tb_category
            {
                Id = 0,
                name = "根节点"
            });
            return Content(dataList.ToJson());
        }
        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(tb_category theData)
        {
            if(theData.Id.IsNullOrEmpty())
            {
                //theData.Id = Guid.NewGuid().ToSequentialGuid();

                _tb_categoryBusiness.AddData(theData);
            }
            else
            {
                _tb_categoryBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _tb_categoryBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        #endregion
    }
}