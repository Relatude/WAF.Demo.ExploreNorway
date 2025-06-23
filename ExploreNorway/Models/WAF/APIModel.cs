// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using System;
using System.Linq;
using System.Collections.Generic;
namespace WAF.API { public class CustomDefinition{ } };

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("6469869a-b2e3-433c-ae29-bcbba3c77b85")]
public class ExplorerCountry : WAF.API.Native.HierarchicalContent {
public ExplorerCountry(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _regionsGuid = new Guid("e6a3e7fb-86fb-4cc6-8354-e2755e24f524");
        [PropertyGuid("e6a3e7fb-86fb-4cc6-8354-e2755e24f524")]
        public IQueryable<WAF.API.TripsToNorwayDemo.Region> Regions {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_regionsGuid)).Cast<WAF.API.TripsToNorwayDemo.Region>();}
        set {DataProvider.SetPropertyValue(_regionsGuid, value);}
        }
      
        static Guid _picturesGuid = new Guid("5fc3a1f7-10c1-4baf-aef3-fa58811af222");
        [PropertyGuid("5fc3a1f7-10c1-4baf-aef3-fa58811af222")]
        public System.Collections.Generic.List<WAF.API.Native.InnerFile> Pictures {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_picturesGuid)).Cast<WAF.API.Native.InnerFile>().ToList();}
        set {DataProvider.SetPropertyValue(_picturesGuid, value);}
        }
      
        static Guid _aboutGuid = new Guid("350d9a93-6fde-4908-903a-63b17a1a2b36");
        [PropertyGuid("350d9a93-6fde-4908-903a-63b17a1a2b36")]
        public string About {
        get { return (string)DataProvider.GetPropertyValue(_aboutGuid); }
        set { DataProvider.SetPropertyValue(_aboutGuid, value); }
        }
      
        static Guid _flagGuid = new Guid("1b5de2a2-07e2-4095-a126-2577d8e82986");
        [PropertyGuid("1b5de2a2-07e2-4095-a126-2577d8e82986")]
        public PropertyTypes.FileInfo Flag {
        get { return DataProvider.GetFileInfo(_flagGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _latitudeGuid = new Guid("1df596bb-b22b-463d-8a53-162fa12b30b0");
        [PropertyGuid("1df596bb-b22b-463d-8a53-162fa12b30b0")]
        public string Latitude {
        get { return (string)DataProvider.GetPropertyValue(_latitudeGuid); }
        set { DataProvider.SetPropertyValue(_latitudeGuid, value); }
        }
      
        static Guid _longitudeGuid = new Guid("4dc761db-dd40-4464-8aa9-be71b7c2a8ad");
        [PropertyGuid("4dc761db-dd40-4464-8aa9-be71b7c2a8ad")]
        public string Longitude {
        get { return (string)DataProvider.GetPropertyValue(_longitudeGuid); }
        set { DataProvider.SetPropertyValue(_longitudeGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("c081d11c-f337-44af-91ec-6a32b34a022f")]
public class Region : WAF.API.Native.HierarchicalContent {
public Region(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _topPictureGuid = new Guid("d19e0fe5-093b-4dc7-96a8-e188ae1f6cb2");
        [PropertyGuid("d19e0fe5-093b-4dc7-96a8-e188ae1f6cb2")]
        public PropertyTypes.FileInfo TopPicture {
        get { return DataProvider.GetFileInfo(_topPictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _countryGuid = new Guid("b6fdd34c-8460-44f3-a3d6-9338e81d9806");
        [PropertyGuid("b6fdd34c-8460-44f3-a3d6-9338e81d9806")]
        public WAF.API.TripsToNorwayDemo.ExplorerCountry Country{
        get { return DataProvider.GetPropertyValue(_countryGuid) as WAF.API.TripsToNorwayDemo.ExplorerCountry;}
        set { DataProvider.SetPropertyValue(_countryGuid, value);}
        }
      
        static Guid _locationsGuid = new Guid("b65271d2-5772-4ad3-8a69-617c1dedb53e");
        [PropertyGuid("b65271d2-5772-4ad3-8a69-617c1dedb53e")]
        public IQueryable<WAF.API.TripsToNorwayDemo.Location> Locations {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_locationsGuid)).Cast<WAF.API.TripsToNorwayDemo.Location>();}
        set {DataProvider.SetPropertyValue(_locationsGuid, value);}
        }
      
        static Guid _picturesGuid = new Guid("ed6652a4-1340-47d5-9476-9e86c4ac466c");
        [PropertyGuid("ed6652a4-1340-47d5-9476-9e86c4ac466c")]
        public System.Collections.Generic.List<WAF.API.Native.InnerFile> Pictures {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_picturesGuid)).Cast<WAF.API.Native.InnerFile>().ToList();}
        set {DataProvider.SetPropertyValue(_picturesGuid, value);}
        }
      
        static Guid _ingressGuid = new Guid("5a3112ea-fd42-4cf2-8c24-6317c996a1fd");
        [PropertyGuid("5a3112ea-fd42-4cf2-8c24-6317c996a1fd")]
        public string Ingress {
        get { return (string)DataProvider.GetPropertyValue(_ingressGuid); }
        set { DataProvider.SetPropertyValue(_ingressGuid, value); }
        }
      
        static Guid _descriptionGuid = new Guid("7255ef67-bc75-43ab-ad19-45ecfa3ff4c7");
        [PropertyGuid("7255ef67-bc75-43ab-ad19-45ecfa3ff4c7")]
        public string Description {
        get { return (string)DataProvider.GetPropertyValue(_descriptionGuid); }
        set { DataProvider.SetPropertyValue(_descriptionGuid, value); }
        }
      
        static Guid _selectedDestinationsGuid = new Guid("b18a3de7-31d3-4724-9cb7-0bb325a64c55");
        [PropertyGuid("b18a3de7-31d3-4724-9cb7-0bb325a64c55")]
        public IQueryable<WAF.API.TripsToNorwayDemo.TouristItem> SelectedDestinations {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_selectedDestinationsGuid)).Cast<WAF.API.TripsToNorwayDemo.TouristItem>();}
        set {DataProvider.SetPropertyValue(_selectedDestinationsGuid, value);}
        }
      
        static Guid _relatedRecipeGuid = new Guid("78c81b02-fa9e-4da6-975a-9781c2ef35d2");
        [PropertyGuid("78c81b02-fa9e-4da6-975a-9781c2ef35d2")]
        public IQueryable<WAF.API.TripsToNorwayDemo.Recipe>
        RelatedRecipe {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_relatedRecipeGuid)).Cast<WAF.API.TripsToNorwayDemo.Recipe>();}
        set {DataProvider.SetPropertyValue(_relatedRecipeGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("787b66bd-7e69-44a8-8c08-d1adf1026eab")]
public class Location : WAF.API.Native.HierarchicalContent {
public Location(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _topPictureGuid = new Guid("56500c39-1ec2-4d34-8526-cac10f04cadc");
        [PropertyGuid("56500c39-1ec2-4d34-8526-cac10f04cadc")]
        public PropertyTypes.FileInfo TopPicture {
        get { return DataProvider.GetFileInfo(_topPictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _regionGuid = new Guid("486f617c-8946-4ef2-b567-06dbeb89da4f");
        [PropertyGuid("486f617c-8946-4ef2-b567-06dbeb89da4f")]
        public WAF.API.TripsToNorwayDemo.Region Region{
        get { return DataProvider.GetPropertyValue(_regionGuid) as WAF.API.TripsToNorwayDemo.Region;}
        set { DataProvider.SetPropertyValue(_regionGuid, value);}
        }
      
        static Guid _ingressGuid = new Guid("7be79d29-bf3f-40f0-b686-d63da32ebc78");
        [PropertyGuid("7be79d29-bf3f-40f0-b686-d63da32ebc78")]
        public string Ingress {
        get { return (string)DataProvider.GetPropertyValue(_ingressGuid); }
        set { DataProvider.SetPropertyValue(_ingressGuid, value); }
        }
      
        static Guid _picturesGuid = new Guid("5be8c834-f167-47af-9bab-67290df31bc6");
        [PropertyGuid("5be8c834-f167-47af-9bab-67290df31bc6")]
        public System.Collections.Generic.List<WAF.API.Native.InnerFile> Pictures {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_picturesGuid)).Cast<WAF.API.Native.InnerFile>().ToList();}
        set {DataProvider.SetPropertyValue(_picturesGuid, value);}
        }
      
        static Guid _descriptionGuid = new Guid("99283b4f-33bb-4852-a845-a021bf74f3dc");
        [PropertyGuid("99283b4f-33bb-4852-a845-a021bf74f3dc")]
        public string Description {
        get { return (string)DataProvider.GetPropertyValue(_descriptionGuid); }
        set { DataProvider.SetPropertyValue(_descriptionGuid, value); }
        }
      
        static Guid _attractionsGuid = new Guid("b7702ede-0a11-425f-b2f9-bdd5291b8e9e");
        [PropertyGuid("b7702ede-0a11-425f-b2f9-bdd5291b8e9e")]
        public IQueryable<WAF.API.TripsToNorwayDemo.TouristItem> Attractions {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_attractionsGuid)).Cast<WAF.API.TripsToNorwayDemo.TouristItem>();}
        set {DataProvider.SetPropertyValue(_attractionsGuid, value);}
        }
      
        static Guid _activitiesGuid = new Guid("1e915686-9c7f-486e-a9bb-fc4fb4681679");
        [PropertyGuid("1e915686-9c7f-486e-a9bb-fc4fb4681679")]
        public IQueryable<WAF.API.TripsToNorwayDemo.TouristActivity> Activities {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_activitiesGuid)).Cast<WAF.API.TripsToNorwayDemo.TouristActivity>();}
        set {DataProvider.SetPropertyValue(_activitiesGuid, value);}
        }
      
        static Guid _accommodationsGuid = new Guid("d3069e79-9b01-4aa5-b936-7787a699d582");
        [PropertyGuid("d3069e79-9b01-4aa5-b936-7787a699d582")]
        public IQueryable<WAF.API.TripsToNorwayDemo.Accommodation> Accommodations {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_accommodationsGuid)).Cast<WAF.API.TripsToNorwayDemo.Accommodation>();}
        set {DataProvider.SetPropertyValue(_accommodationsGuid, value);}
        }
      
        static Guid _foodAndDrinkGuid = new Guid("a7882715-4fea-4447-ad8c-c03e792b52ad");
        [PropertyGuid("a7882715-4fea-4447-ad8c-c03e792b52ad")]
        public IQueryable<WAF.API.TripsToNorwayDemo.PlaceToEatOrDrink> FoodAndDrink {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_foodAndDrinkGuid)).Cast<WAF.API.TripsToNorwayDemo.PlaceToEatOrDrink>();}
        set {DataProvider.SetPropertyValue(_foodAndDrinkGuid, value);}
        }
      
        static Guid _shoppingGuid = new Guid("7245a0b6-f66b-4a61-a4a6-f692b6f2ea7b");
        [PropertyGuid("7245a0b6-f66b-4a61-a4a6-f692b6f2ea7b")]
        public IQueryable<WAF.API.TripsToNorwayDemo.Shopping> Shopping {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_shoppingGuid)).Cast<WAF.API.TripsToNorwayDemo.Shopping>();}
        set {DataProvider.SetPropertyValue(_shoppingGuid, value);}
        }
      
        static Guid _longitudeGuid = new Guid("c459269d-709d-407a-8601-d133807d2874");
        [PropertyGuid("c459269d-709d-407a-8601-d133807d2874")]
        public string Longitude {
        get { return (string)DataProvider.GetPropertyValue(_longitudeGuid); }
        set { DataProvider.SetPropertyValue(_longitudeGuid, value); }
        }
      
        static Guid _latitudeGuid = new Guid("269f6bca-8bf4-4b39-85fe-a535e9ff5590");
        [PropertyGuid("269f6bca-8bf4-4b39-85fe-a535e9ff5590")]
        public string Latitude {
        get { return (string)DataProvider.GetPropertyValue(_latitudeGuid); }
        set { DataProvider.SetPropertyValue(_latitudeGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("5bbadc74-378c-4a7a-a994-3719a949c1cd")]
public class TouristItem : WAF.API.Native.HierarchicalContent {
public TouristItem(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _topPictureGuid = new Guid("c8b7c018-1373-4737-8367-754ae3ad977e");
        [PropertyGuid("c8b7c018-1373-4737-8367-754ae3ad977e")]
        public PropertyTypes.FileInfo TopPicture {
        get { return DataProvider.GetFileInfo(_topPictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _ingressGuid = new Guid("c6af1170-2bb9-4739-a6e9-423dcc4516cd");
        [PropertyGuid("c6af1170-2bb9-4739-a6e9-423dcc4516cd")]
        public string Ingress {
        get { return (string)DataProvider.GetPropertyValue(_ingressGuid); }
        set { DataProvider.SetPropertyValue(_ingressGuid, value); }
        }
      
        static Guid _picturesGuid = new Guid("11a38463-1ce1-4aae-8a43-b3cf21776e86");
        [PropertyGuid("11a38463-1ce1-4aae-8a43-b3cf21776e86")]
        public System.Collections.Generic.List<WAF.API.Native.InnerFile> Pictures {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_picturesGuid)).Cast<WAF.API.Native.InnerFile>().ToList();}
        set {DataProvider.SetPropertyValue(_picturesGuid, value);}
        }
      
        static Guid _descriptionGuid = new Guid("ed6cb390-367d-4b05-b137-6a14eae0d7b4");
        [PropertyGuid("ed6cb390-367d-4b05-b137-6a14eae0d7b4")]
        public string Description {
        get { return (string)DataProvider.GetPropertyValue(_descriptionGuid); }
        set { DataProvider.SetPropertyValue(_descriptionGuid, value); }
        }
      
        static Guid _relatedArticlesGuid = new Guid("d1861dff-b400-40c6-a314-ff4ce604894a");
        [PropertyGuid("d1861dff-b400-40c6-a314-ff4ce604894a")]
        public IQueryable<WAF.API.Native.HierarchicalContent> RelatedArticles {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_relatedArticlesGuid)).Cast<WAF.API.Native.HierarchicalContent>();}
        set {DataProvider.SetPropertyValue(_relatedArticlesGuid, value);}
        }
      
        static Guid _phoneGuid = new Guid("61b410be-d6fd-456a-8a02-84ef1c203fdc");
        [PropertyGuid("61b410be-d6fd-456a-8a02-84ef1c203fdc")]
        public string Phone {
        get { return (string)DataProvider.GetPropertyValue(_phoneGuid); }
        set { DataProvider.SetPropertyValue(_phoneGuid, value); }
        }
      
        static Guid _emailGuid = new Guid("6d70f265-c878-41b9-a5b0-0a8a99d8b3f5");
        [PropertyGuid("6d70f265-c878-41b9-a5b0-0a8a99d8b3f5")]
        public string Email {
        get { return (string)DataProvider.GetPropertyValue(_emailGuid); }
        set { DataProvider.SetPropertyValue(_emailGuid, value); }
        }
      
        static Guid _websiteGuid = new Guid("d0109497-7cc4-4020-b18a-b7af4a4ac387");
        [PropertyGuid("d0109497-7cc4-4020-b18a-b7af4a4ac387")]
        public string Website {
        get { return (string)DataProvider.GetPropertyValue(_websiteGuid); }
        set { DataProvider.SetPropertyValue(_websiteGuid, value); }
        }
      
        static Guid _addressPostalCode_oldGuid = new Guid("9b54897b-cb5a-4336-b687-d9a1a2c3b6e2");
        [PropertyGuid("9b54897b-cb5a-4336-b687-d9a1a2c3b6e2")]
        public string AddressPostalCode_old {
        get { return (string)DataProvider.GetPropertyValue(_addressPostalCode_oldGuid); }
        set { DataProvider.SetPropertyValue(_addressPostalCode_oldGuid, value); }
        }
      
        static Guid _addressRegionGuid = new Guid("6b4e17db-5476-4a35-ac14-52e3d67b8c79");
        [PropertyGuid("6b4e17db-5476-4a35-ac14-52e3d67b8c79")]
        public string AddressRegion {
        get { return (string)DataProvider.GetPropertyValue(_addressRegionGuid); }
        set { DataProvider.SetPropertyValue(_addressRegionGuid, value); }
        }
      
        static Guid _addressLocalityGuid = new Guid("2d0b050f-bb12-4625-8b82-e4571b057d19");
        [PropertyGuid("2d0b050f-bb12-4625-8b82-e4571b057d19")]
        public string AddressLocality {
        get { return (string)DataProvider.GetPropertyValue(_addressLocalityGuid); }
        set { DataProvider.SetPropertyValue(_addressLocalityGuid, value); }
        }
      
        static Guid _addressPostBoxGuid = new Guid("eb9e7712-10de-406b-a6c2-2c7ecb1a7535");
        [PropertyGuid("eb9e7712-10de-406b-a6c2-2c7ecb1a7535")]
        public string AddressPostBox {
        get { return (string)DataProvider.GetPropertyValue(_addressPostBoxGuid); }
        set { DataProvider.SetPropertyValue(_addressPostBoxGuid, value); }
        }
      
        static Guid _addressStreetGuid = new Guid("2c4dae90-e7f8-4e50-b642-9ba38ac9662b");
        [PropertyGuid("2c4dae90-e7f8-4e50-b642-9ba38ac9662b")]
        public string AddressStreet {
        get { return (string)DataProvider.GetPropertyValue(_addressStreetGuid); }
        set { DataProvider.SetPropertyValue(_addressStreetGuid, value); }
        }
      
        static Guid _addressPostalCodeGuid = new Guid("49a44898-d36a-45ef-9d86-df5ed3d7d489");
        [PropertyGuid("49a44898-d36a-45ef-9d86-df5ed3d7d489")]
        public string AddressPostalCode {
        get { return (string)DataProvider.GetPropertyValue(_addressPostalCodeGuid); }
        set { DataProvider.SetPropertyValue(_addressPostalCodeGuid, value); }
        }
      
        static Guid _addressFindingDirectionsGuid = new Guid("4dea6711-b053-4e61-8b3e-e36c9fbb321e");
        [PropertyGuid("4dea6711-b053-4e61-8b3e-e36c9fbb321e")]
        public string AddressFindingDirections {
        get { return (string)DataProvider.GetPropertyValue(_addressFindingDirectionsGuid); }
        set { DataProvider.SetPropertyValue(_addressFindingDirectionsGuid, value); }
        }
      
        static Guid _addressCompanyNameGuid = new Guid("4c7eefe0-4e48-4a22-8fa2-71aa9fd045fe");
        [PropertyGuid("4c7eefe0-4e48-4a22-8fa2-71aa9fd045fe")]
        public string AddressCompanyName {
        get { return (string)DataProvider.GetPropertyValue(_addressCompanyNameGuid); }
        set { DataProvider.SetPropertyValue(_addressCompanyNameGuid, value); }
        }
      
        static Guid _relatedReviewsGuid = new Guid("fc5ac14c-aaa0-43ee-8c8d-19d2d3c0782e");
        [PropertyGuid("fc5ac14c-aaa0-43ee-8c8d-19d2d3c0782e")]
        public IQueryable<WAF.API.TripsToNorwayDemo.ItemReview> RelatedReviews {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_relatedReviewsGuid)).Cast<WAF.API.TripsToNorwayDemo.ItemReview>();}
        set {DataProvider.SetPropertyValue(_relatedReviewsGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("2be1a934-671e-4c62-94de-585f353bc00f")]
public class TouristActivity : WAF.API.TripsToNorwayDemo.TouristItem {
public TouristActivity(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _locationGuid = new Guid("ac4bfa71-f468-4bc1-8118-603397fa30c7");
        [PropertyGuid("ac4bfa71-f468-4bc1-8118-603397fa30c7")]
        public WAF.API.TripsToNorwayDemo.Location Location{
        get { return DataProvider.GetPropertyValue(_locationGuid) as WAF.API.TripsToNorwayDemo.Location;}
        set { DataProvider.SetPropertyValue(_locationGuid, value);}
        }
      
        static Guid _categoriesGuid = new Guid("c79779e2-4e01-4afd-81f3-6ba77573acfe");
        [PropertyGuid("c79779e2-4e01-4afd-81f3-6ba77573acfe")]
        public IQueryable<WAF.API.TripsToNorwayDemo.ActivityCategory> Categories {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_categoriesGuid)).Cast<WAF.API.TripsToNorwayDemo.ActivityCategory>();}
        set {DataProvider.SetPropertyValue(_categoriesGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("483109fa-c68c-45e1-9300-4526ac8fa4c9")]
public class TouristAttraction : WAF.API.TripsToNorwayDemo.TouristItem {
public TouristAttraction(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _locationGuid = new Guid("213d5f0e-5dfc-47f6-ad1e-c5317d95ef2d");
        [PropertyGuid("213d5f0e-5dfc-47f6-ad1e-c5317d95ef2d")]
        public WAF.API.TripsToNorwayDemo.Location Location{
        get { return DataProvider.GetPropertyValue(_locationGuid) as WAF.API.TripsToNorwayDemo.Location;}
        set { DataProvider.SetPropertyValue(_locationGuid, value);}
        }
      
        static Guid _categoriesGuid = new Guid("4c2fd0db-7b1e-4c72-bf1e-98aa44ed16fc");
        [PropertyGuid("4c2fd0db-7b1e-4c72-bf1e-98aa44ed16fc")]
        public IQueryable<WAF.API.TripsToNorwayDemo.AttractionCategory> Categories {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_categoriesGuid)).Cast<WAF.API.TripsToNorwayDemo.AttractionCategory>();}
        set {DataProvider.SetPropertyValue(_categoriesGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("b36aa7d6-dea4-4eb4-bfd1-2cb084869252")]
public class Accommodation : WAF.API.TripsToNorwayDemo.TouristItem {
public Accommodation(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _locationGuid = new Guid("ac88f9ea-6a51-422e-b3d6-4858d8a95124");
        [PropertyGuid("ac88f9ea-6a51-422e-b3d6-4858d8a95124")]
        public WAF.API.TripsToNorwayDemo.Location Location{
        get { return DataProvider.GetPropertyValue(_locationGuid) as WAF.API.TripsToNorwayDemo.Location;}
        set { DataProvider.SetPropertyValue(_locationGuid, value);}
        }
      
        static Guid _categoriesGuid = new Guid("99858316-3405-442a-a927-701c77e18a20");
        [PropertyGuid("99858316-3405-442a-a927-701c77e18a20")]
        public IQueryable<WAF.API.TripsToNorwayDemo.AccommodationCategory> Categories {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_categoriesGuid)).Cast<WAF.API.TripsToNorwayDemo.AccommodationCategory>();}
        set {DataProvider.SetPropertyValue(_categoriesGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("e058b05f-3ec5-457d-8087-d728c0848b0d")]
public class Shopping : WAF.API.TripsToNorwayDemo.TouristItem {
public Shopping(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _locationGuid = new Guid("65d1237b-df97-4f00-9dc2-702121de2914");
        [PropertyGuid("65d1237b-df97-4f00-9dc2-702121de2914")]
        public WAF.API.TripsToNorwayDemo.Location Location{
        get { return DataProvider.GetPropertyValue(_locationGuid) as WAF.API.TripsToNorwayDemo.Location;}
        set { DataProvider.SetPropertyValue(_locationGuid, value);}
        }
      
        static Guid _categoriesGuid = new Guid("6ca597d5-b0dd-4453-9ca1-bebd2de69e2c");
        [PropertyGuid("6ca597d5-b0dd-4453-9ca1-bebd2de69e2c")]
        public IQueryable<WAF.API.TripsToNorwayDemo.ShoppingCategory> Categories {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_categoriesGuid)).Cast<WAF.API.TripsToNorwayDemo.ShoppingCategory>();}
        set {DataProvider.SetPropertyValue(_categoriesGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("08fa5b0b-8fdc-4dce-910f-48904c9859d0")]
public class PlaceToEatOrDrink : WAF.API.TripsToNorwayDemo.TouristItem {
public PlaceToEatOrDrink(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _locationGuid = new Guid("5e6c579f-07d7-481e-98d1-f1b8b1015e36");
        [PropertyGuid("5e6c579f-07d7-481e-98d1-f1b8b1015e36")]
        public WAF.API.TripsToNorwayDemo.Location Location{
        get { return DataProvider.GetPropertyValue(_locationGuid) as WAF.API.TripsToNorwayDemo.Location;}
        set { DataProvider.SetPropertyValue(_locationGuid, value);}
        }
      
        static Guid _categoriesGuid = new Guid("dc4bf465-6913-44db-9216-921ff1e55589");
        [PropertyGuid("dc4bf465-6913-44db-9216-921ff1e55589")]
        public IQueryable<WAF.API.TripsToNorwayDemo.FoodAndDrinkCategory> Categories {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_categoriesGuid)).Cast<WAF.API.TripsToNorwayDemo.FoodAndDrinkCategory>();}
        set {DataProvider.SetPropertyValue(_categoriesGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("6af697af-b9bc-4e6e-9ab9-9d13c167e73e")]
public class Article : WAF.API.Native.HierarchicalContent {
public Article(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _ingressGuid = new Guid("99b1ca08-c6a4-43ea-8fcc-85ddb718447d");
        [PropertyGuid("99b1ca08-c6a4-43ea-8fcc-85ddb718447d")]
        public string Ingress {
        get { return (string)DataProvider.GetPropertyValue(_ingressGuid); }
        set { DataProvider.SetPropertyValue(_ingressGuid, value); }
        }
      
        static Guid _ingressPictureGuid = new Guid("dfb20f02-220e-4079-862f-1f525a99ce8b");
        [PropertyGuid("dfb20f02-220e-4079-862f-1f525a99ce8b")]
        public PropertyTypes.FileInfo IngressPicture {
        get { return DataProvider.GetFileInfo(_ingressPictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _paragraphsGuid = new Guid("0a4a7610-a9f5-4c40-aa48-0b437fa0ef1a");
        [PropertyGuid("0a4a7610-a9f5-4c40-aa48-0b437fa0ef1a")]
        public System.Collections.Generic.List<WAF.API.Native.InnerContentBase> Paragraphs {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_paragraphsGuid)).Cast<WAF.API.Native.InnerContentBase>().ToList();}
        set {DataProvider.SetPropertyValue(_paragraphsGuid, value);}
        }
      
        static Guid _filesGuid = new Guid("d26b2ed7-e0ba-4b8a-a424-9b112308f4f0");
        [PropertyGuid("d26b2ed7-e0ba-4b8a-a424-9b112308f4f0")]
        public System.Collections.Generic.List<WAF.API.Native.InnerFile> Files {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_filesGuid)).Cast<WAF.API.Native.InnerFile>().ToList();}
        set {DataProvider.SetPropertyValue(_filesGuid, value);}
        }
      
        static Guid _relatedArticlesGuid = new Guid("40746398-4e54-4904-85b8-ee48e0890b4c");
        [PropertyGuid("40746398-4e54-4904-85b8-ee48e0890b4c")]
        public IQueryable<WAF.API.Native.HierarchicalContent> RelatedArticles {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_relatedArticlesGuid)).Cast<WAF.API.Native.HierarchicalContent>();}
        set {DataProvider.SetPropertyValue(_relatedArticlesGuid, value);}
        }
      
        static Guid _relatedTouristItemsGuid = new Guid("0b160d77-0fe4-481e-a6f1-ee4fc253cbae");
        [PropertyGuid("0b160d77-0fe4-481e-a6f1-ee4fc253cbae")]
        public IQueryable<WAF.API.TripsToNorwayDemo.TouristItem>
        RelatedTouristItems {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_relatedTouristItemsGuid)).Cast<WAF.API.TripsToNorwayDemo.TouristItem>();}
        set {DataProvider.SetPropertyValue(_relatedTouristItemsGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("e3a0c4a5-8368-49f8-94a3-727b6d24a500")]
public class ParagraphText : WAF.API.Native.InnerContentBase {
public ParagraphText(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _titleGuid = new Guid("73b550d3-d203-4226-88ab-43ee69cf42e6");
        [PropertyGuid("73b550d3-d203-4226-88ab-43ee69cf42e6")]
        public string Title {
        get { return (string)DataProvider.GetPropertyValue(_titleGuid); }
        set { DataProvider.SetPropertyValue(_titleGuid, value); }
        }
      
        static Guid _pictureGuid = new Guid("55e5c6b4-5cda-4525-927d-a55125fffa44");
        [PropertyGuid("55e5c6b4-5cda-4525-927d-a55125fffa44")]
        public PropertyTypes.FileInfo Picture {
        get { return DataProvider.GetFileInfo(_pictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _picturePositionGuid = new Guid("14dddde5-7b5f-45bc-97bd-77a988f8f74b");
        [PropertyGuid("14dddde5-7b5f-45bc-97bd-77a988f8f74b")]
        public string PicturePosition {
        get { return (string)DataProvider.GetPropertyValue(_picturePositionGuid); }
        set { DataProvider.SetPropertyValue(_picturePositionGuid, value); }
        }
      
        static Guid _pictureWidthGuid = new Guid("f74bb119-ac7f-420d-b7f8-2d095b46ade9");
        [PropertyGuid("f74bb119-ac7f-420d-b7f8-2d095b46ade9")]
        public string PictureWidth {
        get { return (string)DataProvider.GetPropertyValue(_pictureWidthGuid); }
        set { DataProvider.SetPropertyValue(_pictureWidthGuid, value); }
        }
      
        static Guid _textGuid = new Guid("c239e3d8-036f-42c8-9cc4-e68034257bca");
        [PropertyGuid("c239e3d8-036f-42c8-9cc4-e68034257bca")]
        public string Text {
        get { return (string)DataProvider.GetPropertyValue(_textGuid); }
        set { DataProvider.SetPropertyValue(_textGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("e4c5b52a-3b54-49db-8766-4b4bf333ff05")]
public class ParagraphVideo : WAF.API.Native.InnerContentBase {
public ParagraphVideo(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _titleGuid = new Guid("c05f4da6-3d1f-407f-8be1-ee975716d3d4");
        [PropertyGuid("c05f4da6-3d1f-407f-8be1-ee975716d3d4")]
        public string Title {
        get { return (string)DataProvider.GetPropertyValue(_titleGuid); }
        set { DataProvider.SetPropertyValue(_titleGuid, value); }
        }
      
        static Guid _videoGuid = new Guid("d7078f96-3f2d-4cf2-8cb8-a5ba500075c7");
        [PropertyGuid("d7078f96-3f2d-4cf2-8cb8-a5ba500075c7")]
        public PropertyTypes.FileInfo Video {
        get { return DataProvider.GetFileInfo(_videoGuid); }
        set { throw new NotSupportedException(); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("e0285d40-cf82-437a-a2a5-c559acb7d6ba")]
public class ParagraphPictureSeries : WAF.API.Native.InnerContentBase {
public ParagraphPictureSeries(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _titleGuid = new Guid("a1d50a9c-e878-429c-91f7-5f1f402fd55c");
        [PropertyGuid("a1d50a9c-e878-429c-91f7-5f1f402fd55c")]
        public string Title {
        get { return (string)DataProvider.GetPropertyValue(_titleGuid); }
        set { DataProvider.SetPropertyValue(_titleGuid, value); }
        }
      
        static Guid _picturesGuid = new Guid("5a9648aa-f025-468d-8fa4-2c29de356b12");
        [PropertyGuid("5a9648aa-f025-468d-8fa4-2c29de356b12")]
        public System.Collections.Generic.List<WAF.API.TripsToNorwayDemo.SeriesPicture> Pictures {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_picturesGuid)).Cast<WAF.API.TripsToNorwayDemo.SeriesPicture>().ToList();}
        set {DataProvider.SetPropertyValue(_picturesGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("48d6467d-c031-4380-ba3c-ad27cb555f3a")]
public class SeriesPicture : WAF.API.Native.InnerFile {
public SeriesPicture(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _descriptionGuid = new Guid("9bab0e80-e43d-4946-87d9-73dca3ffb5ed");
        [PropertyGuid("9bab0e80-e43d-4946-87d9-73dca3ffb5ed")]
        public string Description {
        get { return (string)DataProvider.GetPropertyValue(_descriptionGuid); }
        set { DataProvider.SetPropertyValue(_descriptionGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("98cdc721-1b86-4a02-846d-4d95b8133ba8")]
public class SimpleArticle : WAF.API.Native.HierarchicalContent {
public SimpleArticle(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _ingressGuid = new Guid("3af8b5bd-ae33-41f9-9fd8-acb0a1e0faa9");
        [PropertyGuid("3af8b5bd-ae33-41f9-9fd8-acb0a1e0faa9")]
        public string Ingress {
        get { return (string)DataProvider.GetPropertyValue(_ingressGuid); }
        set { DataProvider.SetPropertyValue(_ingressGuid, value); }
        }
      
        static Guid _ingressPictureGuid = new Guid("9477eb8a-e4f5-4d17-9d19-379f288b78a3");
        [PropertyGuid("9477eb8a-e4f5-4d17-9d19-379f288b78a3")]
        public PropertyTypes.FileInfo IngressPicture {
        get { return DataProvider.GetFileInfo(_ingressPictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _contentGuid = new Guid("84fa5602-95ec-4f96-94dd-20f73a5780e8");
        [PropertyGuid("84fa5602-95ec-4f96-94dd-20f73a5780e8")]
        public string Content {
        get { return (string)DataProvider.GetPropertyValue(_contentGuid); }
        set { DataProvider.SetPropertyValue(_contentGuid, value); }
        }
      
        static Guid _filesGuid = new Guid("8977339d-7320-4e4d-8082-fe5f95b6e861");
        [PropertyGuid("8977339d-7320-4e4d-8082-fe5f95b6e861")]
        public System.Collections.Generic.List<WAF.API.Native.InnerFile> Files {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_filesGuid)).Cast<WAF.API.Native.InnerFile>().ToList();}
        set {DataProvider.SetPropertyValue(_filesGuid, value);}
        }
      
        static Guid _relatedArticlesGuid = new Guid("f6845a79-34da-4c6b-99b2-c23494b180df");
        [PropertyGuid("f6845a79-34da-4c6b-99b2-c23494b180df")]
        public IQueryable<WAF.API.Native.HierarchicalContent> RelatedArticles {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_relatedArticlesGuid)).Cast<WAF.API.Native.HierarchicalContent>();}
        set {DataProvider.SetPropertyValue(_relatedArticlesGuid, value);}
        }
      
        static Guid _relatedTouristItemsGuid = new Guid("5ca6c682-c908-4086-a372-b7932b0e033c");
        [PropertyGuid("5ca6c682-c908-4086-a372-b7932b0e033c")]
        public IQueryable<WAF.API.TripsToNorwayDemo.TouristItem>
        RelatedTouristItems {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_relatedTouristItemsGuid)).Cast<WAF.API.TripsToNorwayDemo.TouristItem>();}
        set {DataProvider.SetPropertyValue(_relatedTouristItemsGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("c4cc7f94-5263-4cf1-888b-a2c10cabcd29")]
public class FrontPage : WAF.API.TripsToNorwayDemo.ModulesPage {
public FrontPage(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _mainImageTitleGuid = new Guid("1680e914-9b7b-4fd9-9f38-3d4c893aab86");
        [PropertyGuid("1680e914-9b7b-4fd9-9f38-3d4c893aab86")]
        public string MainImageTitle {
        get { return (string)DataProvider.GetPropertyValue(_mainImageTitleGuid); }
        set { DataProvider.SetPropertyValue(_mainImageTitleGuid, value); }
        }
      
        static Guid _mainImageTextGuid = new Guid("02f75dab-c494-4172-9133-b5798010ff82");
        [PropertyGuid("02f75dab-c494-4172-9133-b5798010ff82")]
        public string MainImageText {
        get { return (string)DataProvider.GetPropertyValue(_mainImageTextGuid); }
        set { DataProvider.SetPropertyValue(_mainImageTextGuid, value); }
        }
      
        static Guid _mainHeadingGuid = new Guid("381e2478-024d-47ff-979b-97c365a23a65");
        [PropertyGuid("381e2478-024d-47ff-979b-97c365a23a65")]
        public string MainHeading {
        get { return (string)DataProvider.GetPropertyValue(_mainHeadingGuid); }
        set { DataProvider.SetPropertyValue(_mainHeadingGuid, value); }
        }
      
        static Guid _topPictureGuid = new Guid("ce2eccfc-3669-445c-9292-32eb27cf5ec5");
        [PropertyGuid("ce2eccfc-3669-445c-9292-32eb27cf5ec5")]
        public PropertyTypes.FileInfo TopPicture {
        get { return DataProvider.GetFileInfo(_topPictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _videoGuid = new Guid("b23039b2-acf9-4d29-9860-987e34993ab2");
        [PropertyGuid("b23039b2-acf9-4d29-9860-987e34993ab2")]
        public PropertyTypes.FileInfo Video {
        get { return DataProvider.GetFileInfo(_videoGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _aboutSiteGuid = new Guid("a8ee34ba-f5c5-41ff-9935-2a7a7a005e66");
        [PropertyGuid("a8ee34ba-f5c5-41ff-9935-2a7a7a005e66")]
        public string AboutSite {
        get { return (string)DataProvider.GetPropertyValue(_aboutSiteGuid); }
        set { DataProvider.SetPropertyValue(_aboutSiteGuid, value); }
        }
      
        static Guid _filesGuid = new Guid("58e091c0-66ce-431b-8551-dade8c9f4445");
        [PropertyGuid("58e091c0-66ce-431b-8551-dade8c9f4445")]
        public System.Collections.Generic.List<WAF.API.Native.InnerFile> Files {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_filesGuid)).Cast<WAF.API.Native.InnerFile>().ToList();}
        set {DataProvider.SetPropertyValue(_filesGuid, value);}
        }
      
        static Guid _selectedArticlesGuid = new Guid("9033c8b1-4e64-4030-a441-b877f98cc126");
        [PropertyGuid("9033c8b1-4e64-4030-a441-b877f98cc126")]
        public IQueryable<WAF.API.Native.HierarchicalContent> SelectedArticles {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_selectedArticlesGuid)).Cast<WAF.API.Native.HierarchicalContent>();}
        set {DataProvider.SetPropertyValue(_selectedArticlesGuid, value);}
        }
      
        static Guid _introductionTextGuid = new Guid("aa18f0bc-b10f-46c8-a2bd-03e05d489c99");
        [PropertyGuid("aa18f0bc-b10f-46c8-a2bd-03e05d489c99")]
        public string IntroductionText {
        get { return (string)DataProvider.GetPropertyValue(_introductionTextGuid); }
        set { DataProvider.SetPropertyValue(_introductionTextGuid, value); }
        }
      
        static Guid _randomTopPicturesGuid = new Guid("80325560-9be1-40c1-885e-0f8cc13a69d9");
        [PropertyGuid("80325560-9be1-40c1-885e-0f8cc13a69d9")]
        public System.Collections.Generic.List<WAF.API.Native.InnerFile> RandomTopPictures {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_randomTopPicturesGuid)).Cast<WAF.API.Native.InnerFile>().ToList();}
        set {DataProvider.SetPropertyValue(_randomTopPicturesGuid, value);}
        }
      
        static Guid _mapLinksGuid = new Guid("224e55ea-7796-4a37-951e-b8dfc68bf117");
        [PropertyGuid("224e55ea-7796-4a37-951e-b8dfc68bf117")]
        public System.Collections.Generic.List<WAF.API.TripsToNorwayDemo.ImageMapLink> MapLinks {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_mapLinksGuid)).Cast<WAF.API.TripsToNorwayDemo.ImageMapLink>().ToList();}
        set {DataProvider.SetPropertyValue(_mapLinksGuid, value);}
        }
      
        static Guid _selectedAttractionsGuid = new Guid("a7572ca7-f805-4635-9361-6b96402a0937");
        [PropertyGuid("a7572ca7-f805-4635-9361-6b96402a0937")]
        public IQueryable<WAF.API.TripsToNorwayDemo.TouristAttraction> SelectedAttractions {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_selectedAttractionsGuid)).Cast<WAF.API.TripsToNorwayDemo.TouristAttraction>();}
        set {DataProvider.SetPropertyValue(_selectedAttractionsGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("0f78c913-4995-4454-aedd-1c4e31ef09a5")]
public class TouristItemCategory : WAF.API.Native.HierarchicalContent {
public TouristItemCategory(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _contentGuid = new Guid("a8288a02-6ac5-4c97-94c1-9fee40b65cfc");
        [PropertyGuid("a8288a02-6ac5-4c97-94c1-9fee40b65cfc")]
        public string Content {
        get { return (string)DataProvider.GetPropertyValue(_contentGuid); }
        set { DataProvider.SetPropertyValue(_contentGuid, value); }
        }
      
        static Guid _filesGuid = new Guid("4a71b140-b665-4b69-b363-a6fa144ff43c");
        [PropertyGuid("4a71b140-b665-4b69-b363-a6fa144ff43c")]
        public System.Collections.Generic.List<WAF.API.Native.InnerFile> Files {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_filesGuid)).Cast<WAF.API.Native.InnerFile>().ToList();}
        set {DataProvider.SetPropertyValue(_filesGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("302b41a1-047a-4d11-a01b-266564ce2a98")]
public class ActivityCategory : WAF.API.TripsToNorwayDemo.TouristItemCategory {
public ActivityCategory(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _activitiesInThisCategoryGuid = new Guid("2378fcce-aef8-42d4-a09d-c9f922dc6c2b");
        [PropertyGuid("2378fcce-aef8-42d4-a09d-c9f922dc6c2b")]
        public IQueryable<WAF.API.TripsToNorwayDemo.TouristActivity>
        ActivitiesInThisCategory {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_activitiesInThisCategoryGuid)).Cast<WAF.API.TripsToNorwayDemo.TouristActivity>();}
        set {DataProvider.SetPropertyValue(_activitiesInThisCategoryGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("954809b1-6511-46a2-94e1-0ef843ac33e6")]
public class AccommodationCategory : WAF.API.TripsToNorwayDemo.TouristItemCategory {
public AccommodationCategory(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _accommodationsInThisCategoryGuid = new Guid("a3f70e0f-bd7e-42d6-8ead-a965f5583ae4");
        [PropertyGuid("a3f70e0f-bd7e-42d6-8ead-a965f5583ae4")]
        public IQueryable<WAF.API.TripsToNorwayDemo.Accommodation>
        AccommodationsInThisCategory {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_accommodationsInThisCategoryGuid)).Cast<WAF.API.TripsToNorwayDemo.Accommodation>();}
        set {DataProvider.SetPropertyValue(_accommodationsInThisCategoryGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("9a60f0c1-f8eb-461c-80b4-bd34784d2936")]
public class AttractionCategory : WAF.API.TripsToNorwayDemo.TouristItemCategory {
public AttractionCategory(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _attractionsInThisCategoryGuid = new Guid("0c77b6f4-e6f8-4b2d-bb5d-efbcdf359e9d");
        [PropertyGuid("0c77b6f4-e6f8-4b2d-bb5d-efbcdf359e9d")]
        public IQueryable<WAF.API.TripsToNorwayDemo.TouristAttraction>
        AttractionsInThisCategory {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_attractionsInThisCategoryGuid)).Cast<WAF.API.TripsToNorwayDemo.TouristAttraction>();}
        set {DataProvider.SetPropertyValue(_attractionsInThisCategoryGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("b2f0d39f-df0f-4830-bff8-26b72745c61b")]
public class ShoppingCategory : WAF.API.TripsToNorwayDemo.TouristItemCategory {
public ShoppingCategory(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _shoppingInThisCategoryGuid = new Guid("4272bc7d-327f-439c-b2c2-76b0a699d5c4");
        [PropertyGuid("4272bc7d-327f-439c-b2c2-76b0a699d5c4")]
        public IQueryable<WAF.API.TripsToNorwayDemo.Shopping>
        ShoppingInThisCategory {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_shoppingInThisCategoryGuid)).Cast<WAF.API.TripsToNorwayDemo.Shopping>();}
        set {DataProvider.SetPropertyValue(_shoppingInThisCategoryGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("e2009466-cf26-4ac8-8fa1-b11ccb1a2fab")]
public class FoodAndDrinkCategory : WAF.API.TripsToNorwayDemo.TouristItemCategory {
public FoodAndDrinkCategory(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _placesToEatAndDrinkInThisCategoryGuid = new Guid("8c0fe2bf-5d65-462e-8eff-c17bdd75c56a");
        [PropertyGuid("8c0fe2bf-5d65-462e-8eff-c17bdd75c56a")]
        public IQueryable<WAF.API.TripsToNorwayDemo.PlaceToEatOrDrink>
        PlacesToEatAndDrinkInThisCategory {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_placesToEatAndDrinkInThisCategoryGuid)).Cast<WAF.API.TripsToNorwayDemo.PlaceToEatOrDrink>();}
        set {DataProvider.SetPropertyValue(_placesToEatAndDrinkInThisCategoryGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("ef2895c7-d807-47b9-a4b7-ed7ef1f7c320")]
public class ImageMapLink : WAF.API.Native.InnerContentBase {
public ImageMapLink(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _pointX1Guid = new Guid("4dd8a745-10e8-404f-a4e4-a0f33432ea22");
        [PropertyGuid("4dd8a745-10e8-404f-a4e4-a0f33432ea22")]
        public int PointX1 {
        get { return (int)DataProvider.GetPropertyValue(_pointX1Guid); }
        set { DataProvider.SetPropertyValue(_pointX1Guid, value); }
        }
      
        static Guid _pointY1Guid = new Guid("df4e8640-4ba0-49c5-9b27-3a8d2af831ab");
        [PropertyGuid("df4e8640-4ba0-49c5-9b27-3a8d2af831ab")]
        public int PointY1 {
        get { return (int)DataProvider.GetPropertyValue(_pointY1Guid); }
        set { DataProvider.SetPropertyValue(_pointY1Guid, value); }
        }
      
        static Guid _pointX2Guid = new Guid("d21bf7b9-d4bc-468f-a247-860cc5f98163");
        [PropertyGuid("d21bf7b9-d4bc-468f-a247-860cc5f98163")]
        public int PointX2 {
        get { return (int)DataProvider.GetPropertyValue(_pointX2Guid); }
        set { DataProvider.SetPropertyValue(_pointX2Guid, value); }
        }
      
        static Guid _pointY2Guid = new Guid("ed2a1aaa-9514-4859-ac6c-07de0e60bda8");
        [PropertyGuid("ed2a1aaa-9514-4859-ac6c-07de0e60bda8")]
        public int PointY2 {
        get { return (int)DataProvider.GetPropertyValue(_pointY2Guid); }
        set { DataProvider.SetPropertyValue(_pointY2Guid, value); }
        }
      
        static Guid _urlGuid = new Guid("92b16d97-f3c5-473b-a7c6-838d34ab4689");
        [PropertyGuid("92b16d97-f3c5-473b-a7c6-838d34ab4689")]
        public string Url {
        get { return (string)DataProvider.GetPropertyValue(_urlGuid); }
        set { DataProvider.SetPropertyValue(_urlGuid, value); }
        }
      
        static Guid _tooltipGuid = new Guid("640ec0c9-2bc8-4768-9a7a-fac2ab34845a");
        [PropertyGuid("640ec0c9-2bc8-4768-9a7a-fac2ab34845a")]
        public string Tooltip {
        get { return (string)DataProvider.GetPropertyValue(_tooltipGuid); }
        set { DataProvider.SetPropertyValue(_tooltipGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("7e0536e3-77bd-4c88-8055-2c63a834ee20")]
public class ImageGallery : WAF.API.Native.HierarchicalContent {
public ImageGallery(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _picturesGuid = new Guid("124621c4-4618-4101-a659-78eaec3af7e1");
        [PropertyGuid("124621c4-4618-4101-a659-78eaec3af7e1")]
        public System.Collections.Generic.List<WAF.API.TripsToNorwayDemo.GalleryImage> Pictures {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_picturesGuid)).Cast<WAF.API.TripsToNorwayDemo.GalleryImage>().ToList();}
        set {DataProvider.SetPropertyValue(_picturesGuid, value);}
        }
      
        static Guid _displayedOnGuid = new Guid("a700ab67-4657-4bd5-914c-feadce96f98f");
        [PropertyGuid("a700ab67-4657-4bd5-914c-feadce96f98f")]
        public IQueryable<WAF.API.TripsToNorwayDemo.ImageGallery> DisplayedOn {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_displayedOnGuid)).Cast<WAF.API.TripsToNorwayDemo.ImageGallery>();}
        set {DataProvider.SetPropertyValue(_displayedOnGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("72ada119-73b9-426b-8048-68ee476e0a7a")]
public class GalleryImage : WAF.API.Native.InnerFile {
public GalleryImage(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _captionGuid = new Guid("a7ab4caa-2eea-4560-bfa7-41e10206b360");
        [PropertyGuid("a7ab4caa-2eea-4560-bfa7-41e10206b360")]
        public string Caption {
        get { return (string)DataProvider.GetPropertyValue(_captionGuid); }
        set { DataProvider.SetPropertyValue(_captionGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("4d5db0ef-81d6-49c6-8ba5-0fb4ca462fd5")]
public class NewsList : WAF.API.TripsToNorwayDemo.SimpleArticle {
public NewsList(IContentDataProvider dataProvider)
: base(dataProvider) {}
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("d82633c9-b617-4a40-a7f6-41c461aa3656")]
public class NewsArticle : WAF.API.TripsToNorwayDemo.SimpleArticle {
public NewsArticle(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _relatedGalleryGuid = new Guid("f5938017-8f4e-4082-a10d-afd56e6747c0");
        [PropertyGuid("f5938017-8f4e-4082-a10d-afd56e6747c0")]
        public WAF.API.TripsToNorwayDemo.ImageGallery RelatedGallery{
        get { return DataProvider.GetPropertyValue(_relatedGalleryGuid) as WAF.API.TripsToNorwayDemo.ImageGallery;}
        set { DataProvider.SetPropertyValue(_relatedGalleryGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("35cab70a-9b1c-4b55-b2e1-6395fe17621f")]
public class ItemReview : WAF.API.Native.HierarchicalContent {
public ItemReview(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _reviewBodyGuid = new Guid("46beebd7-a172-4680-8f6f-a6454ad4ba77");
        [PropertyGuid("46beebd7-a172-4680-8f6f-a6454ad4ba77")]
        public string ReviewBody {
        get { return (string)DataProvider.GetPropertyValue(_reviewBodyGuid); }
        set { DataProvider.SetPropertyValue(_reviewBodyGuid, value); }
        }
      
        static Guid _ratingValueGuid = new Guid("ee12031c-5a89-4207-a007-05f693cdb291");
        [PropertyGuid("ee12031c-5a89-4207-a007-05f693cdb291")]
        public int RatingValue {
        get { return (int)DataProvider.GetPropertyValue(_ratingValueGuid); }
        set { DataProvider.SetPropertyValue(_ratingValueGuid, value); }
        }
      
        static Guid _reviewedByUserGuid = new Guid("ab2e5766-879f-46d1-a778-11627395fe9b");
        [PropertyGuid("ab2e5766-879f-46d1-a778-11627395fe9b")]
        public WAF.API.Native.SystemUser ReviewedByUser{
        get { return DataProvider.GetPropertyValue(_reviewedByUserGuid) as WAF.API.Native.SystemUser;}
        set { DataProvider.SetPropertyValue(_reviewedByUserGuid, value);}
        }
      
        static Guid _dateAddedGuid = new Guid("92e51bb0-5415-498d-bc26-23c2d4ce3593");
        [PropertyGuid("92e51bb0-5415-498d-bc26-23c2d4ce3593")]
        public DateTime DateAdded {
        get { return (DateTime)DataProvider.GetPropertyValue(_dateAddedGuid); }
        set { DataProvider.SetPropertyValue(_dateAddedGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("a9d3c43e-f56d-422e-b005-2f1a4303a7a4")]
public class RegisteredUser : WAF.API.Native.SystemUser {
public RegisteredUser(IContentDataProvider dataProvider)
: base(dataProvider) {}
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("b7801407-f6ac-4421-9028-2981b8139d02")]
public class Recipe : WAF.API.Native.HierarchicalContent {
public Recipe(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _cookingTimeGuid = new Guid("5868ab15-e732-4102-99d4-bc3e2d86a88f");
        [PropertyGuid("5868ab15-e732-4102-99d4-bc3e2d86a88f")]
        public int CookingTime {
        get { return (int)DataProvider.GetPropertyValue(_cookingTimeGuid); }
        set { DataProvider.SetPropertyValue(_cookingTimeGuid, value); }
        }
      
        static Guid _cookingMethodGuid = new Guid("a98fab78-34a2-4af2-a186-0c33864e4662");
        [PropertyGuid("a98fab78-34a2-4af2-a186-0c33864e4662")]
        public string CookingMethod {
        get { return (string)DataProvider.GetPropertyValue(_cookingMethodGuid); }
        set { DataProvider.SetPropertyValue(_cookingMethodGuid, value); }
        }
      
        static Guid _shortDescriptionGuid = new Guid("5e68a1c2-868e-479b-af05-1013aeb32762");
        [PropertyGuid("5e68a1c2-868e-479b-af05-1013aeb32762")]
        public string ShortDescription {
        get { return (string)DataProvider.GetPropertyValue(_shortDescriptionGuid); }
        set { DataProvider.SetPropertyValue(_shortDescriptionGuid, value); }
        }
      
        static Guid _prepTimeGuid = new Guid("20091c3a-34a1-4a6a-a9b5-b1c549d841d9");
        [PropertyGuid("20091c3a-34a1-4a6a-a9b5-b1c549d841d9")]
        public int PrepTime {
        get { return (int)DataProvider.GetPropertyValue(_prepTimeGuid); }
        set { DataProvider.SetPropertyValue(_prepTimeGuid, value); }
        }
      
        static Guid _pictureGuid = new Guid("eba120df-6d7d-4d5d-ac3d-69a7253f6ea9");
        [PropertyGuid("eba120df-6d7d-4d5d-ac3d-69a7253f6ea9")]
        public PropertyTypes.FileInfo Picture {
        get { return DataProvider.GetFileInfo(_pictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _reviewsGuid = new Guid("17bd7cfc-c133-4496-ae5c-40432d6ab39b");
        [PropertyGuid("17bd7cfc-c133-4496-ae5c-40432d6ab39b")]
        public IQueryable<WAF.API.TripsToNorwayDemo.ItemReview> Reviews {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_reviewsGuid)).Cast<WAF.API.TripsToNorwayDemo.ItemReview>();}
        set {DataProvider.SetPropertyValue(_reviewsGuid, value);}
        }
      
        static Guid _recipeIngredientsGuid = new Guid("7e56a843-0062-4769-9082-c004e24766f0");
        [PropertyGuid("7e56a843-0062-4769-9082-c004e24766f0")]
        public System.Collections.Generic.List<WAF.API.TripsToNorwayDemo.ParagraphShortText> RecipeIngredients {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_recipeIngredientsGuid)).Cast<WAF.API.TripsToNorwayDemo.ParagraphShortText>().ToList();}
        set {DataProvider.SetPropertyValue(_recipeIngredientsGuid, value);}
        }
      
        static Guid _instructionsGuid = new Guid("31f86ec5-f09b-4376-bd0a-340e8ddc3a5f");
        [PropertyGuid("31f86ec5-f09b-4376-bd0a-340e8ddc3a5f")]
        public string Instructions {
        get { return (string)DataProvider.GetPropertyValue(_instructionsGuid); }
        set { DataProvider.SetPropertyValue(_instructionsGuid, value); }
        }
      
        static Guid _contentFatGuid = new Guid("742b5d7d-5aaa-4d4e-897b-e65d8d645fa3");
        [PropertyGuid("742b5d7d-5aaa-4d4e-897b-e65d8d645fa3")]
        public string ContentFat {
        get { return (string)DataProvider.GetPropertyValue(_contentFatGuid); }
        set { DataProvider.SetPropertyValue(_contentFatGuid, value); }
        }
      
        static Guid _contentCaloriesGuid = new Guid("22ea0db9-bca6-48b5-bb75-308e2c20b1df");
        [PropertyGuid("22ea0db9-bca6-48b5-bb75-308e2c20b1df")]
        public string ContentCalories {
        get { return (string)DataProvider.GetPropertyValue(_contentCaloriesGuid); }
        set { DataProvider.SetPropertyValue(_contentCaloriesGuid, value); }
        }
      
        static Guid _contentFiberGuid = new Guid("3928bb21-def6-4054-8884-0456fae70e42");
        [PropertyGuid("3928bb21-def6-4054-8884-0456fae70e42")]
        public string ContentFiber {
        get { return (string)DataProvider.GetPropertyValue(_contentFiberGuid); }
        set { DataProvider.SetPropertyValue(_contentFiberGuid, value); }
        }
      
        static Guid _contentProteinGuid = new Guid("53883b60-c85f-4a4e-b954-decd582655a3");
        [PropertyGuid("53883b60-c85f-4a4e-b954-decd582655a3")]
        public string ContentProtein {
        get { return (string)DataProvider.GetPropertyValue(_contentProteinGuid); }
        set { DataProvider.SetPropertyValue(_contentProteinGuid, value); }
        }
      
        static Guid _contentCarbsGuid = new Guid("4cc7d7cb-8e4c-4f96-b8d9-e030390bdc89");
        [PropertyGuid("4cc7d7cb-8e4c-4f96-b8d9-e030390bdc89")]
        public string ContentCarbs {
        get { return (string)DataProvider.GetPropertyValue(_contentCarbsGuid); }
        set { DataProvider.SetPropertyValue(_contentCarbsGuid, value); }
        }
      
        static Guid _recipeYieldGuid = new Guid("98209a1b-faed-4f0e-901c-6700d7d39bc3");
        [PropertyGuid("98209a1b-faed-4f0e-901c-6700d7d39bc3")]
        public string RecipeYield {
        get { return (string)DataProvider.GetPropertyValue(_recipeYieldGuid); }
        set { DataProvider.SetPropertyValue(_recipeYieldGuid, value); }
        }
      
        static Guid _recipeCategoryGuid = new Guid("61506720-e488-4420-ac22-6662fd2ca0a7");
        [PropertyGuid("61506720-e488-4420-ac22-6662fd2ca0a7")]
        public string RecipeCategory {
        get { return (string)DataProvider.GetPropertyValue(_recipeCategoryGuid); }
        set { DataProvider.SetPropertyValue(_recipeCategoryGuid, value); }
        }
      
        static Guid _historyGuid = new Guid("a95da0f0-c56f-4ec3-80ed-1c845e00758f");
        [PropertyGuid("a95da0f0-c56f-4ec3-80ed-1c845e00758f")]
        public string History {
        get { return (string)DataProvider.GetPropertyValue(_historyGuid); }
        set { DataProvider.SetPropertyValue(_historyGuid, value); }
        }
      
        static Guid _relatedRegionsGuid = new Guid("3dfb87c5-c525-47d9-b6e6-4990a0f421c4");
        [PropertyGuid("3dfb87c5-c525-47d9-b6e6-4990a0f421c4")]
        public IQueryable<WAF.API.TripsToNorwayDemo.Region> RelatedRegions {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_relatedRegionsGuid)).Cast<WAF.API.TripsToNorwayDemo.Region>();}
        set {DataProvider.SetPropertyValue(_relatedRegionsGuid, value);}
        }
      
        static Guid _imageCopyrightGuid = new Guid("137e5551-15ab-4277-b223-53f129a22ea7");
        [PropertyGuid("137e5551-15ab-4277-b223-53f129a22ea7")]
        public string ImageCopyright {
        get { return (string)DataProvider.GetPropertyValue(_imageCopyrightGuid); }
        set { DataProvider.SetPropertyValue(_imageCopyrightGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("c1d15d5e-e60c-4e70-a6d8-fb6f370e2c73")]
public class ParagraphShortText : WAF.API.Native.InnerContentBase {
public ParagraphShortText(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _shortTextGuid = new Guid("33cfebf3-3a1b-4ebd-bbbd-57ca18246147");
        [PropertyGuid("33cfebf3-3a1b-4ebd-bbbd-57ca18246147")]
        public string ShortText {
        get { return (string)DataProvider.GetPropertyValue(_shortTextGuid); }
        set { DataProvider.SetPropertyValue(_shortTextGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("ce6ee110-eac5-49e9-a637-50ea86e01e8e")]
public class VacantPosition : WAF.API.Native.HierarchicalContent {
public VacantPosition(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _salaryGuid = new Guid("859db19e-aac0-4115-804d-03315ae3fb08");
        [PropertyGuid("859db19e-aac0-4115-804d-03315ae3fb08")]
        public int Salary {
        get { return (int)DataProvider.GetPropertyValue(_salaryGuid); }
        set { DataProvider.SetPropertyValue(_salaryGuid, value); }
        }
      
        static Guid _salaryCurrencyGuid = new Guid("01c2f068-7da5-4c22-a8bc-ea5114570691");
        [PropertyGuid("01c2f068-7da5-4c22-a8bc-ea5114570691")]
        public string SalaryCurrency {
        get { return (string)DataProvider.GetPropertyValue(_salaryCurrencyGuid); }
        set { DataProvider.SetPropertyValue(_salaryCurrencyGuid, value); }
        }
      
        static Guid _responsibilitiesGuid = new Guid("0904ede9-5fa2-4cf9-b18f-1a9df65ca41a");
        [PropertyGuid("0904ede9-5fa2-4cf9-b18f-1a9df65ca41a")]
        public string Responsibilities {
        get { return (string)DataProvider.GetPropertyValue(_responsibilitiesGuid); }
        set { DataProvider.SetPropertyValue(_responsibilitiesGuid, value); }
        }
      
        static Guid _employmentTypeGuid = new Guid("7a27533e-895a-4eef-88b6-2309d0685625");
        [PropertyGuid("7a27533e-895a-4eef-88b6-2309d0685625")]
        public string EmploymentType {
        get { return (string)DataProvider.GetPropertyValue(_employmentTypeGuid); }
        set { DataProvider.SetPropertyValue(_employmentTypeGuid, value); }
        }
      
        static Guid _workHoursGuid = new Guid("4c294867-fb94-4f32-9c4d-36d716d9ffd9");
        [PropertyGuid("4c294867-fb94-4f32-9c4d-36d716d9ffd9")]
        public string WorkHours {
        get { return (string)DataProvider.GetPropertyValue(_workHoursGuid); }
        set { DataProvider.SetPropertyValue(_workHoursGuid, value); }
        }
      
        static Guid _industryGuid = new Guid("e6242ba5-8f56-467f-98d2-05223d96d99e");
        [PropertyGuid("e6242ba5-8f56-467f-98d2-05223d96d99e")]
        public string Industry {
        get { return (string)DataProvider.GetPropertyValue(_industryGuid); }
        set { DataProvider.SetPropertyValue(_industryGuid, value); }
        }
      
        static Guid _descriptionGuid = new Guid("ce07abde-e367-49cd-b9a7-1aede976adb9");
        [PropertyGuid("ce07abde-e367-49cd-b9a7-1aede976adb9")]
        public string Description {
        get { return (string)DataProvider.GetPropertyValue(_descriptionGuid); }
        set { DataProvider.SetPropertyValue(_descriptionGuid, value); }
        }
      
        static Guid _skillsGuid = new Guid("302f8ec1-7228-4091-b8d1-23e386486456");
        [PropertyGuid("302f8ec1-7228-4091-b8d1-23e386486456")]
        public string Skills {
        get { return (string)DataProvider.GetPropertyValue(_skillsGuid); }
        set { DataProvider.SetPropertyValue(_skillsGuid, value); }
        }
      
        static Guid _qualificationsGuid = new Guid("6a4cd1a0-2fb5-4c98-8b47-c641a389cb0e");
        [PropertyGuid("6a4cd1a0-2fb5-4c98-8b47-c641a389cb0e")]
        public string Qualifications {
        get { return (string)DataProvider.GetPropertyValue(_qualificationsGuid); }
        set { DataProvider.SetPropertyValue(_qualificationsGuid, value); }
        }
      
        static Guid _benefitsGuid = new Guid("9a19f30c-c055-45c4-b913-31158a176bfa");
        [PropertyGuid("9a19f30c-c055-45c4-b913-31158a176bfa")]
        public string Benefits {
        get { return (string)DataProvider.GetPropertyValue(_benefitsGuid); }
        set { DataProvider.SetPropertyValue(_benefitsGuid, value); }
        }
      
        static Guid _datePostedGuid = new Guid("162d585f-dadf-4825-9c43-3d26c9e27138");
        [PropertyGuid("162d585f-dadf-4825-9c43-3d26c9e27138")]
        public DateTime DatePosted {
        get { return (DateTime)DataProvider.GetPropertyValue(_datePostedGuid); }
        set { DataProvider.SetPropertyValue(_datePostedGuid, value); }
        }
      
        static Guid _hiringOrganizationGuid = new Guid("92744ad4-7e77-46a0-bca4-bfa931d83019");
        [PropertyGuid("92744ad4-7e77-46a0-bca4-bfa931d83019")]
        public string HiringOrganization {
        get { return (string)DataProvider.GetPropertyValue(_hiringOrganizationGuid); }
        set { DataProvider.SetPropertyValue(_hiringOrganizationGuid, value); }
        }
      
        static Guid _jobLocationGuid = new Guid("1e8c1223-2d8c-4bda-99ec-0d6f205b87a5");
        [PropertyGuid("1e8c1223-2d8c-4bda-99ec-0d6f205b87a5")]
        public string JobLocation {
        get { return (string)DataProvider.GetPropertyValue(_jobLocationGuid); }
        set { DataProvider.SetPropertyValue(_jobLocationGuid, value); }
        }
      
        static Guid _occupationalCategoryGuid = new Guid("e1b1c5a9-3ef2-4de4-aa31-f732279dee4e");
        [PropertyGuid("e1b1c5a9-3ef2-4de4-aa31-f732279dee4e")]
        public string OccupationalCategory {
        get { return (string)DataProvider.GetPropertyValue(_occupationalCategoryGuid); }
        set { DataProvider.SetPropertyValue(_occupationalCategoryGuid, value); }
        }
      
        static Guid _additionalInfoGuid = new Guid("63455570-9d11-4083-abac-2708704872c6");
        [PropertyGuid("63455570-9d11-4083-abac-2708704872c6")]
        public string AdditionalInfo {
        get { return (string)DataProvider.GetPropertyValue(_additionalInfoGuid); }
        set { DataProvider.SetPropertyValue(_additionalInfoGuid, value); }
        }
      
        static Guid _educationRequirementsGuid = new Guid("76f32b1a-29c8-409b-839e-3fa6b40c94cd");
        [PropertyGuid("76f32b1a-29c8-409b-839e-3fa6b40c94cd")]
        public string EducationRequirements {
        get { return (string)DataProvider.GetPropertyValue(_educationRequirementsGuid); }
        set { DataProvider.SetPropertyValue(_educationRequirementsGuid, value); }
        }
      
        static Guid _experienceRequirementsGuid = new Guid("ffa5564b-d1ea-48fe-9155-8ef2a7b2899f");
        [PropertyGuid("ffa5564b-d1ea-48fe-9155-8ef2a7b2899f")]
        public string ExperienceRequirements {
        get { return (string)DataProvider.GetPropertyValue(_experienceRequirementsGuid); }
        set { DataProvider.SetPropertyValue(_experienceRequirementsGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("b3d34856-0f44-4e9b-a444-39a2fab3e3da")]
public class BookProduct : WAF.API.Native.ProductBase {
public BookProduct(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _numberOfPagesGuid = new Guid("0691f986-58a0-43ae-be65-1c49cc0e45d8");
        [PropertyGuid("0691f986-58a0-43ae-be65-1c49cc0e45d8")]
        public int NumberOfPages {
        get { return (int)DataProvider.GetPropertyValue(_numberOfPagesGuid); }
        set { DataProvider.SetPropertyValue(_numberOfPagesGuid, value); }
        }
      
        static Guid _writtenByGuid = new Guid("204e6c4d-8c9b-42fb-8635-f1d41a557eb7");
        [PropertyGuid("204e6c4d-8c9b-42fb-8635-f1d41a557eb7")]
        public string WrittenBy {
        get { return (string)DataProvider.GetPropertyValue(_writtenByGuid); }
        set { DataProvider.SetPropertyValue(_writtenByGuid, value); }
        }
      
        static Guid _languageGuid = new Guid("f6e031f1-3dd6-458e-bc88-41f299a8cb49");
        [PropertyGuid("f6e031f1-3dd6-458e-bc88-41f299a8cb49")]
        public string Language {
        get { return (string)DataProvider.GetPropertyValue(_languageGuid); }
        set { DataProvider.SetPropertyValue(_languageGuid, value); }
        }
      
        static Guid _publisherGuid = new Guid("ce5d692e-ed2a-4260-b317-f92fd62d35cc");
        [PropertyGuid("ce5d692e-ed2a-4260-b317-f92fd62d35cc")]
        public string Publisher {
        get { return (string)DataProvider.GetPropertyValue(_publisherGuid); }
        set { DataProvider.SetPropertyValue(_publisherGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("2b34cc81-0b0e-4e8a-8e5a-fbea6e3c0389")]
public class DemoShop : WAF.API.Native.Shop {
public DemoShop(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _ingressGuid = new Guid("8745fbbd-51fb-4983-a34f-0b8c78ff2369");
        [PropertyGuid("8745fbbd-51fb-4983-a34f-0b8c78ff2369")]
        public string Ingress {
        get { return (string)DataProvider.GetPropertyValue(_ingressGuid); }
        set { DataProvider.SetPropertyValue(_ingressGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("fa99ed15-2d17-47ce-8289-bb0372694fb1")]
public class ControlPanel : WAF.API.Native.HierarchicalContent {
public ControlPanel(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _loginPageGuid = new Guid("ca389206-f116-4a78-84d1-a862d7e6faff");
        [PropertyGuid("ca389206-f116-4a78-84d1-a862d7e6faff")]
        public WAF.API.TripsToNorwayDemo.SimpleArticle LoginPage{
        get { return DataProvider.GetPropertyValue(_loginPageGuid) as WAF.API.TripsToNorwayDemo.SimpleArticle;}
        set { DataProvider.SetPropertyValue(_loginPageGuid, value);}
        }
      
        static Guid _searchPageGuid = new Guid("741bd31c-42fd-4b95-8650-deb60daedac0");
        [PropertyGuid("741bd31c-42fd-4b95-8650-deb60daedac0")]
        public WAF.API.TripsToNorwayDemo.SimpleArticle SearchPage{
        get { return DataProvider.GetPropertyValue(_searchPageGuid) as WAF.API.TripsToNorwayDemo.SimpleArticle;}
        set { DataProvider.SetPropertyValue(_searchPageGuid, value);}
        }
      
        static Guid _vacantPositionsFolderGuid = new Guid("59fe8b64-54e8-43ee-a289-b4502e99d25a");
        [PropertyGuid("59fe8b64-54e8-43ee-a289-b4502e99d25a")]
        public WAF.API.Native.HierarchicalFolder VacantPositionsFolder{
        get { return DataProvider.GetPropertyValue(_vacantPositionsFolderGuid) as WAF.API.Native.HierarchicalFolder;}
        set { DataProvider.SetPropertyValue(_vacantPositionsFolderGuid, value);}
        }
      
        static Guid _globalMenuFolderGuid = new Guid("7f4f6267-8d1c-4a05-a97a-5feed30db1c8");
        [PropertyGuid("7f4f6267-8d1c-4a05-a97a-5feed30db1c8")]
        public WAF.API.Native.HierarchicalFolder GlobalMenuFolder{
        get { return DataProvider.GetPropertyValue(_globalMenuFolderGuid) as WAF.API.Native.HierarchicalFolder;}
        set { DataProvider.SetPropertyValue(_globalMenuFolderGuid, value);}
        }
      
        static Guid _footerMenuFolderGuid = new Guid("dc688c25-9640-4c73-a15d-8c05130c2136");
        [PropertyGuid("dc688c25-9640-4c73-a15d-8c05130c2136")]
        public WAF.API.Native.HierarchicalFolder FooterMenuFolder{
        get { return DataProvider.GetPropertyValue(_footerMenuFolderGuid) as WAF.API.Native.HierarchicalFolder;}
        set { DataProvider.SetPropertyValue(_footerMenuFolderGuid, value);}
        }
      
        static Guid _lodgingsPageGuid = new Guid("689d8b21-f81b-469e-93df-cd2b6bb5ab04");
        [PropertyGuid("689d8b21-f81b-469e-93df-cd2b6bb5ab04")]
        public WAF.API.TripsToNorwayDemo.SimpleArticle LodgingsPage{
        get { return DataProvider.GetPropertyValue(_lodgingsPageGuid) as WAF.API.TripsToNorwayDemo.SimpleArticle;}
        set { DataProvider.SetPropertyValue(_lodgingsPageGuid, value);}
        }
      
        static Guid _regionsPageGuid = new Guid("f1ed6912-4708-4a7f-9028-5f14587abf05");
        [PropertyGuid("f1ed6912-4708-4a7f-9028-5f14587abf05")]
        public WAF.API.TripsToNorwayDemo.SimpleArticle RegionsPage{
        get { return DataProvider.GetPropertyValue(_regionsPageGuid) as WAF.API.TripsToNorwayDemo.SimpleArticle;}
        set { DataProvider.SetPropertyValue(_regionsPageGuid, value);}
        }
      
        static Guid _attractionsPageGuid = new Guid("e04ca38a-1f8f-4a5e-9e5e-58b8c9972712");
        [PropertyGuid("e04ca38a-1f8f-4a5e-9e5e-58b8c9972712")]
        public WAF.API.TripsToNorwayDemo.SimpleArticle AttractionsPage{
        get { return DataProvider.GetPropertyValue(_attractionsPageGuid) as WAF.API.TripsToNorwayDemo.SimpleArticle;}
        set { DataProvider.SetPropertyValue(_attractionsPageGuid, value);}
        }
      
        static Guid _activitiesPageGuid = new Guid("26771be1-0f2d-404b-9e96-d7c95cce7140");
        [PropertyGuid("26771be1-0f2d-404b-9e96-d7c95cce7140")]
        public WAF.API.TripsToNorwayDemo.SimpleArticle ActivitiesPage{
        get { return DataProvider.GetPropertyValue(_activitiesPageGuid) as WAF.API.TripsToNorwayDemo.SimpleArticle;}
        set { DataProvider.SetPropertyValue(_activitiesPageGuid, value);}
        }
      
        static Guid _recipesPageGuid = new Guid("59b258b0-9758-4c25-9fef-d8c1c84c39b8");
        [PropertyGuid("59b258b0-9758-4c25-9fef-d8c1c84c39b8")]
        public WAF.API.TripsToNorwayDemo.SimpleArticle RecipesPage{
        get { return DataProvider.GetPropertyValue(_recipesPageGuid) as WAF.API.TripsToNorwayDemo.SimpleArticle;}
        set { DataProvider.SetPropertyValue(_recipesPageGuid, value);}
        }
      
        static Guid _newsPageGuid = new Guid("f374d0ff-250f-4e28-95fd-c42e39fdca12");
        [PropertyGuid("f374d0ff-250f-4e28-95fd-c42e39fdca12")]
        public WAF.API.TripsToNorwayDemo.NewsList NewsPage{
        get { return DataProvider.GetPropertyValue(_newsPageGuid) as WAF.API.TripsToNorwayDemo.NewsList;}
        set { DataProvider.SetPropertyValue(_newsPageGuid, value);}
        }
      
        static Guid _siteColorGuid = new Guid("7ae17d4a-b70d-468d-b938-dc0eb3943f0a");
        [PropertyGuid("7ae17d4a-b70d-468d-b938-dc0eb3943f0a")]
        public string SiteColor {
        get { return (string)DataProvider.GetPropertyValue(_siteColorGuid); }
        set { DataProvider.SetPropertyValue(_siteColorGuid, value); }
        }
      
        static Guid _countryGuid = new Guid("cde977d1-7cdf-4283-82bb-56db2cd6e0c5");
        [PropertyGuid("cde977d1-7cdf-4283-82bb-56db2cd6e0c5")]
        public WAF.API.TripsToNorwayDemo.ExplorerCountry Country{
        get { return DataProvider.GetPropertyValue(_countryGuid) as WAF.API.TripsToNorwayDemo.ExplorerCountry;}
        set { DataProvider.SetPropertyValue(_countryGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("71f7c095-0830-46b5-ba12-cf3a0405182c")]
public class ModulesPage : WAF.API.Native.HierarchicalContent {
public ModulesPage(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _modulesGuid = new Guid("966d366d-0544-4450-ad12-a1501c5669a5");
        [PropertyGuid("966d366d-0544-4450-ad12-a1501c5669a5")]
        public IQueryable<WAF.API.TripsToNorwayDemo.ModuleBase> Modules {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_modulesGuid)).Cast<WAF.API.TripsToNorwayDemo.ModuleBase>();}
        set {DataProvider.SetPropertyValue(_modulesGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("9ee92472-8057-4e1a-aefc-f3fa8af9816c")]
public class ModuleBase : WAF.API.Native.HierarchicalContent {
public ModuleBase(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _modulePagesGuid = new Guid("42ffeba4-f3aa-468e-a3c0-cccdad0b10cf");
        [PropertyGuid("42ffeba4-f3aa-468e-a3c0-cccdad0b10cf")]
        public IQueryable<WAF.API.TripsToNorwayDemo.ModulesPage>
        ModulePages {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_modulePagesGuid)).Cast<WAF.API.TripsToNorwayDemo.ModulesPage>();}
        set {DataProvider.SetPropertyValue(_modulePagesGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("58abc525-8b69-4971-8951-075a1d5ea112")]
public class ModuleParagraph : WAF.API.TripsToNorwayDemo.ModuleBase {
public ModuleParagraph(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _paragraphTitleGuid = new Guid("0cdfd04f-7f8c-4b06-b8fd-5eb0746dbed9");
        [PropertyGuid("0cdfd04f-7f8c-4b06-b8fd-5eb0746dbed9")]
        public string ParagraphTitle {
        get { return (string)DataProvider.GetPropertyValue(_paragraphTitleGuid); }
        set { DataProvider.SetPropertyValue(_paragraphTitleGuid, value); }
        }
      
        static Guid _pictureGuid = new Guid("029334a4-39b0-49e3-9e22-4ed43ff24f73");
        [PropertyGuid("029334a4-39b0-49e3-9e22-4ed43ff24f73")]
        public PropertyTypes.FileInfo Picture {
        get { return DataProvider.GetFileInfo(_pictureGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _picturePositionGuid = new Guid("a764fde8-b87c-4240-b842-e9013b6e73ab");
        [PropertyGuid("a764fde8-b87c-4240-b842-e9013b6e73ab")]
        public string PicturePosition {
        get { return (string)DataProvider.GetPropertyValue(_picturePositionGuid); }
        set { DataProvider.SetPropertyValue(_picturePositionGuid, value); }
        }
      
        static Guid _contentGuid = new Guid("da8bc25c-0509-4c93-8cf8-fec56dc9404f");
        [PropertyGuid("da8bc25c-0509-4c93-8cf8-fec56dc9404f")]
        public string Content {
        get { return (string)DataProvider.GetPropertyValue(_contentGuid); }
        set { DataProvider.SetPropertyValue(_contentGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("5e3c6db8-c1cc-4a62-ab63-e454543443d9")]
public class ModulePictureSeries : WAF.API.TripsToNorwayDemo.ModuleBase {
public ModulePictureSeries(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _paragraphTitleGuid = new Guid("b5382f80-1be3-4aae-9270-96d19e204e7e");
        [PropertyGuid("b5382f80-1be3-4aae-9270-96d19e204e7e")]
        public string ParagraphTitle {
        get { return (string)DataProvider.GetPropertyValue(_paragraphTitleGuid); }
        set { DataProvider.SetPropertyValue(_paragraphTitleGuid, value); }
        }
      
        static Guid _picturesGuid = new Guid("c6eb90bb-8381-49d5-8217-46cab03b5328");
        [PropertyGuid("c6eb90bb-8381-49d5-8217-46cab03b5328")]
        public System.Collections.Generic.List<WAF.API.Native.InnerContentBase> Pictures {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_picturesGuid)).Cast<WAF.API.Native.InnerContentBase>().ToList();}
        set {DataProvider.SetPropertyValue(_picturesGuid, value);}
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("efa52560-d242-4468-9668-aab2ddc3de64")]
public class ModuleCallToAction : WAF.API.TripsToNorwayDemo.ModuleBase {
public ModuleCallToAction(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _buttonTextGuid = new Guid("8826dd45-8560-46d3-9ee1-ca81c25e3bc3");
        [PropertyGuid("8826dd45-8560-46d3-9ee1-ca81c25e3bc3")]
        public string ButtonText {
        get { return (string)DataProvider.GetPropertyValue(_buttonTextGuid); }
        set { DataProvider.SetPropertyValue(_buttonTextGuid, value); }
        }
      
        static Guid _callToActionLinkGuid = new Guid("7470cf11-0d67-42bd-83c5-6b414aec5d18");
        [PropertyGuid("7470cf11-0d67-42bd-83c5-6b414aec5d18")]
        public string CallToActionLink {
        get { return (string)DataProvider.GetPropertyValue(_callToActionLinkGuid); }
        set { DataProvider.SetPropertyValue(_callToActionLinkGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("2dd89f48-8c63-45d1-8f1a-393e99101af2")]
public class ModuleVideo : WAF.API.TripsToNorwayDemo.ModuleBase {
public ModuleVideo(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _videoFileGuid = new Guid("413ae8c0-3e20-4dbe-8b51-0d447e53e7a2");
        [PropertyGuid("413ae8c0-3e20-4dbe-8b51-0d447e53e7a2")]
        public PropertyTypes.FileInfo VideoFile {
        get { return DataProvider.GetFileInfo(_videoFileGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _videoEmbedCodeGuid = new Guid("e9303944-3141-4c9c-8514-88927ba8426f");
        [PropertyGuid("e9303944-3141-4c9c-8514-88927ba8426f")]
        public string VideoEmbedCode {
        get { return (string)DataProvider.GetPropertyValue(_videoEmbedCodeGuid); }
        set { DataProvider.SetPropertyValue(_videoEmbedCodeGuid, value); }
        }
      
}
}

namespace WAF.API.TripsToNorwayDemo {
[ClassGuid("a589a2ba-0466-4849-9f69-ea39a306c6d7")]
public class ModuleTouristItemsList : WAF.API.TripsToNorwayDemo.ModuleBase {
public ModuleTouristItemsList(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _headingGuid = new Guid("8546f0b2-f4a6-469e-b8cb-f41b1203670d");
        [PropertyGuid("8546f0b2-f4a6-469e-b8cb-f41b1203670d")]
        public string Heading {
        get { return (string)DataProvider.GetPropertyValue(_headingGuid); }
        set { DataProvider.SetPropertyValue(_headingGuid, value); }
        }
      
        static Guid _showHeadingGuid = new Guid("85751f72-b5f6-4bdb-83bf-e56c50806d6d");
        [PropertyGuid("85751f72-b5f6-4bdb-83bf-e56c50806d6d")]
        public bool ShowHeading {
        get { return (bool)DataProvider.GetPropertyValue(_showHeadingGuid); }
        set { DataProvider.SetPropertyValue(_showHeadingGuid, value); }
        }
      
        static Guid _touristItemsGuid = new Guid("d515dd9a-2add-401c-ac73-c7a01b039294");
        [PropertyGuid("d515dd9a-2add-401c-ac73-c7a01b039294")]
        public IQueryable<WAF.API.TripsToNorwayDemo.TouristItem>
        TouristItems {
        get {return ((IQueryable<WAF.API.IContent>)DataProvider.GetPropertyValue(_touristItemsGuid)).Cast<WAF.API.TripsToNorwayDemo.TouristItem>();}
        set {DataProvider.SetPropertyValue(_touristItemsGuid, value);}
        }
      
}
}



namespace WAF.API.GraphQL {
public class RelatudeContentQuery {
WAF.API.Web.WAFNativeContext _ctx;
public RelatudeContentQuery(WAF.API.Web.WAFNativeContext ctx) {
  _ctx = ctx;
}


[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BlogPage>> GetBlogPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BlogPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Blog>> GetBlogs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Blog>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BlogCategory>> GetBlogCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BlogCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BlogPost>> GetBlogPosts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BlogPost>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentFile>> GetContentFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DefCulture>> GetDefCultures() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DefCulture>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentSnapshot>> GetContentSnapshots() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentSnapshot>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DocumentFile>> GetDocumentFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DocumentFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Domain>> GetDomains() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Domain>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UrlStatus>> GetUrlStati() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UrlStatus>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Installation>> GetInstallatia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Installation>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentTag>> GetContentTags() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentTag>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TagVocabulary>> GetTagVocabularies() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TagVocabulary>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TagTerm>> GetTagTerms() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TagTerm>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileConversion>> GetFileConversia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileConversion>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileFolder>> GetFileFolders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileFolder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileLibrary>> GetFileLibraries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileLibrary>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Fileshare>> GetFileshares() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Fileshare>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileshareFile>> GetFileshareFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileshareFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileshareFolder>> GetFileshareFolders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileshareFolder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Forum>> GetForums() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Forum>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumCategory>> GetForumCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumGlobalSettings>> GetForumGlobalSettingses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumGlobalSettings>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumMessage>> GetForumMessages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumMessage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumRank>> GetForumRanks() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumRank>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumThread>> GetForumThreads() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumThread>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.GroupFileLibrary>> GetGroupFileLibraries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.GroupFileLibrary>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.HierarchicalContent>> GetHierarchicalContents() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.HierarchicalContent>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ImageFile>> GetImageFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ImageFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.LogSetting>> GetLogSettings() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.LogSetting>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Module>> GetModules() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Module>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Newsletter>> GetNewsletters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Newsletter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.NewsletterDelivery>> GetNewsletterDeliveries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.NewsletterDelivery>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.NewsletterRecipientList>> GetNewsletterRecipientLists() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.NewsletterRecipientList>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ScheduledTask>> GetScheduledTasks() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ScheduledTask>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Site>> GetSites() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Site>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SoundFile>> GetSoundFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SoundFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Stylesheet>> GetStylesheets() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Stylesheet>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SystemUser>> GetSystemUsers() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SystemUser>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Template>> GetTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Template>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.MVCTemplate>> GetMVCTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.MVCTemplate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UserGroup>> GetUserGroups() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UserGroup>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.VideoFile>> GetVideoFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.VideoFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.InteractiveFile>> GetInteractiveFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.InteractiveFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.HierarchicalFolder>> GetHierarchicalFolders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.HierarchicalFolder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SpecializedPage>> GetSpecializedPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SpecializedPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.RedirectPage>> GetRedirectPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.RedirectPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.MessageBase>> GetMessageBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.MessageBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SMS>> GetSMSs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SMS>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentQueryBase>> GetContentQueryBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentQueryBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentQuery>> GetContentQueries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentQuery>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.JoinQuery>> GetJoinQueries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.JoinQuery>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.QueryFilter>> GetQueryFilters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.QueryFilter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ArticleBase>> GetArticleBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ArticleBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.WebForm>> GetWebForms() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.WebForm>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.WebFormSubmit>> GetWebFormSubmits() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.WebFormSubmit>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductBase>> GetProductBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductCategory>> GetProductCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Shop>> GetShops() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Shop>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Review>> GetReviews() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Review>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Order>> GetOrders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Order>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.OrderItem>> GetOrderItems() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.OrderItem>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Currency>> GetCurrencies() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Currency>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Country>> GetCountries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Country>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Manufacturer>> GetManufacturers() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Manufacturer>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ShippingMethod>> GetShippingMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ShippingMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.PaymentMethod>> GetPaymentMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.PaymentMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DashboardBox>> GetDashboardBoxes() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DashboardBox>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ShopEmail>> GetShopEmails() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ShopEmail>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountBase>> GetDiscountBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UsedDiscount>> GetUsedDiscounts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UsedDiscount>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffProduct>> GetDiscountPercentageOffProducts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffProduct>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductImport>> GetProductImports() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductImport>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffProduct>> GetDiscountAmountOffProducts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffProduct>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffOrder>> GetDiscountAmountOffOrders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffOrder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffOrder>> GetDiscountPercentageOffOrders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffOrder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffShipping>> GetDiscountPercentageOffShippings() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffShipping>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffShipping>> GetDiscountAmountOffShippings() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffShipping>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffProductYWhenBuyingX>> GetDiscountAmountOffProductYWhenBuyingXs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffProductYWhenBuyingX>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffProductYWhenBuyingX>> GetDiscountPercentageOffProductYWhenBuyingXs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffProductYWhenBuyingX>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.CreditCardPaymentMethod>> GetCreditCardPaymentMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.CreditCardPaymentMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductBundle>> GetProductBundles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductBundle>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ItemCostShippingCalculationMethod>> GetItemCostShippingCalculationMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ItemCostShippingCalculationMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.PercentageShippingCalculationMethod>> GetPercentageShippingCalculationMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.PercentageShippingCalculationMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.AdaptiveNewsletter>> GetAdaptiveNewsletters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.AdaptiveNewsletter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.NewsletterTemplate>> GetNewsletterTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.NewsletterTemplate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BasicNewsletter>> GetBasicNewsletters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BasicNewsletter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.VisitorSegment>> GetVisitorSegments() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.VisitorSegment>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.StandardVisitorSegment>> GetStandardVisitorSegments() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.StandardVisitorSegment>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SegmentationSettings>> GetSegmentationSettingses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SegmentationSettings>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TaxClass>> GetTaxClasses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TaxClass>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TaxRate>> GetTaxRates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TaxRate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Chat>> GetChats() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Chat>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ChatAccount>> GetChatAccounts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ChatAccount>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.StorageProvider>> GetStorageProviders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.StorageProvider>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentCardTemplate>> GetContentCardTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentCardTemplate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UIMenuItem>> GetUIMenuItems() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UIMenuItem>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UIPlugIn>> GetUIPlugIns() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UIPlugIn>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.OptimizingModule>> GetOptimizingModules() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.OptimizingModule>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentModuleBase>> GetContentModuleBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentModuleBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.HeadlessServer>> GetHeadlessServers() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.HeadlessServer>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductList>> GetProductLists() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductList>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.StatisticsSettings>> GetStatisticsSettingses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.StatisticsSettings>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SalesChannel>> GetSalesChannels() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SalesChannel>(QueryOptions.Default).ToList().AsQueryable());
}


[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ExplorerCountry>> GetExplorerCountries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ExplorerCountry>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.Region>> GetRegia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.Region>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.Location>> GetLocatia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.Location>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.TouristItem>> GetTouristItems() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.TouristItem>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.TouristActivity>> GetTouristActivities() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.TouristActivity>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.TouristAttraction>> GetTouristAttractia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.TouristAttraction>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.Accommodation>> GetAccommodatia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.Accommodation>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.Shopping>> GetShoppings() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.Shopping>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.PlaceToEatOrDrink>> GetPlaceToEatOrDrinks() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.PlaceToEatOrDrink>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.Article>> GetArticles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.Article>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.SimpleArticle>> GetSimpleArticles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.SimpleArticle>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.FrontPage>> GetFrontPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.FrontPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.TouristItemCategory>> GetTouristItemCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.TouristItemCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ActivityCategory>> GetActivityCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ActivityCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.AccommodationCategory>> GetAccommodationCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.AccommodationCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.AttractionCategory>> GetAttractionCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.AttractionCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ShoppingCategory>> GetShoppingCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ShoppingCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.FoodAndDrinkCategory>> GetFoodAndDrinkCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.FoodAndDrinkCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ImageGallery>> GetImageGalleries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ImageGallery>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.NewsList>> GetNewsLists() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.NewsList>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.NewsArticle>> GetNewsArticles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.NewsArticle>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ItemReview>> GetItemReviews() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ItemReview>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.RegisteredUser>> GetRegisteredUsers() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.RegisteredUser>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.Recipe>> GetRecipes() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.Recipe>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.VacantPosition>> GetVacantPositia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.VacantPosition>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.BookProduct>> GetBookProducts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.BookProduct>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.DemoShop>> GetDemoShops() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.DemoShop>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ControlPanel>> GetControlPanels() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ControlPanel>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ModulesPage>> GetModulesPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ModulesPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ModuleBase>> GetModuleBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ModuleBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ModuleParagraph>> GetModuleParagraphs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ModuleParagraph>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ModulePictureSeries>> GetModulePictureSerieses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ModulePictureSeries>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ModuleCallToAction>> GetModuleCallToActia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ModuleCallToAction>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ModuleVideo>> GetModuleVideoes() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ModuleVideo>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.TripsToNorwayDemo.ModuleTouristItemsList>> GetModuleTouristItemsLists() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.TripsToNorwayDemo.ModuleTouristItemsList>(QueryOptions.Default).ToList().AsQueryable());
}
}
}

