﻿using ComedyHub.Core.Infrastructure.Gateway.Contracts;
using ComedyHub.Core.Infrastructure.NineGagModels.Models;
using ComedyHub.Core.Models;
using ComedyHub.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComedyHub.Core.Services
{
    public class NineGagFetchService : INineGagFetchService
    {
        readonly INineGagGateway _nineGagGateway;
        public NineGagFetchService(INineGagGateway nineGagGateway)
        {
            _nineGagGateway = nineGagGateway;
        }

        public async Task<NineGagModel> GetNineGagModelMeme()
        {
            return await _nineGagGateway.GetMeme();
        }
    }
}