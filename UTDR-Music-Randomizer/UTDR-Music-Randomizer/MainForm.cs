using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTDRMusicRandomizer
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void EnableOrDisableControls(bool enable)
        {
            textBoxMusFolder.Enabled = enable;
            buttonBrowse.Enabled = enable;
            buttonRandomize.Enabled = enable;
            buttonRestore.Enabled = enable;

            foreach (var c in groupBoxOptions.Controls)
            {
                if (c is CheckBox)
                {
                    (c as CheckBox).Enabled = enable;
                }
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string path;

            using (var search = new FolderBrowserDialog())
            {
                result = search.ShowDialog();
                path = search.SelectedPath;
            }

            if (result == DialogResult.OK)
            {
                if (Directory.Exists(path))
                {
                    if (UTDRRandomizer.IsValidPath(path))
                    {
                        textBoxMusFolder.Text = path;
                        buttonRandomize.Enabled = true;
                        buttonRestore.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid install path.", "Invalid Path",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Directory doesn't exist.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private async void buttonRandomize_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxMusFolder.Text))
            {
                MessageBox.Show("Directory doesn't exist.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (!UTDRRandomizer.IsValidPath(textBoxMusFolder.Text))
            {
                MessageBox.Show("Please select a valid install path.", "Invalid Path",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnableOrDisableControls(false);
                bool makeBackup = false;
                if (UTDRRandomizer.BackupFolderExists(textBoxMusFolder.Text))
                {
                    var result = MessageBox.Show("Backup folder already exists. Overwrite it? (If you have randomized previously, this will backup the randomized files!)",
                            "Overwrite Backup?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        makeBackup = true;
                    }
                }
                else { makeBackup = true; }

                var options = new RandoOptions(checkBoxSpeedrunLegal.Checked, checkBoxCyberBattle.Checked,
                    checkBoxMultiPart.Checked, checkBoxCredits.Checked, checkBoxAmbience.Checked,
                    checkBoxSFX.Checked);

                Task<RandoResult> task = Task.Run(() => UTDRRandomizer.Randomize(textBoxMusFolder.Text, options, makeBackup));
                await task;

                MessageBox.Show(task.Result.Message, (task.Result.Success ? "Success" : "Error"),
                    MessageBoxButtons.OK, (task.Result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error));

                EnableOrDisableControls(true);
            }
        }

        private async void buttonRestore_Click(object sender, EventArgs e)
        {
            if (!UTDRRandomizer.IsValidPath(textBoxMusFolder.Text))
            {
                MessageBox.Show("Please select a valid install path.", "Invalid Path",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!UTDRRandomizer.BackupFolderExists(textBoxMusFolder.Text))
            {
                MessageBox.Show("Backup folder doesn't exist.", "No backup",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EnableOrDisableControls(false);
                Task<bool> task = Task.Run(() => UTDRRandomizer.RestoreFromBackup(textBoxMusFolder.Text));
                await task;
                bool restored = task.Result;
                if (restored)
                {
                    MessageBox.Show("Restored from backup!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else //something went wrong while restoring the backup
                {
                    MessageBox.Show("A fatal error occurred, and data could not be recovered. Please reinstall the game.",
                        "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                EnableOrDisableControls(true);
            }
        }
    }
}