﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Vic.Core.Application.IServices;
using Vic.Core.Domain.IRepositories;
using System.Linq;
using System.Linq.Expressions;
using Vic.Core.Application.Dtos;
using AutoMapper;
using Vic.Core.Domain.Entities;

namespace Vic.Core.Application.Services
{
    public class BannerAppService : IBannerAppService
    {
        #region interface inject
        private readonly IBannerRepository _repository;
        private static ILogger<BannerAppService> _log;
        /// <summary>
        /// interface inject
        /// </summary>
        /// <param name="log">log</param>
        /// <param name="repository">repository</param>
        public BannerAppService(ILogger<BannerAppService> log, IBannerRepository repository)
        {
            _log = log;
            _repository = repository;
        }
        #endregion

      
	    #region implement interface by master
        /// <summary>
        /// create new record
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool Create(BannerDto dto)
        {
            try
            {
                var entity = _repository.InsertOrUpdate(Mapper.Map<Banner>(dto));
                return entity == null ? false : true;
            }
            catch (Exception ex)
            {
                _log.LogError("BannerAppService Create error occured:" + ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Delete Batch by ids
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public bool DeleteBatch(List<Guid> ids)
        {
            try
            {
                _repository.Delete(it => ids.Contains(it.ID));
                return true;
            }
            catch (Exception ex)
            {
                _log.LogError("BannerAppService DeleteBatch error occured:" + ex.Message);
                return false;
            }
        }
        /// <summary>
        /// delete by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(Guid id)
        {
            try
            {
                _repository.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                _log.LogError("BannerAppService Delete error occured:" + ex.Message);
                return false;
            }
        }
        /// <summary>
        /// edit 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool Edit(BannerDto dto)
        {
            try
            {
                var entity = _repository.InsertOrUpdate(Mapper.Map<Banner>(dto));
                return entity == null ? false : true;
            }
            catch (Exception ex)
            {
                _log.LogError("BannerAppService Edit error occured:" + ex.Message);
                return false;
            }
        }
        /// <summary>
        /// get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BannerDto Get(Guid id)
        {
            try
            {
                return Mapper.Map<BannerDto>(_repository.Get(id));
            }
            catch (Exception ex)
            {
                _log.LogError("BannerAppService Get error occured:" + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// query all form table
        /// </summary>
        /// <returns></returns>
        public List<BannerDto> List()
        {
            try
            {
                return Mapper.Map<List<BannerDto>>(_repository.GetAllList(it => it.ID != Guid.Empty).OrderByDescending(it => it.CreateTime));
            }
            catch (Exception ex)
            {
                _log.LogError("BannerAppService List error occured:" + ex.Message);
                return null;
            }
        }
        /// <summary>
        ///  query list by lanbuda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<BannerDto> QueryList(Expression<Func<Banner, bool>> predicate)
        {
            try
            {
                return Mapper.Map<List<BannerDto>>(_repository.QueryList(predicate));
            }
            catch (Exception ex)
            {
                _log.LogError("BannerAppService List error occured:" + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// query pager by lanbuda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="pageSize"></param>
        /// <param name="curPage"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<BannerDto> PageList(Expression<Func<Banner, bool>> predicate, int pageSize, int curPage, out int count)
        {
            try
            {
                return Mapper.Map<List<BannerDto>>(_repository.LoadPageList(curPage, pageSize, out count, predicate, a => a.CreateTime));
            }
            catch (Exception ex)
            {
                count = 0;
                _log.LogError("BannerAppService PageList error occured:" + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// query signal record by lanbuda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public BannerDto Get(Expression<Func<Banner, bool>> predicate)
        {
            try
            {
                return Mapper.Map<BannerDto>(_repository.FirstOrDefault(predicate));
            }
            catch (Exception ex)
            {

                _log.LogError("BannerAppService Get lanbuda error occured:" + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// query total count by lanbuda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public int Count(Expression<Func<Banner, bool>> predicate)
        {
            try
            {
                return _repository.Count(predicate);
            }
            catch (Exception ex)
            {

                _log.LogError("BannerAppService Count error occured:" + ex.Message);
                return 0;
            }
        }
        /// <summary>
        /// query properties by lanbuda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public IQueryable<object> QueryProperty(Expression<Func<Banner, bool>> predicate, Expression<Func<Banner, object>> selector)
        {
            try
            {
                return _repository.QueryProperty(predicate, selector);
            }
            catch (Exception ex)
            {

                _log.LogError("BannerAppService QueryProperty error occured:" + ex.Message);
                return null;
            }
        }
        #endregion

		#region  implement interface by  by slaves
		/// <summary>
        /// get by id ByReadOnlyDB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BannerDto GetByReadOnlyDB(Guid id)
        {
            try
            {
                return Mapper.Map<BannerDto>(_repository.GetByReadOnlyDB(id));
            }
            catch (Exception ex)
            {
                _log.LogError("BannerAppService GetByReadOnlyDB error occured:" + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// query all form table ByReadOnlyDB
        /// </summary>
        /// <returns></returns>
        public List<BannerDto> ListByReadOnlyDB()
        {
            try
            {
                return Mapper.Map<List<BannerDto>>(_repository.GetAllListByReadOnlyDB(it => it.ID != Guid.Empty).OrderByDescending(it => it.CreateTime));
            }
            catch (Exception ex)
            {
                _log.LogError("BannerAppService ListByReadOnlyDB error occured:" + ex.Message);
                return null;
            }
        }
        /// <summary>
        ///  query list by lanbuda expression ByReadOnlyDB
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<BannerDto> QueryListByReadOnlyDB(Expression<Func<Banner, bool>> predicate)
        {
            try
            {
                return Mapper.Map<List<BannerDto>>(_repository.QueryListByReadOnlyDB(predicate));
            }
            catch (Exception ex)
            {
                _log.LogError("BannerAppService ListByReadOnlyDB error occured:" + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// query pager by lanbuda expression ByReadOnlyDB
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="pageSize"></param>
        /// <param name="curPage"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<BannerDto> PageListByReadOnlyDB(Expression<Func<Banner, bool>> predicate, int pageSize, int curPage, out int count)
        {
            try
            {
                return Mapper.Map<List<BannerDto>>(_repository.LoadPageListByReadOnlyDB(curPage, pageSize, out count, predicate, a => a.CreateTime));
            }
            catch (Exception ex)
            {
                count = 0;
                _log.LogError("BannerAppService PageListByReadOnlyDB error occured:" + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// query signal record by lanbuda expression ByReadOnlyDB
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public BannerDto GetByReadOnlyDB(Expression<Func<Banner, bool>> predicate)
        {
            try
            {
                return Mapper.Map<BannerDto>(_repository.FirstOrDefaultByReadOnlyDB(predicate));
            }
            catch (Exception ex)
            {

                _log.LogError("BannerAppService GetByReadOnlyDB lanbuda error occured:" + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// query total count by lanbuda expression ByReadOnlyDB
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public int CountByReadOnlyDB(Expression<Func<Banner, bool>> predicate)
        {
            try
            {
                return _repository.CountByReadOnlyDB(predicate);
            }
            catch (Exception ex)
            {

                _log.LogError("BannerAppService CountByReadOnlyDB error occured:" + ex.Message);
                return 0;
            }
        }
        /// <summary> 
        /// query properties by lanbuda expression ByReadOnlyDB
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public IQueryable<object> QueryPropertyByReadOnlyDB(Expression<Func<Banner, bool>> predicate, Expression<Func<Banner, object>> selector)
        {
            try
            {
                return _repository.QueryPropertyByReadOnlyDB(predicate, selector);
            }
            catch (Exception ex)
            {

                _log.LogError("BannerAppService QueryPropertyByReadOnlyDB error occured:" + ex.Message);
                return null;
            }
        }
		#endregion
    }
}
