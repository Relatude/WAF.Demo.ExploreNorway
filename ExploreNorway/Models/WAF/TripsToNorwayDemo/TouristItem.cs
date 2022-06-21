// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************


using System;
using WAF.Common;
using WAF.Definition;
using WAF.Engine;
using WAF.Engine.Content;
using WAF.Engine.Content.Native;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;
using WAF.Engine.Property;
using WAF.Data;
using WAF.Data.Query;
using WAF.Data.Query.TripsToNorwayDemo;
using WAF.Data.Content;
using WAF.Data.DataValue;
using WAF.Presentation.Web;

namespace WAF.Engine.Content.TripsToNorwayDemo {
    [Serializable]
    public partial class TouristItem: WAF.Engine.Content.Native.HierarchicalContent {
        FilePropertyValue _topPicture;
        public virtual FilePropertyValue TopPicture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("6dca7c1d-2d3f-4af5-905b-c297a82a2fed"),WAFID.GetDataValueId("5e337358-3342-4625-8d9f-2b48072aa24d"),WAFID.GetDataValueId("206ef12b-7de4-4b92-80e1-4b1dfd89a953"),WAFID.GetDataValueId("1ffef939-5d13-4ae8-9f2e-e5f5c516167f"),WAFID.GetDataValueId("b8e20b26-91e7-44b3-9588-9402c154e858"),WAFID.GetDataValueId("f2560a00-b3d6-4962-98b4-a731ae0483a1"), ref _topPicture, this, WAFID.GetDataValueId("c8b7c018-1373-4737-8367-754ae3ad977e")); }
        }
      
        LongStringPropertyValue _ingress;
        public virtual string Ingress {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("c294b117-9fc4-4411-8749-0dc5aafa091d"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("c294b117-9fc4-4411-8749-0dc5aafa091d"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> _pictures;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> Pictures{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile>.GetValue(WAFID.GetDataValueId("11a38463-1ce1-4aae-8a43-b3cf21776e86"), ref _pictures, this);}
        }
      
        HTMLPropertyValue _description;
        public virtual string Description {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("b88577f4-3c1d-4391-b503-127ba887afa9"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("b88577f4-3c1d-4391-b503-127ba887afa9"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> _relatedArticles;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent> RelatedArticles{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.Native.HierarchicalContent>.GetValue(WAFID.GetDataValueId("d1861dff-b400-40c6-a314-ff4ce604894a"), ref _relatedArticles, this);}
        }
      
        ShortStringPropertyValue _phone;
        public virtual string Phone {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("e421e037-0cab-4b90-b688-d9721e0ae8fe"), ref _phone, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("e421e037-0cab-4b90-b688-d9721e0ae8fe"), ref _phone, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _email;
        public virtual string Email {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("c893d748-7459-4dbf-a5ee-ccfd003f7ce9"), ref _email, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("c893d748-7459-4dbf-a5ee-ccfd003f7ce9"), ref _email, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _website;
        public virtual string Website {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("16e5015b-55b9-4fcb-8d9b-9c317b6db826"), ref _website, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("16e5015b-55b9-4fcb-8d9b-9c317b6db826"), ref _website, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        LongStringPropertyValue _addressPostalCode_old;
        public virtual string AddressPostalCode_old {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("30eb181e-ae51-443d-aad6-90ad15e4e41f"), ref _addressPostalCode_old, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("30eb181e-ae51-443d-aad6-90ad15e4e41f"), ref _addressPostalCode_old, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _addressRegion;
        public virtual string AddressRegion {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("8e7534f5-87c9-4bab-b76b-f154fa09b9a3"), ref _addressRegion, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("8e7534f5-87c9-4bab-b76b-f154fa09b9a3"), ref _addressRegion, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _addressLocality;
        public virtual string AddressLocality {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("9309d2b4-c1cb-463d-9c3c-e8ccac31d361"), ref _addressLocality, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("9309d2b4-c1cb-463d-9c3c-e8ccac31d361"), ref _addressLocality, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _addressPostBox;
        public virtual string AddressPostBox {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("77737ae9-01d6-4e26-8fb7-ff78f5571b02"), ref _addressPostBox, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("77737ae9-01d6-4e26-8fb7-ff78f5571b02"), ref _addressPostBox, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _addressStreet;
        public virtual string AddressStreet {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("5228593a-81bd-4778-8eb8-2bb7e7bc416f"), ref _addressStreet, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("5228593a-81bd-4778-8eb8-2bb7e7bc416f"), ref _addressStreet, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _addressPostalCode;
        public virtual string AddressPostalCode {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("09910c9d-1ee1-41e4-8642-d7218fb7e672"), ref _addressPostalCode, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("09910c9d-1ee1-41e4-8642-d7218fb7e672"), ref _addressPostalCode, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _addressFindingDirections;
        public virtual string AddressFindingDirections {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("2e529255-4dbf-46cd-9910-2f2245aa80fa"), ref _addressFindingDirections, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("2e529255-4dbf-46cd-9910-2f2245aa80fa"), ref _addressFindingDirections, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _addressCompanyName;
        public virtual string AddressCompanyName {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("d86975ed-c007-4b96-b7e3-4e856eea5171"), ref _addressCompanyName, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("d86975ed-c007-4b96-b7e3-4e856eea5171"), ref _addressCompanyName, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ItemReview> _relatedReviews;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ItemReview> RelatedReviews{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ItemReview>.GetValue(WAFID.GetDataValueId("fc5ac14c-aaa0-43ee-8c8d-19d2d3c0782e"), ref _relatedReviews, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<TouristItem>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<TouristItem>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<TouristItem>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd");
            }
        }

        public static int PropertyIdTopPicture {
            get {
                return WAFID.GetPropertyId("c8b7c018-1373-4737-8367-754ae3ad977e");
            }
        }

        public static int DataValueIdTopPictureToppicFilename {
            get {
                return WAFID.GetDataValueId("5e337358-3342-4625-8d9f-2b48072aa24d");
            }
        }

        public static int DataValueIdTopPictureToppicTypeName {
            get {
                return WAFID.GetDataValueId("206ef12b-7de4-4b92-80e1-4b1dfd89a953");
            }
        }

        public static int DataValueIdTopPictureToppicExtension {
            get {
                return WAFID.GetDataValueId("1ffef939-5d13-4ae8-9f2e-e5f5c516167f");
            }
        }

        public static int DataValueIdTopPictureToppicBytes {
            get {
                return WAFID.GetDataValueId("b8e20b26-91e7-44b3-9588-9402c154e858");
            }
        }

        public static int DataValueIdTopPictureToppicInfo {
            get {
                return WAFID.GetDataValueId("f2560a00-b3d6-4962-98b4-a731ae0483a1");
            }
        }

        public static int DataValueIdTopPictureToppicReference {
            get {
                return WAFID.GetDataValueId("6dca7c1d-2d3f-4af5-905b-c297a82a2fed");
            }
        }

        public static int PropertyIdIngress {
            get {
                return WAFID.GetPropertyId("c6af1170-2bb9-4739-a6e9-423dcc4516cd");
            }
        }

        public static int DataValueIdIngressIngress {
            get {
                return WAFID.GetDataValueId("c294b117-9fc4-4411-8749-0dc5aafa091d");
            }
        }

        public static int PropertyIdPictures {
            get {
                return WAFID.GetPropertyId("11a38463-1ce1-4aae-8a43-b3cf21776e86");
            }
        }

        public static int PropertyIdDescription {
            get {
                return WAFID.GetPropertyId("ed6cb390-367d-4b05-b137-6a14eae0d7b4");
            }
        }

        public static int DataValueIdDescriptionDescription {
            get {
                return WAFID.GetDataValueId("b88577f4-3c1d-4391-b503-127ba887afa9");
            }
        }

        public static int PropertyIdRelatedArticles {
            get {
                return WAFID.GetPropertyId("d1861dff-b400-40c6-a314-ff4ce604894a");
            }
        }

        public static int PropertyIdPhone {
            get {
                return WAFID.GetPropertyId("61b410be-d6fd-456a-8a02-84ef1c203fdc");
            }
        }

        public static int DataValueIdPhonePhone {
            get {
                return WAFID.GetDataValueId("e421e037-0cab-4b90-b688-d9721e0ae8fe");
            }
        }

        public static int PropertyIdEmail {
            get {
                return WAFID.GetPropertyId("6d70f265-c878-41b9-a5b0-0a8a99d8b3f5");
            }
        }

        public static int DataValueIdEmailEmail {
            get {
                return WAFID.GetDataValueId("c893d748-7459-4dbf-a5ee-ccfd003f7ce9");
            }
        }

        public static int PropertyIdWebsite {
            get {
                return WAFID.GetPropertyId("d0109497-7cc4-4020-b18a-b7af4a4ac387");
            }
        }

        public static int DataValueIdWebsiteWebsite {
            get {
                return WAFID.GetDataValueId("16e5015b-55b9-4fcb-8d9b-9c317b6db826");
            }
        }

        public static int PropertyIdAddressPostalCode_old {
            get {
                return WAFID.GetPropertyId("9b54897b-cb5a-4336-b687-d9a1a2c3b6e2");
            }
        }

        public static int DataValueIdAddressPostalCode_oldPostAddress {
            get {
                return WAFID.GetDataValueId("30eb181e-ae51-443d-aad6-90ad15e4e41f");
            }
        }

        public static int PropertyIdAddressRegion {
            get {
                return WAFID.GetPropertyId("6b4e17db-5476-4a35-ac14-52e3d67b8c79");
            }
        }

        public static int DataValueIdAddressRegionAddressregion {
            get {
                return WAFID.GetDataValueId("8e7534f5-87c9-4bab-b76b-f154fa09b9a3");
            }
        }

        public static int PropertyIdAddressLocality {
            get {
                return WAFID.GetPropertyId("2d0b050f-bb12-4625-8b82-e4571b057d19");
            }
        }

        public static int DataValueIdAddressLocalityAddresslocality {
            get {
                return WAFID.GetDataValueId("9309d2b4-c1cb-463d-9c3c-e8ccac31d361");
            }
        }

        public static int PropertyIdAddressPostBox {
            get {
                return WAFID.GetPropertyId("eb9e7712-10de-406b-a6c2-2c7ecb1a7535");
            }
        }

        public static int DataValueIdAddressPostBoxAddresspostbox {
            get {
                return WAFID.GetDataValueId("77737ae9-01d6-4e26-8fb7-ff78f5571b02");
            }
        }

        public static int PropertyIdAddressStreet {
            get {
                return WAFID.GetPropertyId("2c4dae90-e7f8-4e50-b642-9ba38ac9662b");
            }
        }

        public static int DataValueIdAddressStreetAddressstreet {
            get {
                return WAFID.GetDataValueId("5228593a-81bd-4778-8eb8-2bb7e7bc416f");
            }
        }

        public static int PropertyIdAddressPostalCode {
            get {
                return WAFID.GetPropertyId("49a44898-d36a-45ef-9d86-df5ed3d7d489");
            }
        }

        public static int DataValueIdAddressPostalCodeAddresspostalcode {
            get {
                return WAFID.GetDataValueId("09910c9d-1ee1-41e4-8642-d7218fb7e672");
            }
        }

        public static int PropertyIdAddressFindingDirections {
            get {
                return WAFID.GetPropertyId("4dea6711-b053-4e61-8b3e-e36c9fbb321e");
            }
        }

        public static int DataValueIdAddressFindingDirectionsAddressfindingdirections {
            get {
                return WAFID.GetDataValueId("2e529255-4dbf-46cd-9910-2f2245aa80fa");
            }
        }

        public static int PropertyIdAddressCompanyName {
            get {
                return WAFID.GetPropertyId("4c7eefe0-4e48-4a22-8fa2-71aa9fd045fe");
            }
        }

        public static int DataValueIdAddressCompanyNameAddresscompanyname {
            get {
                return WAFID.GetDataValueId("d86975ed-c007-4b96-b7e3-4e856eea5171");
            }
        }

        public static int PropertyIdRelatedReviews {
            get {
                return WAFID.GetPropertyId("fc5ac14c-aaa0-43ee-8c8d-19d2d3c0782e");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("c8b7c018-1373-4737-8367-754ae3ad977e")) {
                object init = TopPicture;
                return _topPicture;
            }
            else if (propertyId == WAFID.GetPropertyId("c6af1170-2bb9-4739-a6e9-423dcc4516cd")) {
                object init = Ingress;
                return _ingress;
            }
            else if (propertyId == WAFID.GetPropertyId("11a38463-1ce1-4aae-8a43-b3cf21776e86")) {
                object init = Pictures;
                return _pictures;
            }
            else if (propertyId == WAFID.GetPropertyId("ed6cb390-367d-4b05-b137-6a14eae0d7b4")) {
                object init = Description;
                return _description;
            }
            else if (propertyId == WAFID.GetPropertyId("d1861dff-b400-40c6-a314-ff4ce604894a")) {
                object init = RelatedArticles;
                return _relatedArticles;
            }
            else if (propertyId == WAFID.GetPropertyId("61b410be-d6fd-456a-8a02-84ef1c203fdc")) {
                object init = Phone;
                return _phone;
            }
            else if (propertyId == WAFID.GetPropertyId("6d70f265-c878-41b9-a5b0-0a8a99d8b3f5")) {
                object init = Email;
                return _email;
            }
            else if (propertyId == WAFID.GetPropertyId("d0109497-7cc4-4020-b18a-b7af4a4ac387")) {
                object init = Website;
                return _website;
            }
            else if (propertyId == WAFID.GetPropertyId("9b54897b-cb5a-4336-b687-d9a1a2c3b6e2")) {
                object init = AddressPostalCode_old;
                return _addressPostalCode_old;
            }
            else if (propertyId == WAFID.GetPropertyId("6b4e17db-5476-4a35-ac14-52e3d67b8c79")) {
                object init = AddressRegion;
                return _addressRegion;
            }
            else if (propertyId == WAFID.GetPropertyId("2d0b050f-bb12-4625-8b82-e4571b057d19")) {
                object init = AddressLocality;
                return _addressLocality;
            }
            else if (propertyId == WAFID.GetPropertyId("eb9e7712-10de-406b-a6c2-2c7ecb1a7535")) {
                object init = AddressPostBox;
                return _addressPostBox;
            }
            else if (propertyId == WAFID.GetPropertyId("2c4dae90-e7f8-4e50-b642-9ba38ac9662b")) {
                object init = AddressStreet;
                return _addressStreet;
            }
            else if (propertyId == WAFID.GetPropertyId("49a44898-d36a-45ef-9d86-df5ed3d7d489")) {
                object init = AddressPostalCode;
                return _addressPostalCode;
            }
            else if (propertyId == WAFID.GetPropertyId("4dea6711-b053-4e61-8b3e-e36c9fbb321e")) {
                object init = AddressFindingDirections;
                return _addressFindingDirections;
            }
            else if (propertyId == WAFID.GetPropertyId("4c7eefe0-4e48-4a22-8fa2-71aa9fd045fe")) {
                object init = AddressCompanyName;
                return _addressCompanyName;
            }
            else if (propertyId == WAFID.GetPropertyId("fc5ac14c-aaa0-43ee-8c8d-19d2d3c0782e")) {
                object init = RelatedReviews;
                return _relatedReviews;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _topPicture = null;
            _ingress = null;
            _pictures = null;
            _description = null;
            _relatedArticles = null;
            _phone = null;
            _email = null;
            _website = null;
            _addressPostalCode_old = null;
            _addressRegion = null;
            _addressLocality = null;
            _addressPostBox = null;
            _addressStreet = null;
            _addressPostalCode = null;
            _addressFindingDirections = null;
            _addressCompanyName = null;
            _relatedReviews = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlTouristItem {
        public static SqlTable Table {
            get {
                return new SqlTable("touristitem", WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString TopPicture_toppic_filename {
                get {
                    return new SqlFieldShortString("toppic_filename", Table, WAFID.GetDataValueId("5e337358-3342-4625-8d9f-2b48072aa24d"));
                }
            }

            public static SqlFieldShortString TopPicture_toppic_type_name {
                get {
                    return new SqlFieldShortString("toppic_type_name", Table, WAFID.GetDataValueId("206ef12b-7de4-4b92-80e1-4b1dfd89a953"));
                }
            }

            public static SqlFieldShortString TopPicture_toppic_extension {
                get {
                    return new SqlFieldShortString("toppic_extension", Table, WAFID.GetDataValueId("1ffef939-5d13-4ae8-9f2e-e5f5c516167f"));
                }
            }

            public static SqlFieldFloat TopPicture_toppic_bytes {
                get {
                    return new SqlFieldFloat("toppic_bytes", Table, WAFID.GetDataValueId("b8e20b26-91e7-44b3-9588-9402c154e858"));
                }
            }

            public static SqlFieldLongString TopPicture_toppic_info {
                get {
                    return new SqlFieldLongString("toppic_info", Table, WAFID.GetDataValueId("f2560a00-b3d6-4962-98b4-a731ae0483a1"));
                }
            }

            public static SqlFieldInteger TopPicture_toppic_reference {
                get {
                    return new SqlFieldInteger("toppic_reference", Table, WAFID.GetDataValueId("6dca7c1d-2d3f-4af5-905b-c297a82a2fed"));
                }
            }

            public static SqlFieldLongString Ingress {
                get {
                    return new SqlFieldLongString("ingress", Table, WAFID.GetDataValueId("c294b117-9fc4-4411-8749-0dc5aafa091d"));
                }
            }

            public static SqlFieldLongString Description {
                get {
                    return new SqlFieldLongString("description", Table, WAFID.GetDataValueId("b88577f4-3c1d-4391-b503-127ba887afa9"));
                }
            }

            public static SqlFieldShortString Phone {
                get {
                    return new SqlFieldShortString("phone", Table, WAFID.GetDataValueId("e421e037-0cab-4b90-b688-d9721e0ae8fe"));
                }
            }

            public static SqlFieldShortString Email {
                get {
                    return new SqlFieldShortString("email", Table, WAFID.GetDataValueId("c893d748-7459-4dbf-a5ee-ccfd003f7ce9"));
                }
            }

            public static SqlFieldShortString Website {
                get {
                    return new SqlFieldShortString("website", Table, WAFID.GetDataValueId("16e5015b-55b9-4fcb-8d9b-9c317b6db826"));
                }
            }

            public static SqlFieldLongString AddressPostalCode_old {
                get {
                    return new SqlFieldLongString("post_address", Table, WAFID.GetDataValueId("30eb181e-ae51-443d-aad6-90ad15e4e41f"));
                }
            }

            public static SqlFieldShortString AddressRegion {
                get {
                    return new SqlFieldShortString("addressregion", Table, WAFID.GetDataValueId("8e7534f5-87c9-4bab-b76b-f154fa09b9a3"));
                }
            }

            public static SqlFieldShortString AddressLocality {
                get {
                    return new SqlFieldShortString("addresslocality", Table, WAFID.GetDataValueId("9309d2b4-c1cb-463d-9c3c-e8ccac31d361"));
                }
            }

            public static SqlFieldShortString AddressPostBox {
                get {
                    return new SqlFieldShortString("addresspostbox", Table, WAFID.GetDataValueId("77737ae9-01d6-4e26-8fb7-ff78f5571b02"));
                }
            }

            public static SqlFieldShortString AddressStreet {
                get {
                    return new SqlFieldShortString("addressstreet", Table, WAFID.GetDataValueId("5228593a-81bd-4778-8eb8-2bb7e7bc416f"));
                }
            }

            public static SqlFieldShortString AddressPostalCode {
                get {
                    return new SqlFieldShortString("addresspostalcode", Table, WAFID.GetDataValueId("09910c9d-1ee1-41e4-8642-d7218fb7e672"));
                }
            }

            public static SqlFieldShortString AddressFindingDirections {
                get {
                    return new SqlFieldShortString("addressfindingdirections", Table, WAFID.GetDataValueId("2e529255-4dbf-46cd-9910-2f2245aa80fa"));
                }
            }

            public static SqlFieldShortString AddressCompanyName {
                get {
                    return new SqlFieldShortString("addresscompanyname", Table, WAFID.GetDataValueId("d86975ed-c007-4b96-b7e3-4e856eea5171"));
                }
            }

        }
    }
    public class SqlAliasTouristItem : SqlAlias {
        public SqlAliasTouristItem()
            : base(SqlTouristItem.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlTouristItem.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_filename {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.TopPicture_toppic_filename, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.TopPicture_toppic_type_name, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_extension {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.TopPicture_toppic_extension, this);
            }
        }

        public SqlExpressionFieldFloat TopPicture_toppic_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlTouristItem.Field.TopPicture_toppic_bytes, this);
            }
        }

        public SqlExpressionFieldLongString TopPicture_toppic_info {
            get {
                return new SqlExpressionFieldLongString(SqlTouristItem.Field.TopPicture_toppic_info, this);
            }
        }

        public SqlExpressionFieldInteger TopPicture_toppic_reference {
            get {
                return new SqlExpressionFieldInteger(SqlTouristItem.Field.TopPicture_toppic_reference, this);
            }
        }

        public SqlExpressionFieldLongString Ingress {
            get {
                return new SqlExpressionFieldLongString(SqlTouristItem.Field.Ingress, this);
            }
        }

        public SqlExpressionFieldLongString Description {
            get {
                return new SqlExpressionFieldLongString(SqlTouristItem.Field.Description, this);
            }
        }

        public SqlExpressionFieldShortString Phone {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.Phone, this);
            }
        }

        public SqlExpressionFieldShortString Email {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.Email, this);
            }
        }

        public SqlExpressionFieldShortString Website {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.Website, this);
            }
        }

        public SqlExpressionFieldLongString AddressPostalCode_old {
            get {
                return new SqlExpressionFieldLongString(SqlTouristItem.Field.AddressPostalCode_old, this);
            }
        }

        public SqlExpressionFieldShortString AddressRegion {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.AddressRegion, this);
            }
        }

        public SqlExpressionFieldShortString AddressLocality {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.AddressLocality, this);
            }
        }

        public SqlExpressionFieldShortString AddressPostBox {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.AddressPostBox, this);
            }
        }

        public SqlExpressionFieldShortString AddressStreet {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.AddressStreet, this);
            }
        }

        public SqlExpressionFieldShortString AddressPostalCode {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.AddressPostalCode, this);
            }
        }

        public SqlExpressionFieldShortString AddressFindingDirections {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.AddressFindingDirections, this);
            }
        }

        public SqlExpressionFieldShortString AddressCompanyName {
            get {
                return new SqlExpressionFieldShortString(SqlTouristItem.Field.AddressCompanyName, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlTouristItem{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")); 
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_filename, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_type_name, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_extension, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyFloat TopPicture_toppic_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_bytes, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyLongString TopPicture_toppic_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_info, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyInteger TopPicture_toppic_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.TopPicture_toppic_reference, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyLongString Ingress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.Ingress, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyLongString Description {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.Description, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyRelation RelatedArticles {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("d1861dff-b400-40c6-a314-ff4ce604894a"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItem(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelTouristItemRelatedArticles.Relation));
            }
        }

        public static AqlPropertyShortString Phone {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.Phone, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString Email {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.Email, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString Website {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.Website, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyLongString AddressPostalCode_old {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressPostalCode_old, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString AddressRegion {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressRegion, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString AddressLocality {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressLocality, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString AddressPostBox {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressPostBox, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString AddressStreet {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressStreet, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString AddressPostalCode {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressPostalCode, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString AddressFindingDirections {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressFindingDirections, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString AddressCompanyName {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlTouristItem.Field.AddressCompanyName, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyRelation RelatedReviews {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("fc5ac14c-aaa0-43ee-8c8d-19d2d3c0782e"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItem(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasItemReview(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelTouristItem_ItemReview.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyRelation ContentTags {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a4e4d56c-8ff9-4ede-9232-094e72398668"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasContentTag(), WAF.Engine.Query.Native.AqlRelTaxonomyHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Children {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("cc90eccd-1d77-40c8-aab7-5262842a66e2"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Parent {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a1eca898-8f93-4522-a46c-669c56af9b55"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyBoolean ShowInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasTouristItem
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasTouristItem()
            : base(WAFID.GetContentClassId("5bbadc74-378c-4a7a-a994-3719a949c1cd")) {

        }

        public AqlAliasTouristItem(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString TopPicture_toppic_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.TopPicture_toppic_filename, this);
            }
        }

        public AqlExpressionPropertyShortString TopPicture_toppic_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.TopPicture_toppic_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString TopPicture_toppic_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.TopPicture_toppic_extension, this);
            }
        }

        public AqlExpressionPropertyFloat TopPicture_toppic_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlTouristItem.TopPicture_toppic_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString TopPicture_toppic_info {
            get {
                return new AqlExpressionPropertyLongString(AqlTouristItem.TopPicture_toppic_info, this);
            }
        }

        public AqlExpressionPropertyInteger TopPicture_toppic_reference {
            get {
                return new AqlExpressionPropertyInteger(AqlTouristItem.TopPicture_toppic_reference, this);
            }
        }

        public AqlExpressionPropertyLongString Ingress {
            get {
                return new AqlExpressionPropertyLongString(AqlTouristItem.Ingress, this);
            }
        }

        public AqlExpressionPropertyLongString Description {
            get {
                return new AqlExpressionPropertyLongString(AqlTouristItem.Description, this);
            }
        }

        public AqlExpressionPropertyShortString Phone {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.Phone, this);
            }
        }

        public AqlExpressionPropertyShortString Email {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.Email, this);
            }
        }

        public AqlExpressionPropertyShortString Website {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.Website, this);
            }
        }

        public AqlExpressionPropertyLongString AddressPostalCode_old {
            get {
                return new AqlExpressionPropertyLongString(AqlTouristItem.AddressPostalCode_old, this);
            }
        }

        public AqlExpressionPropertyShortString AddressRegion {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.AddressRegion, this);
            }
        }

        public AqlExpressionPropertyShortString AddressLocality {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.AddressLocality, this);
            }
        }

        public AqlExpressionPropertyShortString AddressPostBox {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.AddressPostBox, this);
            }
        }

        public AqlExpressionPropertyShortString AddressStreet {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.AddressStreet, this);
            }
        }

        public AqlExpressionPropertyShortString AddressPostalCode {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.AddressPostalCode, this);
            }
        }

        public AqlExpressionPropertyShortString AddressFindingDirections {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.AddressFindingDirections, this);
            }
        }

        public AqlExpressionPropertyShortString AddressCompanyName {
            get {
                return new AqlExpressionPropertyShortString(AqlTouristItem.AddressCompanyName, this);
            }
        }

    }
}
