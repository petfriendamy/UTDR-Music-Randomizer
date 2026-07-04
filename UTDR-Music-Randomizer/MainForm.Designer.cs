using System.Windows.Forms;

namespace UTDRMusicRandomizer
{
    partial class MainForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textBoxBrowse = new TextBox();
            buttonBrowse = new Button();
            labelBrowse = new Label();
            groupBoxOptions = new GroupBox();
            checkBoxKrisPiano = new CheckBox();
            checkBoxRhythmGame = new CheckBox();
            checkBoxSFX = new CheckBox();
            checkBoxMultiPart = new CheckBox();
            checkBoxCyberBattle = new CheckBox();
            checkBoxCredits = new CheckBox();
            checkBoxAmbience = new CheckBox();
            checkBoxSpeedrunLegal = new CheckBox();
            buttonRandomize = new Button();
            buttonRestore = new Button();
            checkBoxShortSongs = new CheckBox();
            groupBoxOptions.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxBrowse
            // 
            textBoxBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBrowse.Location = new Point(12, 27);
            textBoxBrowse.Margin = new Padding(4, 3, 4, 3);
            textBoxBrowse.Name = "textBoxBrowse";
            textBoxBrowse.Size = new Size(359, 23);
            textBoxBrowse.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBrowse.Location = new Point(377, 27);
            buttonBrowse.Margin = new Padding(4, 3, 4, 3);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(75, 23);
            buttonBrowse.TabIndex = 1;
            buttonBrowse.Text = "Browse...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // labelBrowse
            // 
            labelBrowse.AutoSize = true;
            labelBrowse.Location = new Point(12, 9);
            labelBrowse.Margin = new Padding(4, 0, 4, 0);
            labelBrowse.Name = "labelBrowse";
            labelBrowse.Size = new Size(332, 15);
            labelBrowse.TabIndex = 2;
            labelBrowse.Text = "Please locate the folder containing Undertale/Deltarune's EXE:";
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOptions.Controls.Add(checkBoxShortSongs);
            groupBoxOptions.Controls.Add(checkBoxKrisPiano);
            groupBoxOptions.Controls.Add(checkBoxRhythmGame);
            groupBoxOptions.Controls.Add(checkBoxSFX);
            groupBoxOptions.Controls.Add(checkBoxMultiPart);
            groupBoxOptions.Controls.Add(checkBoxCyberBattle);
            groupBoxOptions.Controls.Add(checkBoxCredits);
            groupBoxOptions.Controls.Add(checkBoxAmbience);
            groupBoxOptions.Controls.Add(checkBoxSpeedrunLegal);
            groupBoxOptions.Location = new Point(12, 57);
            groupBoxOptions.Margin = new Padding(4, 3, 4, 3);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Padding = new Padding(4, 3, 4, 3);
            groupBoxOptions.Size = new Size(440, 261);
            groupBoxOptions.TabIndex = 3;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Options";
            // 
            // checkBoxKrisPiano
            // 
            checkBoxKrisPiano.AutoSize = true;
            checkBoxKrisPiano.Location = new Point(6, 122);
            checkBoxKrisPiano.Name = "checkBoxKrisPiano";
            checkBoxKrisPiano.Size = new Size(209, 19);
            checkBoxKrisPiano.TabIndex = 7;
            checkBoxKrisPiano.Text = "Include Kris' piano songs (DR only)";
            checkBoxKrisPiano.UseVisualStyleBackColor = true;
            // 
            // checkBoxRhythmGame
            // 
            checkBoxRhythmGame.AutoSize = true;
            checkBoxRhythmGame.Location = new Point(6, 197);
            checkBoxRhythmGame.Margin = new Padding(4, 3, 4, 3);
            checkBoxRhythmGame.Name = "checkBoxRhythmGame";
            checkBoxRhythmGame.Size = new Size(356, 19);
            checkBoxRhythmGame.TabIndex = 6;
            checkBoxRhythmGame.Text = "Include rhythm game songs (DR only, may sound REALLY bad)";
            checkBoxRhythmGame.UseVisualStyleBackColor = true;
            // 
            // checkBoxSFX
            // 
            checkBoxSFX.AutoSize = true;
            checkBoxSFX.Location = new Point(6, 222);
            checkBoxSFX.Margin = new Padding(4, 3, 4, 3);
            checkBoxSFX.Name = "checkBoxSFX";
            checkBoxSFX.Size = new Size(314, 19);
            checkBoxSFX.TabIndex = 5;
            checkBoxSFX.Text = "Include jingles and sound effects (may be even worse!)";
            checkBoxSFX.UseVisualStyleBackColor = true;
            // 
            // checkBoxMultiPart
            // 
            checkBoxMultiPart.AutoSize = true;
            checkBoxMultiPart.Location = new Point(6, 72);
            checkBoxMultiPart.Margin = new Padding(4, 3, 4, 3);
            checkBoxMultiPart.Name = "checkBoxMultiPart";
            checkBoxMultiPart.Size = new Size(313, 19);
            checkBoxMultiPart.TabIndex = 2;
            checkBoxMultiPart.Text = "Include multi-part and layered songs (may sound bad)";
            checkBoxMultiPart.UseVisualStyleBackColor = true;
            // 
            // checkBoxCyberBattle
            // 
            checkBoxCyberBattle.AutoSize = true;
            checkBoxCyberBattle.Location = new Point(6, 47);
            checkBoxCyberBattle.Margin = new Padding(4, 3, 4, 3);
            checkBoxCyberBattle.Name = "checkBoxCyberBattle";
            checkBoxCyberBattle.Size = new Size(327, 19);
            checkBoxCyberBattle.TabIndex = 1;
            checkBoxCyberBattle.Text = "Include cyber_battle_prelude.ogg (DR only, may softlock)";
            checkBoxCyberBattle.UseVisualStyleBackColor = true;
            // 
            // checkBoxCredits
            // 
            checkBoxCredits.AutoSize = true;
            checkBoxCredits.Location = new Point(6, 97);
            checkBoxCredits.Margin = new Padding(4, 3, 4, 3);
            checkBoxCredits.Name = "checkBoxCredits";
            checkBoxCredits.Size = new Size(137, 19);
            checkBoxCredits.TabIndex = 3;
            checkBoxCredits.Text = "Include credits songs";
            checkBoxCredits.UseVisualStyleBackColor = true;
            // 
            // checkBoxAmbience
            // 
            checkBoxAmbience.AutoSize = true;
            checkBoxAmbience.Location = new Point(6, 172);
            checkBoxAmbience.Margin = new Padding(4, 3, 4, 3);
            checkBoxAmbience.Name = "checkBoxAmbience";
            checkBoxAmbience.Size = new Size(120, 19);
            checkBoxAmbience.TabIndex = 4;
            checkBoxAmbience.Text = "Include ambience";
            checkBoxAmbience.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpeedrunLegal
            // 
            checkBoxSpeedrunLegal.AutoSize = true;
            checkBoxSpeedrunLegal.Location = new Point(6, 22);
            checkBoxSpeedrunLegal.Margin = new Padding(4, 3, 4, 3);
            checkBoxSpeedrunLegal.Name = "checkBoxSpeedrunLegal";
            checkBoxSpeedrunLegal.Size = new Size(238, 19);
            checkBoxSpeedrunLegal.TabIndex = 0;
            checkBoxSpeedrunLegal.Text = "Keep speedrun legal (only applies to DR)";
            checkBoxSpeedrunLegal.UseVisualStyleBackColor = true;
            // 
            // buttonRandomize
            // 
            buttonRandomize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonRandomize.Enabled = false;
            buttonRandomize.Font = new Font("Segoe UI", 12F);
            buttonRandomize.Location = new Point(12, 323);
            buttonRandomize.Margin = new Padding(4, 3, 4, 3);
            buttonRandomize.Name = "buttonRandomize";
            buttonRandomize.Size = new Size(440, 38);
            buttonRandomize.TabIndex = 4;
            buttonRandomize.Text = "Randomize!";
            buttonRandomize.UseVisualStyleBackColor = true;
            buttonRandomize.Click += buttonRandomize_Click;
            // 
            // buttonRestore
            // 
            buttonRestore.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonRestore.Enabled = false;
            buttonRestore.Location = new Point(12, 367);
            buttonRestore.Margin = new Padding(4, 3, 4, 3);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new Size(440, 23);
            buttonRestore.TabIndex = 5;
            buttonRestore.Text = "Restore from backup";
            buttonRestore.UseVisualStyleBackColor = true;
            buttonRestore.Click += buttonRestore_Click;
            // 
            // checkBoxShortSongs
            // 
            checkBoxShortSongs.AutoSize = true;
            checkBoxShortSongs.Location = new Point(6, 147);
            checkBoxShortSongs.Name = "checkBoxShortSongs";
            checkBoxShortSongs.Size = new Size(205, 19);
            checkBoxShortSongs.TabIndex = 8;
            checkBoxShortSongs.Text = "Include short songs (e.g. KEYGEN)";
            checkBoxShortSongs.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 401);
            Controls.Add(buttonRestore);
            Controls.Add(buttonRandomize);
            Controls.Add(groupBoxOptions);
            Controls.Add(labelBrowse);
            Controls.Add(buttonBrowse);
            Controls.Add(textBoxBrowse);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(410, 440);
            Name = "MainForm";
            Text = "Undertale/Deltarune Music Randomizer";
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox textBoxBrowse;
        private Button buttonBrowse;
        private Label labelBrowse;
        private GroupBox groupBoxOptions;
        private CheckBox checkBoxAmbience;
        private CheckBox checkBoxSpeedrunLegal;
        private Button buttonRandomize;
        private CheckBox checkBoxCredits;
        private CheckBox checkBoxCyberBattle;
        private CheckBox checkBoxMultiPart;
        private CheckBox checkBoxSFX;
        private Button buttonRestore;
        private CheckBox checkBoxRhythmGame;
        private CheckBox checkBoxKrisPiano;
        private CheckBox checkBoxShortSongs;
    }
}