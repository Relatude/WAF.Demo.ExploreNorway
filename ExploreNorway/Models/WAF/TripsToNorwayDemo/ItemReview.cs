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
    public partial class ItemReview: WAF.Engine.Content.Native.HierarchicalContent {
        LongStringPropertyValue _reviewBody;
        public virtual string ReviewBody {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("c863e375-dca4-4d61-bc2d-2585619ade89"), ref _reviewBody, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("c863e375-dca4-4d61-bc2d-2585619ade89"), ref _reviewBody, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        IntegerPropertyValue _ratingValue;
        public virtual int RatingValue {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("bce22d3c-9fae-471d-85b0-4d31b733fc5a"), ref _ratingValue, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("bce22d3c-9fae-471d-85b0-4d31b733fc5a"), ref _ratingValue, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.Native.SystemUser> _reviewedByUser;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.Native.SystemUser> ReviewedByUser{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.Native.SystemUser>.GetPropValue(WAFID.GetDataValueId("60c69ecc-c068-4ce4-8f14-ad3e88899653"), ref _reviewedByUser, this);}
        }
      
        DateTimePropertyValue _dateAdded;
        public virtual DateTime DateAdded {
        get { return DateTimePropertyValue.GetValue(WAFID.GetDataValueId("33319a4e-9791-47e3-a1c3-f3b61e4a183b"), ref _dateAdded, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); DateTimePropertyValue.SetValue(WAFID.GetDataValueId("33319a4e-9791-47e3-a1c3-f3b61e4a183b"), ref _dateAdded, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ItemReview>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ItemReview>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ItemReview>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f");
            }
        }

        public static int PropertyIdReviewBody {
            get {
                return WAFID.GetPropertyId("46beebd7-a172-4680-8f6f-a6454ad4ba77");
            }
        }

        public static int DataValueIdReviewBodyReviewbody {
            get {
                return WAFID.GetDataValueId("c863e375-dca4-4d61-bc2d-2585619ade89");
            }
        }

        public static int PropertyIdRatingValue {
            get {
                return WAFID.GetPropertyId("ee12031c-5a89-4207-a007-05f693cdb291");
            }
        }

        public static int DataValueIdRatingValueRatingvalue {
            get {
                return WAFID.GetDataValueId("bce22d3c-9fae-471d-85b0-4d31b733fc5a");
            }
        }

        public static int PropertyIdReviewedByUser {
            get {
                return WAFID.GetPropertyId("ab2e5766-879f-46d1-a778-11627395fe9b");
            }
        }

        public static int DataValueIdReviewedByUserMyproperty {
            get {
                return WAFID.GetDataValueId("60c69ecc-c068-4ce4-8f14-ad3e88899653");
            }
        }

        public static int PropertyIdDateAdded {
            get {
                return WAFID.GetPropertyId("92e51bb0-5415-498d-bc26-23c2d4ce3593");
            }
        }

        public static int DataValueIdDateAddedDateadded {
            get {
                return WAFID.GetDataValueId("33319a4e-9791-47e3-a1c3-f3b61e4a183b");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("46beebd7-a172-4680-8f6f-a6454ad4ba77")) {
                object init = ReviewBody;
                return _reviewBody;
            }
            else if (propertyId == WAFID.GetPropertyId("ee12031c-5a89-4207-a007-05f693cdb291")) {
                object init = RatingValue;
                return _ratingValue;
            }
            else if (propertyId == WAFID.GetPropertyId("ab2e5766-879f-46d1-a778-11627395fe9b")) {
                object init = ReviewedByUser;
                return _reviewedByUser;
            }
            else if (propertyId == WAFID.GetPropertyId("92e51bb0-5415-498d-bc26-23c2d4ce3593")) {
                object init = DateAdded;
                return _dateAdded;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _reviewBody = null;
            _ratingValue = null;
            _reviewedByUser = null;
            _dateAdded = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlItemReview {
        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_itemreview", WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldLongString ReviewBody {
                get {
                    return new SqlFieldLongString("reviewbody", Table, WAFID.GetDataValueId("c863e375-dca4-4d61-bc2d-2585619ade89"));
                }
            }

            public static SqlFieldInteger RatingValue {
                get {
                    return new SqlFieldInteger("ratingvalue", Table, WAFID.GetDataValueId("bce22d3c-9fae-471d-85b0-4d31b733fc5a"));
                }
            }

            public static SqlFieldInteger ReviewedByUser {
                get {
                    return new SqlFieldInteger("myproperty", Table, WAFID.GetDataValueId("60c69ecc-c068-4ce4-8f14-ad3e88899653"));
                }
            }

            public static SqlFieldDateTime DateAdded {
                get {
                    return new SqlFieldDateTime("dateadded", Table, WAFID.GetDataValueId("33319a4e-9791-47e3-a1c3-f3b61e4a183b"));
                }
            }

        }
    }
    public class SqlAliasItemReview : SqlAlias {
        public SqlAliasItemReview()
            : base(SqlItemReview.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlItemReview.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString ReviewBody {
            get {
                return new SqlExpressionFieldLongString(SqlItemReview.Field.ReviewBody, this);
            }
        }

        public SqlExpressionFieldInteger RatingValue {
            get {
                return new SqlExpressionFieldInteger(SqlItemReview.Field.RatingValue, this);
            }
        }

        public SqlExpressionFieldInteger ReviewedByUser {
            get {
                return new SqlExpressionFieldInteger(SqlItemReview.Field.ReviewedByUser, this);
            }
        }

        public SqlExpressionFieldDateTime DateAdded {
            get {
                return new SqlExpressionFieldDateTime(SqlItemReview.Field.DateAdded, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlItemReview{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")); 
            }
        }

        public static AqlPropertyLongString ReviewBody {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlItemReview.Field.ReviewBody, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyInteger RatingValue {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlItemReview.Field.RatingValue, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyInteger ReviewedByUser {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlItemReview.Field.ReviewedByUser, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyDateTime DateAdded {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.TripsToNorwayDemo.SqlItemReview.Field.DateAdded, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasItemReview
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasItemReview()
            : base(WAFID.GetContentClassId("35cab70a-9b1c-4b55-b2e1-6395fe17621f")) {

        }

        public AqlAliasItemReview(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString ReviewBody {
            get {
                return new AqlExpressionPropertyLongString(AqlItemReview.ReviewBody, this);
            }
        }

        public AqlExpressionPropertyInteger RatingValue {
            get {
                return new AqlExpressionPropertyInteger(AqlItemReview.RatingValue, this);
            }
        }

        public AqlExpressionPropertyInteger ReviewedByUser {
            get {
                return new AqlExpressionPropertyInteger(AqlItemReview.ReviewedByUser, this);
            }
        }

        public AqlExpressionPropertyDateTime DateAdded {
            get {
                return new AqlExpressionPropertyDateTime(AqlItemReview.DateAdded, this);
            }
        }

    }
}
