using System.Text.Json;
using System.Threading.Tasks;
using FitnessAppPresentation.Models;

namespace FitnessAppPresentation.Services;

public class WorkoutApiService : IWorkoutService
{

    private readonly string url = "https://localhost:5191/api/workout";
    private readonly HttpClient _httpClient;

    public WorkoutApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task Delete(string id)
    {
        throw new NotImplementedException();
    }

    public async Task Get()
    {
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        Console.WriteLine(response.Content.ToString());
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Success");
            return;
        }
        else
        {
            Console.WriteLine("Failure");
            return;
        }
    }

    public async Task Get(string id)
    {
        throw new NotImplementedException();
    }

    public async Task Create(WorkoutViewModel workoutViewModel)
    {
        try
        {
            var workoutJson = JsonSerializer.Serialize(workoutViewModel);
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(url, workoutJson);
            response.EnsureSuccessStatusCode();

        }
        catch
        {
            Console.WriteLine("Could not create item");
        }
    }

    public async Task Update(WorkoutViewModel workoutViewModel)
    {
        throw new NotImplementedException();
    }
}
