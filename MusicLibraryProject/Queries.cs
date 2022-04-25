using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace MusicLibraryProject
{
    class Queries
    {
        SqlConnection musicLibrary = new SqlConnection("Data Source=THANHQUANGPHAN;Initial Catalog=MusicLibrary;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Queries ()
        {
            musicLibrary.Open();
        }
        
        public DataTable ViewAll(string tableName)
        {
            //musicLibrary.Open();
            DataTable toShowTable = new DataTable();
            SqlCommand viewCmd = musicLibrary.CreateCommand();
            viewCmd.CommandText = $"select * from {tableName}";
            SqlDataAdapter viewResult = new SqlDataAdapter(viewCmd.CommandText, musicLibrary);
            viewResult.Fill(toShowTable);            
            //musicLibrary.Close();
            return toShowTable;
        }
        
        public DataTable Search(string searchString, string columnName, string tableName)
        {
            //musicLibrary.Open();
            DataTable toShowTable = new DataTable();
            
                string searchQuery = $"select * from {tableName} where {columnName} like '%{searchString}%'";
                SqlDataAdapter searchResult = new SqlDataAdapter(searchQuery, musicLibrary);
                searchResult.Fill(toShowTable);
               
            //musicLibrary.Close();
            return toShowTable;
        }

        public string Insert(string name, string tableName)

        {
            string ID= getID(name, tableName);
            //musicLibrary.Open();
         
            SqlCommand insertQuery = musicLibrary.CreateCommand();
            insertQuery.CommandText = $"insert into {tableName} (Id, Name) values ('{ID}','{name}')";
            insertQuery.ExecuteScalar();
            //musicLibrary.Close();
            return ID;
          
            
        }

        public void Remove ( string ID, string tableName)
        {
            //musicLibrary.Open();
            SqlCommand removeQuery = musicLibrary.CreateCommand();
            if (tableName == "featuring")
            {
                removeQuery.CommandText = $"delete from {tableName} where songID = '{ID}'";
            }
            else
            {
                removeQuery.CommandText = $"delete from {tableName} where ID = '{ID}'";
            }
            removeQuery.ExecuteScalar();

            //musicLibrary.Close();
        }

        public void Update (string id, string inputString, string fieldName, string tableName)
        {
            //musicLibrary.Open();
            SqlCommand updateQuery = musicLibrary.CreateCommand();
            updateQuery.CommandText = $"update {tableName} set {fieldName} = '{inputString}' where ID = '{id}'; ";
            updateQuery.ExecuteScalar();
            //musicLibrary.Close();
        }

        public void Update(string id, DateTime input, string fieldName, string tableName )
        {
            SqlCommand updateQuery = musicLibrary.CreateCommand();
            updateQuery.CommandText = $"update {tableName} set {fieldName} = '{input}' where ID = '{id}'; ";
            updateQuery.ExecuteScalar();
        }

        public void Update(string id, int inputString, string fieldName, string tableName)
        {
            //musicLibrary.Open();
            SqlCommand updateQuery = musicLibrary.CreateCommand();
            updateQuery.CommandText = $"update {tableName} set {fieldName} = '{inputString}' where ID = '{id}'; ";
            updateQuery.ExecuteScalar();
            //musicLibrary.Close();
        }
        private string getID(string nameString, string tableName)
        {
            string ID = "";
            string nameID = "";
            string newNameString = "";
            for (int i = 0; i < nameString.Length; i++)
            {
                if (nameString[i] != ' ')
                {
                    newNameString += nameString[i];
                }
            }
            if (newNameString.Length >= 3)
            {
                nameID = newNameString.Substring(0, 3);
            }
            else if (newNameString.Length == 2)
            {
                nameID = newNameString + "0";
            }
            else if (newNameString.Length == 1)
            {
                nameID = newNameString + "00";
            }


            //musicLibrary.Open();

            SqlCommand getCount = musicLibrary.CreateCommand();
            getCount.CommandText = $"select count(*) from {tableName};";
            Int32 numID = (Int32)getCount.ExecuteScalar();

            //musicLibrary.Close();
            numID++;
            ID = nameID + numID.ToString("D9");
            return ID;
        }

        public string GetNameFromID (string ID, string tableName)
        {
            string name;
            //musicLibrary.Open();
            SqlCommand getNameFromID = musicLibrary.CreateCommand();
            getNameFromID.CommandText = $"select name from {tableName} where id = '{ID}'";
            name = (string)getNameFromID.ExecuteScalar();
            //musicLibrary.Close();
            return name;
        }

        public List<string> GetFeaturingArtistName(string songID)
        {
            List<string> featArtistList = new List<string>();
            //musicLibrary.Open();
            SqlCommand getFeatArtistName = musicLibrary.CreateCommand();
            getFeatArtistName.CommandText = $"select artist.name from artist where artist.id in (select ArtistID from Featuring inner join song on songID = '{songID}') ";

            DataTable toShowTable = new DataTable();
             
            SqlDataAdapter searchResult = new SqlDataAdapter(getFeatArtistName.CommandText, musicLibrary);
            searchResult.Fill(toShowTable);
            

           for(int i = 0; i < toShowTable.Rows.Count;i++)
            {
                string artistName = toShowTable.Rows[i][0].ToString();

                featArtistList.Add(artistName);
            }
            //musicLibrary.Close();

            return featArtistList;
        }

        public string GetIDThatNotSong (string nameString, string tableName)
            //use to check and input artist and album from song tab
        {
            string ID;
            //musicLibrary.Open();
            SqlCommand checkID = musicLibrary.CreateCommand();
            checkID.CommandText = $"select ID from {tableName} where name = '{nameString}'";
            if(checkID.ExecuteScalar() != null)
            {
                ID = (string)checkID.ExecuteScalar();
                
            }
            else
            {
                //musicLibrary.Close();

                ID = getID(nameString, tableName);
                SqlCommand insertNew = musicLibrary.CreateCommand();
                insertNew.CommandText = $"insert into {tableName} (ID, name) values ('{ID}','{nameString}')";
                
                insertNew.ExecuteScalar();
            }
            //musicLibrary.Close();

            return ID;
        }

        public void DeleteFeatArtist(string songID)
        {
            SqlCommand deleteFeatArtist = musicLibrary.CreateCommand();
            deleteFeatArtist.CommandText = $"delete from featuring where songID = '{songID}'";
            deleteFeatArtist.ExecuteScalar();
        }

        public void UpdateFeaturingArtist(string artistID, string songID)
        {
            SqlCommand updateFeatAritst = musicLibrary.CreateCommand();
            updateFeatAritst.CommandText = $"insert into featuring values ('{artistID}','{songID}')";
            updateFeatAritst.ExecuteScalar();
        }
    }
}
