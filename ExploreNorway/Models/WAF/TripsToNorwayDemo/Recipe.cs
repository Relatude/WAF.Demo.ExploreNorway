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
    public partial class Recipe: WAF.Engine.Content.Native.HierarchicalContent {
        IntegerPropertyValue _cookingTime;
        public virtual int CookingTime {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("378105fa-753c-4d46-b18d-1c6028a42a4d"), ref _cookingTime, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("378105fa-753c-4d46-b18d-1c6028a42a4d"), ref _cookingTime, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _cookingMethod;
        public virtual string CookingMethod {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("c0e467eb-ff51-4c31-8447-ca1f53efdd7f"), ref _cookingMethod, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("c0e467eb-ff51-4c31-8447-ca1f53efdd7f"), ref _cookingMethod, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _shortDescription;
        public virtual string ShortDescription {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("a501252b-70cd-479b-b1f9-fe3434fd6c7c"), ref _shortDescription, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("a501252b-70cd-479b-b1f9-fe3434fd6c7c"), ref _shortDescription, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        IntegerPropertyValue _prepTime;
        public virtual int PrepTime {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("d175b561-dff3-4bcd-84e5-4527d90ec561"), ref _prepTime, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("d175b561-dff3-4bcd-84e5-4527d90ec561"), ref _prepTime, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _picture;
        public virtual FilePropertyValue Picture {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("13cf94a6-2442-438a-a0cc-891839d1f4c5"),WAFID.GetDataValueId("e8a0fcf8-80de-424b-83f2-2fae5600baac"),WAFID.GetDataValueId("4c149da7-9aee-4e06-91b6-b8128ee45846"),WAFID.GetDataValueId("94914600-4cb9-4788-b0b4-40f983761d42"),WAFID.GetDataValueId("61c8f972-f963-475b-9d60-67164e7cedb7"),WAFID.GetDataValueId("bdc50c97-3cbb-4835-8108-4538a058df6b"), ref _picture, this, WAFID.GetDataValueId("eba120df-6d7d-4d5d-ac3d-69a7253f6ea9")); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ItemReview> _reviews;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ItemReview> Reviews{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ItemReview>.GetValue(WAFID.GetDataValueId("17bd7cfc-c133-4496-ae5c-40432d6ab39b"), ref _reviews, this);}
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ParagraphShortText> _recipeIngredients;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ParagraphShortText> RecipeIngredients{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.ParagraphShortText>.GetValue(WAFID.GetDataValueId("7e56a843-0062-4769-9082-c004e24766f0"), ref _recipeIngredients, this);}
        }
      
        HTMLPropertyValue _instructions;
        public virtual string Instructions {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("b90ae58b-5779-46c7-b9a1-5bdc22d2622e"), ref _instructions, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("b90ae58b-5779-46c7-b9a1-5bdc22d2622e"), ref _instructions, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        ShortStringPropertyValue _contentFat;
        public virtual string ContentFat {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("ed09e240-fdbd-4072-91f5-9394054ef000"), ref _contentFat, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("ed09e240-fdbd-4072-91f5-9394054ef000"), ref _contentFat, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _contentCalories;
        public virtual string ContentCalories {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("f09c5bb1-072e-4e30-9821-03e453236dc1"), ref _contentCalories, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("f09c5bb1-072e-4e30-9821-03e453236dc1"), ref _contentCalories, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _contentFiber;
        public virtual string ContentFiber {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("2b458a46-8828-4ec3-9931-0fa144c2898b"), ref _contentFiber, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("2b458a46-8828-4ec3-9931-0fa144c2898b"), ref _contentFiber, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _contentProtein;
        public virtual string ContentProtein {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("5dcc29c5-4267-41d3-bdf5-ff38d6870251"), ref _contentProtein, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("5dcc29c5-4267-41d3-bdf5-ff38d6870251"), ref _contentProtein, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _contentCarbs;
        public virtual string ContentCarbs {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("f08334b2-d218-4306-b4a3-d1a9733575ed"), ref _contentCarbs, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("f08334b2-d218-4306-b4a3-d1a9733575ed"), ref _contentCarbs, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _recipeYield;
        public virtual string RecipeYield {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("7580628b-0220-4045-abb4-bd95800ab5d5"), ref _recipeYield, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("7580628b-0220-4045-abb4-bd95800ab5d5"), ref _recipeYield, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _recipeCategory;
        public virtual string RecipeCategory {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("4128c460-b72b-42bb-a00d-16ad8d042de0"), ref _recipeCategory, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("4128c460-b72b-42bb-a00d-16ad8d042de0"), ref _recipeCategory, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        HTMLPropertyValue _history;
        public virtual string History {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("b0658dc1-4916-4c49-b489-ee8e179d358b"), ref _history, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("b0658dc1-4916-4c49-b489-ee8e179d358b"), ref _history, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Region> _relatedRegions;
        public virtual NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Region> RelatedRegions{
        get {EnsureContentDataIndependence(); return NodeRelationsPropertyValue<WAF.Engine.Content.TripsToNorwayDemo.Region>.GetValue(WAFID.GetDataValueId("3dfb87c5-c525-47d9-b6e6-4990a0f421c4"), ref _relatedRegions, this);}
        }
      
        ShortStringPropertyValue _imageCopyright;
        public virtual string ImageCopyright {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("895245b8-3760-4530-a033-d45de5867007"), ref _imageCopyright, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("895245b8-3760-4530-a033-d45de5867007"), ref _imageCopyright, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Recipe>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Recipe>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Recipe>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02");
            }
        }

        public static int PropertyIdCookingTime {
            get {
                return WAFID.GetPropertyId("5868ab15-e732-4102-99d4-bc3e2d86a88f");
            }
        }

        public static int DataValueIdCookingTimeCookingtime {
            get {
                return WAFID.GetDataValueId("378105fa-753c-4d46-b18d-1c6028a42a4d");
            }
        }

        public static int PropertyIdCookingMethod {
            get {
                return WAFID.GetPropertyId("a98fab78-34a2-4af2-a186-0c33864e4662");
            }
        }

        public static int DataValueIdCookingMethodCookingmethod {
            get {
                return WAFID.GetDataValueId("c0e467eb-ff51-4c31-8447-ca1f53efdd7f");
            }
        }

        public static int PropertyIdShortDescription {
            get {
                return WAFID.GetPropertyId("5e68a1c2-868e-479b-af05-1013aeb32762");
            }
        }

        public static int DataValueIdShortDescriptionShortdescription {
            get {
                return WAFID.GetDataValueId("a501252b-70cd-479b-b1f9-fe3434fd6c7c");
            }
        }

        public static int PropertyIdPrepTime {
            get {
                return WAFID.GetPropertyId("20091c3a-34a1-4a6a-a9b5-b1c549d841d9");
            }
        }

        public static int DataValueIdPrepTimePreptime {
            get {
                return WAFID.GetDataValueId("d175b561-dff3-4bcd-84e5-4527d90ec561");
            }
        }

        public static int PropertyIdPicture {
            get {
                return WAFID.GetPropertyId("eba120df-6d7d-4d5d-ac3d-69a7253f6ea9");
            }
        }

        public static int DataValueIdPictureToppictureName {
            get {
                return WAFID.GetDataValueId("e8a0fcf8-80de-424b-83f2-2fae5600baac");
            }
        }

        public static int DataValueIdPictureToppictureType {
            get {
                return WAFID.GetDataValueId("4c149da7-9aee-4e06-91b6-b8128ee45846");
            }
        }

        public static int DataValueIdPictureToppictureExtension {
            get {
                return WAFID.GetDataValueId("94914600-4cb9-4788-b0b4-40f983761d42");
            }
        }

        public static int DataValueIdPictureToppictureBytes {
            get {
                return WAFID.GetDataValueId("61c8f972-f963-475b-9d60-67164e7cedb7");
            }
        }

        public static int DataValueIdPictureToppictureInfo {
            get {
                return WAFID.GetDataValueId("bdc50c97-3cbb-4835-8108-4538a058df6b");
            }
        }

        public static int DataValueIdPictureToppictureReference {
            get {
                return WAFID.GetDataValueId("13cf94a6-2442-438a-a0cc-891839d1f4c5");
            }
        }

        public static int PropertyIdReviews {
            get {
                return WAFID.GetPropertyId("17bd7cfc-c133-4496-ae5c-40432d6ab39b");
            }
        }

        public static int PropertyIdRecipeIngredients {
            get {
                return WAFID.GetPropertyId("7e56a843-0062-4769-9082-c004e24766f0");
            }
        }

        public static int PropertyIdInstructions {
            get {
                return WAFID.GetPropertyId("31f86ec5-f09b-4376-bd0a-340e8ddc3a5f");
            }
        }

        public static int DataValueIdInstructionsInstructions {
            get {
                return WAFID.GetDataValueId("b90ae58b-5779-46c7-b9a1-5bdc22d2622e");
            }
        }

        public static int PropertyIdContentFat {
            get {
                return WAFID.GetPropertyId("742b5d7d-5aaa-4d4e-897b-e65d8d645fa3");
            }
        }

        public static int DataValueIdContentFatContentfat {
            get {
                return WAFID.GetDataValueId("ed09e240-fdbd-4072-91f5-9394054ef000");
            }
        }

        public static int PropertyIdContentCalories {
            get {
                return WAFID.GetPropertyId("22ea0db9-bca6-48b5-bb75-308e2c20b1df");
            }
        }

        public static int DataValueIdContentCaloriesContentcalories {
            get {
                return WAFID.GetDataValueId("f09c5bb1-072e-4e30-9821-03e453236dc1");
            }
        }

        public static int PropertyIdContentFiber {
            get {
                return WAFID.GetPropertyId("3928bb21-def6-4054-8884-0456fae70e42");
            }
        }

        public static int DataValueIdContentFiberContentfiber {
            get {
                return WAFID.GetDataValueId("2b458a46-8828-4ec3-9931-0fa144c2898b");
            }
        }

        public static int PropertyIdContentProtein {
            get {
                return WAFID.GetPropertyId("53883b60-c85f-4a4e-b954-decd582655a3");
            }
        }

        public static int DataValueIdContentProteinContentprotein {
            get {
                return WAFID.GetDataValueId("5dcc29c5-4267-41d3-bdf5-ff38d6870251");
            }
        }

        public static int PropertyIdContentCarbs {
            get {
                return WAFID.GetPropertyId("4cc7d7cb-8e4c-4f96-b8d9-e030390bdc89");
            }
        }

        public static int DataValueIdContentCarbsContentcarbs {
            get {
                return WAFID.GetDataValueId("f08334b2-d218-4306-b4a3-d1a9733575ed");
            }
        }

        public static int PropertyIdRecipeYield {
            get {
                return WAFID.GetPropertyId("98209a1b-faed-4f0e-901c-6700d7d39bc3");
            }
        }

        public static int DataValueIdRecipeYieldRecipeyield {
            get {
                return WAFID.GetDataValueId("7580628b-0220-4045-abb4-bd95800ab5d5");
            }
        }

        public static int PropertyIdRecipeCategory {
            get {
                return WAFID.GetPropertyId("61506720-e488-4420-ac22-6662fd2ca0a7");
            }
        }

        public static int DataValueIdRecipeCategoryRecipecategory {
            get {
                return WAFID.GetDataValueId("4128c460-b72b-42bb-a00d-16ad8d042de0");
            }
        }

        public static int PropertyIdHistory {
            get {
                return WAFID.GetPropertyId("a95da0f0-c56f-4ec3-80ed-1c845e00758f");
            }
        }

        public static int DataValueIdHistoryHistory {
            get {
                return WAFID.GetDataValueId("b0658dc1-4916-4c49-b489-ee8e179d358b");
            }
        }

        public static int PropertyIdRelatedRegions {
            get {
                return WAFID.GetPropertyId("3dfb87c5-c525-47d9-b6e6-4990a0f421c4");
            }
        }

        public static int PropertyIdImageCopyright {
            get {
                return WAFID.GetPropertyId("137e5551-15ab-4277-b223-53f129a22ea7");
            }
        }

        public static int DataValueIdImageCopyrightImagecopyright {
            get {
                return WAFID.GetDataValueId("895245b8-3760-4530-a033-d45de5867007");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("5868ab15-e732-4102-99d4-bc3e2d86a88f")) {
                object init = CookingTime;
                return _cookingTime;
            }
            else if (propertyId == WAFID.GetPropertyId("a98fab78-34a2-4af2-a186-0c33864e4662")) {
                object init = CookingMethod;
                return _cookingMethod;
            }
            else if (propertyId == WAFID.GetPropertyId("5e68a1c2-868e-479b-af05-1013aeb32762")) {
                object init = ShortDescription;
                return _shortDescription;
            }
            else if (propertyId == WAFID.GetPropertyId("20091c3a-34a1-4a6a-a9b5-b1c549d841d9")) {
                object init = PrepTime;
                return _prepTime;
            }
            else if (propertyId == WAFID.GetPropertyId("eba120df-6d7d-4d5d-ac3d-69a7253f6ea9")) {
                object init = Picture;
                return _picture;
            }
            else if (propertyId == WAFID.GetPropertyId("17bd7cfc-c133-4496-ae5c-40432d6ab39b")) {
                object init = Reviews;
                return _reviews;
            }
            else if (propertyId == WAFID.GetPropertyId("7e56a843-0062-4769-9082-c004e24766f0")) {
                object init = RecipeIngredients;
                return _recipeIngredients;
            }
            else if (propertyId == WAFID.GetPropertyId("31f86ec5-f09b-4376-bd0a-340e8ddc3a5f")) {
                object init = Instructions;
                return _instructions;
            }
            else if (propertyId == WAFID.GetPropertyId("742b5d7d-5aaa-4d4e-897b-e65d8d645fa3")) {
                object init = ContentFat;
                return _contentFat;
            }
            else if (propertyId == WAFID.GetPropertyId("22ea0db9-bca6-48b5-bb75-308e2c20b1df")) {
                object init = ContentCalories;
                return _contentCalories;
            }
            else if (propertyId == WAFID.GetPropertyId("3928bb21-def6-4054-8884-0456fae70e42")) {
                object init = ContentFiber;
                return _contentFiber;
            }
            else if (propertyId == WAFID.GetPropertyId("53883b60-c85f-4a4e-b954-decd582655a3")) {
                object init = ContentProtein;
                return _contentProtein;
            }
            else if (propertyId == WAFID.GetPropertyId("4cc7d7cb-8e4c-4f96-b8d9-e030390bdc89")) {
                object init = ContentCarbs;
                return _contentCarbs;
            }
            else if (propertyId == WAFID.GetPropertyId("98209a1b-faed-4f0e-901c-6700d7d39bc3")) {
                object init = RecipeYield;
                return _recipeYield;
            }
            else if (propertyId == WAFID.GetPropertyId("61506720-e488-4420-ac22-6662fd2ca0a7")) {
                object init = RecipeCategory;
                return _recipeCategory;
            }
            else if (propertyId == WAFID.GetPropertyId("a95da0f0-c56f-4ec3-80ed-1c845e00758f")) {
                object init = History;
                return _history;
            }
            else if (propertyId == WAFID.GetPropertyId("3dfb87c5-c525-47d9-b6e6-4990a0f421c4")) {
                object init = RelatedRegions;
                return _relatedRegions;
            }
            else if (propertyId == WAFID.GetPropertyId("137e5551-15ab-4277-b223-53f129a22ea7")) {
                object init = ImageCopyright;
                return _imageCopyright;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _cookingTime = null;
            _cookingMethod = null;
            _shortDescription = null;
            _prepTime = null;
            _picture = null;
            _reviews = null;
            _recipeIngredients = null;
            _instructions = null;
            _contentFat = null;
            _contentCalories = null;
            _contentFiber = null;
            _contentProtein = null;
            _contentCarbs = null;
            _recipeYield = null;
            _recipeCategory = null;
            _history = null;
            _relatedRegions = null;
            _imageCopyright = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlRecipe {
        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_recipe", WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldInteger CookingTime {
                get {
                    return new SqlFieldInteger("cookingtime", Table, WAFID.GetDataValueId("378105fa-753c-4d46-b18d-1c6028a42a4d"));
                }
            }

            public static SqlFieldShortString CookingMethod {
                get {
                    return new SqlFieldShortString("cookingmethod", Table, WAFID.GetDataValueId("c0e467eb-ff51-4c31-8447-ca1f53efdd7f"));
                }
            }

            public static SqlFieldShortString ShortDescription {
                get {
                    return new SqlFieldShortString("shortdescription", Table, WAFID.GetDataValueId("a501252b-70cd-479b-b1f9-fe3434fd6c7c"));
                }
            }

            public static SqlFieldInteger PrepTime {
                get {
                    return new SqlFieldInteger("preptime", Table, WAFID.GetDataValueId("d175b561-dff3-4bcd-84e5-4527d90ec561"));
                }
            }

            public static SqlFieldShortString Picture_toppicture_name {
                get {
                    return new SqlFieldShortString("toppicture_name", Table, WAFID.GetDataValueId("e8a0fcf8-80de-424b-83f2-2fae5600baac"));
                }
            }

            public static SqlFieldShortString Picture_toppicture_type {
                get {
                    return new SqlFieldShortString("toppicture_type", Table, WAFID.GetDataValueId("4c149da7-9aee-4e06-91b6-b8128ee45846"));
                }
            }

            public static SqlFieldShortString Picture_toppicture_extension {
                get {
                    return new SqlFieldShortString("toppicture_extension", Table, WAFID.GetDataValueId("94914600-4cb9-4788-b0b4-40f983761d42"));
                }
            }

            public static SqlFieldFloat Picture_toppicture_bytes {
                get {
                    return new SqlFieldFloat("toppicture_bytes", Table, WAFID.GetDataValueId("61c8f972-f963-475b-9d60-67164e7cedb7"));
                }
            }

            public static SqlFieldLongString Picture_toppicture_info {
                get {
                    return new SqlFieldLongString("toppicture_info", Table, WAFID.GetDataValueId("bdc50c97-3cbb-4835-8108-4538a058df6b"));
                }
            }

            public static SqlFieldInteger Picture_toppicture_reference {
                get {
                    return new SqlFieldInteger("toppicture_reference", Table, WAFID.GetDataValueId("13cf94a6-2442-438a-a0cc-891839d1f4c5"));
                }
            }

            public static SqlFieldLongString Instructions {
                get {
                    return new SqlFieldLongString("instructions", Table, WAFID.GetDataValueId("b90ae58b-5779-46c7-b9a1-5bdc22d2622e"));
                }
            }

            public static SqlFieldShortString ContentFat {
                get {
                    return new SqlFieldShortString("contentfat", Table, WAFID.GetDataValueId("ed09e240-fdbd-4072-91f5-9394054ef000"));
                }
            }

            public static SqlFieldShortString ContentCalories {
                get {
                    return new SqlFieldShortString("contentcalories", Table, WAFID.GetDataValueId("f09c5bb1-072e-4e30-9821-03e453236dc1"));
                }
            }

            public static SqlFieldShortString ContentFiber {
                get {
                    return new SqlFieldShortString("contentfiber", Table, WAFID.GetDataValueId("2b458a46-8828-4ec3-9931-0fa144c2898b"));
                }
            }

            public static SqlFieldShortString ContentProtein {
                get {
                    return new SqlFieldShortString("contentprotein", Table, WAFID.GetDataValueId("5dcc29c5-4267-41d3-bdf5-ff38d6870251"));
                }
            }

            public static SqlFieldShortString ContentCarbs {
                get {
                    return new SqlFieldShortString("contentcarbs", Table, WAFID.GetDataValueId("f08334b2-d218-4306-b4a3-d1a9733575ed"));
                }
            }

            public static SqlFieldShortString RecipeYield {
                get {
                    return new SqlFieldShortString("recipeyield", Table, WAFID.GetDataValueId("7580628b-0220-4045-abb4-bd95800ab5d5"));
                }
            }

            public static SqlFieldShortString RecipeCategory {
                get {
                    return new SqlFieldShortString("recipecategory", Table, WAFID.GetDataValueId("4128c460-b72b-42bb-a00d-16ad8d042de0"));
                }
            }

            public static SqlFieldLongString History {
                get {
                    return new SqlFieldLongString("history", Table, WAFID.GetDataValueId("b0658dc1-4916-4c49-b489-ee8e179d358b"));
                }
            }

            public static SqlFieldShortString ImageCopyright {
                get {
                    return new SqlFieldShortString("imagecopyright", Table, WAFID.GetDataValueId("895245b8-3760-4530-a033-d45de5867007"));
                }
            }

        }
    }
    public class SqlAliasRecipe : SqlAlias {
        public SqlAliasRecipe()
            : base(SqlRecipe.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlRecipe.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldInteger CookingTime {
            get {
                return new SqlExpressionFieldInteger(SqlRecipe.Field.CookingTime, this);
            }
        }

        public SqlExpressionFieldShortString CookingMethod {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.CookingMethod, this);
            }
        }

        public SqlExpressionFieldShortString ShortDescription {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.ShortDescription, this);
            }
        }

        public SqlExpressionFieldInteger PrepTime {
            get {
                return new SqlExpressionFieldInteger(SqlRecipe.Field.PrepTime, this);
            }
        }

        public SqlExpressionFieldShortString Picture_toppicture_name {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.Picture_toppicture_name, this);
            }
        }

        public SqlExpressionFieldShortString Picture_toppicture_type {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.Picture_toppicture_type, this);
            }
        }

        public SqlExpressionFieldShortString Picture_toppicture_extension {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.Picture_toppicture_extension, this);
            }
        }

        public SqlExpressionFieldFloat Picture_toppicture_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlRecipe.Field.Picture_toppicture_bytes, this);
            }
        }

        public SqlExpressionFieldLongString Picture_toppicture_info {
            get {
                return new SqlExpressionFieldLongString(SqlRecipe.Field.Picture_toppicture_info, this);
            }
        }

        public SqlExpressionFieldInteger Picture_toppicture_reference {
            get {
                return new SqlExpressionFieldInteger(SqlRecipe.Field.Picture_toppicture_reference, this);
            }
        }

        public SqlExpressionFieldLongString Instructions {
            get {
                return new SqlExpressionFieldLongString(SqlRecipe.Field.Instructions, this);
            }
        }

        public SqlExpressionFieldShortString ContentFat {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.ContentFat, this);
            }
        }

        public SqlExpressionFieldShortString ContentCalories {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.ContentCalories, this);
            }
        }

        public SqlExpressionFieldShortString ContentFiber {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.ContentFiber, this);
            }
        }

        public SqlExpressionFieldShortString ContentProtein {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.ContentProtein, this);
            }
        }

        public SqlExpressionFieldShortString ContentCarbs {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.ContentCarbs, this);
            }
        }

        public SqlExpressionFieldShortString RecipeYield {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.RecipeYield, this);
            }
        }

        public SqlExpressionFieldShortString RecipeCategory {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.RecipeCategory, this);
            }
        }

        public SqlExpressionFieldLongString History {
            get {
                return new SqlExpressionFieldLongString(SqlRecipe.Field.History, this);
            }
        }

        public SqlExpressionFieldShortString ImageCopyright {
            get {
                return new SqlExpressionFieldShortString(SqlRecipe.Field.ImageCopyright, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlRecipe{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")); 
            }
        }

        public static AqlPropertyInteger CookingTime {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.CookingTime, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString CookingMethod {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.CookingMethod, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString ShortDescription {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.ShortDescription, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyInteger PrepTime {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.PrepTime, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString Picture_toppicture_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.Picture_toppicture_name, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString Picture_toppicture_type {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.Picture_toppicture_type, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString Picture_toppicture_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.Picture_toppicture_extension, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyFloat Picture_toppicture_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.Picture_toppicture_bytes, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyLongString Picture_toppicture_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.Picture_toppicture_info, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyInteger Picture_toppicture_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.Picture_toppicture_reference, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyRelation Reviews {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("17bd7cfc-c133-4496-ae5c-40432d6ab39b"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasRecipe(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasItemReview(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelRecipe_ItemReview.Relation));
            }
        }

        public static AqlPropertyLongString Instructions {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.Instructions, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString ContentFat {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.ContentFat, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString ContentCalories {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.ContentCalories, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString ContentFiber {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.ContentFiber, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString ContentProtein {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.ContentProtein, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString ContentCarbs {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.ContentCarbs, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString RecipeYield {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.RecipeYield, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString RecipeCategory {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.RecipeCategory, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyLongString History {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.History, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyRelation RelatedRegions {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("3dfb87c5-c525-47d9-b6e6-4990a0f421c4"), new AqlAliasRelation(new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasRecipe(), new WAF.Engine.Query.TripsToNorwayDemo.AqlAliasRegion(), WAF.Engine.Query.TripsToNorwayDemo.AqlRelRecipe_Region.Relation));
            }
        }

        public static AqlPropertyShortString ImageCopyright {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlRecipe.Field.ImageCopyright, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasRecipe
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasRecipe()
            : base(WAFID.GetContentClassId("b7801407-f6ac-4421-9028-2981b8139d02")) {

        }

        public AqlAliasRecipe(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyInteger CookingTime {
            get {
                return new AqlExpressionPropertyInteger(AqlRecipe.CookingTime, this);
            }
        }

        public AqlExpressionPropertyShortString CookingMethod {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.CookingMethod, this);
            }
        }

        public AqlExpressionPropertyShortString ShortDescription {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.ShortDescription, this);
            }
        }

        public AqlExpressionPropertyInteger PrepTime {
            get {
                return new AqlExpressionPropertyInteger(AqlRecipe.PrepTime, this);
            }
        }

        public AqlExpressionPropertyShortString Picture_toppicture_name {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.Picture_toppicture_name, this);
            }
        }

        public AqlExpressionPropertyShortString Picture_toppicture_type {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.Picture_toppicture_type, this);
            }
        }

        public AqlExpressionPropertyShortString Picture_toppicture_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.Picture_toppicture_extension, this);
            }
        }

        public AqlExpressionPropertyFloat Picture_toppicture_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlRecipe.Picture_toppicture_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString Picture_toppicture_info {
            get {
                return new AqlExpressionPropertyLongString(AqlRecipe.Picture_toppicture_info, this);
            }
        }

        public AqlExpressionPropertyInteger Picture_toppicture_reference {
            get {
                return new AqlExpressionPropertyInteger(AqlRecipe.Picture_toppicture_reference, this);
            }
        }

        public AqlExpressionPropertyLongString Instructions {
            get {
                return new AqlExpressionPropertyLongString(AqlRecipe.Instructions, this);
            }
        }

        public AqlExpressionPropertyShortString ContentFat {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.ContentFat, this);
            }
        }

        public AqlExpressionPropertyShortString ContentCalories {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.ContentCalories, this);
            }
        }

        public AqlExpressionPropertyShortString ContentFiber {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.ContentFiber, this);
            }
        }

        public AqlExpressionPropertyShortString ContentProtein {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.ContentProtein, this);
            }
        }

        public AqlExpressionPropertyShortString ContentCarbs {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.ContentCarbs, this);
            }
        }

        public AqlExpressionPropertyShortString RecipeYield {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.RecipeYield, this);
            }
        }

        public AqlExpressionPropertyShortString RecipeCategory {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.RecipeCategory, this);
            }
        }

        public AqlExpressionPropertyLongString History {
            get {
                return new AqlExpressionPropertyLongString(AqlRecipe.History, this);
            }
        }

        public AqlExpressionPropertyShortString ImageCopyright {
            get {
                return new AqlExpressionPropertyShortString(AqlRecipe.ImageCopyright, this);
            }
        }

    }
}
