// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using WAF.Data.Query;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;

namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelCountryRegion {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_country_region", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger CountryId {
                get {
                    return new SqlFieldPrimaryInteger("country_id", Table);
                }
            }

            public static SqlFieldInteger RegionId {
                get {
                    return new SqlFieldPrimaryInteger("region_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelRegionLocations {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_region_locations", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger RegionId {
                get {
                    return new SqlFieldPrimaryInteger("region_id", Table);
                }
            }

            public static SqlFieldInteger LocationId {
                get {
                    return new SqlFieldPrimaryInteger("location_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelRegionSelectedDestinations {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_region_selecteddestinations", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger RegionId {
                get {
                    return new SqlFieldPrimaryInteger("region_id", Table);
                }
            }

            public static SqlFieldInteger DestinationId {
                get {
                    return new SqlFieldPrimaryInteger("destination_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelLocationTouristAttractions {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_location_touristitem", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger LocationId {
                get {
                    return new SqlFieldPrimaryInteger("location_id", Table);
                }
            }

            public static SqlFieldInteger AttractionId {
                get {
                    return new SqlFieldPrimaryInteger("attraction_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelLocationActivities {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_location_activities", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger LocationId {
                get {
                    return new SqlFieldPrimaryInteger("location_id", Table);
                }
            }

            public static SqlFieldInteger ActivityId {
                get {
                    return new SqlFieldPrimaryInteger("activity_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelLocationAccommodations {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_location_accommodations", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger LocationId {
                get {
                    return new SqlFieldPrimaryInteger("location_id", Table);
                }
            }

            public static SqlFieldInteger AccommodationId {
                get {
                    return new SqlFieldPrimaryInteger("accommodation_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelLocationEatDrink {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_location_eatdrink", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger LocationId {
                get {
                    return new SqlFieldPrimaryInteger("location_id", Table);
                }
            }

            public static SqlFieldInteger EatdrinkId {
                get {
                    return new SqlFieldPrimaryInteger("eatdrink_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelLocationShopping {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_location_shopping", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger LocationId {
                get {
                    return new SqlFieldPrimaryInteger("location_id", Table);
                }
            }

            public static SqlFieldInteger ShopId {
                get {
                    return new SqlFieldPrimaryInteger("shop_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelFrontPageArticles {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_frontpage_articles", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger FrontpageId {
                get {
                    return new SqlFieldPrimaryInteger("frontpage_id", Table);
                }
            }

            public static SqlFieldInteger ArticleId {
                get {
                    return new SqlFieldPrimaryInteger("article_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelLodgingCategories {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_lodging_categories", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger LodgingId {
                get {
                    return new SqlFieldPrimaryInteger("lodging_id", Table);
                }
            }

            public static SqlFieldInteger CatId {
                get {
                    return new SqlFieldPrimaryInteger("cat_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelActivityCategories {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_activity_categories", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ActivityId {
                get {
                    return new SqlFieldPrimaryInteger("activity_id", Table);
                }
            }

            public static SqlFieldInteger CatId {
                get {
                    return new SqlFieldPrimaryInteger("cat_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelAttractionCategories {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_attraction_categories", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger AttractionId {
                get {
                    return new SqlFieldPrimaryInteger("attraction_id", Table);
                }
            }

            public static SqlFieldInteger CatId {
                get {
                    return new SqlFieldPrimaryInteger("cat_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelShoppingCategories {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_shopping_categories", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ShoppingId {
                get {
                    return new SqlFieldPrimaryInteger("shopping_id", Table);
                }
            }

            public static SqlFieldInteger CatId {
                get {
                    return new SqlFieldPrimaryInteger("cat_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelFoodAndDrinkCategories {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_foodanddrink_categories", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger FoodanddrinkId {
                get {
                    return new SqlFieldPrimaryInteger("foodanddrink_id", Table);
                }
            }

            public static SqlFieldInteger CatId {
                get {
                    return new SqlFieldPrimaryInteger("cat_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelRelatedArticles {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_related_articles", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelTouristItemRelatedArticles {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_touristitem_related_articles", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ItemId {
                get {
                    return new SqlFieldPrimaryInteger("item_id", Table);
                }
            }

            public static SqlFieldInteger ArtId {
                get {
                    return new SqlFieldPrimaryInteger("art_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelFrontPageAttractions {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_frontpage_attractions", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ItemId {
                get {
                    return new SqlFieldPrimaryInteger("item_id", Table);
                }
            }

            public static SqlFieldInteger ArtId {
                get {
                    return new SqlFieldPrimaryInteger("art_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelNewsArticle_ImageGallery {

        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_relnewsarticle_imagegallery", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelTouristItem_ItemReview {

        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_RelTouristItem_ItemReview", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelRecipe_ItemReview {

        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_relrecipe_itemreview", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelRecipe_Region {

        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_relrecipe_region", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelModularPageModules {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_rel_modular_page_modules", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {

    public abstract class SqlRelTouristItemsModules {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_rel_tourist_items_modules", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelCountryRegion{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("e1b5664a-1e7e-4355-941f-c3e5e481e571") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelRegionLocations{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("f0c5bdb4-11af-45f1-8427-cab7399c8a21") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelRegionSelectedDestinations{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("fb1631cb-24a6-41c0-9181-fad043d861b4") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelLocationTouristAttractions{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("8b19b911-b92c-449a-974b-046cb999fea4") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelLocationActivities{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("12c82ea0-262b-4e0f-84ce-16c6c3f8af90") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelLocationAccommodations{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("c8b0002f-2878-4432-bd62-3403a3f4a000") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelLocationEatDrink{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("734ea4e1-2735-4de1-9d59-8cae984fc3c7") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelLocationShopping{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("7cfe6a05-0b19-4578-98fd-b6a7d70a0417") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelFrontPageArticles{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("10f1e3dd-652a-4c5f-b16d-0708ee2992dc") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelLodgingCategories{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("1dd43406-1714-47e5-8a6f-f8bd40ce0a15") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelActivityCategories{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("03a5b8c5-a84a-4be0-a329-2eb1c8fcb742") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelAttractionCategories{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("8ba2e8a6-dde9-42ab-8c06-eb57e18a522a") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelShoppingCategories{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("c8acb67e-71eb-4890-8aaf-6d3d93042c34") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelFoodAndDrinkCategories{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("7cbd8db3-8818-439b-a730-304cd4adf656") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelRelatedArticles{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("713b731c-e6e5-4e39-aa65-3f958b0911bb") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelTouristItemRelatedArticles{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("7d56046a-07ac-4cb9-a0f7-c24268b171bc") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelFrontPageAttractions{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("f3f18c00-f07b-461b-b55e-fc5929a11f67") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelNewsArticle_ImageGallery{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("49aaf615-d210-46cc-b576-89bad6f2a566") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelTouristItem_ItemReview{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("96e9894e-6d8f-4d6e-aa1e-038c79b7ae58") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelRecipe_ItemReview{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("cb8e946b-22ea-4fea-888d-e219f28dbe9e") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelRecipe_Region{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("6c63e5cb-70eb-4c92-8f24-0bfe46e29158") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelModularPageModules{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("fda6ef4c-9cdf-4337-8f90-65f6f2bee4d0") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public abstract class AqlRelTouristItemsModules{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("c6631f21-7188-4317-8dd9-4a9bf5abc289") );
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelCountryRegion: AqlAliasRelation {

        public AqlAliasRelCountryRegion(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelCountryRegion.Relation) {

        }
        public AqlAliasRelCountryRegion(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelCountryRegion.Relation, onParent ) {

        }
        public AqlAliasRelCountryRegion(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelCountryRegion.Relation, onChild ) {

        }
        public AqlAliasRelCountryRegion(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelCountryRegion.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelRegionLocations: AqlAliasRelation {

        public AqlAliasRelRegionLocations(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelRegionLocations.Relation) {

        }
        public AqlAliasRelRegionLocations(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelRegionLocations.Relation, onParent ) {

        }
        public AqlAliasRelRegionLocations(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelRegionLocations.Relation, onChild ) {

        }
        public AqlAliasRelRegionLocations(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelRegionLocations.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelRegionSelectedDestinations: AqlAliasRelation {

        public AqlAliasRelRegionSelectedDestinations(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelRegionSelectedDestinations.Relation) {

        }
        public AqlAliasRelRegionSelectedDestinations(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelRegionSelectedDestinations.Relation, onParent ) {

        }
        public AqlAliasRelRegionSelectedDestinations(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelRegionSelectedDestinations.Relation, onChild ) {

        }
        public AqlAliasRelRegionSelectedDestinations(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelRegionSelectedDestinations.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelLocationTouristAttractions: AqlAliasRelation {

        public AqlAliasRelLocationTouristAttractions(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelLocationTouristAttractions.Relation) {

        }
        public AqlAliasRelLocationTouristAttractions(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelLocationTouristAttractions.Relation, onParent ) {

        }
        public AqlAliasRelLocationTouristAttractions(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelLocationTouristAttractions.Relation, onChild ) {

        }
        public AqlAliasRelLocationTouristAttractions(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelLocationTouristAttractions.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelLocationActivities: AqlAliasRelation {

        public AqlAliasRelLocationActivities(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelLocationActivities.Relation) {

        }
        public AqlAliasRelLocationActivities(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelLocationActivities.Relation, onParent ) {

        }
        public AqlAliasRelLocationActivities(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelLocationActivities.Relation, onChild ) {

        }
        public AqlAliasRelLocationActivities(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelLocationActivities.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelLocationAccommodations: AqlAliasRelation {

        public AqlAliasRelLocationAccommodations(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelLocationAccommodations.Relation) {

        }
        public AqlAliasRelLocationAccommodations(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelLocationAccommodations.Relation, onParent ) {

        }
        public AqlAliasRelLocationAccommodations(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelLocationAccommodations.Relation, onChild ) {

        }
        public AqlAliasRelLocationAccommodations(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelLocationAccommodations.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelLocationEatDrink: AqlAliasRelation {

        public AqlAliasRelLocationEatDrink(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelLocationEatDrink.Relation) {

        }
        public AqlAliasRelLocationEatDrink(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelLocationEatDrink.Relation, onParent ) {

        }
        public AqlAliasRelLocationEatDrink(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelLocationEatDrink.Relation, onChild ) {

        }
        public AqlAliasRelLocationEatDrink(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelLocationEatDrink.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelLocationShopping: AqlAliasRelation {

        public AqlAliasRelLocationShopping(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelLocationShopping.Relation) {

        }
        public AqlAliasRelLocationShopping(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelLocationShopping.Relation, onParent ) {

        }
        public AqlAliasRelLocationShopping(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelLocationShopping.Relation, onChild ) {

        }
        public AqlAliasRelLocationShopping(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelLocationShopping.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelFrontPageArticles: AqlAliasRelation {

        public AqlAliasRelFrontPageArticles(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelFrontPageArticles.Relation) {

        }
        public AqlAliasRelFrontPageArticles(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelFrontPageArticles.Relation, onParent ) {

        }
        public AqlAliasRelFrontPageArticles(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelFrontPageArticles.Relation, onChild ) {

        }
        public AqlAliasRelFrontPageArticles(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelFrontPageArticles.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelLodgingCategories: AqlAliasRelation {

        public AqlAliasRelLodgingCategories(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelLodgingCategories.Relation) {

        }
        public AqlAliasRelLodgingCategories(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelLodgingCategories.Relation, onParent ) {

        }
        public AqlAliasRelLodgingCategories(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelLodgingCategories.Relation, onChild ) {

        }
        public AqlAliasRelLodgingCategories(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelLodgingCategories.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelActivityCategories: AqlAliasRelation {

        public AqlAliasRelActivityCategories(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelActivityCategories.Relation) {

        }
        public AqlAliasRelActivityCategories(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelActivityCategories.Relation, onParent ) {

        }
        public AqlAliasRelActivityCategories(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelActivityCategories.Relation, onChild ) {

        }
        public AqlAliasRelActivityCategories(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelActivityCategories.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelAttractionCategories: AqlAliasRelation {

        public AqlAliasRelAttractionCategories(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelAttractionCategories.Relation) {

        }
        public AqlAliasRelAttractionCategories(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelAttractionCategories.Relation, onParent ) {

        }
        public AqlAliasRelAttractionCategories(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelAttractionCategories.Relation, onChild ) {

        }
        public AqlAliasRelAttractionCategories(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelAttractionCategories.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelShoppingCategories: AqlAliasRelation {

        public AqlAliasRelShoppingCategories(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelShoppingCategories.Relation) {

        }
        public AqlAliasRelShoppingCategories(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelShoppingCategories.Relation, onParent ) {

        }
        public AqlAliasRelShoppingCategories(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelShoppingCategories.Relation, onChild ) {

        }
        public AqlAliasRelShoppingCategories(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelShoppingCategories.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelFoodAndDrinkCategories: AqlAliasRelation {

        public AqlAliasRelFoodAndDrinkCategories(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelFoodAndDrinkCategories.Relation) {

        }
        public AqlAliasRelFoodAndDrinkCategories(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelFoodAndDrinkCategories.Relation, onParent ) {

        }
        public AqlAliasRelFoodAndDrinkCategories(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelFoodAndDrinkCategories.Relation, onChild ) {

        }
        public AqlAliasRelFoodAndDrinkCategories(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelFoodAndDrinkCategories.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelRelatedArticles: AqlAliasRelation {

        public AqlAliasRelRelatedArticles(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelRelatedArticles.Relation) {

        }
        public AqlAliasRelRelatedArticles(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelRelatedArticles.Relation, onParent ) {

        }
        public AqlAliasRelRelatedArticles(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelRelatedArticles.Relation, onChild ) {

        }
        public AqlAliasRelRelatedArticles(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelRelatedArticles.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelTouristItemRelatedArticles: AqlAliasRelation {

        public AqlAliasRelTouristItemRelatedArticles(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelTouristItemRelatedArticles.Relation) {

        }
        public AqlAliasRelTouristItemRelatedArticles(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelTouristItemRelatedArticles.Relation, onParent ) {

        }
        public AqlAliasRelTouristItemRelatedArticles(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelTouristItemRelatedArticles.Relation, onChild ) {

        }
        public AqlAliasRelTouristItemRelatedArticles(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelTouristItemRelatedArticles.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelFrontPageAttractions: AqlAliasRelation {

        public AqlAliasRelFrontPageAttractions(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelFrontPageAttractions.Relation) {

        }
        public AqlAliasRelFrontPageAttractions(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelFrontPageAttractions.Relation, onParent ) {

        }
        public AqlAliasRelFrontPageAttractions(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelFrontPageAttractions.Relation, onChild ) {

        }
        public AqlAliasRelFrontPageAttractions(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelFrontPageAttractions.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelNewsArticle_ImageGallery: AqlAliasRelation {

        public AqlAliasRelNewsArticle_ImageGallery(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelNewsArticle_ImageGallery.Relation) {

        }
        public AqlAliasRelNewsArticle_ImageGallery(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelNewsArticle_ImageGallery.Relation, onParent ) {

        }
        public AqlAliasRelNewsArticle_ImageGallery(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelNewsArticle_ImageGallery.Relation, onChild ) {

        }
        public AqlAliasRelNewsArticle_ImageGallery(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelNewsArticle_ImageGallery.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelTouristItem_ItemReview: AqlAliasRelation {

        public AqlAliasRelTouristItem_ItemReview(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelTouristItem_ItemReview.Relation) {

        }
        public AqlAliasRelTouristItem_ItemReview(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelTouristItem_ItemReview.Relation, onParent ) {

        }
        public AqlAliasRelTouristItem_ItemReview(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelTouristItem_ItemReview.Relation, onChild ) {

        }
        public AqlAliasRelTouristItem_ItemReview(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelTouristItem_ItemReview.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelRecipe_ItemReview: AqlAliasRelation {

        public AqlAliasRelRecipe_ItemReview(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelRecipe_ItemReview.Relation) {

        }
        public AqlAliasRelRecipe_ItemReview(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelRecipe_ItemReview.Relation, onParent ) {

        }
        public AqlAliasRelRecipe_ItemReview(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelRecipe_ItemReview.Relation, onChild ) {

        }
        public AqlAliasRelRecipe_ItemReview(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelRecipe_ItemReview.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelRecipe_Region: AqlAliasRelation {

        public AqlAliasRelRecipe_Region(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelRecipe_Region.Relation) {

        }
        public AqlAliasRelRecipe_Region(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelRecipe_Region.Relation, onParent ) {

        }
        public AqlAliasRelRecipe_Region(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelRecipe_Region.Relation, onChild ) {

        }
        public AqlAliasRelRecipe_Region(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelRecipe_Region.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelModularPageModules: AqlAliasRelation {

        public AqlAliasRelModularPageModules(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelModularPageModules.Relation) {

        }
        public AqlAliasRelModularPageModules(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelModularPageModules.Relation, onParent ) {

        }
        public AqlAliasRelModularPageModules(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelModularPageModules.Relation, onChild ) {

        }
        public AqlAliasRelModularPageModules(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelModularPageModules.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo{

    [System.Serializable]
    public class AqlAliasRelTouristItemsModules: AqlAliasRelation {

        public AqlAliasRelTouristItemsModules(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelTouristItemsModules.Relation) {

        }
        public AqlAliasRelTouristItemsModules(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelTouristItemsModules.Relation, onParent ) {

        }
        public AqlAliasRelTouristItemsModules(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelTouristItemsModules.Relation, onChild ) {

        }
        public AqlAliasRelTouristItemsModules(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelTouristItemsModules.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelCountryRegion: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("e1b5664a-1e7e-4355-941f-c3e5e481e571");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelRegionLocations: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("f0c5bdb4-11af-45f1-8427-cab7399c8a21");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelRegionSelectedDestinations: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("fb1631cb-24a6-41c0-9181-fad043d861b4");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelLocationTouristAttractions: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("8b19b911-b92c-449a-974b-046cb999fea4");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelLocationActivities: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("12c82ea0-262b-4e0f-84ce-16c6c3f8af90");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelLocationAccommodations: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("c8b0002f-2878-4432-bd62-3403a3f4a000");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelLocationEatDrink: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("734ea4e1-2735-4de1-9d59-8cae984fc3c7");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelLocationShopping: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("7cfe6a05-0b19-4578-98fd-b6a7d70a0417");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelFrontPageArticles: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("10f1e3dd-652a-4c5f-b16d-0708ee2992dc");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelLodgingCategories: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("1dd43406-1714-47e5-8a6f-f8bd40ce0a15");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelActivityCategories: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("03a5b8c5-a84a-4be0-a329-2eb1c8fcb742");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelAttractionCategories: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("8ba2e8a6-dde9-42ab-8c06-eb57e18a522a");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelShoppingCategories: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("c8acb67e-71eb-4890-8aaf-6d3d93042c34");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelFoodAndDrinkCategories: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("7cbd8db3-8818-439b-a730-304cd4adf656");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelRelatedArticles: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("713b731c-e6e5-4e39-aa65-3f958b0911bb");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelTouristItemRelatedArticles: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("7d56046a-07ac-4cb9-a0f7-c24268b171bc");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelFrontPageAttractions: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("f3f18c00-f07b-461b-b55e-fc5929a11f67");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelNewsArticle_ImageGallery: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("49aaf615-d210-46cc-b576-89bad6f2a566");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelTouristItem_ItemReview: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("96e9894e-6d8f-4d6e-aa1e-038c79b7ae58");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelRecipe_ItemReview: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("cb8e946b-22ea-4fea-888d-e219f28dbe9e");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelRecipe_Region: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("6c63e5cb-70eb-4c92-8f24-0bfe46e29158");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelModularPageModules: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("fda6ef4c-9cdf-4337-8f90-65f6f2bee4d0");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{
    [System.Serializable]
    public partial class RelTouristItemsModules: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("c6631f21-7188-4317-8dd9-4a9bf5abc289");
            }
        }

    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{

    public enum ParagraphPicturePosition: int{

        Left=0,
        Below=1,
        Above=2,
        Right=3,
        Hidden=4,
    }
}
namespace WAF.Engine.Content.TripsToNorwayDemo{

    public enum PictureWidth: int{

        Width48=0,
        Width128=1,
        Width256=2,
        Width320=3,
        Width480=4,
        Width512=5,
    }
}
