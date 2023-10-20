using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FitnessAppPresentation.Models;

namespace FitnessAppPresentation.Controllers;

public class WorkoutController : Controller
{
    public IActionResult Planner()
    {
        return View();
    }
    public IActionResult Logs()
    {
        return View();
    }
}
