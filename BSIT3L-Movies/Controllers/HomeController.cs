using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel { Id = 1, Name = "Army Of Thieves", Rating = "5", ReleaseYear = 2021, Genre = "Thriller", ytid="Ith2WetKXlg",
                   ImageUrl="https://drive.google.com/uc?id=1Vcjye-8F8ZRpR1PmkWTxEC6ONHQ4-ifG" },
new MovieViewModel { Id = 2, Name = "Skycraper", Rating = "4", ReleaseYear = 2018, Genre = "Action/Thriller" , ytid="t9QePUT-Yt8",
                   ImageUrl="https://drive.google.com/uc?id=116voYuaXC9EXgRvEj6SQ-kleinRJ5OOB"},
new MovieViewModel { Id = 3, Name = "Red Notice", Rating = "5", ReleaseYear = 2021, Genre ="Action/Comedy", ytid="3yuTUnBYtic",
                   ImageUrl="https://drive.google.com/uc?id=16nJuxdUBonH05GPCMI2ts1ympPQ4DvJP" },
new MovieViewModel { Id = 4, Name = "Time to Hunt", Rating = "5", ReleaseYear = 2020, Genre = "Drama/Crime", ytid="1qFSdKY2wvk",
                   ImageUrl="https://drive.google.com/uc?id=1hMq6MGyafu-bPsAdmA91CZnmFULCOD7r" },
new MovieViewModel { Id = 5, Name = "Nowhere", Rating = "5", ReleaseYear = 2023, Genre = "Survial Thriller", ytid="KDUtdcU10YA",
                   ImageUrl="https://drive.google.com/uc?id=1L1KM3MNJpNx5oJ-s4ml5gappEDoA137b" },
new MovieViewModel { Id = 6, Name = "6 Underground", Rating = "4", ReleaseYear = 2019, Genre = "Action/Thriller", ytid="YLE85olJjp8",
                   ImageUrl="https://drive.google.com/uc?id=1br95Vt8TJHJ07zmmhLKOrq5FgCEJI-qL" },
new MovieViewModel { Id = 7, Name = "The Thieves", Rating = "4", ReleaseYear = 2012, Genre = "Drama/Action", ytid="28qTsiPhYCI",
                   ImageUrl="https://drive.google.com/uc?id=1_WwP2kSM4G0MzL52-giDSLGVljHugcKc" },
new MovieViewModel { Id = 8, Name = "Fast Furious 7", Rating = "5", ReleaseYear = 2015, Genre = "Action/Thriller", ytid="Ith2WetKXlg",
                   ImageUrl="https://drive.google.com/uc?id=15QhwRDiLv0k35ORrcyrkbtvAajeJLsPv" },
new MovieViewModel { Id = 9, Name = "Now You See Me 2", Rating = "5", ReleaseYear = 2016, Genre = "Adventure/Crime", ytid="Skpu5HaVkOc",
                   ImageUrl="https://drive.google.com/uc?id=1Uoac73rgjIUusEZy71XMshYJrZVMF_bh" },
new MovieViewModel { Id = 10, Name ="Avengers: Endgame", Rating = "5", ReleaseYear = 2019, Genre = "Action/Sci-fi", ytid="4I8rVcSQbic",
                   ImageUrl="https://drive.google.com/uc?id=1ZocPmteyx5Oa7TcO8xpWRaOx38Vs31Hv" },
new MovieViewModel { Id = 11, Name = "Retribution", Rating = "3", ReleaseYear = 2023, Genre = "Action/Thriller", ytid="TcMBFSGVi1c",
                   ImageUrl="https://drive.google.com/uc?id=1pJT9rVlIkWb7f9wBFVXDjrQG1y0qopAf" },
new MovieViewModel { Id = 12, Name = "I Want to Eat Your Pancreas", Rating = "5", ReleaseYear = 2018, Genre = "Drama/Romance", ytid="jzQn0-WH4WM",
                   ImageUrl="https://drive.google.com/uc?id=1SCbBElXjhf5PGc__JTZpinMqCnxzqx47" },
new MovieViewModel { Id = 13, Name = "Xtreme", Rating = "5", ReleaseYear = 2021, Genre = "Action/Drama/Crime/Thirller", ytid="X2O1OW6i820",
                   ImageUrl="https://drive.google.com/uc?id=1wMNuJY6CioSJAvWBxUnkBwLaQvHeTJZY" },
new MovieViewModel { Id = 14, Name = "London has Fallen", Rating = "4", ReleaseYear = 2016, Genre = "Action/Thriller", ytid="3AsOdX7NcJs",
                   ImageUrl="https://drive.google.com/uc?id=1m-iZdW2i7q9bOGXMbfQftXHxWCeZfAhA" },
new MovieViewModel { Id = 15, Name = "Minions", Rating = "5", ReleaseYear = 2015, Genre = "Family/Comedy", ytid="eisKxhjBnZ0",
                   ImageUrl="https://drive.google.com/uc?id=1ZR2Em4Xyye-moEf7ODqX2971EMoL4eMt" },
};
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
