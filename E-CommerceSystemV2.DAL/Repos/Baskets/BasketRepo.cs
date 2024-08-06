using E_CommerceSystemV2.API;
using E_CommerceSystemV2.DAL.Data.Models;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace E_CommerceSystemV2;
public class BasketRepo : IBasketRepo
{
    private readonly IDatabase _database;

    public BasketRepo(IConnectionMultiplexer redis)
    {
        _database = redis.GetDatabase();
    }

    public async Task<bool> DeleteBasketAsync(string id)
    {
       return await _database.KeyDeleteAsync(id);
    }

    public async Task<CustomerBasket?> GetBasketAsync(string id)
    {
        var data = await _database.StringGetAsync(id);
        return data.IsNullOrEmpty ? null : JsonSerializer.Deserialize<CustomerBasket>(data!);
    }

    public async Task<CustomerBasket?> UpdateBasketAsync(CustomerBasket basket)
    {
        var created = await _database.StringSetAsync(basket.Id, JsonSerializer.Serialize(basket),TimeSpan.FromDays(30));
        return await GetBasketAsync(basket.Id);

    }
}
