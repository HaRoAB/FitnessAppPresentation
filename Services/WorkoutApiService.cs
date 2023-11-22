using System.Text.Json;
using System.Threading.Tasks;
using FitnessAppPresentation.Models;

namespace FitnessAppPresentation.Services;

public class WorkoutApiService : IService
{

    private readonly string url = Environment.GetEnvironmentVariable("WORKOUT_API_URL");
    private readonly HttpClient _httpClient;

    public WorkoutApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task Delete(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<WorkoutDTO>> Get()
    {
        try
        {
            var response = await _httpClient.GetAsync($"{url}/workout");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var workoutList = JsonSerializer.Deserialize<List<WorkoutDTO>>(json);

                if (workoutList != null)
                {
                    foreach (var workout in workoutList)
                    {
                        Console.WriteLine(workout);
                    }
                    return workoutList;
                }
            }
            else
            {
                Console.WriteLine("Received an error response from the API.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Handle the exception accordingly
        }

        return new List<WorkoutDTO>(); // Return an empty list or handle the failure case accordingly
    }


    public async Task<WorkoutDTO> Get(string id)
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
