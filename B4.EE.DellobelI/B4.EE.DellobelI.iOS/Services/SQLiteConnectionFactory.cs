using System;
using B4.EE.DellobelI.Domain.Services.Abstract;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;
using SQLite.Net.Platform.XamarinIOS;
using SQLite.Net.Interop;

[assembly: Dependency(typeof(B4.EE.DellobelI.iOS.Services.SQLiteConnectionFactory))]

namespace B4.EE.DellobelI.iOS.Services
{
    internal class SQLiteConnectionFactory : ISQLiteConnectionFactory
    {
        public SQLiteConnection CreateConnection(string databaseFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = Path.Combine(path, databaseFileName);

            return new SQLiteConnection(
                new SQLitePlatformIOS(),
                path,
                SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite,
                storeDateTimeAsTicks: false
            );
        }
    }
}