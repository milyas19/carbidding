using System;
using System.Net.Http.Json;
using MongoDB.Entities;
using SearchServices.Model;

namespace SearchServices.Services;

public class AuctionSvcHttpClient
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _config;

    public AuctionSvcHttpClient(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        _config = config;
    }

    public async Task<List<Item>> GetItemsForSearchDb()
    {
      var lastUpdated = await DB.Find<Item, string>()
        .Sort(x => x.Descending(x => x.UpdatedAt))
        .Project(x => x.UpdatedAt.ToString())
        .ExecuteFirstAsync();

        lastUpdated = "2024-08-01 13:57:50"; // fordi lastupdated linje 21 fungerer ikke som forventet

        var itemList = await _httpClient.GetFromJsonAsync<List<Item>>(_config["AuctionServiceUrl"] 
                                            + "/api/auctions?date=" + lastUpdated);
        return itemList;
    }
}
