using System.Collections.Generic;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.AuditTrail;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace FroneriATS.Module.Controllers
{
    // ReSharper disable once InconsistentNaming
    public class ctr_EditMode : ViewController<DetailView>
    {
        
        protected override void OnActivated()
        {
            base.OnActivated();
            if (View.ViewEditMode == ViewEditMode.View)
            {
                View.ViewEditMode = ViewEditMode.Edit;
            }
        }
    }
}
