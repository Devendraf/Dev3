﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Goibibo_Test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The International_flight recording.
    /// </summary>
    [TestModule("1059b405-4c16-42f4-8fdf-294449b58f89", ModuleType.Recording, 1)]
    public partial class International_flight : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Goibibo_TestRepository repository.
        /// </summary>
        public static Goibibo_TestRepository repo = Goibibo_TestRepository.Instance;

        static International_flight instance = new International_flight();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public International_flight()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static International_flight Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.IconFlightsDbBlueIco24Lh12PadT5P' at 31;24.", repo.OnlineFlightBookingHotelsBusAmp1.IconFlightsDbBlueIco24Lh12PadT5PInfo, new RecordItemIndex(0));
            repo.OnlineFlightBookingHotelsBusAmp1.IconFlightsDbBlueIco24Lh12PadT5P.Click("31;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.GosuggestInputSrc' at 99;34.", repo.OnlineFlightBookingHotelsBusAmp1.GosuggestInputSrcInfo, new RecordItemIndex(1));
            repo.OnlineFlightBookingHotelsBusAmp1.GosuggestInputSrc.Click("99;34");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Delhi' with focus on 'OnlineFlightBookingHotelsBusAmp1.GosuggestInputSrc'.", repo.OnlineFlightBookingHotelsBusAmp1.GosuggestInputSrcInfo, new RecordItemIndex(2));
            repo.OnlineFlightBookingHotelsBusAmp1.GosuggestInputSrc.PressKeys("Delhi");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.SpanTagDEL' at 24;0.", repo.OnlineFlightBookingHotelsBusAmp1.SpanTagDELInfo, new RecordItemIndex(3));
            repo.OnlineFlightBookingHotelsBusAmp1.SpanTagDEL.Click("24;0");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.GosuggestInputDest' at 65;22.", repo.OnlineFlightBookingHotelsBusAmp1.GosuggestInputDestInfo, new RecordItemIndex(4));
            repo.OnlineFlightBookingHotelsBusAmp1.GosuggestInputDest.Click("65;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'singa' with focus on 'OnlineFlightBookingHotelsBusAmp1.GosuggestInputDest'.", repo.OnlineFlightBookingHotelsBusAmp1.GosuggestInputDestInfo, new RecordItemIndex(5));
            repo.OnlineFlightBookingHotelsBusAmp1.GosuggestInputDest.PressKeys("singa");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.Singapore' at 27;7.", repo.OnlineFlightBookingHotelsBusAmp1.SingaporeInfo, new RecordItemIndex(6));
            repo.OnlineFlightBookingHotelsBusAmp1.Singapore.Click("27;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(7));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.Fare20190118' at 7;6.", repo.OnlineFlightBookingHotelsBusAmp1.Fare20190118Info, new RecordItemIndex(8));
            repo.OnlineFlightBookingHotelsBusAmp1.Fare20190118.Click("7;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.PaxLabel' at 96;18.", repo.OnlineFlightBookingHotelsBusAmp1.PaxLabelInfo, new RecordItemIndex(9));
            repo.OnlineFlightBookingHotelsBusAmp1.PaxLabel.Click("96;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.AdultPaxPlus' at 12;6.", repo.OnlineFlightBookingHotelsBusAmp1.AdultPaxPlusInfo, new RecordItemIndex(10));
            repo.OnlineFlightBookingHotelsBusAmp1.AdultPaxPlus.Click("12;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.AdultPaxMinus' at 24;12.", repo.OnlineFlightBookingHotelsBusAmp1.AdultPaxMinusInfo, new RecordItemIndex(11));
            repo.OnlineFlightBookingHotelsBusAmp1.AdultPaxMinus.Click("24;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.PaxClose' at 6;7.", repo.OnlineFlightBookingHotelsBusAmp1.PaxCloseInfo, new RecordItemIndex(12));
            repo.OnlineFlightBookingHotelsBusAmp1.PaxClose.Click("6;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.GiSearchBtn' at 94;18.", repo.OnlineFlightBookingHotelsBusAmp1.GiSearchBtnInfo, new RecordItemIndex(13));
            repo.OnlineFlightBookingHotelsBusAmp1.GiSearchBtn.Click("94;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(14));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(15));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.Time' at 24;4.", repo.OnlineFlightBookingHotelsBusAmp1.TimeInfo, new RecordItemIndex(16));
            repo.OnlineFlightBookingHotelsBusAmp1.Time.Click("24;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.DbGreyDrIconSunriseIco24' at 47;12.", repo.OnlineFlightBookingHotelsBusAmp1.DbGreyDrIconSunriseIco24Info, new RecordItemIndex(17));
            repo.OnlineFlightBookingHotelsBusAmp1.DbGreyDrIconSunriseIco24.Click("47;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.DbGreyDrIconSunIco24' at 49;8.", repo.OnlineFlightBookingHotelsBusAmp1.DbGreyDrIconSunIco24Info, new RecordItemIndex(18));
            repo.OnlineFlightBookingHotelsBusAmp1.DbGreyDrIconSunIco24.Click("49;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.ResetFilters' at 61;6.", repo.OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.ResetFiltersInfo, new RecordItemIndex(19));
            repo.OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.ResetFilters.Click("61;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.Stops' at 23;4.", repo.OnlineFlightBookingHotelsBusAmp1.StopsInfo, new RecordItemIndex(20));
            repo.OnlineFlightBookingHotelsBusAmp1.Stops.Click("23;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.NonStop' at 9;4.", repo.OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.NonStopInfo, new RecordItemIndex(21));
            repo.OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.NonStop.Click("9;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.LabelTag1Stop' at 6;2.", repo.OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.LabelTag1StopInfo, new RecordItemIndex(22));
            repo.OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.LabelTag1Stop.Click("6;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.LabelTag2Stops' at 11;8.", repo.OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.LabelTag2StopsInfo, new RecordItemIndex(23));
            repo.OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.LabelTag2Stops.Click("11;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.AllStops' at 9;11.", repo.OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.AllStopsInfo, new RecordItemIndex(24));
            repo.OnlineFlightBookingHotelsBusAmp1.NavSectionTabs.AllStops.Click("9;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.Airlines' at 18;4.", repo.OnlineFlightBookingHotelsBusAmp1.AirlinesInfo, new RecordItemIndex(25));
            repo.OnlineFlightBookingHotelsBusAmp1.Airlines.Click("18;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(26));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(27));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.Airports' at 30;4.", repo.OnlineFlightBookingHotelsBusAmp1.AirportsInfo, new RecordItemIndex(28));
            repo.OnlineFlightBookingHotelsBusAmp1.Airports.Click("30;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(29));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 480 units.", new RecordItemIndex(30));
            Mouse.ScrollWheel(480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1080 units.", new RecordItemIndex(31));
            Mouse.ScrollWheel(-1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.Button' at 18;20.", repo.OnlineFlightBookingHotelsBusAmp1.ButtonInfo, new RecordItemIndex(32));
            repo.OnlineFlightBookingHotelsBusAmp1.Button.Click("18;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(33));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.BaggageAndFareRules' at 44;13.", repo.OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.BaggageAndFareRulesInfo, new RecordItemIndex(34));
            repo.OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.BaggageAndFareRules.Click("44;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OnlineFlightBookingHotelsBusAmp1.FltFareRulesTab' at 39;19.", repo.OnlineFlightBookingHotelsBusAmp1.FltFareRulesTabInfo, new RecordItemIndex(35));
            repo.OnlineFlightBookingHotelsBusAmp1.FltFareRulesTab.DoubleClick("39;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(36));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(37));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.JavascriptVoid01' at 3;5.", repo.OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.JavascriptVoid01Info, new RecordItemIndex(38));
            repo.OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.JavascriptVoid01.Click("3;5");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.FltFareRulesTab' at 50;4.", repo.OnlineFlightBookingHotelsBusAmp1.FltFareRulesTabInfo, new RecordItemIndex(39));
            //repo.OnlineFlightBookingHotelsBusAmp1.FltFareRulesTab.Click("50;4");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(40));
            //Mouse.ScrollWheel(-360);
            //Delay.Milliseconds(500);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(41));
            //Mouse.ScrollWheel(360);
            //Delay.Milliseconds(500);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.JavascriptVoid0' at 3;5.", repo.OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.JavascriptVoid0Info, new RecordItemIndex(42));
            //repo.OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.JavascriptVoid0.Click("3;5");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(43));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.FarebreakupTooltipBaseFare' at 260;43.", repo.OnlineFlightBookingHotelsBusAmp1.FarebreakupTooltipBaseFareInfo, new RecordItemIndex(44));
            repo.OnlineFlightBookingHotelsBusAmp1.FarebreakupTooltipBaseFare.Click("260;43");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.FarebreakupTooltipFeeSurcharge' at 256;83.", repo.OnlineFlightBookingHotelsBusAmp1.FarebreakupTooltipFeeSurchargeInfo, new RecordItemIndex(45));
            repo.OnlineFlightBookingHotelsBusAmp1.FarebreakupTooltipFeeSurcharge.Click("256;83");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(46));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.InsuranceRadio' at 9;7.", repo.OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.InsuranceRadioInfo, new RecordItemIndex(47));
            repo.OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.InsuranceRadio.Click("9;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.InsuranceRadio' at 9;7.", repo.OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.InsuranceRadioInfo, new RecordItemIndex(48));
            repo.OnlineFlightBookingHotelsBusAmp1.FlightDetailsFl.InsuranceRadio.Click("9;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(49));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.ControlIndicatorVMiddle' at 7;10.", repo.OnlineFlightBookingHotelsBusAmp1.ControlIndicatorVMiddleInfo, new RecordItemIndex(50));
            repo.OnlineFlightBookingHotelsBusAmp1.ControlIndicatorVMiddle.Click("7;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.ButtonTagOK' at 14;12.", repo.OnlineFlightBookingHotelsBusAmp1.ButtonTagOKInfo, new RecordItemIndex(51));
            repo.OnlineFlightBookingHotelsBusAmp1.ButtonTagOK.Click("14;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.ControlIndicatorVMiddle1' at 7;7.", repo.OnlineFlightBookingHotelsBusAmp1.ControlIndicatorVMiddle1Info, new RecordItemIndex(52));
            repo.OnlineFlightBookingHotelsBusAmp1.ControlIndicatorVMiddle1.Click("7;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.ButtonTagOK' at 18;4.", repo.OnlineFlightBookingHotelsBusAmp1.ButtonTagOKInfo, new RecordItemIndex(53));
            repo.OnlineFlightBookingHotelsBusAmp1.ButtonTagOK.Click("18;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(54));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item 'OnlineFlightBookingHotelsBusAmp1.Adulttitle1'.", repo.OnlineFlightBookingHotelsBusAmp1.Adulttitle1Info, new RecordItemIndex(55));
            repo.OnlineFlightBookingHotelsBusAmp1.Adulttitle1.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.AdultfirstName1' at 69;31.", repo.OnlineFlightBookingHotelsBusAmp1.AdultfirstName1Info, new RecordItemIndex(56));
            repo.OnlineFlightBookingHotelsBusAmp1.AdultfirstName1.Click("69;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Devendra' with focus on 'OnlineFlightBookingHotelsBusAmp1.AdultfirstName1'.", repo.OnlineFlightBookingHotelsBusAmp1.AdultfirstName1Info, new RecordItemIndex(57));
            repo.OnlineFlightBookingHotelsBusAmp1.AdultfirstName1.PressKeys("Devendra");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OnlineFlightBookingHotelsBusAmp1.AdultlastName1' at 7;15.", repo.OnlineFlightBookingHotelsBusAmp1.AdultlastName1Info, new RecordItemIndex(58));
            repo.OnlineFlightBookingHotelsBusAmp1.AdultlastName1.DoubleClick("7;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'gUpta' with focus on 'OnlineFlightBookingHotelsBusAmp1.AdultlastName1'.", repo.OnlineFlightBookingHotelsBusAmp1.AdultlastName1Info, new RecordItemIndex(59));
            repo.OnlineFlightBookingHotelsBusAmp1.AdultlastName1.PressKeys("gUpta");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.Email' at 255;22.", repo.OnlineFlightBookingHotelsBusAmp1.EmailInfo, new RecordItemIndex(60));
            repo.OnlineFlightBookingHotelsBusAmp1.Email.Click("255;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'testnoc009{LShiftKey down}{@ down}{LShiftKey up}gmail.com' with focus on 'OnlineFlightBookingHotelsBusAmp1.Email'.", repo.OnlineFlightBookingHotelsBusAmp1.EmailInfo, new RecordItemIndex(61));
            repo.OnlineFlightBookingHotelsBusAmp1.Email.PressKeys("testnoc009{LShiftKey down}{@ down}{LShiftKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.Mobile' at 175;7.", repo.OnlineFlightBookingHotelsBusAmp1.MobileInfo, new RecordItemIndex(62));
            repo.OnlineFlightBookingHotelsBusAmp1.Mobile.Click("175;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9999999999' with focus on 'OnlineFlightBookingHotelsBusAmp1.Mobile'.", repo.OnlineFlightBookingHotelsBusAmp1.MobileInfo, new RecordItemIndex(63));
            repo.OnlineFlightBookingHotelsBusAmp1.Mobile.PressKeys("9999999999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.ProceedToPayment' at 31;6.", repo.OnlineFlightBookingHotelsBusAmp1.ProceedToPaymentInfo, new RecordItemIndex(64));
            repo.OnlineFlightBookingHotelsBusAmp1.ProceedToPayment.Click("31;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.NetBanking' at 39;11.", repo.OnlineFlightBookingHotelsBusAmp1.NetBankingInfo, new RecordItemIndex(65));
            repo.OnlineFlightBookingHotelsBusAmp1.NetBanking.Click("39;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(66));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(67));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(68));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.TezTab' at 36;13.", repo.OnlineFlightBookingHotelsBusAmp1.TezTabInfo, new RecordItemIndex(69));
            repo.OnlineFlightBookingHotelsBusAmp1.TezTab.Click("36;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.NetBanking' at 28;21.", repo.OnlineFlightBookingHotelsBusAmp1.NetBankingInfo, new RecordItemIndex(70));
            repo.OnlineFlightBookingHotelsBusAmp1.NetBanking.Click("28;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(71));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.PayNetbRb' at 5;2.", repo.OnlineFlightBookingHotelsBusAmp1.PayNetbRbInfo, new RecordItemIndex(72));
            repo.OnlineFlightBookingHotelsBusAmp1.PayNetbRb.Click("5;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.Submit' at 195;16.", repo.OnlineFlightBookingHotelsBusAmp1.SubmitInfo, new RecordItemIndex(73));
            repo.OnlineFlightBookingHotelsBusAmp1.Submit.Click("195;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'StateBankOfIndiaInternetBanking.ClickHere' at 12;6.", repo.StateBankOfIndiaInternetBanking.ClickHereInfo, new RecordItemIndex(74));
            repo.StateBankOfIndiaInternetBanking.ClickHere.Click("12;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp1.HttpsGoibiboIbcdnComStyleguideIma' at 80;17.", repo.OnlineFlightBookingHotelsBusAmp1.HttpsGoibiboIbcdnComStyleguideImaInfo, new RecordItemIndex(75));
            repo.OnlineFlightBookingHotelsBusAmp1.HttpsGoibiboIbcdnComStyleguideIma.Click("80;17");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
