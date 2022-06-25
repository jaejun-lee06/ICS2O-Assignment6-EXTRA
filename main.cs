// Created by: Jaejun Lee
// Created on: June 2022
//
// This program accepts user input

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    public static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        string response = await client.GetStringAsync(
            "https://api.thecatapi.com/v1/images/search"
        );
        var json = System.Text.Json.JsonSerializer.Deserialize<Object>(response);
        JsonNode jsonData = JsonNode.Parse(response)!;
        JsonNode url = jsonData[0]["url"];

        Console.WriteLine("Random Cat picture " + url + " .");
        Console.WriteLine("\nDone");
    }
}