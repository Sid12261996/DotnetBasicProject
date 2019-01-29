using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectBasic.Models;
using ProjectBasic.Properties;
using MongoDB.Driver;


namespace ProjectBasic.Models
{
    public class UserModel
    {
        UserCredential User = new UserCredential();

        public MongoDatabase database;
        public UserModel()
        {
            var client = new MongoClient(Settings.Default.SignupConnectionString);
            var server = client.GetServer();
            database = server.GetDatabase(Settings.Default.Databasename);
            

        }
        public MongoCollection<UserCredential> Users => database.GetCollection<UserCredential>("users");
    }
}