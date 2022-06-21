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
    public partial class Country: WAF.Engine.Content.Native.HierarchicalContent {
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Region> _regions;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Region> Regions{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Region>.GetValue(WAFID.GetDataValueId("e6a3e7fb-86fb-4cc6-8354-e2755e24f524"), ref _regions, this);}
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> _pictures;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> Pictures{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile>.GetValue(WAFID.GetDataValueId("5fc3a1f7-10c1-4baf-aef3-fa58811af222"), ref _pictures, this);}
        }
      
        HTMLPropertyValue _about;
        public virtual string About {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("1dcfbc6f-73f7-496e-84b9-2d8a3b26591d"), ref _about, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("1dcfbc6f-73f7-496e-84b9-2d8a3b26591d"), ref _about, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        FilePropertyValue _flag;
        public virtual FilePropertyValue Flag {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("7552a524-0644-4b87-a6d8-762c05b782dc"),WAFID.GetDataValueId("f3d0cd38-be7b-4df8-902e-2854c850ef04"),WAFID.GetDataValueId("b0fcdc75-61a2-458a-9202-6bd23393b5fe"),WAFID.GetDataValueId("03b55f37-7cbd-4b86-a889-75bb46f44ea4"),WAFID.GetDataValueId("fcd7c7d7-e5f8-4c25-83d6-2483523d02da"),WAFID.GetDataValueId("e07c465b-d488-4142-99b0-5e28508cb7ed"), ref _flag, this, WAFID.GetDataValueId("1b5de2a2-07e2-4095-a126-2577d8e82986")); }
        }
      
        ShortStringPropertyValue _latitude;
        public virtual string Latitude {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("40a62fb6-9cc2-425a-841f-dbcefab855ae"), ref _latitude, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("40a62fb6-9cc2-425a-841f-dbcefab855ae"), ref _latitude, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _longitude;
        public virtual string Longitude {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("c29c407f-a14a-429b-9a60-ba5ffaa9e6dc"), ref _longitude, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("c29c407f-a14a-429b-9a60-ba5ffaa9e6dc"), ref _longitude, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Country>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Country>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Country>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85");
            }
        }

        public static int PropertyIdRegions {
            get {
                return WAFID.GetPropertyId("e6a3e7fb-86fb-4cc6-8354-e2755e24f524");
            }
        }

        public static int PropertyIdPictures {
            get {
                return WAFID.GetPropertyId("5fc3a1f7-10c1-4baf-aef3-fa58811af222");
            }
        }

        public static int PropertyIdAbout {
            get {
                return WAFID.GetPropertyId("350d9a93-6fde-4908-903a-63b17a1a2b36");
            }
        }

        public static int DataValueIdAboutAbout {
            get {
                return WAFID.GetDataValueId("1dcfbc6f-73f7-496e-84b9-2d8a3b26591d");
            }
        }

        public static int PropertyIdFlag {
            get {
                return WAFID.GetPropertyId("1b5de2a2-07e2-4095-a126-2577d8e82986");
            }
        }

        public static int DataValueIdFlagFlagFilename {
            get {
                return WAFID.GetDataValueId("f3d0cd38-be7b-4df8-902e-2854c850ef04");
            }
        }

        public static int DataValueIdFlagFlagTypeName {
            get {
                return WAFID.GetDataValueId("b0fcdc75-61a2-458a-9202-6bd23393b5fe");
            }
        }

        public static int DataValueIdFlagFlagExtension {
            get {
                return WAFID.GetDataValueId("03b55f37-7cbd-4b86-a889-75bb46f44ea4");
            }
        }

        public static int DataValueIdFlagFlagBytes {
            get {
                return WAFID.GetDataValueId("fcd7c7d7-e5f8-4c25-83d6-2483523d02da");
            }
        }

        public static int DataValueIdFlagFlagInfo {
            get {
                return WAFID.GetDataValueId("e07c465b-d488-4142-99b0-5e28508cb7ed");
            }
        }

        public static int DataValueIdFlagFlagReference {
            get {
                return WAFID.GetDataValueId("7552a524-0644-4b87-a6d8-762c05b782dc");
            }
        }

        public static int PropertyIdLatitude {
            get {
                return WAFID.GetPropertyId("1df596bb-b22b-463d-8a53-162fa12b30b0");
            }
        }

        public static int DataValueIdLatitudeLatitude {
            get {
                return WAFID.GetDataValueId("40a62fb6-9cc2-425a-841f-dbcefab855ae");
            }
        }

        public static int PropertyIdLongitude {
            get {
                return WAFID.GetPropertyId("4dc761db-dd40-4464-8aa9-be71b7c2a8ad");
            }
        }

        public static int DataValueIdLongitudeLongitude {
            get {
                return WAFID.GetDataValueId("c29c407f-a14a-429b-9a60-ba5ffaa9e6dc");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("e6a3e7fb-86fb-4cc6-8354-e2755e24f524")) {
                object init = Regions;
                return _regions;
            }
            else if (propertyId == WAFID.GetPropertyId("5fc3a1f7-10c1-4baf-aef3-fa58811af222")) {
                object init = Pictures;
                return _pictures;
            }
            else if (propertyId == WAFID.GetPropertyId("350d9a93-6fde-4908-903a-63b17a1a2b36")) {
                object init = About;
                return _about;
            }
            else if (propertyId == WAFID.GetPropertyId("1b5de2a2-07e2-4095-a126-2577d8e82986")) {
                object init = Flag;
                return _flag;
            }
            else if (propertyId == WAFID.GetPropertyId("1df596bb-b22b-463d-8a53-162fa12b30b0")) {
                object init = Latitude;
                return _latitude;
            }
            else if (propertyId == WAFID.GetPropertyId("4dc761db-dd40-4464-8aa9-be71b7c2a8ad")) {
                object init = Longitude;
                return _longitude;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _regions = null;
            _pictures = null;
            _about = null;
            _flag = null;
            _latitude = null;
            _longitude = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlCountry {
        public static SqlTable Table {
            get {
                return new SqlTable("country", WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldLongString About {
                get {
                    return new SqlFieldLongString("about", Table, WAFID.GetDataValueId("1dcfbc6f-73f7-496e-84b9-2d8a3b26591d"));
                }
            }

            public static SqlFieldShortString Flag_flag_filename {
                get {
                    return new SqlFieldShortString("flag_filename", Table, WAFID.GetDataValueId("f3d0cd38-be7b-4df8-902e-2854c850ef04"));
                }
            }

            public static SqlFieldShortString Flag_flag_type_name {
                get {
                    return new SqlFieldShortString("flag_type_name", Table, WAFID.GetDataValueId("b0fcdc75-61a2-458a-9202-6bd23393b5fe"));
                }
            }

            public static SqlFieldShortString Flag_flag_extension {
                get {
                    return new SqlFieldShortString("flag_extension", Table, WAFID.GetDataValueId("03b55f37-7cbd-4b86-a889-75bb46f44ea4"));
                }
            }

            public static SqlFieldFloat Flag_flag_bytes {
                get {
                    return new SqlFieldFloat("flag_bytes", Table, WAFID.GetDataValueId("fcd7c7d7-e5f8-4c25-83d6-2483523d02da"));
                }
            }

            public static SqlFieldLongString Flag_flag_info {
                get {
                    return new SqlFieldLongString("flag_info", Table, WAFID.GetDataValueId("e07c465b-d488-4142-99b0-5e28508cb7ed"));
                }
            }

            public static SqlFieldInteger Flag_flag_reference {
                get {
                    return new SqlFieldInteger("flag_reference", Table, WAFID.GetDataValueId("7552a524-0644-4b87-a6d8-762c05b782dc"));
                }
            }

            public static SqlFieldShortString Latitude {
                get {
                    return new SqlFieldShortString("latitude", Table, WAFID.GetDataValueId("40a62fb6-9cc2-425a-841f-dbcefab855ae"));
                }
            }

            public static SqlFieldShortString Longitude {
                get {
                    return new SqlFieldShortString("longitude", Table, WAFID.GetDataValueId("c29c407f-a14a-429b-9a60-ba5ffaa9e6dc"));
                }
            }

        }
    }
    public class SqlAliasCountry : SqlAlias {
        public SqlAliasCountry()
            : base(SqlCountry.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlCountry.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString About {
            get {
                return new SqlExpressionFieldLongString(SqlCountry.Field.About, this);
            }
        }

        public SqlExpressionFieldShortString Flag_flag_filename {
            get {
                return new SqlExpressionFieldShortString(SqlCountry.Field.Flag_flag_filename, this);
            }
        }

        public SqlExpressionFieldShortString Flag_flag_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlCountry.Field.Flag_flag_type_name, this);
            }
        }

        public SqlExpressionFieldShortString Flag_flag_extension {
            get {
                return new SqlExpressionFieldShortString(SqlCountry.Field.Flag_flag_extension, this);
            }
        }

        public SqlExpressionFieldFloat Flag_flag_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlCountry.Field.Flag_flag_bytes, this);
            }
        }

        public SqlExpressionFieldLongString Flag_flag_info {
            get {
                return new SqlExpressionFieldLongString(SqlCountry.Field.Flag_flag_info, this);
            }
        }

        public SqlExpressionFieldInteger Flag_flag_reference {
            get {
                return new SqlExpressionFieldInteger(SqlCountry.Field.Flag_flag_reference, this);
            }
        }

        public SqlExpressionFieldShortString Latitude {
            get {
                return new SqlExpressionFieldShortString(SqlCountry.Field.Latitude, this);
            }
        }

        public SqlExpressionFieldShortString Longitude {
            get {
                return new SqlExpressionFieldShortString(SqlCountry.Field.Longitude, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlCountry{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")); 
            }
        }

        public static AqlPropertyRelation Regions {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("e6a3e7fb-86fb-4cc6-8354-e2755e24f524"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasCountry(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasRegion(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelCountryRegion.Relation));
            }
        }

        public static AqlPropertyLongString About {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlCountry.Field.About, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyShortString Flag_flag_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlCountry.Field.Flag_flag_filename, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyShortString Flag_flag_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlCountry.Field.Flag_flag_type_name, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyShortString Flag_flag_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlCountry.Field.Flag_flag_extension, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyFloat Flag_flag_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlCountry.Field.Flag_flag_bytes, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyLongString Flag_flag_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlCountry.Field.Flag_flag_info, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyInteger Flag_flag_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlCountry.Field.Flag_flag_reference, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyShortString Latitude {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlCountry.Field.Latitude, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyShortString Longitude {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlCountry.Field.Longitude, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasCountry
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasCountry()
            : base(WAFID.GetContentClassId("6469869a-b2e3-433c-ae29-bcbba3c77b85")) {

        }

        public AqlAliasCountry(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString About {
            get {
                return new AqlExpressionPropertyLongString(AqlCountry.About, this);
            }
        }

        public AqlExpressionPropertyShortString Flag_flag_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlCountry.Flag_flag_filename, this);
            }
        }

        public AqlExpressionPropertyShortString Flag_flag_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlCountry.Flag_flag_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString Flag_flag_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlCountry.Flag_flag_extension, this);
            }
        }

        public AqlExpressionPropertyFloat Flag_flag_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlCountry.Flag_flag_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString Flag_flag_info {
            get {
                return new AqlExpressionPropertyLongString(AqlCountry.Flag_flag_info, this);
            }
        }

        public AqlExpressionPropertyInteger Flag_flag_reference {
            get {
                return new AqlExpressionPropertyInteger(AqlCountry.Flag_flag_reference, this);
            }
        }

        public AqlExpressionPropertyShortString Latitude {
            get {
                return new AqlExpressionPropertyShortString(AqlCountry.Latitude, this);
            }
        }

        public AqlExpressionPropertyShortString Longitude {
            get {
                return new AqlExpressionPropertyShortString(AqlCountry.Longitude, this);
            }
        }

    }
}
