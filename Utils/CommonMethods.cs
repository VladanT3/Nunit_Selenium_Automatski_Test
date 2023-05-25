using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace Nunit_Selenium_Automatski_Test.Utils
{
    public class CommonMethods
    {
        public static WebDriverWait? wait;


        /// <summary>
        /// Metoda koja ceka vidljivost elementa
        /// </summary>
        private static void WaitElementVisibility(IWebDriver driver, By element, uint timeOut = 20)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(element));
        }


        /// <summary>
        /// Metoda koja klikne na element
        /// </summary>
        /// <param name="driver">driver</param>
        /// <param name="element">element</param>
        public static void ClickElement(IWebDriver driver, By element)
        {
            WaitElementVisibility(driver, element);
            driver.FindElement(element).Click();
        }


        /// <summary>
        /// Metoda koja upisuje tekst u element
        /// </summary>
        /// <param name="driver">driver</param>
        /// <param name="element">element</param>
        /// <param name="text">text</param>
        public static void WriteText(IWebDriver driver, By element, string text)
        {
            WaitElementVisibility(driver, element);
            driver.FindElement(element).SendKeys(text);
        }


        /// <summary>
        /// Metoda koja cita tekst iz elementa
        /// </summary>
        /// <param name="driver">driver</param>
        /// <param name="element">element</param>
        /// <returns></returns>
        public static string ReadText(IWebDriver driver, By element)
        {
            WaitElementVisibility(driver, element);
            return driver.FindElement(element).Text;
        }


        /// <summary>
        /// Vraca url link stranice
        /// </summary>
        /// <returns></returns>
        public static string UrlLink(IWebDriver driver)
        {
            return driver.Url;
        }


        /// <summary>
        /// Vraca tekst iz svih option elemenata iz nekog selecta
        /// </summary>
        /// <param name="driver">driver</param>
        /// <returns></returns>
        private static List<string> GetAllOptions(IWebDriver driver, By element)
        {
            List<string> options = new List<string>();

            try
            {
                ReadOnlyCollection<IWebElement> allOptions = driver.FindElements(element);

                foreach (IWebElement option in allOptions)
                {
                    options.Add(option.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return options;
        }


        /// <summary>
        /// Vrati random string iz liste
        /// </summary>
        /// <param name="list">Lista</param>
        /// <param name="skip">Koliko clanova sa pocetka se preskace</param>
        /// <returns>Random string iz liste</returns>
        public static string GetRandomItemFromList(List<string> list, int skip = 0)
        {
            Random random = new Random();
            return list[random.Next(skip, list.Count - 1)];
        }


        /// <summary>
        /// Ocisti tekst iz elementa
        /// </summary>
        /// <param name="driver">driver</param>
        /// <param name="element">element</param>
        public static void ClearText(IWebDriver driver, By element)
        {
            WaitElementVisibility(driver, element);
            driver.FindElement(element).Clear();
        }


        /// <summary>
        /// Klikne random option iz selecta
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="selectElement">Select</param>
        /// <param name="optionsElement">Options</param>
        /// <param name="skip">Koliko clanova sa pocetka se preskace</param>
        public static void ClickRandomOption(IWebDriver driver, By selectElement, By optionsElement, int skip = 0)
        {
            WaitElementVisibility(driver, optionsElement);
            List<string> options = GetAllOptions(driver, optionsElement);

            WaitElementVisibility(driver, selectElement);
            SelectElement select = new SelectElement(driver.FindElement(selectElement));

            select.SelectByText(GetRandomItemFromList(options, skip));
        }


        /// <summary>
        /// Generise random username sa predefinisanom osnovom
        /// </summary>
        /// <param name="baseName">Osnovni deo username-a</param>
        /// <returns>Random username</returns>
        public static string GenerateRandomUsername(string baseName)
        {
            Random random = new Random();
            return baseName + random.Next(1000, 9999);
        }


        /// <summary>
        /// Generise random email sa predefinisanom osnovom i ostatkom posle znaka '@'
        /// </summary>
        /// <param name="baseMail">Osnovni deo email-a</param>
        /// <returns>Random email</returns>
        public static string GenerateRandomEmail(string baseMail)
        {
            Random random = new Random();
            return baseMail + random.Next(1000, 9999) + "@test.com";
        }


        /// <summary>
        /// Vraca vrednost iz jedne kolone iz poslednje reda u tabeli
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="tableRows">By element koju u sebi sadrzi i table i tr tagove</param>
        /// <param name="indexOfColumnReturned">
        ///     Koja kolona se vraca iz tabele (default 0):
        ///     0 - prva;
        ///     1 - druga;
        ///     itd.
        /// </param>
        /// <returns>Vrednost iz kolone</returns>
        public static string GetAnyValueFromLastTableRow(IWebDriver driver, By tableRows, int indexOfColumnReturned = 0)
        {
            List<string> allColumnValues = new List<string>();

            try
            {
                //svi redovi
                ReadOnlyCollection<IWebElement> rows = driver.FindElements(tableRows);
                //poslednji red
                IWebElement lastRow = rows[rows.Count - 1];
                //kolone iz poslednje reda
                ReadOnlyCollection<IWebElement> columns = lastRow.FindElements(By.XPath("./td"));

                foreach(IWebElement column in columns)
                {
                    allColumnValues.Add(column.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return allColumnValues[indexOfColumnReturned];
        }


        /// <summary>
        /// Sklanja prvi karakter iz stringa i prebacuje broj u float
        /// </summary>
        /// <param name="element">Element iz kog se vadi tekst</param>
        /// <returns>Realan broj bez $, €, £ i sl.</returns>
        public static float RemoveFirstCharacterFromStringAndConvertToFloat(IWebDriver driver, By element)
        {
            string totalPriceFromElementText = ReadText(driver, element);

            return float.Parse(totalPriceFromElementText.Remove(0, 1));
        }


        /// <summary>
        /// Sabira vrednosti iz kolona u tabeli
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="tableRows">Redovi iz tabele</param>
        /// <param name="numberOfRowsToSkip">Broj koliko redova da se preskoci od pocetka</param>
        /// <param name="indexOfColumnsToSum">Broj kolone koja se sabira</param>
        /// <returns>Zbir vrednosti iz kolone</returns>
        public static float SumColumnValues(IWebDriver driver, By tableRows, int numberOfRowsToSkip, int indexOfColumnsToSum)
        {
            float sum = 0;

            try
            {
                ReadOnlyCollection<IWebElement> rows = driver.FindElements(tableRows);

                for(int i = numberOfRowsToSkip; i < rows.Count; i++)
                {
                    IWebElement column = rows[i].FindElement(By.XPath($"./td[{indexOfColumnsToSum}]"));
                    //sklanja '$' da bi mogo da ga konvertuje
                    sum += float.Parse(column.Text.Remove(0, 1));
                }
            }
            catch (Exception)
            {
                throw;
            }

            return sum;
        }


        /// <summary>
        /// Proverava da li element postoji
        /// </summary>
        /// <param name="element">By element</param>
        /// <returns>Da li element postoji ili ne</returns>
        public static bool ElementExists(IWebDriver driver, By element)
        {
            bool exists = false;

            try
            {
                IWebElement tryElement = driver.FindElement(element);
                exists = true;
            }
            catch (NoSuchElementException)
            {
                throw;
            }

            return exists;
        }


        public static int ReturnNumberOfRowsFromTable(IWebDriver driver, By tableRows)
        {
            WaitElementVisibility(driver, tableRows);
            ReadOnlyCollection<IWebElement> rows = driver.FindElements(tableRows);

            return rows.Count;
        }
    }
}
