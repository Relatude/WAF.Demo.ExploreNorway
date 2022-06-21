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
    public partial class Region: WAF.Engine.Content.Native.HierarchicalContent {
        FilePropertyValue _topPicture;
        public virtual FilePropertyValue TopPicture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("38c3510e-68b6-4375-94a1-e5e6f02a6ca3"),WAFID.GetDataValueId("92049705-4c92-4389-9d63-f8c85f893676"),WAFID.GetDataValueId("87c6c85b-dd04-435f-adbb-28e883ed47dd"),WAFID.GetDataValueId("c9ef883c-1169-413e-a366-e2d9ec9a0935"),WAFID.GetDataValueId("1c74481f-30ba-4aba-b5e4-31dab855d70d"),WAFID.GetDataValueId("0f344805-25d0-4f4b-aaee-9b66035826aa"), ref _topPicture, this, WAFID.GetDataValueId("d19e0fe5-093b-4dc7-96a8-e188ae1f6cb2")); }
        }
      
        NodeRelationPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Country> _country;
        public virtual NodeRelationPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Country> Country{
        get { EnsureContentDataIndependence(); return NodeRelationPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Country>.GetValue(WAFID.GetDataValueId("b6fdd34c-8460-44f3-a3d6-9338e81d9806"), ref _country, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Location> _locations;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Location> Locations{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Location>.GetValue(WAFID.GetDataValueId("b65271d2-5772-4ad3-8a69-617c1dedb53e"), ref _locations, this);}
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> _pictures;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> Pictures{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile>.GetValue(WAFID.GetDataValueId("ed6652a4-1340-47d5-9476-9e86c4ac466c"), ref _pictures, this);}
        }
      
        LongStringPropertyValue _ingress;
        public virtual string Ingress {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("7b41bb46-b760-4f7d-999e-b25bae1619ef"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("7b41bb46-b760-4f7d-999e-b25bae1619ef"), ref _ingress, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        HTMLPropertyValue _description;
        public virtual string Description {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("eadfa839-300d-4903-9360-26d379a6658f"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("eadfa839-300d-4903-9360-26d379a6658f"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem> _selectedDestinations;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem> SelectedDestinations{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.TouristItem>.GetValue(WAFID.GetDataValueId("b18a3de7-31d3-4724-9cb7-0bb325a64c55"), ref _selectedDestinations, this);}
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Recipe> _relatedRecipe;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Recipe> RelatedRecipe{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Recipe>.GetValue(WAFID.GetDataValueId("78c81b02-fa9e-4da6-975a-9781c2ef35d2"), ref _relatedRecipe, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Region>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Region>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Region>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f");
            }
        }

        public static int PropertyIdTopPicture {
            get {
                return WAFID.GetPropertyId("d19e0fe5-093b-4dc7-96a8-e188ae1f6cb2");
            }
        }

        public static int DataValueIdTopPictureToppicFilename {
            get {
                return WAFID.GetDataValueId("92049705-4c92-4389-9d63-f8c85f893676");
            }
        }

        public static int DataValueIdTopPictureToppicTypeName {
            get {
                return WAFID.GetDataValueId("87c6c85b-dd04-435f-adbb-28e883ed47dd");
            }
        }

        public static int DataValueIdTopPictureToppicExtension {
            get {
                return WAFID.GetDataValueId("c9ef883c-1169-413e-a366-e2d9ec9a0935");
            }
        }

        public static int DataValueIdTopPictureToppicBytes {
            get {
                return WAFID.GetDataValueId("1c74481f-30ba-4aba-b5e4-31dab855d70d");
            }
        }

        public static int DataValueIdTopPictureToppicInfo {
            get {
                return WAFID.GetDataValueId("0f344805-25d0-4f4b-aaee-9b66035826aa");
            }
        }

        public static int DataValueIdTopPictureToppicReference {
            get {
                return WAFID.GetDataValueId("38c3510e-68b6-4375-94a1-e5e6f02a6ca3");
            }
        }

        public static int PropertyIdCountry {
            get {
                return WAFID.GetPropertyId("b6fdd34c-8460-44f3-a3d6-9338e81d9806");
            }
        }

        public static int PropertyIdLocations {
            get {
                return WAFID.GetPropertyId("b65271d2-5772-4ad3-8a69-617c1dedb53e");
            }
        }

        public static int PropertyIdPictures {
            get {
                return WAFID.GetPropertyId("ed6652a4-1340-47d5-9476-9e86c4ac466c");
            }
        }

        public static int PropertyIdIngress {
            get {
                return WAFID.GetPropertyId("5a3112ea-fd42-4cf2-8c24-6317c996a1fd");
            }
        }

        public static int DataValueIdIngressIngress {
            get {
                return WAFID.GetDataValueId("7b41bb46-b760-4f7d-999e-b25bae1619ef");
            }
        }

        public static int PropertyIdDescription {
            get {
                return WAFID.GetPropertyId("7255ef67-bc75-43ab-ad19-45ecfa3ff4c7");
            }
        }

        public static int DataValueIdDescriptionDescription {
            get {
                return WAFID.GetDataValueId("eadfa839-300d-4903-9360-26d379a6658f");
            }
        }

        public static int PropertyIdSelectedDestinations {
            get {
                return WAFID.GetPropertyId("b18a3de7-31d3-4724-9cb7-0bb325a64c55");
            }
        }

        public static int PropertyIdRelatedRecipe {
            get {
                return WAFID.GetPropertyId("78c81b02-fa9e-4da6-975a-9781c2ef35d2");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("d19e0fe5-093b-4dc7-96a8-e188ae1f6cb2")) {
                object init = TopPicture;
                return _topPicture;
            }
            else if (propertyId == WAFID.GetPropertyId("b6fdd34c-8460-44f3-a3d6-9338e81d9806")) {
                object init = Country;
                return _country;
            }
            else if (propertyId == WAFID.GetPropertyId("b65271d2-5772-4ad3-8a69-617c1dedb53e")) {
                object init = Locations;
                return _locations;
            }
            else if (propertyId == WAFID.GetPropertyId("ed6652a4-1340-47d5-9476-9e86c4ac466c")) {
                object init = Pictures;
                return _pictures;
            }
            else if (propertyId == WAFID.GetPropertyId("5a3112ea-fd42-4cf2-8c24-6317c996a1fd")) {
                object init = Ingress;
                return _ingress;
            }
            else if (propertyId == WAFID.GetPropertyId("7255ef67-bc75-43ab-ad19-45ecfa3ff4c7")) {
                object init = Description;
                return _description;
            }
            else if (propertyId == WAFID.GetPropertyId("b18a3de7-31d3-4724-9cb7-0bb325a64c55")) {
                object init = SelectedDestinations;
                return _selectedDestinations;
            }
            else if (propertyId == WAFID.GetPropertyId("78c81b02-fa9e-4da6-975a-9781c2ef35d2")) {
                object init = RelatedRecipe;
                return _relatedRecipe;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _topPicture = null;
            _country = null;
            _locations = null;
            _pictures = null;
            _ingress = null;
            _description = null;
            _selectedDestinations = null;
            _relatedRecipe = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlRegion {
        public static SqlTable Table {
            get {
                return new SqlTable("region", WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
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
                    return new SqlFieldShortString("toppic_filename", Table, WAFID.GetDataValueId("92049705-4c92-4389-9d63-f8c85f893676"));
                }
            }

            public static SqlFieldShortString TopPicture_toppic_type_name {
                get {
                    return new SqlFieldShortString("toppic_type_name", Table, WAFID.GetDataValueId("87c6c85b-dd04-435f-adbb-28e883ed47dd"));
                }
            }

            public static SqlFieldShortString TopPicture_toppic_extension {
                get {
                    return new SqlFieldShortString("toppic_extension", Table, WAFID.GetDataValueId("c9ef883c-1169-413e-a366-e2d9ec9a0935"));
                }
            }

            public static SqlFieldFloat TopPicture_toppic_bytes {
                get {
                    return new SqlFieldFloat("toppic_bytes", Table, WAFID.GetDataValueId("1c74481f-30ba-4aba-b5e4-31dab855d70d"));
                }
            }

            public static SqlFieldLongString TopPicture_toppic_info {
                get {
                    return new SqlFieldLongString("toppic_info", Table, WAFID.GetDataValueId("0f344805-25d0-4f4b-aaee-9b66035826aa"));
                }
            }

            public static SqlFieldInteger TopPicture_toppic_reference {
                get {
                    return new SqlFieldInteger("toppic_reference", Table, WAFID.GetDataValueId("38c3510e-68b6-4375-94a1-e5e6f02a6ca3"));
                }
            }

            public static SqlFieldLongString Ingress {
                get {
                    return new SqlFieldLongString("ingress", Table, WAFID.GetDataValueId("7b41bb46-b760-4f7d-999e-b25bae1619ef"));
                }
            }

            public static SqlFieldLongString Description {
                get {
                    return new SqlFieldLongString("description", Table, WAFID.GetDataValueId("eadfa839-300d-4903-9360-26d379a6658f"));
                }
            }

        }
    }
    public class SqlAliasRegion : SqlAlias {
        public SqlAliasRegion()
            : base(SqlRegion.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlRegion.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_filename {
            get {
                return new SqlExpressionFieldShortString(SqlRegion.Field.TopPicture_toppic_filename, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlRegion.Field.TopPicture_toppic_type_name, this);
            }
        }

        public SqlExpressionFieldShortString TopPicture_toppic_extension {
            get {
                return new SqlExpressionFieldShortString(SqlRegion.Field.TopPicture_toppic_extension, this);
            }
        }

        public SqlExpressionFieldFloat TopPicture_toppic_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlRegion.Field.TopPicture_toppic_bytes, this);
            }
        }

        public SqlExpressionFieldLongString TopPicture_toppic_info {
            get {
                return new SqlExpressionFieldLongString(SqlRegion.Field.TopPicture_toppic_info, this);
            }
        }

        public SqlExpressionFieldInteger TopPicture_toppic_reference {
            get {
                return new SqlExpressionFieldInteger(SqlRegion.Field.TopPicture_toppic_reference, this);
            }
        }

        public SqlExpressionFieldLongString Ingress {
            get {
                return new SqlExpressionFieldLongString(SqlRegion.Field.Ingress, this);
            }
        }

        public SqlExpressionFieldLongString Description {
            get {
                return new SqlExpressionFieldLongString(SqlRegion.Field.Description, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlRegion{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")); 
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRegion.Field.TopPicture_toppic_filename, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRegion.Field.TopPicture_toppic_type_name, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyShortString TopPicture_toppic_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRegion.Field.TopPicture_toppic_extension, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyFloat TopPicture_toppic_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlRegion.Field.TopPicture_toppic_bytes, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyLongString TopPicture_toppic_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlRegion.Field.TopPicture_toppic_info, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyInteger TopPicture_toppic_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlRegion.Field.TopPicture_toppic_reference, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyRelation Country {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("b6fdd34c-8460-44f3-a3d6-9338e81d9806"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasCountry(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasRegion(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelCountryRegion.Relation));
            }
        }

        public static AqlPropertyRelation Locations {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("b65271d2-5772-4ad3-8a69-617c1dedb53e"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasRegion(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasLocation(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelRegionLocations.Relation));
            }
        }

        public static AqlPropertyLongString Ingress {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlRegion.Field.Ingress, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyLongString Description {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlRegion.Field.Description, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyRelation SelectedDestinations {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("b18a3de7-31d3-4724-9cb7-0bb325a64c55"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasRegion(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasTouristItem(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelRegionSelectedDestinations.Relation));
            }
        }

        public static AqlPropertyRelation RelatedRecipe {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("78c81b02-fa9e-4da6-975a-9781c2ef35d2"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasRecipe(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasRegion(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelRecipe_Region.Relation));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasRegion
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasRegion()
            : base(WAFID.GetContentClassId("c081d11c-f337-44af-91ec-6a32b34a022f")) {

        }

        public AqlAliasRegion(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString TopPicture_toppic_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlRegion.TopPicture_toppic_filename, this);
            }
        }

        public AqlExpressionPropertyShortString TopPicture_toppic_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlRegion.TopPicture_toppic_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString TopPicture_toppic_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlRegion.TopPicture_toppic_extension, this);
            }
        }

        public AqlExpressionPropertyFloat TopPicture_toppic_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlRegion.TopPicture_toppic_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString TopPicture_toppic_info {
            get {
                return new AqlExpressionPropertyLongString(AqlRegion.TopPicture_toppic_info, this);
            }
        }

        public AqlExpressionPropertyInteger TopPicture_toppic_reference {
            get {
                return new AqlExpressionPropertyInteger(AqlRegion.TopPicture_toppic_reference, this);
            }
        }

        public AqlExpressionPropertyLongString Ingress {
            get {
                return new AqlExpressionPropertyLongString(AqlRegion.Ingress, this);
            }
        }

        public AqlExpressionPropertyLongString Description {
            get {
                return new AqlExpressionPropertyLongString(AqlRegion.Description, this);
            }
        }

    }
}
