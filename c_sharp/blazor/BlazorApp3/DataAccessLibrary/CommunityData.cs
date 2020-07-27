using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLibrary.Models;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CommunityData : ICommunityData
    {
        private readonly ISqlDataAccess _db;
        public CommunityData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<CommunityModel>> GetCommunity()
        {
            string sql = "select * from dbo.CommunityTable";
            return _db.LoadData<CommunityModel, dynamic>(sql, new { });
        }
        public Task InsertCommunity(CommunityModel community)
        {
            string sql = @"insert into dbo.CommunityTable (Name, Text, EmailAddress)
values (@Name, @Text, @EmailAddress);";
            return _db.SaveData(sql, community);
        }
        public Task DeleteCommunity(CommunityModel community)
        {
            string sql = @"delete from dbo.CommunityTable where Id = @uid ;";
            return _db.SaveData(sql, community);
        }
    }
}
