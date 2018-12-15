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
    ///The Car recording.
    /// </summary>
    [TestModule("6c4d174f-d768-4ce1-aac8-a20a37f2ba54", ModuleType.Recording, 1)]
    public partial class Car : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Goibibo_TestRepository repository.
        /// </summary>
        public static Goibibo_TestRepository repo = Goibibo_TestRepository.Instance;

        static Car instance = new Car();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Car Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.IconAirportTransferDbBlueIco24Lh1' at 21;15.", repo.OnlineFlightBookingHotelsBusAmp.IconAirportTransferDbBlueIco24Lh1Info, new RecordItemIndex(0));
            repo.OnlineFlightBookingHotelsBusAmp.IconAirportTransferDbBlueIco24Lh1.Click("21;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.PTagNewDelhi' at 79;9.", repo.OnlineFlightBookingHotelsBusAmp.Root.PTagNewDelhiInfo, new RecordItemIndex(1));
            repo.OnlineFlightBookingHotelsBusAmp.Root.PTagNewDelhi.Click("79;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL' at 118;15.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(2));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.Click("118;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'del' with focus on 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL'.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(3));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.PressKeys("del");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.DelhiCantonmentNewDelhiDelhiIndi' at 106;-1.", repo.OnlineFlightBookingHotelsBusAmp.DelhiCantonmentNewDelhiDelhiIndiInfo, new RecordItemIndex(4));
            repo.OnlineFlightBookingHotelsBusAmp.DelhiCantonmentNewDelhiDelhiIndi.Click("106;-1");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.Agra' at 85;7.", repo.OnlineFlightBookingHotelsBusAmp.Root.AgraInfo, new RecordItemIndex(5));
            repo.OnlineFlightBookingHotelsBusAmp.Root.Agra.Click("85;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL' at 142;10.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(6));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.Click("142;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'agra' with focus on 'OnlineFlightBookingHotelsBusAmp.GosuggestInputL'.", repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputLInfo, new RecordItemIndex(7));
            repo.OnlineFlightBookingHotelsBusAmp.GosuggestInputL.PressKeys("agra");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.CustomResult' at 122;5.", repo.OnlineFlightBookingHotelsBusAmp.CustomResultInfo, new RecordItemIndex(8));
            repo.OnlineFlightBookingHotelsBusAmp.CustomResult.Click("122;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.Text' at 39;16.", repo.OnlineFlightBookingHotelsBusAmp.Root.TextInfo, new RecordItemIndex(9));
            repo.OnlineFlightBookingHotelsBusAmp.Root.Text.Click("39;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(10));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.DayPickerNavButtonDayPickerNavButton' at 8;4.", repo.OnlineFlightBookingHotelsBusAmp.Root.DayPickerNavButtonDayPickerNavButtonInfo, new RecordItemIndex(11));
            repo.OnlineFlightBookingHotelsBusAmp.Root.DayPickerNavButtonDayPickerNavButton.Click("8;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.DivTag1' at 29;7.", repo.OnlineFlightBookingHotelsBusAmp.Root.DivTag1Info, new RecordItemIndex(12));
            repo.OnlineFlightBookingHotelsBusAmp.Root.DivTag1.Click("29;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.SearchCabs' at 220;10.", repo.OnlineFlightBookingHotelsBusAmp.Root.SearchCabsInfo, new RecordItemIndex(13));
            repo.OnlineFlightBookingHotelsBusAmp.Root.SearchCabs.Click("220;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(14));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(15));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(16));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(17));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.Sedan' at 69;6.", repo.OnlineFlightBookingHotelsBusAmp.Root.SedanInfo, new RecordItemIndex(18));
            repo.OnlineFlightBookingHotelsBusAmp.Root.Sedan.Click("69;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.PTagSuv' at 67;11.", repo.OnlineFlightBookingHotelsBusAmp.Root.PTagSuvInfo, new RecordItemIndex(19));
            repo.OnlineFlightBookingHotelsBusAmp.Root.PTagSuv.Click("67;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(20));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(21));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.Hatchback' at 52;10.", repo.OnlineFlightBookingHotelsBusAmp.Root.HatchbackInfo, new RecordItemIndex(22));
            repo.OnlineFlightBookingHotelsBusAmp.Root.Hatchback.Click("52;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(23));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.IcongocarsInfoBlueIco20' at 1;10.", repo.OnlineFlightBookingHotelsBusAmp.Root.IcongocarsInfoBlueIco20Info, new RecordItemIndex(24));
            repo.OnlineFlightBookingHotelsBusAmp.Root.IcongocarsInfoBlueIco20.Click("1;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.GOTIT' at 38;6.", repo.OnlineFlightBookingHotelsBusAmp.Root.GOTITInfo, new RecordItemIndex(25));
            repo.OnlineFlightBookingHotelsBusAmp.Root.GOTIT.Click("38;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(26));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.FareDetails' at 18;3.", repo.OnlineFlightBookingHotelsBusAmp.Root.FareDetailsInfo, new RecordItemIndex(27));
            repo.OnlineFlightBookingHotelsBusAmp.Root.FareDetails.Click("18;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(28));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.GOTIT' at 25;4.", repo.OnlineFlightBookingHotelsBusAmp.Root.GOTITInfo, new RecordItemIndex(29));
            repo.OnlineFlightBookingHotelsBusAmp.Root.GOTIT.Click("25;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(30));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.Pay306' at 38;0.", repo.OnlineFlightBookingHotelsBusAmp.Root.Pay306Info, new RecordItemIndex(31));
            repo.OnlineFlightBookingHotelsBusAmp.Root.Pay306.Click("38;0");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(32));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.PayOptMobTabs' at 474;-20.", repo.OnlineFlightBookingHotelsBusAmp.PayOptMobTabsInfo, new RecordItemIndex(33));
            repo.OnlineFlightBookingHotelsBusAmp.PayOptMobTabs.Click("474;-20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.NetBanking' at 40;11.", repo.OnlineFlightBookingHotelsBusAmp.NetBankingInfo, new RecordItemIndex(34));
            repo.OnlineFlightBookingHotelsBusAmp.NetBanking.Click("40;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.PayNetbRb' at 7;6.", repo.OnlineFlightBookingHotelsBusAmp.PayNetbRbInfo, new RecordItemIndex(35));
            repo.OnlineFlightBookingHotelsBusAmp.PayNetbRb.Click("7;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(36));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Submit' at 130;9.", repo.OnlineFlightBookingHotelsBusAmp.SubmitInfo, new RecordItemIndex(37));
            repo.OnlineFlightBookingHotelsBusAmp.Submit.Click("130;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'StateBankOfIndiaInternetBanking.ClickHere' at 15;3.", repo.StateBankOfIndiaInternetBanking.ClickHereInfo, new RecordItemIndex(38));
            repo.StateBankOfIndiaInternetBanking.ClickHere.Click("15;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OnlineFlightBookingHotelsBusAmp.Root.GoibiboLogo' at 48;11.", repo.OnlineFlightBookingHotelsBusAmp.Root.GoibiboLogoInfo, new RecordItemIndex(39));
            repo.OnlineFlightBookingHotelsBusAmp.Root.GoibiboLogo.Click("48;11");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}