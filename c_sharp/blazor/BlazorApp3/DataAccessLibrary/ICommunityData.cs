﻿using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ICommunityData
    {
        Task<List<CommunityModel>> GetCommunity();
        Task InsertCommunity(CommunityModel community);
        Task DeleteCommunity(CommunityModel communityDel);
        Task UpdateCommunity(CommunityModel community);

        Task<CommunityModel> getCommunitybyId(int community);
    }
}
