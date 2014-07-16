﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Easy4net.Common;

namespace Easy4net.EntityManager
{
    public interface EntityManager
    {
        IDbTransaction Transaction{get;set;}

        int Save<T>(T entity) where T : new();

        int Update<T>(T entity) where T : new();

        int Remove<T>(T entity);

        int Remove<T>(object id) where T : new();

        List<T> FindAll<T>() where T : new();

        List<T> FindBySql<T>(string strSql) where T : new();

        List<T> FindBySql<T>(string strSql, int pageIndex, int pageSize, string order, bool desc) where T : new();

        List<T> FindBySql<T>(string strSql, ParamMap param) where T : new();

        List<T> FindByProperty<T>(string propertyName, object propertyValue) where T : new();

        T FindById<T>(object id) where T : new();        

        int FindCount<T>() where T : new();

        int FindCount<T>(DbCondition condition) where T : new();

        int FindCount<T>(string propertyName, object propertyValue) where T : new();

        List<T> Find<T>(DbCondition condition) where T : new();
    }
}
