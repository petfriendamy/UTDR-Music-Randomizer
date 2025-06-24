
namespace UTDRMusicRandomizer
{
	public partial class MainWindow
	{
		private global::Gtk.Fixed fixedContainerMain;

		private global::Gtk.Frame frameOptions;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.Fixed fixedContainerOptions;

		private global::Gtk.CheckButton checkbuttonSpeedrunLegal;

		private global::Gtk.CheckButton checkbuttonCyberBattle;

		private global::Gtk.CheckButton checkbuttonMultiPart;

		private global::Gtk.CheckButton checkbuttonAmbience;

		private global::Gtk.CheckButton checkbuttonSFX;

		private global::Gtk.CheckButton checkbuttonCredits;

		private global::Gtk.Label GtkLabelOptions;

		private global::Gtk.Entry entryInstallPath;

		private global::Gtk.Button buttonBrowse;

		private global::Gtk.Label labelInstallPath;

		private global::Gtk.Button buttonRandomize;

		private global::Gtk.Button buttonRestore;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget GtkTest.MainWindow
			this.Name = "GtkTest.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("UTDR Music Randomizer");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(10));
			this.Resizable = false;
			//this.AllowGrow = false;
			// Container child GtkTest.MainWindow.Gtk.Container+ContainerChild
			this.fixedContainerMain = new global::Gtk.Fixed();
			this.fixedContainerMain.Name = "fixedContainerMain";
			this.fixedContainerMain.HasWindow = false;
			// Container child fixedContainerMain.Gtk.Fixed+FixedChild
			this.frameOptions = new global::Gtk.Frame();
			this.frameOptions.WidthRequest = 520;
			this.frameOptions.HeightRequest = 180;
			this.frameOptions.Name = "frameOptions";
			this.frameOptions.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frameOptions.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.WidthRequest = 366;
			this.GtkAlignment.HeightRequest = 132;
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			this.GtkAlignment.BorderWidth = ((uint)(1));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.fixedContainerOptions = new global::Gtk.Fixed();
			this.fixedContainerOptions.Name = "fixedContainerOptions";
			this.fixedContainerOptions.HasWindow = false;
			// Container child fixedContainerOptions.Gtk.Fixed+FixedChild
			this.checkbuttonSpeedrunLegal = new global::Gtk.CheckButton();
			this.checkbuttonSpeedrunLegal.CanFocus = true;
			this.checkbuttonSpeedrunLegal.Name = "checkbuttonSpeedrunLegal";
			this.checkbuttonSpeedrunLegal.Label = global::Mono.Unix.Catalog.GetString("Include cyber.ogg and mansion.ogg (applies to DR only)");
			this.checkbuttonSpeedrunLegal.DrawIndicator = true;
			this.checkbuttonSpeedrunLegal.UseUnderline = true;
			this.fixedContainerOptions.Add(this.checkbuttonSpeedrunLegal);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerOptions[this.checkbuttonSpeedrunLegal]));
			w1.Y = 5;
			// Container child fixedContainerOptions.Gtk.Fixed+FixedChild
			this.checkbuttonCyberBattle = new global::Gtk.CheckButton();
			this.checkbuttonCyberBattle.CanFocus = true;
			this.checkbuttonCyberBattle.Name = "checkbuttonCyberBattle";
			this.checkbuttonCyberBattle.Label = global::Mono.Unix.Catalog.GetString("Include cyber_battle_prelude.ogg (DR only, may cause softlocks)");
			this.checkbuttonCyberBattle.DrawIndicator = true;
			this.fixedContainerOptions.Add(this.checkbuttonCyberBattle);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerOptions[this.checkbuttonCyberBattle]));
			w2.Y = 30;
			// Container child fixedContainerOptions.Gtk.Fixed+FixedChild
			this.checkbuttonMultiPart = new global::Gtk.CheckButton();
			this.checkbuttonMultiPart.CanFocus = true;
			this.checkbuttonMultiPart.Name = "checkbuttonMultiPart";
			this.checkbuttonMultiPart.Label = global::Mono.Unix.Catalog.GetString("Include Your Best Nightmare + Finale (UT only)");
			this.checkbuttonMultiPart.DrawIndicator = true;
			this.fixedContainerOptions.Add(this.checkbuttonMultiPart);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerOptions[this.checkbuttonMultiPart]));
			w3.Y = 55;
			// Container child fixedContainerOptions.Gtk.Fixed+FixedChild
			this.checkbuttonAmbience = new global::Gtk.CheckButton();
			this.checkbuttonAmbience.CanFocus = true;
			this.checkbuttonAmbience.Name = "checkbuttonAmbience";
			this.checkbuttonAmbience.Label = global::Mono.Unix.Catalog.GetString("Include ambient sounds");
			this.checkbuttonAmbience.DrawIndicator = true;
			this.checkbuttonAmbience.UseUnderline = true;
			this.fixedContainerOptions.Add(this.checkbuttonAmbience);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerOptions[this.checkbuttonAmbience]));
			w4.Y = 105;
			// Container child fixedContainerOptions.Gtk.Fixed+FixedChild
			this.checkbuttonSFX = new global::Gtk.CheckButton();
			this.checkbuttonSFX.CanFocus = true;
			this.checkbuttonSFX.Name = "checkbuttonSFX";
			this.checkbuttonSFX.Label = global::Mono.Unix.Catalog.GetString("Include jingles and SFX (may have VERY BAD results)");
			this.checkbuttonSFX.DrawIndicator = true;
			this.checkbuttonSFX.UseUnderline = true;
			this.fixedContainerOptions.Add(this.checkbuttonSFX);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerOptions[this.checkbuttonSFX]));
			w5.Y = 130;
			// Container child fixedContainerOptions.Gtk.Fixed+FixedChild
			this.checkbuttonCredits = new global::Gtk.CheckButton();
			this.checkbuttonCredits.CanFocus = true;
			this.checkbuttonCredits.Name = "checkbuttonCredits";
			this.checkbuttonCredits.Label = global::Mono.Unix.Catalog.GetString("Include credits songs");
			this.checkbuttonCredits.DrawIndicator = true;
			this.checkbuttonCredits.UseUnderline = true;
			this.fixedContainerOptions.Add(this.checkbuttonCredits);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerOptions[this.checkbuttonCredits]));
			w6.Y = 80;
			this.GtkAlignment.Add(this.fixedContainerOptions);
			this.frameOptions.Add(this.GtkAlignment);
			this.GtkLabelOptions = new global::Gtk.Label();
			this.GtkLabelOptions.Name = "GtkLabelOptions";
			this.GtkLabelOptions.LabelProp = global::Mono.Unix.Catalog.GetString("Options");
			this.frameOptions.LabelWidget = this.GtkLabelOptions;
			this.fixedContainerMain.Add(this.frameOptions);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerMain[this.frameOptions]));
			w9.X = 5;
			w9.Y = 65;
			// Container child fixedContainerMain.Gtk.Fixed+FixedChild
			this.entryInstallPath = new global::Gtk.Entry();
			this.entryInstallPath.WidthRequest = 430;
			this.entryInstallPath.CanFocus = true;
			this.entryInstallPath.Name = "entryInstallPath";
			this.entryInstallPath.IsEditable = true;
			this.entryInstallPath.InvisibleChar = '•';
			this.fixedContainerMain.Add(this.entryInstallPath);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerMain[this.entryInstallPath]));
			w10.X = 5;
			w10.Y = 30;
			// Container child fixedContainerMain.Gtk.Fixed+FixedChild
			this.buttonBrowse = new global::Gtk.Button();
			this.buttonBrowse.WidthRequest = 90;
			this.buttonBrowse.CanFocus = true;
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.UseUnderline = true;
			this.buttonBrowse.Label = "Browse...";
			this.fixedContainerMain.Add(this.buttonBrowse);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerMain[this.buttonBrowse]));
			w11.X = 440;
			w11.Y = 28;
			// Container child fixedContainerMain.Gtk.Fixed+FixedChild
			this.labelInstallPath = new global::Gtk.Label();
			this.labelInstallPath.Name = "labelInstallPath";
			this.labelInstallPath.LabelProp = global::Mono.Unix.Catalog.GetString("Please locate Undertale/Deltarune\'s install path:");
			this.fixedContainerMain.Add(this.labelInstallPath);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerMain[this.labelInstallPath]));
			w12.X = 5;
			w12.Y = 5;
			// Container child fixedContainerMain.Gtk.Fixed+FixedChild
			this.buttonRandomize = new global::Gtk.Button();
			this.buttonRandomize.WidthRequest = 520;
			this.buttonRandomize.HeightRequest = 40;
			this.buttonRandomize.Sensitive = false;
			this.buttonRandomize.CanFocus = true;
			this.buttonRandomize.Name = "buttonRandomize";
			this.buttonRandomize.UseUnderline = true;
			this.buttonRandomize.Label = global::Mono.Unix.Catalog.GetString("Randomize!");
			this.fixedContainerMain.Add(this.buttonRandomize);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerMain[this.buttonRandomize]));
			w13.X = 5;
			w13.Y = 255;
			// Container child fixedContainerMain.Gtk.Fixed+FixedChild
			this.buttonRestore = new global::Gtk.Button();
			this.buttonRestore.WidthRequest = 520;
			this.buttonRestore.Sensitive = false;
			this.buttonRestore.CanFocus = true;
			this.buttonRestore.Name = "buttonRestore";
			this.buttonRestore.UseUnderline = true;
			this.buttonRestore.Label = global::Mono.Unix.Catalog.GetString("Restore from backup");
			this.fixedContainerMain.Add(this.buttonRestore);
			global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixedContainerMain[this.buttonRestore]));
			w14.X = 5;
			w14.Y = 300;
			this.Add(this.fixedContainerMain);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 560;
			this.DefaultHeight = 363;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.buttonBrowse.Clicked += new global::System.EventHandler(this.BrowseOnClick);
			this.buttonRandomize.Clicked += new global::System.EventHandler(this.RandomizeOnClick);
			this.buttonRestore.Clicked += new global::System.EventHandler(this.RestoreOnClick);
		}
	}
}
