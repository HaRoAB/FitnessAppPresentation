using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FitnessAppPresentation.Models;
using FitnessAppPresentation.Services;
using System.Text.Json;

namespace FitnessAppPresentation.Controllers;

public class WorkoutController : Controller
{
    private readonly WorkoutApiService _workoutApiService;

    public WorkoutController(WorkoutApiService workoutApiService)
    {
        _workoutApiService = workoutApiService;
    }

    public IActionResult Planner()
    {
        return View();
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
