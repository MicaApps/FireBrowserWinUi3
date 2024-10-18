using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.IO;
using System.Threading.Tasks;
using FireBrowserWinUi3MultiCore;
using Microsoft.UI.Windowing;
using Microsoft.UI;
using Windows.Graphics;
using WinRT.Interop;
using System.Diagnostics;

namespace FireBrowserWinUi3.Controls
{
    public sealed partial class CreateBackup : Window
    {
        private string _backupFilePath;
        private AppWindow appWindow;
        private AppWindowTitleBar titleBar;
        public CreateBackup()
        {
            this.InitializeComponent();
            UpdateBack();
            InitializeWindow();
        }

      private async void UpdateBack()
        {
            await StartBackupProcess();

        }

        private void InitializeWindow()
        {
            var hWnd = WindowNative.GetWindowHandle(this);
            WindowId windowId = Win32Interop.GetWindowIdFromWindow(hWnd);
            appWindow = AppWindow.GetFromWindowId(windowId);

            appWindow.MoveAndResize(new RectInt32(500, 500, 850, 500));
            FireBrowserWinUi3Core.Helpers.Windowing.Center(this);
            appWindow.SetPresenter(AppWindowPresenterKind.CompactOverlay);
            appWindow.MoveInZOrderAtTop();
            appWindow.ShowOnceWithRequestedStartupState();
            appWindow.SetIcon("backup.ico");

            if (!AppWindowTitleBar.IsCustomizationSupported())
            {
                throw new Exception("Unsupported OS version.");
            }
            else
            {
                titleBar = appWindow.TitleBar;
                titleBar.ExtendsContentIntoTitleBar = true;
                var btnColor = Colors.Transparent;
                titleBar.BackgroundColor = btnColor;
                titleBar.ButtonBackgroundColor = btnColor;
                titleBar.InactiveBackgroundColor = btnColor;
                titleBar.ButtonInactiveBackgroundColor = btnColor;
            }
        }
        private async Task StartBackupProcess()
        {
            try
            {
                StatusTextBlock.Text = "Creating backup...";
                await Task.Delay(100);

                _backupFilePath = await Task.Run(() => BackupManager.CreateBackup());

                await Task.Delay(100);
                StatusTextBlock.Text = $"Backup created successfully at:\n{_backupFilePath}";

                string tempPath = Path.GetTempPath();
                string backupFilePath = Path.Combine(tempPath, "backup.fireback");

                File.Delete(backupFilePath);
                Microsoft.Windows.AppLifecycle.AppInstance.Restart("");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}