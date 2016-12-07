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
    [Table ("StudyImages")]
    public class StudyImage
    {
        [PrimaryKey, AutoIncrement,Column("_id")]
        public int ID { get; set; }
        [NotNull]
        public int Image { get; set; }
        public int order { get; set; }
    }
    


}