using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Query;
using WAF.Presentation.Web;
using WAF.Engine.Content.TripsToNorwayDemo;
using WAF.Engine.Query.TripsToNorwayDemo;
using WAF.Engine.Content.Native;

/// <summary>
/// Summary description for SMSRegistrationsDataSource
/// </summary>
public class NewsItemDataSource {

    public NewsItemDataSource() {
    }
   
    public List<NewsArticle> GetNewsItems(int startRowIndex, int maximumRows) {
        throw new NotImplementedException();
        //int pageSize = maximumRows;
        //int pageIndex = 0;
        //int totalCount = 0;
        //if (startRowIndex > 0) {
        //    pageIndex = (int)Math.Round(((double)startRowIndex / (double)pageSize));
        //}
        //HierarchicalContent hc = WAFContext.Session.GetContent<HierarchicalContent>(350);
        //List<NewsArticle> newsItems = new List<NewsArticle>();
        //newsItems = hc.Children.Query<NewsArticle>().Execute(pageIndex, pageSize, out totalCount);
        //return newsItems;
    }
    
    public int GetNewsItemCount() {
        throw new NotImplementedException();
        //return WAFContext.Session.Query<NewsArticle>().Execute().Count;
    }

}