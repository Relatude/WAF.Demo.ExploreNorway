using ExploreNorway.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.TripsToNorwayDemo;
using WAF.Engine.Query;
using WAF.Engine.Query.TripsToNorwayDemo;
using WAF.Presentation.Web;

namespace ExploreNorway.Code
{
    public class ViewModelHelper
    {
        private readonly WAFNativeContext wafContext;
        public ViewModelHelper(WAFNativeContext wafCtx)
        {
            wafContext = wafCtx;
        }

        public static ViewModelHelper GetInstance(WAFNativeContext wafCtx)
        {
            return new ViewModelHelper(wafCtx);
        }


        public ListPageViewModel<PlaceToEatOrDrink> GetEatOrDrinkViewModel(SimpleArticle content, int page, int cat, int region, int location)
        {
            var vm = new ListPageViewModel<PlaceToEatOrDrink>(content);

            int pageCount;
            if (page < 1)
                page = 1;
            vm.ListItems = GetEatDrinkListItems(page, cat, region, location, out pageCount);
            vm.PageIndex = page;
            vm.PageCount = pageCount;
            return vm;
        }


        public ListPageViewModel<Accommodation> GetLodgingViewModel(SimpleArticle content, int page, int cat, int region, int location)
        {
            var vm = new ListPageViewModel<Accommodation>(content);

            int pageCount;
            if (page < 1)
                page = 1;
            vm.ListItems = GetLodgingListItems(page, cat, region, location, out pageCount);
            vm.PageIndex = page;
            vm.PageCount = pageCount;

            Helper.ListPageFilters.GetInstance(wafContext).SetListPageModelFilters(vm, cat, region, location);

            return vm;
        }


        public ListPageViewModel<TouristActivity> GetActivityViewModel(SimpleArticle content, int page, int cat, int region, int location)
        {
            var vm = new ListPageViewModel<TouristActivity>(content);
            int pageCount;
            if (page < 1)
                page = 1;
            vm.ListItems = GetActivityListItems(page, cat, region, location, out pageCount);
            vm.PageIndex = page;
            vm.PageCount = pageCount;

            Helper.ListPageFilters.GetInstance(wafContext).SetListPageModelFilters(vm, cat, region, location);
            return vm;
        }


        public ListPageViewModel<TouristAttraction> GetAttractionViewModel(SimpleArticle content, int page, int cat, int region, int location)
        {
            var vm = new ListPageViewModel<TouristAttraction>(content);
            int pageCount;
            if (page < 1)
                page = 1;
            vm.ListItems = GetAttractionListItems(page, cat, region, location, out pageCount);
            vm.PageIndex = page;
            vm.PageCount = pageCount;

            Helper.ListPageFilters.GetInstance(wafContext).SetListPageModelFilters(vm, cat, region, location);
            return vm;
        }


        public ListPageViewModel<Shopping> GetShoppingViewModel(SimpleArticle content, int page, int cat, int region, int location)
        {
            var vm = new ListPageViewModel<Shopping>(content);
            int pageCount;
            if (page < 1)
                page = 1;
            vm.ListItems = GetShoppingListItems(page, cat, region, location, out pageCount);
            vm.PageIndex = page;
            vm.PageCount = pageCount;
            return vm;
        }



        private List<Accommodation> GetLodgingListItems(int pageIndex, int categoryId, int regionId, int locationId, out int pageCount)
        {
            pageIndex = pageIndex - 1;

            var listItems = new List<Accommodation>();
            AqlQuery q = wafContext.Session.CreateQuery();
            AqlAliasAccommodation aliasAccommodation = new AqlAliasAccommodation();
            AqlAliasLocation aliasLocation = new AqlAliasLocation();
            AqlAliasAccommodationCategory aliasCat = new AqlAliasAccommodationCategory();
            AqlAliasRegion aliasRegion = new AqlAliasRegion();

            if (locationId > 0 && categoryId > 0)
            {
                AqlAliasRelLocationAccommodations relLocationAccommodations = new AqlAliasRelLocationAccommodations(aliasLocation, aliasAccommodation);
                AqlAliasRelLodgingCategories relAccommodationsCategories = new AqlAliasRelLodgingCategories(relLocationAccommodations, aliasCat, aliasAccommodation);
                q.From(relAccommodationsCategories);
                q.Where(aliasLocation.NodeId == locationId);
                q.Where(aliasCat.NodeId == categoryId);
            }
            else if (locationId > 0 && categoryId <= 0)
            {
                AqlAliasRelLocationAccommodations relLocationAccommodations = new AqlAliasRelLocationAccommodations(aliasLocation, aliasAccommodation);
                q.From(relLocationAccommodations);
                q.Where(aliasLocation.NodeId == locationId);

            }
            else if (locationId <= 0 && categoryId > 0)
            {
                AqlAliasRelLodgingCategories relAccommodationsCategories = new AqlAliasRelLodgingCategories(aliasAccommodation, aliasCat);

                if (regionId > 0)
                {
                    AqlAliasRelLocationAccommodations relLocationAccommodations = new AqlAliasRelLocationAccommodations(aliasLocation, relAccommodationsCategories, aliasAccommodation);
                    AqlAliasRelRegionLocations relRegionLocations = new AqlAliasRelRegionLocations(aliasRegion, relLocationAccommodations, aliasLocation);
                    q.From(relRegionLocations);
                    q.Where(aliasCat.NodeId == categoryId);
                    q.Where(aliasRegion.NodeId == regionId);
                }
                else
                {
                    q.From(relAccommodationsCategories);
                    q.Where(aliasCat.NodeId == categoryId);
                }
            }
            else
            {
                // location and category not set
                if (regionId > 0)
                {
                    AqlAliasRelLocationAccommodations relLocationAccommodations = new AqlAliasRelLocationAccommodations(aliasLocation, aliasAccommodation);
                    AqlAliasRelRegionLocations relRegionLocations = new AqlAliasRelRegionLocations(aliasRegion, relLocationAccommodations, aliasLocation);
                    q.From(relRegionLocations);
                    q.Where(aliasRegion.NodeId == regionId);
                }
                else
                {
                    q.From(aliasAccommodation);
                }
            }
            q.Where(aliasAccommodation.SiteId == wafContext.Session.SiteId);
            AqlResultContent<Accommodation> accommodation = q.Select<Accommodation>(aliasAccommodation);
            q.PageIndex = pageIndex;
            q.PageSize = 10;
            q.RetrieveTotalCount = true;
            AqlResultSet rs = q.Execute();
            pageCount = rs.PageCount;
            while (rs.Read())
            {
                listItems.Add(accommodation.Value);
            }

            return listItems;
        }




        private List<Shopping> GetShoppingListItems(int pageIndex, int categoryId, int regionId, int locationId, out int pageCount)
        {
            pageIndex = pageIndex - 1;

            List<Shopping> listItems = new List<Shopping>();
            AqlQuery q = wafContext.Session.CreateQuery();

            AqlAliasShopping aliasShopping = new AqlAliasShopping();
            AqlResultContent<Shopping> shopping = null;
            if (locationId > 0 && categoryId > 0)
            {
                AqlAliasLocation aliasLocation = new AqlAliasLocation();
                AqlAliasShoppingCategory aliasCat = new AqlAliasShoppingCategory();
                //Join Shopping and Location
                AqlAliasRelLocationShopping relLocationShopping = new AqlAliasRelLocationShopping(aliasLocation, aliasShopping);
                //Join Shopping and Category
                AqlAliasRelShoppingCategories relShoppingCategories = new AqlAliasRelShoppingCategories(relLocationShopping, aliasCat, aliasShopping);
                //Fetch result from the join
                q.From(relShoppingCategories);
                shopping = q.Select<Shopping>(aliasShopping);
                //Constraints
                q.Where(aliasLocation.NodeId == locationId);
                q.Where(aliasCat.NodeId == categoryId);
            }
            else if (locationId > 0 && categoryId == 0)
            {
                AqlAliasLocation aliasLocation = new AqlAliasLocation();
                AqlAliasRelLocationShopping relLocationShopping = new AqlAliasRelLocationShopping(aliasLocation, aliasShopping);
                q.From(relLocationShopping);
                shopping = q.Select<Shopping>(aliasShopping);
                q.Where(aliasLocation.NodeId == locationId);
            }
            else if (locationId == 0 && categoryId > 0)
            {
                AqlAliasShoppingCategory aliasCat = new AqlAliasShoppingCategory();
                AqlAliasRelShoppingCategories relShoppingCategories = new AqlAliasRelShoppingCategories(aliasShopping, aliasCat);
                if (regionId > 0)
                {
                    AqlAliasLocation aliasLocation = new AqlAliasLocation();
                    AqlAliasRegion aliasRegion = new AqlAliasRegion();
                    AqlAliasRelLocationShopping relLocationShopping = new AqlAliasRelLocationShopping(aliasLocation, relShoppingCategories, aliasShopping);
                    AqlAliasRelRegionLocations relRegionLocations = new AqlAliasRelRegionLocations(aliasRegion, relLocationShopping, aliasLocation);
                    q.From(relRegionLocations);
                    shopping = q.Select<Shopping>(aliasShopping);
                    q.Where(aliasCat.NodeId == categoryId);
                    q.Where(aliasRegion.NodeId == regionId);
                }
                else
                {
                    q.From(relShoppingCategories);
                    shopping = q.Select<Shopping>(aliasShopping);
                    q.Where(aliasCat.NodeId == categoryId);
                }
            }
            else
            {
                //no parameters set -> fetch all shops
                if (regionId > 0)
                {
                    AqlAliasLocation aliasLocation = new AqlAliasLocation();
                    AqlAliasRegion aliasRegion = new AqlAliasRegion();
                    AqlAliasRelLocationShopping relLocationShopping = new AqlAliasRelLocationShopping(aliasLocation, aliasShopping);
                    AqlAliasRelRegionLocations relRegionLocations = new AqlAliasRelRegionLocations(aliasRegion, relLocationShopping, aliasLocation);
                    q.From(relRegionLocations);
                    shopping = q.Select<Shopping>(aliasShopping);
                    q.Where(aliasRegion.NodeId == regionId);
                }
                else
                {
                    q.From(aliasShopping);
                    shopping = q.Select<Shopping>(aliasShopping);
                }
            }
            q.Where(aliasShopping.SiteId == wafContext.Session.SiteId);
            q.PageIndex = pageIndex;
            q.PageSize = 10;
            q.RetrieveTotalCount = true;
            AqlResultSet rs = q.Execute();
            pageCount = rs.PageCount;
            while (rs.Read())
            {
                listItems.Add(shopping.Value);
            }

            return listItems;
        }





        private List<TouristAttraction> GetAttractionListItems(int pageIndex, int categoryId, int regionId, int locationId, out int pageCount)
        {

            pageIndex = pageIndex - 1;

            var listItems = new List<TouristAttraction>();
            AqlQuery q = wafContext.Session.CreateQuery();
            AqlAliasTouristAttraction aliasAttraction = new AqlAliasTouristAttraction();
            AqlAliasLocation aliasLocation = new AqlAliasLocation();
            AqlAliasAttractionCategory aliasCat = new AqlAliasAttractionCategory();
            AqlAliasRegion aliasRegion = new AqlAliasRegion();

            if (locationId > 0 && categoryId > 0)
            {
                AqlAliasRelLocationTouristAttractions relLocationAttractions = new AqlAliasRelLocationTouristAttractions(aliasLocation, aliasAttraction);
                AqlAliasRelAttractionCategories relAttractionsCategories = new AqlAliasRelAttractionCategories(relLocationAttractions, aliasCat, aliasAttraction);
                q.From(relAttractionsCategories);
                q.Where(aliasLocation.NodeId == locationId);
                q.Where(aliasCat.NodeId == categoryId);
            }
            else if (locationId > 0 && categoryId <= 0)
            {
                AqlAliasRelLocationTouristAttractions relLocationAttractions = new AqlAliasRelLocationTouristAttractions(aliasLocation, aliasAttraction);
                q.From(relLocationAttractions);
                q.Where(aliasLocation.NodeId == locationId);

            }
            else if (locationId <= 0 && categoryId > 0)
            {
                AqlAliasRelAttractionCategories relAttractionsCategories = new AqlAliasRelAttractionCategories(aliasAttraction, aliasCat);

                if (regionId > 0)
                {
                    AqlAliasRelLocationTouristAttractions relLocationAttractions = new AqlAliasRelLocationTouristAttractions(aliasLocation, relAttractionsCategories, aliasAttraction);
                    AqlAliasRelRegionLocations relRegionLocations = new AqlAliasRelRegionLocations(aliasRegion, relLocationAttractions, aliasLocation);
                    q.From(relRegionLocations);
                    q.Where(aliasCat.NodeId == categoryId);
                    q.Where(aliasRegion.NodeId == regionId);
                }
                else
                {
                    q.From(relAttractionsCategories);
                    q.Where(aliasCat.NodeId == categoryId);
                }
            }
            else
            {
                // location and category not set
                if (regionId > 0)
                {
                    AqlAliasRelLocationTouristAttractions relLocationAttractions = new AqlAliasRelLocationTouristAttractions(aliasLocation, aliasAttraction);
                    AqlAliasRelRegionLocations relRegionLocations = new AqlAliasRelRegionLocations(aliasRegion, relLocationAttractions, aliasLocation);
                    q.From(relRegionLocations);
                    q.Where(aliasRegion.NodeId == regionId);
                }
                else
                {
                    q.From(aliasAttraction);
                }
            }

            AqlResultContent<TouristAttraction> attraction = q.Select<TouristAttraction>(aliasAttraction);
            q.PageIndex = pageIndex;
            q.Where(aliasAttraction.SiteId == wafContext.Session.SiteId);
            q.PageSize = 10;
            q.RetrieveTotalCount = true;
            AqlResultSet rs = q.Execute();
            pageCount = rs.PageCount;
            while (rs.Read())
            {
                listItems.Add(attraction.Value);
            }

            return listItems;
        }


        private List<PlaceToEatOrDrink> GetEatDrinkListItems(int pageIndex, int categoryId, int regionId, int locationId, out int pageCount)
        {
            pageIndex = pageIndex - 1;

            List<PlaceToEatOrDrink> listItems = new List<PlaceToEatOrDrink>();
            AqlQuery q = wafContext.Session.CreateQuery();

            AqlAliasPlaceToEatOrDrink aliasPlaceToEatDrink = new AqlAliasPlaceToEatOrDrink();

            AqlResultContent<PlaceToEatOrDrink> placeToEatDrink = null;
            if (locationId > 0 && categoryId > 0)
            {
                AqlAliasLocation aliasLocation = new AqlAliasLocation();

                AqlAliasFoodAndDrinkCategory aliasCat = new AqlAliasFoodAndDrinkCategory();
                //Join PlaceToEatOrDrink and Location

                AqlAliasRelLocationEatDrink relLocationEatDrink = new AqlAliasRelLocationEatDrink(aliasLocation, aliasPlaceToEatDrink);
                //Join PlaceToEatOrDrink and Category

                AqlAliasRelFoodAndDrinkCategories relPlaceToEatOrDrinkCategories = new AqlAliasRelFoodAndDrinkCategories(relLocationEatDrink, aliasCat, aliasPlaceToEatDrink);
                //Fetch result from the join
                q.From(relPlaceToEatOrDrinkCategories);
                placeToEatDrink = q.Select<PlaceToEatOrDrink>(aliasPlaceToEatDrink);
                //Constraints
                q.Where(aliasLocation.NodeId == locationId);
                q.Where(aliasCat.NodeId == categoryId);
            }
            else if (locationId > 0 && categoryId == 0)
            {
                AqlAliasLocation aliasLocation = new AqlAliasLocation();
                AqlAliasRelLocationEatDrink relLocationEatDrink = new AqlAliasRelLocationEatDrink(aliasLocation, aliasPlaceToEatDrink);
                q.From(relLocationEatDrink);
                placeToEatDrink = q.Select<PlaceToEatOrDrink>(aliasPlaceToEatDrink);
                q.Where(aliasLocation.NodeId == locationId);
            }
            else if (locationId == 0 && categoryId > 0)
            {
                AqlAliasFoodAndDrinkCategory aliasCat = new AqlAliasFoodAndDrinkCategory();
                AqlAliasRelFoodAndDrinkCategories relPlaceToEatOrDrinkCategories = new AqlAliasRelFoodAndDrinkCategories(aliasPlaceToEatDrink, aliasCat);
                if (regionId > 0)
                {
                    AqlAliasLocation aliasLocation = new AqlAliasLocation();
                    AqlAliasRegion aliasRegion = new AqlAliasRegion();
                    AqlAliasRelLocationEatDrink relLocationEatDrink = new AqlAliasRelLocationEatDrink(aliasLocation, relPlaceToEatOrDrinkCategories, aliasPlaceToEatDrink);
                    AqlAliasRelRegionLocations relRegionLocations = new AqlAliasRelRegionLocations(aliasRegion, relLocationEatDrink, aliasLocation);
                    q.From(relRegionLocations);
                    placeToEatDrink = q.Select<PlaceToEatOrDrink>(aliasPlaceToEatDrink);
                    q.Where(aliasCat.NodeId == categoryId);
                    q.Where(aliasRegion.NodeId == regionId);
                }
                else
                {
                    q.From(relPlaceToEatOrDrinkCategories);
                    placeToEatDrink = q.Select<PlaceToEatOrDrink>(aliasPlaceToEatDrink);
                    q.Where(aliasCat.NodeId == categoryId);
                }
            }
            else
            {
                //no parameters set -> fetch all places to eat or drink
                if (regionId > 0)
                {
                    AqlAliasLocation aliasLocation = new AqlAliasLocation();
                    AqlAliasRegion aliasRegion = new AqlAliasRegion();
                    AqlAliasRelLocationEatDrink relLocationEatDrink = new AqlAliasRelLocationEatDrink(aliasLocation, aliasPlaceToEatDrink);
                    AqlAliasRelRegionLocations relRegionLocations = new AqlAliasRelRegionLocations(aliasRegion, relLocationEatDrink, aliasLocation);
                    q.From(relRegionLocations);
                    placeToEatDrink = q.Select<PlaceToEatOrDrink>(aliasPlaceToEatDrink);
                    q.Where(aliasRegion.NodeId == regionId);
                }
                else
                {
                    q.From(aliasPlaceToEatDrink);
                    placeToEatDrink = q.Select<PlaceToEatOrDrink>(aliasPlaceToEatDrink);
                }
            }
            q.Where(aliasPlaceToEatDrink.SiteId == wafContext.Session.SiteId);
            q.PageIndex = pageIndex;
            q.PageSize = 10;
            q.RetrieveTotalCount = true;
            AqlResultSet rs = q.Execute();
            pageCount = rs.PageCount;

            while (rs.Read())
            {
                listItems.Add(placeToEatDrink.Value);
            }
            return listItems;

        }


        private List<TouristActivity> GetActivityListItems(int pageIndex, int categoryId, int regionId, int locationId, out int pageCount)
        {
            pageIndex = pageIndex - 1;

            var listItems = new List<TouristActivity>();
            AqlQuery q = wafContext.Session.CreateQuery();
            AqlAliasTouristActivity aliasTouristActivity = new AqlAliasTouristActivity();
            AqlAliasLocation aliasLocation = new AqlAliasLocation();
            AqlAliasActivityCategory aliasCat = new AqlAliasActivityCategory();
            AqlAliasRegion aliasRegion = new AqlAliasRegion();

            if (locationId > 0 && categoryId > 0)
            {
                AqlAliasRelLocationActivities relLocationActivities = new AqlAliasRelLocationActivities(aliasLocation, aliasTouristActivity);
                AqlAliasRelActivityCategories relActivitiesCategories = new AqlAliasRelActivityCategories(relLocationActivities, aliasCat, aliasTouristActivity);
                q.From(relActivitiesCategories);
                q.Where(aliasLocation.NodeId == locationId);
                q.Where(aliasCat.NodeId == categoryId);
            }
            else if (locationId > 0 && categoryId <= 0)
            {
                AqlAliasRelLocationActivities relLocationActivities = new AqlAliasRelLocationActivities(aliasLocation, aliasTouristActivity);
                q.From(relLocationActivities);
                q.Where(aliasLocation.NodeId == locationId);

            }
            else if (locationId <= 0 && categoryId > 0)
            {
                AqlAliasRelActivityCategories relActivitiesCategories = new AqlAliasRelActivityCategories(aliasTouristActivity, aliasCat);

                if (regionId > 0)
                {
                    AqlAliasRelLocationActivities relLocationActivities = new AqlAliasRelLocationActivities(aliasLocation, relActivitiesCategories, aliasTouristActivity);
                    AqlAliasRelRegionLocations relRegionLocations = new AqlAliasRelRegionLocations(aliasRegion, relLocationActivities, aliasLocation);
                    q.From(relRegionLocations);
                    q.Where(aliasCat.NodeId == categoryId);
                    q.Where(aliasRegion.NodeId == regionId);
                }
                else
                {
                    q.From(relActivitiesCategories);
                    q.Where(aliasCat.NodeId == categoryId);
                }
            }
            else
            {
                // location and category not set
                if (regionId > 0)
                {
                    AqlAliasRelLocationActivities relLocationActivities = new AqlAliasRelLocationActivities(aliasLocation, aliasTouristActivity);
                    AqlAliasRelRegionLocations relRegionLocations = new AqlAliasRelRegionLocations(aliasRegion, relLocationActivities, aliasLocation);
                    q.From(relRegionLocations);
                    q.Where(aliasRegion.NodeId == regionId);
                }
                else
                {
                    q.From(aliasTouristActivity);
                }
            }
            q.Where(aliasTouristActivity.SiteId == wafContext.Session.SiteId);
            AqlResultContent<TouristActivity> activitiy = q.Select<TouristActivity>(aliasTouristActivity);
            q.PageIndex = pageIndex;
            q.PageSize = 10;
            q.RetrieveTotalCount = true;
            AqlResultSet rs = q.Execute();
            pageCount = rs.PageCount;
            while (rs.Read())
            {
                listItems.Add(activitiy.Value);
            }

            return listItems;
        }
    }
}