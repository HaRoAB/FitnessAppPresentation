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
            if (string.IsNullOrEmpty(url))
            {
                Console.WriteLine("URL is null or empty. Cannot make the request.");
                Console.WriteLine("url : " + url);
                return new List<WorkoutDTO>();
            }

            var response = await _httpClient.GetAsync($"{url}/workout").ConfigureAwait(false);
            Console.WriteLine("url : " + url);

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
    public async Task Update(WorkoutViewModel workoutViewModel)
    {
        throw new NotImplementedException();
    }

    public async Task<WorkoutDTO> Get(string id)
    {
        throw new NotImplementedException();
    }
    public async Task Create(WorkoutViewModel workoutViewModel)
    {
        try
        {
            if (string.IsNullOrEmpty(url))
            {
                Console.WriteLine("URL is null or empty. Cannot make the request.");
                Console.WriteLine($"Logging time: {DateTime.Now}");
                Console.WriteLine("url : " + url);
                return;
            }

            var workoutJson = JsonSerializer.Serialize(workoutViewModel);
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(url, workoutJson);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Item created successfully.");
            }
            else
            {
                Console.WriteLine($"Received an error response from the API. Status Code: {response.StatusCode}");
                Console.WriteLine($"Logging time: {DateTime.Now}");

                // Optionally, you can log the response content for further analysis
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error response content: {errorContent}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine($"Logging time: {DateTime.Now}");
            // Handle the exception accordingly
        }
    }

}
