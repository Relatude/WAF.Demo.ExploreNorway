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
    public partial class RegisteredUser: WAF.Engine.Content.Native.SystemUser {
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<RegisteredUser>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<RegisteredUser>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<RegisteredUser>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlRegisteredUser {
        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_registereduser", WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

        }
    }
    public class SqlAliasRegisteredUser : SqlAlias {
        public SqlAliasRegisteredUser()
            : base(SqlRegisteredUser.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlRegisteredUser.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlRegisteredUser{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")); 
            }
        }

        public static AqlPropertyShortString UserName {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.UserName, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Password {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Password, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean IsAdmin {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.IsAdmin, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean AllowEditLogin {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.AllowEditLogin, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyRelation DirectMemberships {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("6facd1bc-df8e-4d9c-ab2e-4614e26834e6"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasUserGroup(), new WAF.Engine.Query.Native.AqlAliasSystemUser(), WAF.Engine.Query.Native.AqlRelUserGroup.Relation));
            }
        }

        public static AqlPropertyShortString Forename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Forename, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Surname {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Surname, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Email {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Email, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyInteger Gender {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.Gender, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyDateTime Birth {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.Birth, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Company {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Company, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString JobTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.JobTitle, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Street {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Street, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString PostZipCode {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.PostZipCode, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString ProvinceState {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.ProvinceState, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString City {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.City, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Country {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Country, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Mobile {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Mobile, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Phone {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Phone, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString IM {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.IM, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Website {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Website, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Photo_photo_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_filename, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Photo_photo_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_type_name, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString Photo_photo_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_extension, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyFloat Photo_photo_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_bytes, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyLongString Photo_photo_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_info, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyInteger Photo_photo_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_reference, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyLongString Signature {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.Signature, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyLongString Comment {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.Comment, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyInteger StartSite {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.StartSite, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyInteger PreferredLanguage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.PreferredLanguage, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean IsApproved {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.IsApproved, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean IsLocked {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.IsLocked, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyInteger FailedLogins {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.FailedLogins, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyLongString PasswordAnswer {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.PasswordAnswer, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyLongString PasswordQuestion {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.PasswordQuestion, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyDateTime LastPasswordChangedDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastPasswordChangedDate, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyDateTime LastLoginDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastLoginDate, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyDateTime LastActivityDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastActivityDate, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyDateTime LastLockoutDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastLockoutDate, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString GUID {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.GUID, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyRelation Orders {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("42822b2c-241c-4879-a8bd-360aee78e58f"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasSystemUser(), new WAF.Engine.Query.Native.AqlAliasOrder(), WAF.Engine.Query.Native.AqlRelCustomerOrders.Relation));
            }
        }

        public static AqlPropertyInteger PreferredUILanguage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.PreferredUILanguage, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyLongString RestrictLoginsByIPs {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.RestrictLoginsByIPs, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString VisitorId {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.VisitorId, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyLongString UIConfig {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.UIConfig, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyLongString TwoFactorPersistentKeys {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.TwoFactorPersistentKeys, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyInteger StartNode {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.StartNode, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString StartModule {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.StartModule, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasRegisteredUser
        : WAF.Engine.Query.Native.AqlAliasSystemUser{

        public AqlAliasRegisteredUser()
            : base(WAFID.GetContentClassId("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")) {

        }

        public AqlAliasRegisteredUser(int contentClassId)
            : base(contentClassId) {

        }

    }
}
