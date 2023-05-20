﻿using OpenQA.Selenium;
using AutomationTestStoreDomaci.Utils;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationTestStoreDomaci.Pages
{
    public class BasePage
    {
        public IWebDriver? driver;

        /// <summary>
        /// Poziva common metodu ClickElement da izvrsi klik na neki element
        /// </summary>
        /// <param name="element">Element</param>
        protected void ClickOnElement(By element)
        {
            CommonMethods.ClickElement(driver, element);
        }


        /// <summary>
        /// Poziva common metodu WriteText da upise tekst u neki element
        /// </summary>
        /// <param name="element">Element</param>
        /// <param name="text">Tekst</param>
        protected void WriteTextToElement(By element, string text)
        {
            CommonMethods.WriteText(driver, element, text);
        }


        /// <summary>
        /// Poziva common metodu ReadText da vrati tekst iz nekog element
        /// </summary>
        /// <param name="element">Element</param>
        /// <returns>Tekst iz elementa</returns>
        protected string ReadTextFromElement(By element)
        {
            return CommonMethods.ReadText(driver, element);
        }


        /// <summary>
        /// Poziva common metodu ClearText da izbrise tekst iz nekog element
        /// </summary>
        /// <param name="element">Element</param>
        protected void ClearTextFromElement(By element)
        {
            CommonMethods.ClearText(driver, element);
        }


        /// <summary>
        /// Poziva common metodu ReadAlertText da vrati tekst iz Alert Box-a
        /// </summary>
        /// <returns>Tekst iz Alert Box-a</returns>
        protected string ReadTextFromAlertBox()
        {
            return CommonMethods.ReadAlertText(driver);
        }


        /// <summary>
        /// Poziva common metodu CloseAlert da zatvori Alert Box
        /// </summary>
        protected void AcceptAlertBox()
        {
            CommonMethods.CloseAlert(driver);
        }


        /// <summary>
        /// Poziva common metodu ElementExists da vrati da li element postoji ili ne
        /// </summary>
        /// <param name="element">Element</param>
        /// <returns>Bool vrednost u odnosu da li element postoji</returns>
        protected bool CheckIfElementExists(By element)
        {
            return CommonMethods.ElementExists(driver, element);
        }


        /// <summary>
        /// Poziva common metodu UrlLink da vrati url link trenutne stranice
        /// </summary>
        /// <returns>Url link trenutne stranice</returns>
        protected string GetUrlLink()
        {
            return CommonMethods.UrlLink(driver);
        }


        /// <summary>
        /// Poziva common metodu ClickRandomOption da klikne na random option tag u selectu
        /// </summary>
        /// <param name="selectElement">Select element</param>
        /// <param name="optionsElement">Option elementi</param>
        /// <param name="skip">Koliko clanova sa pocetka se preskace</param>
        protected void ClickRandomOptionFromSelect(By selectElement, By optionsElement, int skip = 0)
        {
            CommonMethods.ClickRandomOption(driver, selectElement, optionsElement, skip);
        }


        /// <summary>
        /// Poziva common metodu GetAnyValueFromLastTableRow koja vraca vrednost iz kolone iz poslednje reda prosledjene tabele
        /// </summary>
        /// <param name="tableRows">By element koji u sebi ima i table i sve tr tagove</param>
        /// <param name="columnReturned">
        ///     Koja kolona se vraca iz tabele (default 0):
        ///     0 - prva;
        ///     1 - druga;
        ///     itd.
        /// </param>
        /// <returns></returns>
        protected string GetValueFromLastTableRow(By tableRows, int columnReturned = 0)
        {
            return CommonMethods.GetAnyValueFromLastTableRow(driver, tableRows, columnReturned);
        }


        /// <summary>
        /// Poziva common metodu RemoveFirstCharacterFromStringAndConvertToFloat koja sklanja prvi karakter iz stringa i pretvara broj u float
        /// </summary>
        /// <param name="priceElement">Element ciji je tekst neka cena</param>
        /// <returns>Realan broj bez $, €, £ i sl.</returns>
        protected float GetFloatFromPriceText(By priceElement)
        {
            return CommonMethods.RemoveFirstCharacterFromStringAndConvertToFloat(driver, priceElement);
        }


        /// <summary>
        /// Poziva common metodu SumColumnValues da prvo skloni prvi karakter iz stringa i potom sabere brojeve koji su ostali
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="tableRows">Redovi iz tabele</param>
        /// <param name="numberOfRowsToSkip">Broj koliko redova da se preskoci od pocetka (default 0)</param>
        /// <param name="indexOfColumnsToSum">Broj kolone koja se sabira (default 1 zbog html-a jer index krece od 1)</param>
        /// <returns>Zbir vrednosti iz kolone</returns>
        protected float GetSumOfColumnValues(By tableRows, int numberOfRowsToSkip = 0, int indexOfColumnsToSum = 1)
        {
            return CommonMethods.SumColumnValues(driver, tableRows, numberOfRowsToSkip, indexOfColumnsToSum);
        }
    }
}
