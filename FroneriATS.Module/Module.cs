using System;
using System.Text;
using System.Linq;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using System.Collections.Generic;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo;
using FroneriATS.Module.BusinessObjects.FroneriATS;

namespace FroneriATS.Module {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppModuleBasetopic.aspx.
    public sealed partial class FroneriATSModule : ModuleBase {
        public FroneriATSModule() {
            InitializeComponent();
            DevExpress.Persistent.BaseImpl.BaseObject.OidInitializationMode = DevExpress.Persistent.BaseImpl.OidInitializationMode.AfterConstruction;
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }
        public override void Setup(XafApplication application) {
            base.Setup(application);
            // Manage various aspects of the application UI and behavior at the module level.
        }
        public override void CustomizeTypesInfo(ITypesInfo typesInfo) {
            base.CustomizeTypesInfo(typesInfo);
            CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo);

            CustomizeUserInventoryWUserTypeInfo(typesInfo);
        }

        private void CustomizeUserInventoryWUserTypeInfo(ITypesInfo typesInfo)
        {
            //obj
            TypeInfo objTypeInfo = typesInfo.FindTypeInfo(typeof(user_inventory)) as TypeInfo;
            IMemberInfo objmemberInfo = objTypeInfo.FindMember("user_id");
            objmemberInfo.AddAttribute(
                new AssociationAttribute("user_inventoryReferencesUser", typeof(PermissionPolicyUser)), true);
            //collection
            TypeInfo collectionTypeInfo = typesInfo.FindTypeInfo(typeof(PermissionPolicyUser)) as TypeInfo;
            IMemberInfo collectionmemberInfo =
                collectionTypeInfo.CreateMember("user_inventories", typeof(XPCollection<user_inventory>));
            collectionmemberInfo.AddAttribute(new DevExpress.Xpo.DisplayNameAttribute("User Inventories"));
            collectionmemberInfo.AddAttribute(
                new AssociationAttribute("user_inventoryReferencesUser", typeof(user_inventory)), true);
            collectionmemberInfo.AddAttribute(new DevExpress.Xpo.AggregatedAttribute(), true);
            //refresh
            ((XafMemberInfo)objmemberInfo).Refresh();
            ((XafMemberInfo)collectionmemberInfo).Refresh();

        }
    }
}
