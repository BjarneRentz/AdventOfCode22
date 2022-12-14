// See https://aka.ms/new-console-template for more information

using AdventOfCode22.Challenges;

Console.WriteLine("Hello, World!");

var cookie = Environment.GetEnvironmentVariable("AOC_COOKIE");

using var httpClient = new HttpClient();

var message = new HttpRequestMessage();
message.Headers.Add("Cookie", cookie);
message.Method  = HttpMethod.Get;
message.RequestUri = new Uri("https://adventofcode.com/2022/day/1/input");

var result = await httpClient.SendAsync(message);
var challengeInput = await result.Content.ReadAsStringAsync();

var challenge = new Challenge1();

challenge.Solve(challengeInput);