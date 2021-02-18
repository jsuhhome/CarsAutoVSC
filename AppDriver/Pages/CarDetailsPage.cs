using System;
using OpenQA.Selenium;
using AppDriver.Selenium;


namespace AppDriver.Pages
{
    public class CarDetailsPage
    {

        protected Selenium.UiDriver UiDriver;
        protected AllPages Pages;

        #region IWebElements
        readonly By btnCheckAvailibility = By.CssSelector(@"button[type='submit'][name='submit'][data-linkname='submit-email-lead']");
        readonly By tBxFirstName = By.CssSelector(@"input[type='text'][name='fname']");
        readonly By tBxLastName = By.CssSelector(@"input[type='text'][name='lname']");
        readonly By tBxEmail = By.CssSelector(@"input[type='email'][name='email']");

        readonly By frmCalculator = By.CssSelector(@"form[class='calculator-form ng-pristine ng-valid']");
        readonly By divPaymentCalc = By.CssSelector(@"div[id='details-section'] h2");
        #endregion

        public CarDetailsPage(AllPages allPages, IWebDriver webDriver)
        {
            this.UiDriver = new Selenium.UiDriver(webDriver);
            this.Pages = allPages;
        }

        public bool IsCheckAvailabilityDisplayed() 
        {
            try
            {
                UiDriver.WaitForPageToLoad();
                return UiDriver.IsDisplayed(btnCheckAvailibility);
            }
            catch (System.Exception ex)
            {
                // throw exception, log it, but removed for this take home
            }
            return false;
        }

        public void EnterFirstNameLastNameEmail(string firstName, string lastName, string email)
        {
            try
            {
                UiDriver.ClearAndSendKeys(tBxFirstName, firstName);
                UiDriver.ClearAndSendKeys(tBxLastName, lastName);
                UiDriver.ClearAndSendKeys(tBxEmail, email);
                UiDriver.WaitForPageToLoad();
            }
            catch (System.Exception ex)
            {
                // throw exception, log it, but removed for this take home
            }
        }

        public void ViewAndSnapPaymentCalculator(string saveLocation)
        {
            try
            {
                UiDriver.ScrollIntoView(divPaymentCalc);
                UiDriver.WaitForPageToLoad();

                Screenshot screen = ((ITakesScreenshot)UiDriver.driver).GetScreenshot();
                string screenshotfilename = saveLocation + "\\PaymentCalcForm_" + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss") + ".jpg";
                screen.SaveAsFile(screenshotfilename);
            }
            catch (System.Exception ex)
            {
                // throw exception, log it, but removed for this take home
            }

        }


    }
}
