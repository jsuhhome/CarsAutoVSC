using OpenQA.Selenium;
using AppDriver.Selenium;


namespace AppDriver.Pages
{
    public class SearchResultsPage
    {
        protected Selenium.UiDriver UiDriver;
        protected AllPages Pages;

        #region IWebElements
        readonly By filterMaxPrice50k = By.CssSelector(@"div[class='listings-top'] header[class='filter-header'] li[data-dtm='{\""name\"":\""Max Price\"",\""value\"":\""$50,000\""}']");
        readonly By filterHonda = By.CssSelector(@"div[class='listings-top'] header[class='filter-header'] li[data-dtm='{\""name"":\""Make\"",\""value\"":""Honda\""}']");
        readonly By filterPilot = By.CssSelector(@"div[class='listings-top'] header[class='filter-header'] li[data-dtm='{\""name"":\""Model\"",\""value\"":""Pilot\""}']");
        readonly By filterUsed = By.CssSelector(@"div[class='listings-top'] header[class='filter-header'] li[data-dtm='{\""name"":\""New/Used\"",\""value\"":""Used\""}']");
        readonly By filterNew = By.CssSelector(@"div[class='listings-top'] header[class='filter-header'] li[data-dtm='{\""name"":\""New/Used\"",\""value\"":""New\""}']");
        readonly By filterTouring8Passenger = By.CssSelector(@"div[class='listings-top'] header[class='filter-header'] li[data-dtm='{\""name"":\""Trim\"",\""value\"":""Touring 8-Passenger\""}']");


        readonly By rBtnNew = By.CssSelector(@"li[id='stkTypId'] label[for='stkTypId-28880']");

        readonly By cbTrim8Passenger = By.CssSelector(@"li[id='trId'] label[for='trId-36434822']");

        readonly By row2ndItem = By.CssSelector(@"div[id='srp-listing-rows-container'] a[data-position='2']");

        


        #endregion

        public SearchResultsPage(AllPages allPages, IWebDriver webDriver)
        {
            this.UiDriver = new Selenium.UiDriver(webDriver);
            this.Pages = allPages;
        }

        public bool HeaderSearchFilterExists(string filter)
        {
            //in real world, the input filters css selector would be dynamically created instead of being hard coded By types from above
            //also, it would be better to simply get all filters being used and rename this function GetHeaderSearchFilters() or something else...
            try
            {
                if (filter == "Maximum Price: $50,000")
                {
                    return UiDriver.IsElementExist(filterMaxPrice50k);
                }
                if (filter == "Honda")
                {
                    return UiDriver.IsElementExist(filterHonda);
                }
                if (filter == "Pilot")
                {
                    return UiDriver.IsElementExist(filterPilot);
                }
                if (filter == "Used")
                {
                    return UiDriver.IsElementExist(filterUsed);
                }
                if (filter == "New")
                {
                    return UiDriver.IsElementExist(filterNew);
                }
                if (filter == "Touring8Passenger")
                {
                    return UiDriver.IsElementExist(filterTouring8Passenger);
                }
                UiDriver.WaitForPageToLoad();
            }
            catch (System.Exception ex)
            {
                // throw exception, log it, but removed for this take home
            }
            return false;
        }

        public void SelectNewFilter()
        {
            try
            {
                UiDriver.Click(rBtnNew);
                UiDriver.WaitForPageToLoad();
            }
            catch (System.Exception ex)
            {
                // throw exception, log it, but removed for this take home
            }
        }

        public void SelectTouring8Passenger()
        {
            try
            {
                UiDriver.Click(cbTrim8Passenger);
                UiDriver.WaitForPageToLoad();
            }
            catch (System.Exception ex)
            {
                // throw exception, log it, but removed for this take home
            }
        }

        public void Select2ndItem() //in real world, this would be parameterized so that the csss selector is generated
        {
            try
            {
                UiDriver.Click(row2ndItem);
                UiDriver.WaitForPageToLoad();
            }
            catch (System.Exception ex)
            {
                // throw exception, log it, but removed for this take home
            }
        }



    }
}
