using System.Collections.Generic;
using System.Linq;
using ClicknifeAPI.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace ClicknifeAPI.Services
{
    public class PortfolioService
    {
        private readonly IMongoCollection<Portfolio> _portolio;

        public PortfolioService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("clicknifePortfolioDB"));
            var database = client.GetDatabase("clicknifePortfolioDB");

            _portolio = database.GetCollection<Portfolio>("portfolio");
        }

        public List<Portfolio> Get()
        {
            return _portolio.Find(portfolio => true).ToList();
        }

        public Portfolio Get(string id)
        {
            return _portolio.Find<Portfolio>(portfolio => portfolio.Id == id).FirstOrDefault();
        }

        public Portfolio Create(Portfolio portfolio)
        {
            _portolio.InsertOne(portfolio);
            return portfolio;
        }

        public void Update(string id, Portfolio portIn)
        {
            _portolio.ReplaceOne(Portfolio => Portfolio.Id == id, portIn);
        }

        public void Remove(Portfolio portIn)
        {
            _portolio.DeleteOne(portfolio => portfolio.Id == portIn.Id);
        }

        public void Remove(string id)
        {
            _portolio.DeleteOne(portfolio => portfolio.Id == id);
        }

    }
}
