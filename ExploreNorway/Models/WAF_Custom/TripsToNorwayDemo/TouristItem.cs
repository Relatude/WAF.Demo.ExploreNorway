
// WAF Custom. Add your own code here to customize the default behavior.
using System;
using WAF.Common;
using WAF.Definition;
using WAF.Engine;
using WAF.Engine.Content.Native;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;
using WAF.Engine.Property;
using WAF.Data;
using WAF.Data.Query;
using WAF.Data.Query.TripsToNorwayDemo;
using WAF.Data.Content;
using WAF.Data.DataValue;

namespace WAF.Engine.Content.TripsToNorwayDemo {

    public partial class TouristItem {

        public override void OnInit() {

            base.OnInit();
        }

        public override void OnNew() {

            base.OnNew();
        }

        public override void OnBeforeInsert() {

             base.OnBeforeInsert();
        }

        public override void OnBeforeUpdate() {

             base.OnBeforeUpdate();
        }

        public override void OnAfterInsert() {

             base.OnAfterInsert();
        }

        public override void OnAfterUpdate() {

             base.OnAfterUpdate();
        }

        public override void OnAfterDelete(bool permanently) {

             base.OnAfterDelete(permanently);
        }
        public FilePropertyValue GetPicture() {
            if (this.TopPicture.IsImage()) {
                return this.TopPicture;
            } else if (this.Pictures.Count > 0) {
                var file = this.Pictures.GetByIndex(0);
                if (file.File.IsImage()) {
                    return file.File;
                }
            }
            return null;
        }

    }
}
