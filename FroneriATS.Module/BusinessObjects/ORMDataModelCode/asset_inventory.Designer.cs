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

    public partial class asset_inventory : XPLiteObject
    {
        int fasset_inventory_id;
        [Key(true)]
        [MemberDesignTimeVisibility(false)]
        [DevExpress.Xpo.DisplayName(@"Oid")]
        public int asset_inventory_id
        {
            get { return fasset_inventory_id; }
            set { SetPropertyValue<int>(nameof(asset_inventory_id), ref fasset_inventory_id, value); }
        }
        string fasset_inventory_name;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Inventory name")]
        [DevExpress.Persistent.Validation.RuleRequiredField("asset_inventory_asset_inventory_name_vld_req", DevExpress.Persistent.Validation.DefaultContexts.Save, "Please Enter Inventory Name")]
        public string asset_inventory_name
        {
            get { return fasset_inventory_name; }
            set { SetPropertyValue<string>(nameof(asset_inventory_name), ref fasset_inventory_name, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Assets")]
        [Association(@"assetReferencesasset_inventory")]
        public XPCollection<asset> assets { get { return GetCollection<asset>(nameof(assets)); } }
    }

}