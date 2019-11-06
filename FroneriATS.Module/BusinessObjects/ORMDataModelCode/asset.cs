using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace FroneriATS.Module.BusinessObjects.FroneriATS
{
    [DevExpress.Persistent.Base.DefaultClassOptions]
    [DevExpress.Persistent.Base.NavigationItem("Data Entry")]
    [DevExpress.ExpressApp.DC.XafDefaultProperty("asset_serial_number")]
    [DevExpress.ExpressApp.DC.XafDisplayName("Assets")]
    [DevExpress.ExpressApp.SystemModule.ListViewAutoFilterRow(true)]
    //[DevExpress.ExpressApp.DefaultListViewOptions(true, DevExpress.ExpressApp.NewItemRowPosition.Top)]
    [DevExpress.ExpressApp.ListViewFindPanel(true)]
    public partial class asset
    {
        public asset(Session session) : base(session) { }
        public override void AfterConstruction() {
            base.AfterConstruction();
            available = true;

        }
        //Audit Trail
        public XPCollection<DevExpress.Persistent.BaseImpl.AuditDataItemPersistent> AuditTrail => DevExpress.Persistent.BaseImpl.AuditedObjectWeakReference.GetAuditTrail(Session, this);
        protected override void OnSaving()
        {
            base.OnSaving();
            if (!IsLoading || asset_number == null)
            {
                DateTime now = Core.SqlOp.GetServerDateTime(Session);
                string number = $"{now.Year}{now.Month.ToString("00")}{now.Day.ToString("00")}{now.Hour.ToString("00")}{now.Minute.ToString("00")}{now.Second.ToString("00")}{now.Millisecond.ToString("00")}";
                asset_number = $"{asset_type_id?.asset_type_name}-{asset_model_id?.asset_model_name}-{number}";
            }
        }
    }

}
