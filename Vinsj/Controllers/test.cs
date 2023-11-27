using System.Diagnostics;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vinsj.Data;
using Vinsj.Models;

namespace Vinsj.Controllers;
/*
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;
    private readonly ApplicationDbContext _context;
    public TestController(ILogger<TestController> logger,
        ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }
/*
    [HttpGet(Name = "GetAllDrivers")]
    public async Task<IActionResult> Get()
    {
        var test = new test()
        {
            DriverNumber = 44,
            Name = "test"
        };

        _context.Add(test);
        await _context.SaveChangesAsync();

        var allTests = await _context.Tests.ToListAsync();

        return Ok(allTests);
    }
    
}    */