﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace FroneriATS.Module.BusinessObjects.FroneriATS
{
    public static class ConnectionHelper
    {
        static Type[] persistentTypes = new Type[] {
            typeof(asset),
            typeof(asset_inventory),
            typeof(asset_model),
            typeof(asset_person),
            typeof(asset_status),
            typeof(asset_type)
        };
        public static Type[] GetPersistentTypes()
        {
            Type[] copy = new Type[persistentTypes.Length];
            Array.Copy(persistentTypes, copy, persistentTypes.Length);
            return copy;
        }
        public const string ConnectionString = @"XpoProvider=MSSqlServer;data source=.\SQL16;user id=sa;password=2491983;initial catalog=FroneriATS;Persist Security Info=true";
        public static void Connect(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, bool threadSafe = false)
        {
            if (threadSafe)
            {
                var provider = XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
                var dictionary = new DevExpress.Xpo.Metadata.ReflectionDictionary();
                dictionary.GetDataStoreSchema(persistentTypes);
                XpoDefault.DataLayer = new ThreadSafeDataLayer(dictionary, provider);
            }
            else
            {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
            }
            XpoDefault.Session = null;
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, out IDisposable[] objectsToDisposeOnDisconnect)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption, out objectsToDisposeOnDisconnect);
        }
        public static IDataLayer GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
        }
    }

}