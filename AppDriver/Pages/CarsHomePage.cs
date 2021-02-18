using OpenQA.Selenium;
using AppDriver.Selenium;


namespace AppDriver.Pages
{


    
    public class CarsHomePage
    {
        protected Selenium.UiDriver UiDriver;
        protected AllPages Pages;

        #region IWebElements
        readonly By DdStockType = By.Name("stockType");
        readonly By DdStockTypeUsed = By.CssSelector("select[name='stockType'] > option[value='28881']");

        readonly By DdMake = By.Name("makeId");
        readonly By DdMakeHonda = By.CssSelector("select[name='makeId'] > option[value='20017']");

        readonly By DdModel = By.Name("modelId");
        readonly By DdModelPilot = By.CssSelector("select[name='modelId'] > option[value='21729']");

        readonly By DdMaxPrice = By.Name("priceMax");
        readonly By DdMaxPrice50k = By.CssSelector("select[name='priceMax'] > option[value='50000']");

        readonly By DdMaxDistance = By.Name("radius");
        readonly By DdMaxDistance100 = By.CssSelector("select[name='radius'] > option[value='100']");

        readonly By DdZipCode = By.Name("zip");

        readonly By BtnSearch = By.CssSelector("input[value='Search'][type='submit']");
        #endregion

        public CarsHomePage(AllPages allPages, IWebDriver webDriver)
        {
            this.UiDriver = new Selenium.UiDriver(webDriver);
            this.Pages = allPages;
        }

        public void Goto()
        {
            try
            {
                UiDriver.GotoPage("https:\\www.cars.com");
                UiDriver.WaitForPageToLoad();
            }
            catch (System.Exception ex)
            {
                // throw exception, removed for this take home
            }
        }

        public void Search(string stockType, string make, string model, string maxPrice, string radius, string zipCode)
        {

            //for this assingment, the input parameters obviously don't do anything, but in the real world, 
            //this would convert the string and dynamically create the css selector instead of selecting from a predefined option above
            try
            {
                UiDriver.Click(DdStockType);
                UiDriver.WaitForPageToLoad();

                UiDriver.Click(DdStockTypeUsed);
                UiDriver.WaitForPageToLoad();

                UiDriver.Click(DdMake);
                UiDriver.WaitForPageToLoad();

                UiDriver.Click(DdMakeHonda);
                UiDriver.WaitForPageToLoad();

                UiDriver.Click(DdModel);
                UiDriver.WaitForPageToLoad();

                UiDriver.Click(DdModelPilot);
                UiDriver.WaitForPageToLoad();

                UiDriver.Click(DdMaxPrice);
                UiDriver.WaitForPageToLoad();

                UiDriver.Click(DdMaxPrice50k);
                UiDriver.WaitForPageToLoad();

                UiDriver.Click(DdMaxDistance);
                UiDriver.WaitForPageToLoad();

                UiDriver.Click(DdMaxDistance100);
                UiDriver.WaitForPageToLoad();

                UiDriver.Click(DdZipCode);
                UiDriver.ClearAndSendKeys(DdZipCode, zipCode);
                UiDriver.WaitForPageToLoad();

                //System.Threading.Thread.Sleep(3000);

                UiDriver.Click(BtnSearch);
                UiDriver.WaitForPageToLoad();
            }
            catch (System.Exception ex)
            {
                // throw exception, removed for this take home
            }
        }





    }
}
