using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FitnessAppPresentation.Models;
using FitnessAppPresentation.Services;
using System.Text.Json;

namespace FitnessAppPresentation.Controllers;

[AutoValidateAntiforgeryToken]
public class WorkoutController : Controller
{
    private readonly WorkoutApiService _workoutApiService;

    public WorkoutController(WorkoutApiService workoutApiService)
    {
        _workoutApiService = workoutApiService;
    }

    public async Task<IActionResult> Planner()
    {
        WorkoutViewModel workoutViewModel = new()
        {
            Workouts = await _workoutApiService.Get()
        };
        return View(workoutViewModel);
    }

    [HttpPost]
    public IActionResult Planner(WorkoutViewModel workoutViewModel)
    {
        _workoutApiService.Create(workoutViewModel);
        return RedirectToAction("Planner");
    }
    public IActionResult Logs()
    {
        return View();
    }
}
