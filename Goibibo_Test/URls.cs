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
    ///The URls recording.
    /// </summary>
    [TestModule("d2fd989a-e110-48a3-8872-d1af3a0035fb", ModuleType.Recording, 1)]
    public partial class URls : ITestModule
    {
        /// <summary>
        /// Holds an instance of the IF repository.
        /// </summary>
        public static IF repo = IF.Instance;

        static URls instance = new URls();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public URls()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static URls Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1' at 35;14.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1Info, new RecordItemIndex(0));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.HttpsGoibiboIbcdnComStyleguideIma1.Click("35;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus' at 21;41.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MorePlusInfo, new RecordItemIndex(1));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus.Click("21;41");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.OffersPromotions' at 26;10.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.OffersPromotionsInfo, new RecordItemIndex(2));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.OffersPromotions.Click("26;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(3));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 120 units.", new RecordItemIndex(4));
            Mouse.ScrollWheel(120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(5));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(6));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(7));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(8));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(9));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(10));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(11));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(12));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.FaIconFlightsIconsLe' at 16;24.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconFlightsIconsLeInfo, new RecordItemIndex(13));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconFlightsIconsLe.Click("16;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1080 units.", new RecordItemIndex(14));
            Mouse.ScrollWheel(-1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(15));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.FaIconHotelsIconsLe' at 19;0.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconHotelsIconsLeInfo, new RecordItemIndex(16));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconHotelsIconsLe.Click("19;0");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1200 units.", new RecordItemIndex(17));
            Mouse.ScrollWheel(-1200);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(18));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComOffersBusOffer' at 28;12.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComOffersBusOfferInfo, new RecordItemIndex(19));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComOffersBusOffer.Click("28;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1200 units.", new RecordItemIndex(20));
            Mouse.ScrollWheel(-1200);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 600 units.", new RecordItemIndex(21));
            Mouse.ScrollWheel(600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.FaIconsLeIconAirportTransfer' at 22;16.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconsLeIconAirportTransferInfo, new RecordItemIndex(22));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconsLeIconAirportTransfer.Click("22;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1080 units.", new RecordItemIndex(23));
            Mouse.ScrollWheel(-1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 480 units.", new RecordItemIndex(24));
            Mouse.ScrollWheel(480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.FaIconTrainFrontViewIconsLe' at 7;16.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconTrainFrontViewIconsLeInfo, new RecordItemIndex(25));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconTrainFrontViewIconsLe.Click("7;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(26));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(27));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComOffersBankOffe' at 31;9.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComOffersBankOffeInfo, new RecordItemIndex(28));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComOffersBankOffe.Click("31;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1320 units.", new RecordItemIndex(29));
            Mouse.ScrollWheel(-1320);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(30));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.FaIconMobilesIconsLe' at 3;10.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconMobilesIconsLeInfo, new RecordItemIndex(31));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconMobilesIconsLe.Click("3;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1080 units.", new RecordItemIndex(32));
            Mouse.ScrollWheel(-1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(33));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.FaIconGo' at 11;19.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconGoInfo, new RecordItemIndex(34));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.FaIconGo.Click("11;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(35));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(36));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComOffersExpiredO' at 56;19.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComOffersExpiredOInfo, new RecordItemIndex(37));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.HttpsWwwGoibiboComOffersExpiredO.Click("56;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1440 units.", new RecordItemIndex(38));
            Mouse.ScrollWheel(-1440);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 1560 units.", new RecordItemIndex(39));
            Mouse.ScrollWheel(1560);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus1' at 24;22.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus1Info, new RecordItemIndex(40));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus1.Click("24;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.ReviewsRatings' at 18;2.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.ReviewsRatingsInfo, new RecordItemIndex(41));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.ReviewsRatings.Click("18;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -2760 units.", new RecordItemIndex(42));
            Mouse.ScrollWheel(-2760);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 3000 units.", new RecordItemIndex(43));
            Mouse.ScrollWheel(3000);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus2' at 13;31.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus2Info, new RecordItemIndex(44));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus2.Click("13;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.MobileApps' at 31;9.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MobileAppsInfo, new RecordItemIndex(45));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.MobileApps.Click("31;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -3240 units.", new RecordItemIndex(46));
            Mouse.ScrollWheel(-3240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 2760 units.", new RecordItemIndex(47));
            Mouse.ScrollWheel(2760);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.InputTagMbl' at 116;26.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.InputTagMblInfo, new RecordItemIndex(48));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.InputTagMbl.Click("116;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '88' with focus on 'Hotel.OnlineFlightBookingHotelsBusAmp.InputTagMbl'.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.InputTagMblInfo, new RecordItemIndex(49));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.InputTagMbl.PressKeys("88");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '58558819' with focus on 'Hotel.OnlineFlightBookingHotelsBusAmp.InputTagMbl'.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.InputTagMblInfo, new RecordItemIndex(50));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.InputTagMbl.PressKeys("58558819");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.GetDownloadLink' at 125;29.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.GetDownloadLinkInfo, new RecordItemIndex(51));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.GetDownloadLink.Click("125;29");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(52));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 1080 units.", new RecordItemIndex(53));
            Mouse.ScrollWheel(1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus1' at 10;15.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus1Info, new RecordItemIndex(54));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus1.Click("10;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Events' at 19;8.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.EventsInfo, new RecordItemIndex(55));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Events.Click("19;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -3720 units.", new RecordItemIndex(56));
            Mouse.ScrollWheel(-3720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 4080 units.", new RecordItemIndex(57));
            Mouse.ScrollWheel(4080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus1' at 20;23.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus1Info, new RecordItemIndex(58));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.MorePlus1.Click("20;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.RoutePlanner' at 40;10.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.RoutePlannerInfo, new RecordItemIndex(59));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.RoutePlanner.Click("40;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1440 units.", new RecordItemIndex(60));
            Mouse.ScrollWheel(-1440);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(61));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1440 units.", new RecordItemIndex(62));
            Mouse.ScrollWheel(-1440);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 1680 units.", new RecordItemIndex(63));
            Mouse.ScrollWheel(1680);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.goibibo.com/myaccount/trips/' with browser 'Chrome' in normal mode .", new RecordItemIndex(64));
            Host.Current.OpenBrowser("https://www.goibibo.com/myaccount/trips/", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(65));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(66));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(67));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(68));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(69));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(70));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(71));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(72));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(73));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(74));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(75));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(76));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(77));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(78));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(79));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(80));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(81));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(82));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(83));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(84));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(85));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(86));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(87));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(88));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(89));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(90));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(91));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(92));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(93));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(94));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(95));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(96));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(97));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(98));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(99));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(100));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(101));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 1440 units.", new RecordItemIndex(102));
            Mouse.ScrollWheel(1440);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(103));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(104));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(105));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(106));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Reviews' at 15;4.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.ReviewsInfo, new RecordItemIndex(107));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Reviews.Click("15;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(108));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(109));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(110));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(111));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(112));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(113));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(114));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(115));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(116));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(117));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(118));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(119));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(120));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(121));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(122));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(123));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(124));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(125));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -960 units.", new RecordItemIndex(126));
            Mouse.ScrollWheel(-960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(127));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(128));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(129));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(130));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(131));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(132));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(133));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(134));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(135));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(136));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.GoCashPlus' at 12;7.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.GoCashPlusInfo, new RecordItemIndex(137));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.GoCashPlus.Click("12;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(138));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 960 units.", new RecordItemIndex(139));
            Mouse.ScrollWheel(960);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(140));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 840 units.", new RecordItemIndex(141));
            Mouse.ScrollWheel(840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hotel.OnlineFlightBookingHotelsBusAmp.Settings' at 4;2.", repo.Hotel.OnlineFlightBookingHotelsBusAmp.SettingsInfo, new RecordItemIndex(142));
            repo.Hotel.OnlineFlightBookingHotelsBusAmp.Settings.Click("4;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(143));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(144));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(145));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(146));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.goibibo.com/logoutuser/' with browser 'Chrome' in normal mode .", new RecordItemIndex(147));
            Host.Current.OpenBrowser("https://www.goibibo.com/logoutuser/", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(148));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.Goibibo.com/logoutuser/' with browser 'Chrome' in normal mode .", new RecordItemIndex(149));
            Host.Current.OpenBrowser("http://www.Goibibo.com/logoutuser/", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 720 units.", new RecordItemIndex(150));
            Mouse.ScrollWheel(720);
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
