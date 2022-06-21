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
    public partial class Location: WAF.Engine.Content.Native.HierarchicalContent {
        FilePropertyValue _topPicture;
        public virtual FilePropertyValue TopPicture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("21399924-99ea-481c-9f03-77aa90847d5a"),WAFID.GetDataValueId("ef039c9d-7eed-402e-b4a9-e5b6f9b9db4c"),WAFID.GetDataValueId("e25fd665-10d3-4d41-8d8c-e6b117cb61da"),WAFID.GetDataValueId("cf4ab9f7-e048-4a3f-8761-a6df240cada0"),WAFID.GetDataValueId("8f0eb2a7-7ecc-44e7-aa56-913e8f89b1d4"),WAFID.GetDataValueId("3c2b8d5d-84ef-4345-9ecf-aeccd00743c5"), ref _topPicture, this, WAFID.GetDataValueId("56500c39-1ec2-4d34-8526-cac10f04cadc")); }
        }
      
        NodeRelationPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Region> _region;
        public virtual NodeRelationPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Region> Region{
        get { EnsureContentDataIndependence(); return NodeRelationPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Region>.GetValue(WAFID.GetDataValueId("486f617c-8946-4ef2-b567-06dbeb89da4f"), ref _region, this);}
        }
      
        LongStringPropertyValue _ingress;
        public virtual string Ingress {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("cd9b3a8c-dba2-4f3b-9c06-76461bbf20e4"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("cd9b3a8c-dba2-4f3b-9c06-76461bbf20e4"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> _pictures;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> Pictures{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile>.GetValue(WAFID.GetDataValueId("5be8c834-f167-47af-9bab-67290df31bc6"), ref _pictures, this);}
        }
      
        HTMLPropertyValue _description;
        public virtual string Description {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("d5c233bc-b7c7-45ee-8218-f17bc7afc4a2"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("d5c233bc-b7c7-45ee-8218-f17bc7afc4a2"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem> _attractions;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem> Attractions{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem>.GetValue(WAFID.GetDataValueId("b7702ede-0a11-425f-b2f9-bdd5291b8e9e"), ref _attractions, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristActivity> _activities;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristActivity> Activities{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristActivity>.GetValue(WAFID.GetDataValueId("1e915686-9c7f-486e-a9bb-fc4fb4681679"), ref _activities, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Accommodation> _accommodations;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Accommodation> Accommodations{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Accommodation>.GetValue(WAFID.GetDataValueId("d3069e79-9b01-4aa5-b936-7787a699d582"), ref _accommodations, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.PlaceToEatOrDrink> _foodAndDrink;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.PlaceToEatOrDrink> FoodAndDrink{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.PlaceToEatOrDrink>.GetValue(WAFID.GetDataValueId("a7882715-4fea-4447-ad8c-c03e792b52ad"), ref _foodAndDrink, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Shopping> _shopping;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Shopping> Shopping{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Shopping>.GetValue(WAFID.GetDataValueId("7245a0b6-f66b-4a61-a4a6-f692b6f2ea7b"), ref _shopping, this);}
        }
      
        ShortStringPropertyValue _longitude;
        public virtual string Longitude {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("3f0c3a6b-d638-4a4b-b7a4-38a75227129c"), ref _longitude, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("3f0c3a6b-d638-4a4b-b7a4-38a75227129c"), ref _longitude, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _latitude;
        public virtual string Latitude {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("5b23f26e-0922-4383-9e75-02cf6a601c96"), ref _latitude, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("5b23f26e-0922-4383-9e75-02cf6a601c96"), ref _latitude, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Location>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Location>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Location>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab");
            }
        }

        public static int PropertyIdTopPicture {
            get {
                return WAFID.GetPropertyId("56500c39-1ec2-4d34-8526-cac10f04cadc");
            }
        }

        public static int DataValueIdTopPictureToppicFilename {
            get {
                return WAFID.GetDataValueId("ef039c9d-7eed-402e-b4a9-e5b6f9b9db4c");
            }
        }

        public static int DataValueIdTopPictureToppicTypeName {
            get {
                return WAFID.GetDataValueId("e25fd665-10d3-4d41-8d8c-e6b117cb61da");
            }
        }

        public static int DataValueIdTopPictureToppicExtension {
            get {
                return WAFID.GetDataValueId("cf4ab9f7-e048-4a3f-8761-a6df240cada0");
            }
        }

        public static int DataValueIdTopPictureToppicBytes {
            get {
                return WAFID.GetDataValueId("8f0eb2a7-7ecc-44e7-aa56-913e8f89b1d4");
            }
        }

        public static int DataValueIdTopPictureToppicInfo {
            get {
                return WAFID.GetDataValueId("3c2b8d5d-84ef-4345-9ecf-aeccd00743c5");
            }
        }

        public static int DataValueIdTopPictureToppicReference {
            get {
                return WAFID.GetDataValueId("21399924-99ea-481c-9f03-77aa90847d5a");
            }
        }

        public static int PropertyIdRegion {
            get {
                return WAFID.GetPropertyId("486f617c-8946-4ef2-b567-06dbeb89da4f");
            }
        }

        public static int PropertyIdIngress {
            get {
                return WAFID.GetPropertyId("7be79d29-bf3f-40f0-b686-d63da32ebc78");
            }
        }

        public static int DataValueIdIngressIngress {
            get {
                return WAFID.GetDataValueId("cd9b3a8c-dba2-4f3b-9c06-76461bbf20e4");
            }
        }

        public static int PropertyIdPictures {
            get {
                return WAFID.GetPropertyId("5be8c834-f167-47af-9bab-67290df31bc6");
            }
        }

        public static int PropertyIdDescription {
            get {
                return WAFID.GetPropertyId("99283b4f-33bb-4852-a845-a021bf74f3dc");
            }
        }

        public static int DataValueIdDescriptionDescription {
            get {
                return WAFID.GetDataValueId("d5c233bc-b7c7-45ee-8218-f17bc7afc4a2");
            }
        }

        public static int PropertyIdAttractions {
            get {
                return WAFID.GetPropertyId("b7702ede-0a11-425f-b2f9-bdd5291b8e9e");
            }
        }

        public static int PropertyIdActivities {
            get {
                return WAFID.GetPropertyId("1e915686-9c7f-486e-a9bb-fc4fb4681679");
            }
        }

        public static int PropertyIdAccommodations {
            get {
                return WAFID.GetPropertyId("d3069e79-9b01-4aa5-b936-7787a699d582");
            }
        }

        public static int PropertyIdFoodAndDrink {
            get {
                return WAFID.GetPropertyId("a7882715-4fea-4447-ad8c-c03e792b52ad");
            }
        }

        public static int PropertyIdShopping {
            get {
                return WAFID.GetPropertyId("7245a0b6-f66b-4a61-a4a6-f692b6f2ea7b");
            }
        }

        public static int PropertyIdLongitude {
            get {
                return WAFID.GetPropertyId("c459269d-709d-407a-8601-d133807d2874");
            }
        }

        public static int DataValueIdLongitudeLongitude {
            get {
                return WAFID.GetDataValueId("3f0c3a6b-d638-4a4b-b7a4-38a75227129c");
            }
        }

        public static int PropertyIdLatitude {
            get {
                return WAFID.GetPropertyId("269f6bca-8bf4-4b39-85fe-a535e9ff5590");
            }
        }

        public static int DataValueIdLatitudeLattitude {
            get {
                return WAFID.GetDataValueId("5b23f26e-0922-4383-9e75-02cf6a601c96");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("56500c39-1ec2-4d34-8526-cac10f04cadc")) {
                object init = TopPicture;
                return _topPicture;
            }
            else if (propertyId == WAFID.GetPropertyId("486f617c-8946-4ef2-b567-06dbeb89da4f")) {
                object init = Region;
                return _region;
            }
            else if (propertyId == WAFID.GetPropertyId("7be79d29-bf3f-40f0-b686-d63da32ebc78")) {
                object init = Ingress;
                return _ingress;
            }
            else if (propertyId == WAFID.GetPropertyId("5be8c834-f167-47af-9bab-67290df31bc6")) {
                object init = Pictures;
                return _pictures;
            }
            else if (propertyId == WAFID.GetPropertyId("99283b4f-33bb-4852-a845-a021bf74f3dc")) {
                object init = Description;
                return _description;
            }
            else if (propertyId == WAFID.GetPropertyId("b7702ede-0a11-425f-b2f9-bdd5291b8e9e")) {
                object init = Attractions;
                return _attractions;
            }
            else if (propertyId == WAFID.GetPropertyId("1e915686-9c7f-486e-a9bb-fc4fb4681679")) {
                object init = Activities;
                return _activities;
            }
            else if (propertyId == WAFID.GetPropertyId("d3069e79-9b01-4aa5-b936-7787a699d582")) {
                object init = Accommodations;
                return _accommodations;
            }
            else if (propertyId == WAFID.GetPropertyId("a7882715-4fea-4447-ad8c-c03e792b52ad")) {
                object init = FoodAndDrink;
                return _foodAndDrink;
            }
            else if (propertyId == WAFID.GetPropertyId("7245a0b6-f66b-4a61-a4a6-f692b6f2ea7b")) {
                object init = Shopping;
                return _shopping;
            }
            else if (propertyId == WAFID.GetPropertyId("c459269d-709d-407a-8601-d133807d2874")) {
                object init = Longitude;
                return _longitude;
            }
            else if (propertyId == WAFID.GetPropertyId("269f6bca-8bf4-4b39-85fe-a535e9ff5590")) {
                object init = Latitude;
                return _latitude;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _topPicture = null;
            _region = null;
            _ingress = null;
            _pictures = null;
            _description = null;
            _attractions = null;
            _activities = null;
            _accommodations = null;
            _foodAndDrink = null;
            _shopping = null;
            _longitude = null;
            _latitude = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlLocation {
        public static SqlTable Table {
            get {
                return new SqlTable("location", WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
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
                    return new SqlFieldShortString("toppic_filename", Table, WAFID.GetDataValueId("ef039c9d-7eed-402e-b4a9-e5b6f9b9db4c"));
                }
            }

            public static SqlFieldShortString TopPicture_toppic_type_name {
                get {
                    return new SqlFieldShortString("toppic_type_name", Table, WAFID.GetDataValueId("e25fd665-10d3-4d41-8d8c-e6b117cb61da"));
                }
            }

            public static SqlFieldShortString TopPicture_toppic_extension {
                get {
                    return new SqlFieldShortString("toppic_extension", Table, WAFID.GetDataValueId("cf4ab9f7-e048-4a3f-8761-a6df240cada0"));
                }
            }

            public static SqlFieldFloat TopPicture_toppic_bytes {
                get {
                    return new SqlFieldFloat("toppic_bytes", Table, WAFID.GetDataValueId("8f0eb2a7-7ecc-44e7-aa56-913e8f89b1d4"));
                }
            }

            public static SqlFieldLongString TopPicture_toppic_info {
                get {
                    return new SqlFieldLongString("toppic_info", Table, WAFID.GetDataValueId("3c2b8d5d-84ef-4345-9ecf-aeccd00743c5"));
                }
            }

            public static SqlFieldInteger TopPicture_toppic_reference {
                get {
                    return new SqlFieldInteger("toppic_reference", Table, WAFID.GetDataValueId("21399924-99ea-481c-9f03-77aa90847d5a"));
                }
            }

            public static SqlFieldLongString Ingress {
                get {
                    return new SqlFieldLongString("ingress", Table, WAFID.GetDataValueId("cd9b3a8c-dba2-4f3b-9c06-76461bbf20e4"));
                }
            }

            public static SqlFieldLongString Description {
                get {
                    return new SqlFieldLongString("description", Table, WAFID.GetDataValueId("d5c233bc-b7c7-45ee-8218-f17bc7afc4a2"));
                }
            }

            public static SqlFieldShortString Longitude {
                get {
                    return new SqlFieldShortString("longitude", Table, WAFID.GetDataValueId("3f0c3a6b-d638-4a4b-b7a4-38a75227129c"));
                }
            }

            public static SqlFieldShortString Latitude {
                get {
                    return new SqlFieldShortString("lattitude", Table, WAFID.GetDataValueId("5b23f26e-0922-4383-9e75-02cf6a601c96"));
                }
            }

        }
    }
    public class SqlAliasLocation : SqlAlias {
        public SqlAliasLocation()
            : base(SqlLocation.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlLocation.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_filename {
            get {
                return new SqlExpressionFieldShortString(SqlLocation.Field.TopPicture_toppic_filename, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlLocation.Field.TopPicture_toppic_type_name, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_extension {
            get {
                return new SqlExpressionFieldShortString(SqlLocation.Field.TopPicture_toppic_extension, this);
            }
        }

        public SqlExpressionFieldFloat TopPicture_toppic_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlLocation.Field.TopPicture_toppic_bytes, this);
            }
        }

        public SqlExpressionFieldLongString TopPicture_toppic_info {
            get {
                return new SqlExpressionFieldLongString(SqlLocation.Field.TopPicture_toppic_info, this);
            }
        }

        public SqlExpressionFieldInteger TopPicture_toppic_reference {
            get {
                return new SqlExpressionFieldInteger(SqlLocation.Field.TopPicture_toppic_reference, this);
            }
        }

        public SqlExpressionFieldLongString Ingress {
            get {
                return new SqlExpressionFieldLongString(SqlLocation.Field.Ingress, this);
            }
        }

        public SqlExpressionFieldLongString Description {
            get {
                return new SqlExpressionFieldLongString(SqlLocation.Field.Description, this);
            }
        }

        public SqlExpressionFieldShortString Longitude {
            get {
                return new SqlExpressionFieldShortString(SqlLocation.Field.Longitude, this);
            }
        }

        public SqlExpressionFieldShortString Latitude {
            get {
                return new SqlExpressionFieldShortString(SqlLocation.Field.Latitude, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlLocation{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")); 
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlLocation.Field.TopPicture_toppic_filename, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlLocation.Field.TopPicture_toppic_type_name, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlLocation.Field.TopPicture_toppic_extension, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyFloat TopPicture_toppic_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlLocation.Field.TopPicture_toppic_bytes, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyLongString TopPicture_toppic_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlLocation.Field.TopPicture_toppic_info, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyInteger TopPicture_toppic_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlLocation.Field.TopPicture_toppic_reference, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyRelation Region {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("486f617c-8946-4ef2-b567-06dbeb89da4f"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasRegion(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasLocation(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelRegionLocations.Relation));
            }
        }

        public static AqlPropertyLongString Ingress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlLocation.Field.Ingress, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyLongString Description {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlLocation.Field.Description, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyRelation Attractions {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("b7702ede-0a11-425f-b2f9-bdd5291b8e9e"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasLocation(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItem(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelLocationTouristAttractions.Relation));
            }
        }

        public static AqlPropertyRelation Activities {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("1e915686-9c7f-486e-a9bb-fc4fb4681679"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasLocation(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristActivity(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelLocationActivities.Relation));
            }
        }

        public static AqlPropertyRelation Accommodations {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("d3069e79-9b01-4aa5-b936-7787a699d582"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasLocation(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasAccommodation(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelLocationAccommodations.Relation));
            }
        }

        public static AqlPropertyRelation FoodAndDrink {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a7882715-4fea-4447-ad8c-c03e792b52ad"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasLocation(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasPlaceToEatOrDrink(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelLocationEatDrink.Relation));
            }
        }

        public static AqlPropertyRelation Shopping {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("7245a0b6-f66b-4a61-a4a6-f692b6f2ea7b"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasLocation(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasShopping(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelLocationShopping.Relation));
            }
        }

        public static AqlPropertyShortString Longitude {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlLocation.Field.Longitude, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyShortString Latitude {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlLocation.Field.Latitude, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasLocation
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasLocation()
            : base(WAFID.GetContentClassId("787b66bd-7e69-44a8-8c08-d1adf1026eab")) {

        }

        public AqlAliasLocation(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString TopPicture_toppic_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlLocation.TopPicture_toppic_filename, this);
            }
        }

        public AqlExpressionPropertyShortString TopPicture_toppic_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlLocation.TopPicture_toppic_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString TopPicture_toppic_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlLocation.TopPicture_toppic_extension, this);
            }
        }

        public AqlExpressionPropertyFloat TopPicture_toppic_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlLocation.TopPicture_toppic_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString TopPicture_toppic_info {
            get {
                return new AqlExpressionPropertyLongString(AqlLocation.TopPicture_toppic_info, this);
            }
        }

        public AqlExpressionPropertyInteger TopPicture_toppic_reference {
            get {
                return new AqlExpressionPropertyInteger(AqlLocation.TopPicture_toppic_reference, this);
            }
        }

        public AqlExpressionPropertyLongString Ingress {
            get {
                return new AqlExpressionPropertyLongString(AqlLocation.Ingress, this);
            }
        }

        public AqlExpressionPropertyLongString Description {
            get {
                return new AqlExpressionPropertyLongString(AqlLocation.Description, this);
            }
        }

        public AqlExpressionPropertyShortString Longitude {
            get {
                return new AqlExpressionPropertyShortString(AqlLocation.Longitude, this);
            }
        }

        public AqlExpressionPropertyShortString Latitude {
            get {
                return new AqlExpressionPropertyShortString(AqlLocation.Latitude, this);
            }
        }

    }
}
