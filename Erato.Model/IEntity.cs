﻿using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Erato.Model
{
    /// <summary>
    /// 通用实体接口
    /// </summary>
    /// <typeparam name="TKey">实体ID类型</typeparam>
    public interface IEntity<TKey>
    {
        /// <summary>
        /// 实体主键
        /// </summary>
        TKey _id { get; set; }
    }

    /// <summary>
    /// MongoDB实体接口
    /// </summary>
    public interface IMongoEntity : IEntity<string>
    {
    }
}
