using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using FroneriATS.Module.BusinessObjects.FroneriATS;

namespace FroneriEG.Module.BusinessObjects.NonPersistent
{
    [DomainComponent]
    [NavigationItem(false)]
    [DefaultProperty("ID")]
    [XafDefaultProperty("ID")]
    [XafDisplayName("Change Printer Status")]
    //[DevExpress.ExpressApp.SystemModule.ListViewAutoFilterRow(true)]
    [ListViewFindPanel(true)]
    public class ChangePrinterStatus : IXafEntityObject, IObjectSpaceLink, INotifyPropertyChanged
    {
        private IObjectSpace objectSpace;
        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public ChangePrinterStatus()
        {
        }
        // Add this property as the key member in the CustomizeTypesInfo event
        [Browsable(false)]  // Hide the entity identifier from UI.
        public string ID { get; set; }

        private printer_status fstatus_id;
        [XafDisplayName("Status")]
        public printer_status status_id
        {
            get => fstatus_id;
            set
            {
                if (fstatus_id != value)
                {
                    fstatus_id = value;
                    OnPropertyChanged();
                }
            }
        }


        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.SampleProperty = "Paid";
        //}

        #region IXafEntityObject members (see https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppIXafEntityObjecttopic.aspx)
        void IXafEntityObject.OnCreated()
        {
            // Place the entity initialization code here.
            // You can initialize reference properties using Object Space methods; e.g.:
            //Get Last Email
            //IObjectSpace objSpace = ((NonPersistentObjectSpace)objectSpace).AdditionalObjectSpaces[0];
        }
        void IXafEntityObject.OnLoaded()
        {
            // Place the code that is executed each time the entity is loaded here.
        }
        void IXafEntityObject.OnSaving()
        {
            // Place the code that is executed each time the entity is saved here.
        }
        #endregion

        #region IObjectSpaceLink members (see https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppIObjectSpaceLinktopic.aspx)
        // Use the Object Space to access other entities from IXafEntityObject methods (see https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113707.aspx).
        IObjectSpace IObjectSpaceLink.ObjectSpace
        {
            get { return objectSpace; }
            set { objectSpace = value; }
        }
        #endregion

        #region INotifyPropertyChanged members (see http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(v=vs.110).aspx)
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}