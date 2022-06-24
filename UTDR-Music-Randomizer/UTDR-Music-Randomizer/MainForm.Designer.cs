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
            this.textBoxMusFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxSFX = new System.Windows.Forms.CheckBox();
            this.checkBoxMultiPart = new System.Windows.Forms.CheckBox();
            this.checkBoxCyberBattle = new System.Windows.Forms.CheckBox();
            this.checkBoxCredits = new System.Windows.Forms.CheckBox();
            this.checkBoxAmbience = new System.Windows.Forms.CheckBox();
            this.checkBoxSpeedrunLegal = new System.Windows.Forms.CheckBox();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMusFolder
            // 
            this.textBoxMusFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMusFolder.Location = new System.Drawing.Point(10, 23);
            this.textBoxMusFolder.Name = "textBoxMusFolder";
            this.textBoxMusFolder.Size = new System.Drawing.Size(325, 20);
            this.textBoxMusFolder.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(340, 23);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(64, 20);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please locate Undertale/Deltarune\'s install folder:";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOptions.Controls.Add(this.checkBoxSFX);
            this.groupBoxOptions.Controls.Add(this.checkBoxMultiPart);
            this.groupBoxOptions.Controls.Add(this.checkBoxCyberBattle);
            this.groupBoxOptions.Controls.Add(this.checkBoxCredits);
            this.groupBoxOptions.Controls.Add(this.checkBoxAmbience);
            this.groupBoxOptions.Controls.Add(this.checkBoxSpeedrunLegal);
            this.groupBoxOptions.Location = new System.Drawing.Point(10, 49);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(394, 156);
            this.groupBoxOptions.TabIndex = 3;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // checkBoxSFX
            // 
            this.checkBoxSFX.AutoSize = true;
            this.checkBoxSFX.Location = new System.Drawing.Point(5, 127);
            this.checkBoxSFX.Name = "checkBoxSFX";
            this.checkBoxSFX.Size = new System.Drawing.Size(326, 17);
            this.checkBoxSFX.TabIndex = 5;
            this.checkBoxSFX.Text = "Include jingles and sound effects (may have VERY BAD results)";
            this.checkBoxSFX.UseVisualStyleBackColor = true;
            // 
            // checkBoxMultiPart
            // 
            this.checkBoxMultiPart.AutoSize = true;
            this.checkBoxMultiPart.Location = new System.Drawing.Point(5, 62);
            this.checkBoxMultiPart.Name = "checkBoxMultiPart";
            this.checkBoxMultiPart.Size = new System.Drawing.Size(247, 17);
            this.checkBoxMultiPart.TabIndex = 2;
            this.checkBoxMultiPart.Text = "Include Your Best Nightmare + Finale (UT only)";
            this.checkBoxMultiPart.UseVisualStyleBackColor = true;
            // 
            // checkBoxCyberBattle
            // 
            this.checkBoxCyberBattle.AutoSize = true;
            this.checkBoxCyberBattle.Location = new System.Drawing.Point(5, 41);
            this.checkBoxCyberBattle.Name = "checkBoxCyberBattle";
            this.checkBoxCyberBattle.Size = new System.Drawing.Size(296, 17);
            this.checkBoxCyberBattle.TabIndex = 1;
            this.checkBoxCyberBattle.Text = "Include cyber_battle_prelude.ogg (DR only, may softlock)";
            this.checkBoxCyberBattle.UseVisualStyleBackColor = true;
            // 
            // checkBoxCredits
            // 
            this.checkBoxCredits.AutoSize = true;
            this.checkBoxCredits.Location = new System.Drawing.Point(5, 84);
            this.checkBoxCredits.Name = "checkBoxCredits";
            this.checkBoxCredits.Size = new System.Drawing.Size(126, 17);
            this.checkBoxCredits.TabIndex = 3;
            this.checkBoxCredits.Text = "Include credits songs";
            this.checkBoxCredits.UseVisualStyleBackColor = true;
            // 
            // checkBoxAmbience
            // 
            this.checkBoxAmbience.AutoSize = true;
            this.checkBoxAmbience.Location = new System.Drawing.Point(5, 106);
            this.checkBoxAmbience.Name = "checkBoxAmbience";
            this.checkBoxAmbience.Size = new System.Drawing.Size(110, 17);
            this.checkBoxAmbience.TabIndex = 4;
            this.checkBoxAmbience.Text = "Include ambience";
            this.checkBoxAmbience.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpeedrunLegal
            // 
            this.checkBoxSpeedrunLegal.AutoSize = true;
            this.checkBoxSpeedrunLegal.Location = new System.Drawing.Point(5, 19);
            this.checkBoxSpeedrunLegal.Name = "checkBoxSpeedrunLegal";
            this.checkBoxSpeedrunLegal.Size = new System.Drawing.Size(290, 17);
            this.checkBoxSpeedrunLegal.TabIndex = 0;
            this.checkBoxSpeedrunLegal.Text = "Include cyber.ogg and mansion.ogg (only applies to DR)";
            this.checkBoxSpeedrunLegal.UseVisualStyleBackColor = true;
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRandomize.Enabled = false;
            this.buttonRandomize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonRandomize.Location = new System.Drawing.Point(10, 210);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(394, 33);
            this.buttonRandomize.TabIndex = 4;
            this.buttonRandomize.Text = "Randomize!";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestore.Enabled = false;
            this.buttonRestore.Location = new System.Drawing.Point(10, 248);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(394, 20);
            this.buttonRestore.TabIndex = 5;
            this.buttonRestore.Text = "Restore from backup";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 278);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxMusFolder);
            this.MinimumSize = new System.Drawing.Size(388, 317);
            this.Name = "MainForm";
            this.Text = "Undertale/Deltarune Music Randomizer";
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxMusFolder;
        private Button buttonBrowse;
        private Label label1;
        private GroupBox groupBoxOptions;
        private CheckBox checkBoxAmbience;
        private CheckBox checkBoxSpeedrunLegal;
        private Button buttonRandomize;
        private CheckBox checkBoxCredits;
        private CheckBox checkBoxCyberBattle;
        private CheckBox checkBoxMultiPart;
        private CheckBox checkBoxSFX;
        private Button buttonRestore;
    }
}