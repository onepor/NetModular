﻿using System.Threading.Tasks;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.Admin.Application.SystemService.ViewModels;

namespace NetModular.Module.Admin.Application.SystemService
{
    /// <summary>
    /// 系统相关服务
    /// </summary>
    public interface ISystemService
    {
        /// <summary>
        /// 获取系统配置信息
        /// </summary>
        /// <returns></returns>
        Task<IResultModel<SystemConfigModel>> GetConfig(string host = null);

        /// <summary>
        /// 更改系统配置
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        IResultModel UpdateConfig(SystemConfigModel model);
    }
}
