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
            string sql = "select * from CommunityTable order by CreatedDate DESC";
            //string sql = "select * from dbo.CommunityTable order by CreatedDate DESC";
            return _db.LoadData<CommunityModel, dynamic>(sql, new { });
        }
        public Task InsertCommunity(CommunityModel community)
        {
            string sql = @"insert into CommunityTable (Name, Title, Text, EmailAddress)
values (@Name, @Title, @Text, @EmailAddress);";
            //string sql = @"insert into dbo.CommunityTable (Name, Title, Text, EmailAddress)
//values (@Name, @Title, @Text, @EmailAddress);";
            return _db.SaveData(sql, community);
        }
        public Task DeleteCommunity(CommunityModel communityDel)
        {
            string sql = @"delete from CommunityTable where Id = @Id ;";
            //string sql = @"delete from dbo.CommunityTable where Id = @Id ;";
            return _db.SaveData(sql, communityDel);
        }

        public Task UpdateCommunity(CommunityModel communityUp)
        {
            string sql = @"Update CommunityTable set Name=@Name, Title = @Title, Text =@Text, EmailAddress = @EmailAddress where Id = @Id ;";
            //string sql = @"Update dbo.CommunityTable set Name=@Name, Title = @Title, Text =@Text, EmailAddress = @EmailAddress where Id = @Id ;";
            return _db.SaveData(sql, communityUp);
        }

        public Task<CommunityModel> getCommunitybyId(int community)
        {
            string sql = "select * from CommunityTable where Id = @community;";
            //string sql = "select * from dbo.CommunityTable where Id = @community;";
            return _db.LoadDataOne<CommunityModel, dynamic>(sql, new { });
        }
    }
}
