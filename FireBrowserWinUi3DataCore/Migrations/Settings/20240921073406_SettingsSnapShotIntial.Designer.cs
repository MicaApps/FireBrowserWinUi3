﻿// <auto-generated />
using FireBrowserWinUi3DataCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FireBrowserWinUi3DataCore.Migrations.Settings
{
    [DbContext(typeof(SettingsContext))]
    [Migration("20240921073406_SettingsSnapShotIntial")]
    partial class SettingsSnapShotIntial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.7.24405.3");

            modelBuilder.Entity("FireBrowserWinUi3MultiCore.Settings", b =>
                {
                    b.Property<string>("PackageName")
                        .HasColumnType("TEXT");

                    b.Property<int>("AdBlockerType")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AdblockBtn")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Auto")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BackButton")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Background")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BrowserKeys")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BrowserScripts")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ColorBackground")
                        .HasColumnType("TEXT");

                    b.Property<string>("ColorTV")
                        .HasColumnType("TEXT");

                    b.Property<string>("ColorTool")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ConfirmCloseDlg")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DarkIcon")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DisableGenAutoFill")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DisableJavaScript")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DisablePassSave")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DisableWebMess")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Downloads")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EngineFriendlyName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Eq2fa")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EqHis")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Eqfav")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Eqsets")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExceptionLog")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ExitDialog")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Favorites")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FavoritesL")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ForwardButton")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Historybtn")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HomeButton")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAdBlockerEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFavoritesToggled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFavoritesVisible")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHistoryToggled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHistoryVisible")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsLogoVisible")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSearchBoxToggled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSearchVisible")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTrendingVisible")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lang")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LightMode")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("NtpCoreVisibility")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("NtpDateTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NtpTextColor")
                        .HasColumnType("TEXT");

                    b.Property<bool>("OpSw")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("OpenTabHandel")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("PipMode")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("QrCode")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ReadButton")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RefreshButton")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ResourceSave")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SearchUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("StatusBar")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ToolIcon")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrackPrevention")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Translate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Useragent")
                        .HasColumnType("TEXT");

                    b.HasKey("PackageName");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            PackageName = "FireBrowswerWinUi3_806e5648-8335-46f4-a406-56b28cbfe096",
                            AdBlockerType = 0,
                            AdblockBtn = true,
                            Auto = false,
                            BackButton = true,
                            Background = 0,
                            BrowserKeys = true,
                            BrowserScripts = true,
                            ColorBackground = "#000000",
                            ColorTV = "#000000",
                            ColorTool = "#000000",
                            ConfirmCloseDlg = true,
                            DarkIcon = true,
                            DisableGenAutoFill = false,
                            DisableJavaScript = false,
                            DisablePassSave = false,
                            DisableWebMess = false,
                            Downloads = true,
                            EngineFriendlyName = "Google",
                            Eq2fa = true,
                            EqHis = false,
                            Eqfav = false,
                            Eqsets = false,
                            ExceptionLog = "Low",
                            ExitDialog = false,
                            Favorites = true,
                            FavoritesL = true,
                            ForwardButton = true,
                            Historybtn = true,
                            HomeButton = true,
                            IsAdBlockerEnabled = false,
                            IsFavoritesToggled = false,
                            IsFavoritesVisible = true,
                            IsHistoryToggled = false,
                            IsHistoryVisible = true,
                            IsLogoVisible = true,
                            IsSearchBoxToggled = false,
                            IsSearchVisible = true,
                            IsTrendingVisible = true,
                            Lang = "nl-NL",
                            LightMode = false,
                            NtpCoreVisibility = true,
                            NtpDateTime = true,
                            NtpTextColor = "#FFFFFF",
                            OpSw = true,
                            OpenTabHandel = false,
                            PipMode = false,
                            QrCode = true,
                            ReadButton = true,
                            RefreshButton = true,
                            ResourceSave = false,
                            SearchUrl = "https://www.google.com/search?q=",
                            StatusBar = true,
                            ToolIcon = true,
                            TrackPrevention = 2,
                            Translate = true,
                            Useragent = "WebView"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
