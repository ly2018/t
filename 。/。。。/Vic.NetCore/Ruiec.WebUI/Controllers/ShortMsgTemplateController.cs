﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vic.Core.Application.Dtos;
using Vic.Core.Application.IServices;
using Vic.Core.Domain.Entities;
using Vic.Core.Utils;
using Vic.Core.Utils.RequestParameters;
using Vic.Core.Utils.ResponseData;

namespace Ruiec.WebUI.Controllers
{
    public class ShortMsgTemplateController : BaseController
    {
        #region 数据接口
        private readonly IShortMsgTemplateAppService _ShortMsgTemplateAppService;
        private readonly ILanguageTypeAppService _languageTypeAppService;
        #endregion

        #region 构造器
        public ShortMsgTemplateController(ILanguageTypeAppService languageTypeAppService, IShortMsgTemplateAppService ShortMsgTemplateAppService)
        {
            _languageTypeAppService = languageTypeAppService;
            _ShortMsgTemplateAppService = ShortMsgTemplateAppService;
        }
        #endregion

        #region 首页
        /// <summary>
        /// 首页列表分页及模糊查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index(PageParameter pageParams)
        {
            PageDataResponse<ShortMsgTemplateDto> pageData = new PageDataResponse<ShortMsgTemplateDto>();
            var parameterExpression = System.Linq.Expressions.Expression.Parameter(typeof(ShortMsgTemplate));
            var filter = (System.Linq.Expressions.Expression)System.Linq.Expressions.Expression.Constant(true);
            if (!string.IsNullOrEmpty(pageParams.Key))
            {
                pageParams.Key = pageParams.Key.Trim();
                filter = (System.Linq.Expressions.Expression)System.Linq.Expressions.Expression.Constant(false);
                Guid guid = Guid.Empty;
                if (Guid.TryParse(pageParams.Key, out guid))
                    filter = filter.GotoOrElse(parameterExpression.GotoEqual("ID", guid));
            }
            else
            {
                filter = filter.GotoOrElse(parameterExpression.GotoNotEqual("ID", Guid.Empty));
            }
            if (pageParams.BeginTime != null && pageParams.EndTime != null && pageParams.BeginTime <= pageParams.EndTime)
            {
                filter = filter.GotoAndAlso(parameterExpression.GotoGreaterThanByDateTime("CreateTime", pageParams.BeginTime));
                filter = filter.GotoAndAlso(parameterExpression.GotoLessThanByDateTime("CreateTime", pageParams.EndTime));
            }
            var queryLambdaFilter = System.Linq.Expressions.Expression.Lambda<Func<ShortMsgTemplate, bool>>(filter, parameterExpression);
            int Count;
            List<ShortMsgTemplateDto> List = _ShortMsgTemplateAppService.PageList(queryLambdaFilter, pageParams.PageSize, pageParams.CurPage, out Count);
            if (List.Any())
            {
                Guid[] langIds = List.Select(a => a.LanguageTypeID).Distinct().ToArray();
                var langList = _languageTypeAppService.QueryList(a => langIds.Contains(a.ID));
                foreach (var item in List)
                {
                    var temp = langList.FirstOrDefault(a => a.ID.Equals(item.LanguageTypeID));
                    if (temp != null)
                    {
                        item.LanguageTypeName = string.Format("{0}/{1}", temp.Code, temp.Title);
                    }
                }
            }
            pageData.Data = List;
            pageData.TotalItem = Count;
            pageData.QueryData = pageParams;
            pageData.PageHTML = base.PageHtml(Count, pageParams.CurPage, pageParams.PageSize, this.HttpContext);
            return View(pageData);
        }
        #endregion

        #region 新增
        /// <summary>
        /// 新增页面
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.LangList = _languageTypeAppService.QueryList(a => a.ID != Guid.Empty);
            return View();
        }

        /// <summary>
        /// 保存新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Create(ShortMsgTemplateDto model)
        {
            string errs = GetModelStateError();
            if (!string.IsNullOrEmpty(errs))
            {
                return Json(new OperateMessage<string>(OperateResult.Fail, true, errs));
            }
            bool IsSucceed = _ShortMsgTemplateAppService.Create(new ShortMsgTemplateDto()
            {
                ID = Guid.NewGuid(),
                CallEnumKey = model.CallEnumKey,
                Content = model.Content,
                LanguageTypeID=model.LanguageTypeID,
                CreateTime = DateTime.Now,
                CreatorID = _currUser.ID,
                IsDefault = model.IsDefault,
                LastUpdateTime = DateTime.Now,
                LastUpdateUserID = _currUser.ID,
                Title = model.Title,

            });
            if (IsSucceed)
            {
                return Json(new OperateMessage<string>("/ShortMsgTemplate/Index"));
            }
            return Json(new OperateMessage<string>(IsSucceed ? OperateResult.Success : OperateResult.Fail, true, IsSucceed ? "添加成功！" : "添加失败！"));

        }
        #endregion

        #region 编辑
        /// <summary>
        /// 编辑页面
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(Guid ID)
        {
            ViewBag.LangList = _languageTypeAppService.QueryList(a => a.ID != Guid.Empty);
            ShortMsgTemplateDto currModel = _ShortMsgTemplateAppService.Get(ID);
            return View(currModel);
        }

        /// <summary>
        /// 保存编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Edit(ShortMsgTemplateDto model)
        {
            string errs = GetModelStateError();
            if (!string.IsNullOrEmpty(errs))
            {
                return Json(new OperateMessage<string>(OperateResult.Fail, true, errs));
            }
            ShortMsgTemplateDto currModel = _ShortMsgTemplateAppService.Get(model.ID);
            if (currModel == null)
            {
                return Json(new OperateMessage<string>(OperateResult.Fail, true, "修改失败，修改的内容不存在！"));
            }
            currModel.LanguageTypeID = model.LanguageTypeID;
            currModel.CallEnumKey = model.CallEnumKey;
            currModel.Content = model.Content;
            currModel.IsDefault = model.IsDefault;
            currModel.LastUpdateTime = DateTime.Now;
            currModel.LastUpdateUserID = _currUser.ID;
            currModel.Title = model.Title;

            bool IsSucceed = _ShortMsgTemplateAppService.Edit(currModel);
            if (IsSucceed)
            {
                return Json(new OperateMessage<string>("/ShortMsgTemplate/Index"));
            }
            return Json(new OperateMessage<string>(IsSucceed ? OperateResult.Success : OperateResult.Fail, true, IsSucceed ? "修改成功！" : "修改失败！"));
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(string Ids)
        {
            string[] arr = Ids.Split(',').ToArray();
            if (arr.Length <= 0)
            {
                return Json(new { ret = "-999", msg = "请选择要删除的记录！" });
            }
            List<Guid> delIds = new List<Guid>();
            foreach (var item in arr)
            {
                delIds.Add(Guid.Parse(item));
            }
            bool IsSucceed = _ShortMsgTemplateAppService.DeleteBatch(delIds);
            return Json(new { ret = IsSucceed ? "0000" : "-999", msg = IsSucceed ? "删除成功！" : "删除失败，请先删除外键关联记录！" });
        }
        #endregion
    }
}