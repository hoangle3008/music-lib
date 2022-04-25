
namespace MusicLibraryProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlbumTab = new System.Windows.Forms.TabControl();
            this.SongTab = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.Button();
            this.IsExplicit = new System.Windows.Forms.CheckBox();
            this.IsSingle = new System.Windows.Forms.CheckBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.FeatArtistText = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.ComboBox();
            this.leadSingerText = new System.Windows.Forms.TextBox();
            this.albumText = new System.Windows.Forms.TextBox();
            this.SongNameText = new System.Windows.Forms.TextBox();
            this.SongIDToShow = new System.Windows.Forms.Label();
            this.ArtistTab = new System.Windows.Forms.TabPage();
            this.ArtistAll = new System.Windows.Forms.Button();
            this.ArtistUpdate = new System.Windows.Forms.Button();
            this.ArtistInsert = new System.Windows.Forms.Button();
            this.ArtistSearch = new System.Windows.Forms.Button();
            this.ArtistIDToShow = new System.Windows.Forms.Label();
            this.ArtistCountry = new System.Windows.Forms.TextBox();
            this.ArtistDebutYear = new System.Windows.Forms.TextBox();
            this.ArtistDoB = new System.Windows.Forms.DateTimePicker();
            this.ArtistName = new System.Windows.Forms.TextBox();
            this.AlbumInfoTab = new System.Windows.Forms.TabPage();
            this.AlbumAll = new System.Windows.Forms.Button();
            this.AlbumUpdate = new System.Windows.Forms.Button();
            this.AlbumInsert = new System.Windows.Forms.Button();
            this.AlbumSearch = new System.Windows.Forms.Button();
            this.LabelBox = new System.Windows.Forms.TextBox();
            this.ArtistInAlbum = new System.Windows.Forms.TextBox();
            this.AlbumIDToShow = new System.Windows.Forms.Label();
            this.AlbumName = new System.Windows.Forms.TextBox();
            this.ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.QueryResult = new System.Windows.Forms.DataGridView();
            this.HideSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AlbumTab.SuspendLayout();
            this.SongTab.SuspendLayout();
            this.ArtistTab.SuspendLayout();
            this.AlbumInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // AlbumTab
            // 
            this.AlbumTab.Controls.Add(this.SongTab);
            this.AlbumTab.Controls.Add(this.ArtistTab);
            this.AlbumTab.Controls.Add(this.AlbumInfoTab);
            this.AlbumTab.Location = new System.Drawing.Point(0, -1);
            this.AlbumTab.Margin = new System.Windows.Forms.Padding(2);
            this.AlbumTab.Name = "AlbumTab";
            this.AlbumTab.SelectedIndex = 0;
            this.AlbumTab.Size = new System.Drawing.Size(366, 516);
            this.AlbumTab.TabIndex = 0;
            // 
            // SongTab
            // 
            this.SongTab.BackgroundImage = global::MusicLibraryProject.Properties.Resources.resizedSongTabBackGround;
            this.SongTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SongTab.Controls.Add(this.Search);
            this.SongTab.Controls.Add(this.IsExplicit);
            this.SongTab.Controls.Add(this.IsSingle);
            this.SongTab.Controls.Add(this.ViewButton);
            this.SongTab.Controls.Add(this.RemoveButton);
            this.SongTab.Controls.Add(this.UpdateButton);
            this.SongTab.Controls.Add(this.AddNewButton);
            this.SongTab.Controls.Add(this.FeatArtistText);
            this.SongTab.Controls.Add(this.GenreBox);
            this.SongTab.Controls.Add(this.leadSingerText);
            this.SongTab.Controls.Add(this.albumText);
            this.SongTab.Controls.Add(this.SongNameText);
            this.SongTab.Controls.Add(this.SongIDToShow);
            this.SongTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongTab.Location = new System.Drawing.Point(4, 22);
            this.SongTab.Margin = new System.Windows.Forms.Padding(2);
            this.SongTab.Name = "SongTab";
            this.SongTab.Padding = new System.Windows.Forms.Padding(2);
            this.SongTab.Size = new System.Drawing.Size(358, 490);
            this.SongTab.TabIndex = 0;
            this.SongTab.Text = "Song";
            this.SongTab.UseVisualStyleBackColor = true;
            this.SongTab.Enter += new System.EventHandler(this.SongTab_Enter);
            // 
            // Search
            // 
            this.Search.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Search1;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(304, 46);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Search.Size = new System.Drawing.Size(50, 33);
            this.Search.TabIndex = 18;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // IsExplicit
            // 
            this.IsExplicit.AutoSize = true;
            this.IsExplicit.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Insert;
            this.IsExplicit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IsExplicit.FlatAppearance.BorderSize = 0;
            this.IsExplicit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsExplicit.Location = new System.Drawing.Point(273, 370);
            this.IsExplicit.Margin = new System.Windows.Forms.Padding(2);
            this.IsExplicit.Name = "IsExplicit";
            this.IsExplicit.Size = new System.Drawing.Size(12, 11);
            this.IsExplicit.TabIndex = 17;
            this.IsExplicit.UseVisualStyleBackColor = true;
            // 
            // IsSingle
            // 
            this.IsSingle.AutoSize = true;
            this.IsSingle.CausesValidation = false;
            this.IsSingle.FlatAppearance.BorderSize = 0;
            this.IsSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsSingle.ImageKey = "(none)";
            this.IsSingle.Location = new System.Drawing.Point(149, 370);
            this.IsSingle.Margin = new System.Windows.Forms.Padding(2);
            this.IsSingle.Name = "IsSingle";
            this.IsSingle.Size = new System.Drawing.Size(12, 11);
            this.IsSingle.TabIndex = 16;
            this.IsSingle.UseVisualStyleBackColor = true;
            // 
            // ViewButton
            // 
            this.ViewButton.BackgroundImage = global::MusicLibraryProject.Properties.Resources.All;
            this.ViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ViewButton.FlatAppearance.BorderSize = 0;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Location = new System.Drawing.Point(250, 405);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(50, 42);
            this.ViewButton.TabIndex = 15;
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Remove1;
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Location = new System.Drawing.Point(198, 405);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(50, 42);
            this.RemoveButton.TabIndex = 14;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Update;
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(146, 405);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(50, 42);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Insert1;
            this.AddNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewButton.FlatAppearance.BorderSize = 0;
            this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewButton.Location = new System.Drawing.Point(94, 405);
            this.AddNewButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(50, 42);
            this.AddNewButton.TabIndex = 12;
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // FeatArtistText
            // 
            this.FeatArtistText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FeatArtistText.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeatArtistText.Location = new System.Drawing.Point(94, 254);
            this.FeatArtistText.Margin = new System.Windows.Forms.Padding(2);
            this.FeatArtistText.Name = "FeatArtistText";
            this.FeatArtistText.Size = new System.Drawing.Size(206, 27);
            this.FeatArtistText.TabIndex = 11;
            // 
            // GenreBox
            // 
            this.GenreBox.BackColor = System.Drawing.Color.Cyan;
            this.GenreBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.Items.AddRange(new object[] {
            "Pop",
            "R&B",
            "Rock",
            "Hip Hop",
            "Alternative",
            "Country",
            "Folk",
            "Jazz",
            "Soul",
            "Dance",
            "EDM",
            "Rap"});
            this.GenreBox.Location = new System.Drawing.Point(94, 144);
            this.GenreBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(206, 28);
            this.GenreBox.TabIndex = 10;
            // 
            // leadSingerText
            // 
            this.leadSingerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leadSingerText.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadSingerText.Location = new System.Drawing.Point(94, 201);
            this.leadSingerText.Margin = new System.Windows.Forms.Padding(2);
            this.leadSingerText.Name = "leadSingerText";
            this.leadSingerText.Size = new System.Drawing.Size(206, 27);
            this.leadSingerText.TabIndex = 9;
            // 
            // albumText
            // 
            this.albumText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumText.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumText.Location = new System.Drawing.Point(94, 308);
            this.albumText.Margin = new System.Windows.Forms.Padding(2);
            this.albumText.Name = "albumText";
            this.albumText.Size = new System.Drawing.Size(206, 27);
            this.albumText.TabIndex = 8;
            // 
            // SongNameText
            // 
            this.SongNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SongNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SongNameText.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongNameText.Location = new System.Drawing.Point(94, 49);
            this.SongNameText.Margin = new System.Windows.Forms.Padding(2);
            this.SongNameText.Name = "SongNameText";
            this.SongNameText.Size = new System.Drawing.Size(206, 27);
            this.SongNameText.TabIndex = 7;
            // 
            // SongIDToShow
            // 
            this.SongIDToShow.AutoSize = true;
            this.SongIDToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongIDToShow.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SongIDToShow.Location = new System.Drawing.Point(107, 103);
            this.SongIDToShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SongIDToShow.Name = "SongIDToShow";
            this.SongIDToShow.Size = new System.Drawing.Size(65, 17);
            this.SongIDToShow.TabIndex = 6;
            this.SongIDToShow.Text = "Song ID";
            // 
            // ArtistTab
            // 
            this.ArtistTab.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Artist;
            this.ArtistTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ArtistTab.Controls.Add(this.ArtistAll);
            this.ArtistTab.Controls.Add(this.ArtistUpdate);
            this.ArtistTab.Controls.Add(this.ArtistInsert);
            this.ArtistTab.Controls.Add(this.ArtistSearch);
            this.ArtistTab.Controls.Add(this.ArtistIDToShow);
            this.ArtistTab.Controls.Add(this.ArtistCountry);
            this.ArtistTab.Controls.Add(this.ArtistDebutYear);
            this.ArtistTab.Controls.Add(this.ArtistDoB);
            this.ArtistTab.Controls.Add(this.ArtistName);
            this.ArtistTab.Location = new System.Drawing.Point(4, 22);
            this.ArtistTab.Margin = new System.Windows.Forms.Padding(2);
            this.ArtistTab.Name = "ArtistTab";
            this.ArtistTab.Padding = new System.Windows.Forms.Padding(2);
            this.ArtistTab.Size = new System.Drawing.Size(358, 490);
            this.ArtistTab.TabIndex = 1;
            this.ArtistTab.Text = "Artist";
            this.ArtistTab.UseVisualStyleBackColor = true;
            this.ArtistTab.Enter += new System.EventHandler(this.ArtistTab_Enter);
            // 
            // ArtistAll
            // 
            this.ArtistAll.BackgroundImage = global::MusicLibraryProject.Properties.Resources.All;
            this.ArtistAll.FlatAppearance.BorderSize = 0;
            this.ArtistAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.ArtistAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ArtistAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistAll.Location = new System.Drawing.Point(238, 363);
            this.ArtistAll.Name = "ArtistAll";
            this.ArtistAll.Size = new System.Drawing.Size(50, 42);
            this.ArtistAll.TabIndex = 14;
            this.ArtistAll.UseVisualStyleBackColor = true;
            this.ArtistAll.Click += new System.EventHandler(this.ArtistAll_Click);
            // 
            // ArtistUpdate
            // 
            this.ArtistUpdate.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Update;
            this.ArtistUpdate.FlatAppearance.BorderSize = 0;
            this.ArtistUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.ArtistUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ArtistUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistUpdate.Location = new System.Drawing.Point(172, 363);
            this.ArtistUpdate.Name = "ArtistUpdate";
            this.ArtistUpdate.Size = new System.Drawing.Size(50, 42);
            this.ArtistUpdate.TabIndex = 12;
            this.ArtistUpdate.UseVisualStyleBackColor = true;
            this.ArtistUpdate.Click += new System.EventHandler(this.ArtistUpdate_Click);
            // 
            // ArtistInsert
            // 
            this.ArtistInsert.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Insert1;
            this.ArtistInsert.FlatAppearance.BorderSize = 0;
            this.ArtistInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.ArtistInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ArtistInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistInsert.Location = new System.Drawing.Point(108, 363);
            this.ArtistInsert.Name = "ArtistInsert";
            this.ArtistInsert.Size = new System.Drawing.Size(50, 42);
            this.ArtistInsert.TabIndex = 11;
            this.ArtistInsert.UseVisualStyleBackColor = true;
            this.ArtistInsert.Click += new System.EventHandler(this.ArtistInsert_Click);
            // 
            // ArtistSearch
            // 
            this.ArtistSearch.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Search1;
            this.ArtistSearch.FlatAppearance.BorderSize = 0;
            this.ArtistSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistSearch.Location = new System.Drawing.Point(294, 98);
            this.ArtistSearch.Name = "ArtistSearch";
            this.ArtistSearch.Size = new System.Drawing.Size(50, 33);
            this.ArtistSearch.TabIndex = 10;
            this.ArtistSearch.UseVisualStyleBackColor = true;
            this.ArtistSearch.Click += new System.EventHandler(this.ArtistSearch_Click);
            // 
            // ArtistIDToShow
            // 
            this.ArtistIDToShow.AutoSize = true;
            this.ArtistIDToShow.Location = new System.Drawing.Point(105, 159);
            this.ArtistIDToShow.Name = "ArtistIDToShow";
            this.ArtistIDToShow.Size = new System.Drawing.Size(81, 13);
            this.ArtistIDToShow.TabIndex = 9;
            this.ArtistIDToShow.Text = "ArtistIDToShow";
            // 
            // ArtistCountry
            // 
            this.ArtistCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistCountry.Location = new System.Drawing.Point(108, 249);
            this.ArtistCountry.Name = "ArtistCountry";
            this.ArtistCountry.Size = new System.Drawing.Size(180, 29);
            this.ArtistCountry.TabIndex = 8;
            // 
            // ArtistDebutYear
            // 
            this.ArtistDebutYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistDebutYear.Location = new System.Drawing.Point(108, 300);
            this.ArtistDebutYear.Name = "ArtistDebutYear";
            this.ArtistDebutYear.Size = new System.Drawing.Size(180, 29);
            this.ArtistDebutYear.TabIndex = 7;
            // 
            // ArtistDoB
            // 
            this.ArtistDoB.Location = new System.Drawing.Point(108, 207);
            this.ArtistDoB.Name = "ArtistDoB";
            this.ArtistDoB.Size = new System.Drawing.Size(180, 20);
            this.ArtistDoB.TabIndex = 6;
            this.ArtistDoB.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // ArtistName
            // 
            this.ArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistName.Location = new System.Drawing.Point(108, 100);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(180, 29);
            this.ArtistName.TabIndex = 5;
            // 
            // AlbumInfoTab
            // 
            this.AlbumInfoTab.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Album;
            this.AlbumInfoTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlbumInfoTab.Controls.Add(this.AlbumAll);
            this.AlbumInfoTab.Controls.Add(this.AlbumUpdate);
            this.AlbumInfoTab.Controls.Add(this.AlbumInsert);
            this.AlbumInfoTab.Controls.Add(this.AlbumSearch);
            this.AlbumInfoTab.Controls.Add(this.LabelBox);
            this.AlbumInfoTab.Controls.Add(this.ArtistInAlbum);
            this.AlbumInfoTab.Controls.Add(this.AlbumIDToShow);
            this.AlbumInfoTab.Controls.Add(this.AlbumName);
            this.AlbumInfoTab.Controls.Add(this.ReleaseDate);
            this.AlbumInfoTab.Location = new System.Drawing.Point(4, 22);
            this.AlbumInfoTab.Margin = new System.Windows.Forms.Padding(2);
            this.AlbumInfoTab.Name = "AlbumInfoTab";
            this.AlbumInfoTab.Padding = new System.Windows.Forms.Padding(2);
            this.AlbumInfoTab.Size = new System.Drawing.Size(358, 490);
            this.AlbumInfoTab.TabIndex = 2;
            this.AlbumInfoTab.Text = "Album";
            this.AlbumInfoTab.UseVisualStyleBackColor = true;
            this.AlbumInfoTab.Enter += new System.EventHandler(this.AlbumInfoTab_Enter);
            // 
            // AlbumAll
            // 
            this.AlbumAll.BackgroundImage = global::MusicLibraryProject.Properties.Resources.All;
            this.AlbumAll.FlatAppearance.BorderSize = 0;
            this.AlbumAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.AlbumAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AlbumAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumAll.Location = new System.Drawing.Point(280, 368);
            this.AlbumAll.Name = "AlbumAll";
            this.AlbumAll.Size = new System.Drawing.Size(50, 42);
            this.AlbumAll.TabIndex = 17;
            this.AlbumAll.UseVisualStyleBackColor = true;
            this.AlbumAll.Click += new System.EventHandler(this.AlbumAll_Click);
            // 
            // AlbumUpdate
            // 
            this.AlbumUpdate.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Update;
            this.AlbumUpdate.FlatAppearance.BorderSize = 0;
            this.AlbumUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.AlbumUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AlbumUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumUpdate.Location = new System.Drawing.Point(201, 368);
            this.AlbumUpdate.Name = "AlbumUpdate";
            this.AlbumUpdate.Size = new System.Drawing.Size(50, 42);
            this.AlbumUpdate.TabIndex = 16;
            this.AlbumUpdate.UseVisualStyleBackColor = true;
            this.AlbumUpdate.Click += new System.EventHandler(this.AlbumUpdate_Click);
            // 
            // AlbumInsert
            // 
            this.AlbumInsert.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Insert1;
            this.AlbumInsert.FlatAppearance.BorderSize = 0;
            this.AlbumInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.AlbumInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AlbumInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumInsert.Location = new System.Drawing.Point(111, 368);
            this.AlbumInsert.Name = "AlbumInsert";
            this.AlbumInsert.Size = new System.Drawing.Size(50, 42);
            this.AlbumInsert.TabIndex = 15;
            this.AlbumInsert.UseVisualStyleBackColor = true;
            this.AlbumInsert.Click += new System.EventHandler(this.AlbumInsert_Click);
            // 
            // AlbumSearch
            // 
            this.AlbumSearch.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Search1;
            this.AlbumSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlbumSearch.FlatAppearance.BorderSize = 0;
            this.AlbumSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumSearch.Location = new System.Drawing.Point(280, 145);
            this.AlbumSearch.Name = "AlbumSearch";
            this.AlbumSearch.Size = new System.Drawing.Size(50, 33);
            this.AlbumSearch.TabIndex = 10;
            this.AlbumSearch.UseVisualStyleBackColor = true;
            this.AlbumSearch.Click += new System.EventHandler(this.AlbumSearch_Click);
            // 
            // LabelBox
            // 
            this.LabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBox.Location = new System.Drawing.Point(111, 310);
            this.LabelBox.Name = "LabelBox";
            this.LabelBox.Size = new System.Drawing.Size(219, 24);
            this.LabelBox.TabIndex = 9;
            // 
            // ArtistInAlbum
            // 
            this.ArtistInAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistInAlbum.Location = new System.Drawing.Point(111, 259);
            this.ArtistInAlbum.Name = "ArtistInAlbum";
            this.ArtistInAlbum.Size = new System.Drawing.Size(219, 24);
            this.ArtistInAlbum.TabIndex = 8;
            // 
            // AlbumIDToShow
            // 
            this.AlbumIDToShow.AutoSize = true;
            this.AlbumIDToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumIDToShow.Location = new System.Drawing.Point(108, 160);
            this.AlbumIDToShow.Name = "AlbumIDToShow";
            this.AlbumIDToShow.Size = new System.Drawing.Size(126, 18);
            this.AlbumIDToShow.TabIndex = 7;
            this.AlbumIDToShow.Text = "Album ID to Show";
            // 
            // AlbumName
            // 
            this.AlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumName.Location = new System.Drawing.Point(111, 100);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(219, 24);
            this.AlbumName.TabIndex = 6;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseDate.Location = new System.Drawing.Point(111, 206);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(219, 22);
            this.ReleaseDate.TabIndex = 5;
            this.ReleaseDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // QueryResult
            // 
            this.QueryResult.AllowUserToAddRows = false;
            this.QueryResult.AllowUserToDeleteRows = false;
            this.QueryResult.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.QueryResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryResult.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.QueryResult.Location = new System.Drawing.Point(372, 79);
            this.QueryResult.Margin = new System.Windows.Forms.Padding(2);
            this.QueryResult.Name = "QueryResult";
            this.QueryResult.ReadOnly = true;
            this.QueryResult.RowHeadersWidth = 51;
            this.QueryResult.RowTemplate.Height = 24;
            this.QueryResult.Size = new System.Drawing.Size(447, 352);
            this.QueryResult.TabIndex = 1;
            this.QueryResult.Visible = false;
            this.QueryResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QueryResult_CellContentClick);
            // 
            // HideSearchButton
            // 
            this.HideSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.HideSearchButton.BackgroundImage = global::MusicLibraryProject.Properties.Resources.HIDE;
            this.HideSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HideSearchButton.FlatAppearance.BorderSize = 0;
            this.HideSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideSearchButton.Location = new System.Drawing.Point(767, 21);
            this.HideSearchButton.Name = "HideSearchButton";
            this.HideSearchButton.Size = new System.Drawing.Size(50, 42);
            this.HideSearchButton.TabIndex = 2;
            this.HideSearchButton.UseVisualStyleBackColor = false;
            this.HideSearchButton.Click += new System.EventHandler(this.HideSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the one you want to update";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MusicLibraryProject.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HideSearchButton);
            this.Controls.Add(this.QueryResult);
            this.Controls.Add(this.AlbumTab);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Library";
            this.AlbumTab.ResumeLayout(false);
            this.SongTab.ResumeLayout(false);
            this.SongTab.PerformLayout();
            this.ArtistTab.ResumeLayout(false);
            this.ArtistTab.PerformLayout();
            this.AlbumInfoTab.ResumeLayout(false);
            this.AlbumInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AlbumTab;
        private System.Windows.Forms.TabPage SongTab;
        private System.Windows.Forms.TabPage ArtistTab;
        private System.Windows.Forms.TabPage AlbumInfoTab;
        private System.Windows.Forms.DataGridView QueryResult;
        private System.Windows.Forms.CheckBox IsExplicit;
        private System.Windows.Forms.CheckBox IsSingle;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.TextBox FeatArtistText;
        private System.Windows.Forms.ComboBox GenreBox;
        private System.Windows.Forms.TextBox leadSingerText;
        private System.Windows.Forms.TextBox albumText;
        private System.Windows.Forms.TextBox SongNameText;
        private System.Windows.Forms.Label SongIDToShow;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button HideSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ArtistDoB;
        private System.Windows.Forms.TextBox ArtistName;
        private System.Windows.Forms.Label ArtistIDToShow;
        private System.Windows.Forms.TextBox ArtistCountry;
        private System.Windows.Forms.TextBox ArtistDebutYear;
        private System.Windows.Forms.Button ArtistSearch;
        private System.Windows.Forms.Button AlbumSearch;
        private System.Windows.Forms.TextBox LabelBox;
        private System.Windows.Forms.TextBox ArtistInAlbum;
        private System.Windows.Forms.Label AlbumIDToShow;
        private System.Windows.Forms.TextBox AlbumName;
        private System.Windows.Forms.DateTimePicker ReleaseDate;
        private System.Windows.Forms.Button ArtistAll;
        private System.Windows.Forms.Button ArtistUpdate;
        private System.Windows.Forms.Button ArtistInsert;
        private System.Windows.Forms.Button AlbumAll;
        private System.Windows.Forms.Button AlbumUpdate;
        private System.Windows.Forms.Button AlbumInsert;
    }
}

