using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Validation;

namespace FroneriATS.Module.BusinessObjects.FroneriATS
{
    [DevExpress.Persistent.Base.DefaultClassOptions]
    [DevExpress.Persistent.Base.NavigationItem("Printer")]
    [DevExpress.ExpressApp.DC.XafDefaultProperty("serial_number")]
    [DevExpress.ExpressApp.DC.XafDisplayName("Printer")]
    [DevExpress.ExpressApp.SystemModule.ListViewAutoFilterRow(true)]
    //[DevExpress.ExpressApp.DefaultListViewOptions(true, DevExpress.ExpressApp.NewItemRowPosition.Top)]
    [DevExpress.ExpressApp.ListViewFindPanel(true)]
    //[RuleCriteria("printer_serial_length_length", DefaultContexts.Save, "LEN(serial_number) == model_id.serial_length", "Incorrect Serial Number Length", SkipNullOrEmptyValues = false)]

    public partial class printer
    {
        public printer(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            status_id = Session.GetObjectByKey<printer_status>(5);
            available = true;
        }
        //Audit Trail
        public XPCollection<DevExpress.Persistent.BaseImpl.AuditDataItemPersistent> AuditTrail => DevExpress.Persistent.BaseImpl.AuditedObjectWeakReference.GetAuditTrail(Session, this);
    }

}
