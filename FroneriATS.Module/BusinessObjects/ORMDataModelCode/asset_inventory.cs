using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace FroneriATS.Module.BusinessObjects.FroneriATS
{
    [DevExpress.Persistent.Base.DefaultClassOptions]
    [DevExpress.Persistent.Base.NavigationItem("Data Entry")]
    [DevExpress.ExpressApp.DC.XafDefaultProperty("asset_inventory_name")]
    [DevExpress.ExpressApp.DC.XafDisplayName("Inventory")]
    [DevExpress.ExpressApp.SystemModule.ListViewAutoFilterRow(true)]
    //[DevExpress.ExpressApp.DefaultListViewOptions(true, DevExpress.ExpressApp.NewItemRowPosition.Top)]
    [DevExpress.ExpressApp.ListViewFindPanel(true)]
    public partial class asset_inventory
    {
        public asset_inventory(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        //Audit Trail
        public XPCollection<DevExpress.Persistent.BaseImpl.AuditDataItemPersistent> AuditTrail => DevExpress.Persistent.BaseImpl.AuditedObjectWeakReference.GetAuditTrail(Session, this);
    }

}
