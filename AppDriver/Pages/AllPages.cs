using OpenQA.Selenium;



namespace AppDriver.Pages
{
    public class AllPages
    {

        public CarsHomePage CarsHome;
        public SearchResultsPage SearchResults;
        public CarDetailsPage CarDetails;

        public AllPages(IWebDriver webDriver)
        {
            CarsHome = new CarsHomePage(this, webDriver);
            SearchResults = new SearchResultsPage(this, webDriver);
            CarDetails = new CarDetailsPage(this, webDriver);
        }
    }
}
