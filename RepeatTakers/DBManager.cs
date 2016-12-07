using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace RepeatTakers
{
    public class DBManager
    {
        private DBManager() { }
        SQLiteConnection dbConn;
        private const string DB_NAME = "RepeatTakers_DB.db3;";

        private static readonly DBManager instance = new DBManager();
        public static DBManager Instance
        {
            get
            {
                return Instance;
            }
        }

        public void CreateTable()
        {
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            dbConn = new SQLiteConnection(System.IO.Path.Combine(path, DB_NAME));
            dbConn.CreateTable<StudyImage>();
        }
        public void SeedTable()
        {
            //create list
            List<StudyImage> images = new List<StudyImage>();
            //load the list with objects
            var newImage = new StudyImage { ID = 1, Image = Resource.Drawable.i112, order = 1 };
            images.Add(newImage);
            newImage = new StudyImage { ID = 2, Image = Resource.Drawable.i29, order = 2 };
            images.Add(newImage);
            //insert all
            //dbConn.InsertOrReplace(new StudyImage { ID = 1, Image = 2, order= 3 });
            dbConn.InsertAll(images);
        }

        public int SaveImage(StudyImage img)
        {
            int result = dbConn.InsertOrReplace(img);
            //Console.WriteLine("Record inserted", result);
            return result;
        }

        public List<StudyImage> GetImagesFromCache()
        {
            //var ImageListData = new List<StudyImage>();
            var ImageListData = dbConn.Table<StudyImage>().ToList();

            //IEnumerable<StudyImage> table = dbConn.Table<StudyImage>();
            //foreach (StudyImage img in table)
            //{
            //    ImageListData.Add(img);
            //}
            return ImageListData;
        }
    }
}