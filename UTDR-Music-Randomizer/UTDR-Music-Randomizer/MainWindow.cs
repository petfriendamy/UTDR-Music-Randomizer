using System;
using System.IO;
using Gtk;

namespace UTDRMusicRandomizer
{
    public partial class MainWindow : Window
    {
        public MainWindow() : base(WindowType.Toplevel)
        {
            Build();
        }

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        private void ShowDialog(string message, MessageType messageType)
        {
            var dialog = new MessageDialog(null, DialogFlags.Modal, messageType, ButtonsType.Ok, message);
            dialog.Run();
            dialog.Destroy();
        }

        private void EnableOrDisableControls(bool enable)
        {
            entryInstallPath.IsEditable = enable;
            buttonBrowse.Sensitive = enable;
            buttonRandomize.Sensitive = enable;
            buttonRestore.Sensitive = enable;

            foreach (var c in fixedContainerOptions.Children)
            {
                if (c is CheckButton)
                {
                    (c as CheckButton).Sensitive = enable;
                }
            }
        }

        protected void BrowseOnClick(object sender, EventArgs e)
        {
            var search = new FileChooserDialog("Select folder", null, FileChooserAction.SelectFolder);
            search.AddButton(Stock.Cancel, ResponseType.Cancel);
            search.AddButton(Stock.Ok, ResponseType.Ok);
            search.DefaultResponse = ResponseType.Ok;
            search.SelectMultiple = false;
            if (Directory.Exists(entryInstallPath.Text))
            {
                search.SetCurrentFolder(entryInstallPath.Text);
            }

            var result = (ResponseType)search.Run();
            string path = search.Filename;
            search.Destroy();

            if (result == ResponseType.Ok)
            {
                if (Directory.Exists(path))
                {
                    if (UTDRRandomizer.IsValidPath(path))
                    {
                        entryInstallPath.Text = path;
                        buttonRandomize.Sensitive = true;
                        buttonRestore.Sensitive = true;
                    }
                    else
                    {
                        ShowDialog("Please select a valid install path.", MessageType.Error);
                    }
                }
                else
                {
                    ShowDialog("Directory doesn't exist.", MessageType.Error);
                }
            }
        }

        protected void RandomizeOnClick(object sender, EventArgs e)
        {
            if (!Directory.Exists(entryInstallPath.Text))
            {
                ShowDialog("Directory doesn't exist.", MessageType.Error);
            }
            else if (!UTDRRandomizer.IsValidPath(entryInstallPath.Text))
            {
                ShowDialog("Please select a valid install path.", MessageType.Error);
            }
            else
            {
                EnableOrDisableControls(false);
                bool makeBackup = false;
                if (UTDRRandomizer.BackupFolderExists(entryInstallPath.Text))
                {
                    var dialog = new MessageDialog(null, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo,
                        "Backup folder already exists. Overwrite it? (If you have randomized previously, this will backup the randomized files!)");
                    var answer = (ResponseType)dialog.Run();

                    if (answer == ResponseType.Yes)
                    {
                        makeBackup = true;
                    }
                    dialog.Destroy();
                }
                else { makeBackup = true; }

                var options = new RandoOptions(checkbuttonSpeedrunLegal.Active, checkbuttonCyberBattle.Active,
                    checkbuttonMultiPart.Active, checkbuttonCredits.Active, checkbuttonAmbience.Active,
                    checkbuttonSFX.Active);

                var result = UTDRRandomizer.Randomize(entryInstallPath.Text, options, makeBackup);
                ShowDialog(result.Message, (result.Success ? MessageType.Info : MessageType.Error));

                EnableOrDisableControls(true);
            }
        }

        protected void RestoreOnClick(object sender, EventArgs e)
        {
            if (!UTDRRandomizer.IsValidPath(entryInstallPath.Text))
            {
                ShowDialog("Please select a valid install path.", MessageType.Error);
            }
            else if (!UTDRRandomizer.BackupFolderExists(entryInstallPath.Text))
            {
                ShowDialog("Directory doesn't exist.", MessageType.Error);
            }
            else
            {
                EnableOrDisableControls(false);
                bool restored = UTDRRandomizer.RestoreFromBackup(entryInstallPath.Text);
                if (restored)
                {
                    ShowDialog("Restored from backup!", MessageType.Info);
                }
                else //something went wrong while restoring the backup
                {
                    ShowDialog("A fatal error occurred, and data could not be recovered. Please reinstall the game.",
                        MessageType.Error);
                }
                EnableOrDisableControls(true);
            }
        }
    }
}
