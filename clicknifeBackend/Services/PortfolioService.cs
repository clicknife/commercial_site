using System.Collections.Generic;
using System.Linq;
using clicknifeAPI.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace ClicknifeAPI.Services
{
    public class PortfolioService
    {
        private readonly IMongoCollection<Portfolio> _portolio;
        
    }
}
