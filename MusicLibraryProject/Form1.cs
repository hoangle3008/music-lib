using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MusicLibraryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 370;
         
        }
        Queries newQueries = new Queries();
        string tabActive = "song";
        //general use

        private void QueryResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabActive == "song")
            {
                SongIDToShow.Text = QueryResult.CurrentRow.Cells[0].Value.ToString();
                SongNameText.Text = QueryResult.CurrentRow.Cells[1].Value.ToString();
                GenreBox.SelectedItem = QueryResult.CurrentRow.Cells[2].Value;
                if (QueryResult.CurrentRow.Cells[3].Value.Equals(true))
                {
                    IsSingle.Checked = true;
                }
                if (QueryResult.CurrentRow.Cells[4].Value.Equals(true))
                {
                    IsExplicit.Checked = true;
                }

                leadSingerText.Text = newQueries.GetNameFromID(QueryResult.CurrentRow.Cells[5].Value.ToString(), "artist");
                albumText.Text = newQueries.GetNameFromID(QueryResult.CurrentRow.Cells[6].Value.ToString(), "album");

                string[] FeatArtistList = newQueries.GetFeaturingArtistName(SongIDToShow.Text).ToArray();
                FeatArtistText.Text = ""; //reset after each click
                foreach (string artistName in FeatArtistList)
                {
                    FeatArtistText.Text += artistName + ", ";
                }
            }

            if (tabActive == "artist")
            {
                ArtistIDToShow.Text = QueryResult.CurrentRow.Cells[0].Value.ToString();
                ArtistName.Text = QueryResult.CurrentRow.Cells[1].Value.ToString();
                if (DateTime.TryParse(QueryResult.CurrentRow.Cells[2].Value.ToString(), out DateTime DoB))
                { ArtistDoB.Value = DoB; }
                else { ArtistDoB.Value = DateTime.Today; }
                //ArtistDoB.Value = QueryResult.CurrentRow.Cells[2].Value.ToString();
                ArtistCountry.Text = QueryResult.CurrentRow.Cells[3].Value.ToString();
                if (DateTime.TryParse(QueryResult.CurrentRow.Cells[4].Value.ToString(), out DateTime debutYear))
                { ArtistDebutYear.Text = debutYear.Year.ToString(); }
                else { ArtistDebutYear.Text = ""; }

            }
            if (tabActive == "album")
            {
                AlbumIDToShow.Text = QueryResult.CurrentRow.Cells[0].Value.ToString();
                AlbumName.Text = QueryResult.CurrentRow.Cells[1].Value.ToString();
                if (DateTime.TryParse(QueryResult.CurrentRow.Cells[2].Value.ToString(), out DateTime release))
                { ReleaseDate.Value = release; }
                else { ReleaseDate.Value = DateTime.Today; }
                //ArtistInAlbum.Text = QueryResult.CurrentRow.Cells[3].Value.ToString();
                ArtistInAlbum.Text = newQueries.GetNameFromID(QueryResult.CurrentRow.Cells[3].Value.ToString(), "artist");
                LabelBox.Text = QueryResult.CurrentRow.Cells[4].Value.ToString();
                
            }
        }

        private void HideSearchButton_Click(object sender, EventArgs e)
        {
            this.Width = 370;
            fieldReset();
        }

        //song tab
        private void SongTab_Enter(object sender, EventArgs e)
        {
            tabActive = "song";
            QueryResult.Visible = false;
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            if(SongNameText.Text != "")
            {
                SongIDToShow.Text = newQueries.Insert(SongNameText.Text, "song");

                DoSongUpdate();
                viewSearch(SongIDToShow.Text, "ID", "song");
                MessageBox.Show("A new song has been successfully added!");
                fieldReset();
            }
            else
            {
                MessageBox.Show("No new song added");
            }
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(SongNameText.Text !="")
            {
                DoSongUpdate();
                viewSearch(SongIDToShow.Text, "ID", "song");
                MessageBox.Show("One song has been successfullyupdated!");
                fieldReset();
            }
            else
            {
                MessageBox.Show("Select a song to update!");
            }
           
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                newQueries.Remove(SongIDToShow.Text, "song");
                newQueries.Remove(SongIDToShow.Text, "featuring"); //this is to remove all record related to the removed song 
                                                                   //it's better to handle this with sql but i dont know how

                MessageBox.Show("One song has been successfully removed!");
                fieldReset();
            }
            catch
            {
                MessageBox.Show("Unable to remove the song due to the database constrant!");
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            visiableDataGrid();
            QueryResult.DataSource = newQueries.ViewAll("song");


        }

        private void Search_Click(object sender, EventArgs e)
        {
            viewSearch(SongNameText.Text, "name", "song");
        }



        //artist tab     
        private void ArtistTab_Enter(object sender, EventArgs e)
        {
            tabActive = "artist";
            QueryResult.Visible = false;
        }

        private void ArtistSearch_Click(object sender, EventArgs e)
        {
            viewSearch(ArtistName.Text, "name","artist");
            
        }                      
                
        private void ArtistAll_Click(object sender, EventArgs e)
        {
            visiableDataGrid();
            QueryResult.DataSource = newQueries.ViewAll("artist");
        }

        private void ArtistInsert_Click(object sender, EventArgs e)
        {
            if(ArtistName.Text != "")
            {
                ArtistIDToShow.Text = newQueries.GetIDThatNotSong(ArtistName.Text, "artist");
                doArtistUpdate();
                viewSearch(ArtistIDToShow.Text, "ID", "artist");
                //do update for other fields
                MessageBox.Show("A new artist has been successfully added!");

                fieldReset();
            }
            else
            {
                MessageBox.Show("No new artist added.");
            }
        }

        private void ArtistUpdate_Click(object sender, EventArgs e)
        {
            if (ArtistName.Text != "")
            {
                doArtistUpdate();
                viewSearch(ArtistIDToShow.Text, "ID", "artist");
                MessageBox.Show("An artist has been successfully updated!");
                fieldReset();
            }
            else
            {
                MessageBox.Show("Select an artist to update!");
            }
                
        }


        //album tab
        private void AlbumInfoTab_Enter(object sender, EventArgs e)
        {
            tabActive = "album";
            QueryResult.Visible = false;
        }

        private void AlbumSearch_Click(object sender, EventArgs e)
        {
            viewSearch(albumText.Text, "name", "album");
        }

        private void AlbumAll_Click(object sender, EventArgs e)
        {
            visiableDataGrid();
            QueryResult.DataSource = newQueries.ViewAll("album");
        }

        private void AlbumInsert_Click(object sender, EventArgs e)
        {
            if(AlbumName.Text != "")
            {
                AlbumIDToShow.Text = newQueries.GetIDThatNotSong(albumText.Text, "album");
                doAlbumUpdate();
                MessageBox.Show("A new album has been successfully added!");
                fieldReset();
            }
            else
            {
                MessageBox.Show("No new album added");
            }
           
        }

        private void AlbumUpdate_Click(object sender, EventArgs e)
        {
            if (AlbumName.Text != "")
            {
                doAlbumUpdate();
                viewSearch(AlbumIDToShow.Text, "ID", "artist");
                MessageBox.Show("An album has been successfully updated!");
                fieldReset();
            }
            else
            {
                MessageBox.Show("Select an album to update.");
            }
            
        }




        //methods to call
        private void fieldReset()
        {
            SongNameText.Text = "";
            leadSingerText.Text = "";
            IsExplicit.Checked = false;
            IsSingle.Checked = false;
            GenreBox.SelectedItem = null;
            FeatArtistText.Text = "";
            SongIDToShow.Text = "";
            albumText.Text = "";
        }

        private void viewSearch(string searchString, string columnName, string tableName)
        {
            visiableDataGrid();
            QueryResult.DataSource = newQueries.Search(searchString, columnName, tableName);
            fieldReset();
        }

        private void DoSongUpdate()
        {


            //newQueries.Update(SongIDToShow.Text, leadSingerText.Text, "leadArtist", "song");
            newQueries.Update(SongIDToShow.Text, SongNameText.Text, "name", "song");
            if (GenreBox.SelectedItem != null)
            {
                newQueries.Update(SongIDToShow.Text, GenreBox.SelectedItem.ToString(), "genre", "song");
            }


            if (IsExplicit.Checked)
            {
                newQueries.Update(SongIDToShow.Text, 1, "IsExplicit", "song");
            }
            else
            {
                newQueries.Update(SongIDToShow.Text, 0, "IsExplicit", "song");
            }

            if (IsSingle.Checked)
            {
                newQueries.Update(SongIDToShow.Text, 1, "IsSingle", "song");
            }
            else
            {
                newQueries.Update(SongIDToShow.Text, 0, "IsSingle", "song");
            }
            if (leadSingerText.Text != "")
            {
                string leadSingerID = newQueries.GetIDThatNotSong(leadSingerText.Text, "artist");
                newQueries.Update(SongIDToShow.Text, leadSingerID, "leadArtist", "song");
            }

            if (albumText.Text != "")
            {
                string albumID = newQueries.GetIDThatNotSong(albumText.Text, "album");
                newQueries.Update(SongIDToShow.Text, albumID, "album", "song");
            }

            if (FeatArtistText.Text != "")
            {
                newQueries.DeleteFeatArtist(SongIDToShow.Text);
                string[] featArtistList = FeatArtistText.Text.Split(',');
                foreach (string featArtist in featArtistList)
                {
                    if(featArtist != "")
                    {
                        string artistID = newQueries.GetIDThatNotSong(featArtist.Trim(), "artist");
                        newQueries.UpdateFeaturingArtist(artistID, SongIDToShow.Text);
                    }
                    
                }
            }
            fieldReset();

        }

        private void doArtistUpdate()
        {
            if(ArtistCountry.Text !="")
            {
                newQueries.Update(ArtistIDToShow.Text, ArtistCountry.Text, "country", "artist");
            }
            if(Int32.TryParse(ArtistDebutYear.Text, out int debutYear))
            {
                newQueries.Update(ArtistIDToShow.Text,debutYear,"DebutYear","Artist");
            }
            if (DateTime.TryParse(ArtistDoB.Value.ToShortDateString(), out DateTime DOB))
            {
                newQueries.Update(ArtistIDToShow.Text, DOB.ToShortDateString(), "DoB", "Artist");
                //default DoB is 01/01/1900
            }
        }     

        private void resetDataGrid()
        {
            QueryResult.CancelEdit();
            QueryResult.Columns.Clear();
            QueryResult.DataSource = null;

        }

        private void visiableDataGrid()
        {
            this.Width = 825;
            QueryResult.Visible = true;
            resetDataGrid();
        }

        private void doAlbumUpdate()
        {
            if(LabelBox.Text != "")
            {
                newQueries.Update(AlbumIDToShow.Text, LabelBox.Text, "label", "album");
            }
            if(ArtistInAlbum.Text != "")
            {
                string singerID = newQueries.GetIDThatNotSong(ArtistInAlbum.Text, "artist");
                newQueries.Update(AlbumIDToShow.Text, singerID, "Artist", "Album");
            }
            if (DateTime.TryParse( ReleaseDate.Value.ToShortDateString(), out DateTime releaseDate))
            {
                newQueries.Update(AlbumIDToShow.Text, releaseDate, "releaseDate", "album");
                //default release date is 01/01/1900
            }
            fieldReset();
        }
    }
}