using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkyLine.Models;
using SkyLine.Repositories;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SkyLine.Areas.Customer.Controllers;

[Area(SD.CustomerArea)]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository<Flight> _flight;
    private readonly IRepository<FlightSegment> _Segment;

    public HomeController(ILogger<HomeController> logger, IRepository<Flight> flight1, IRepository<FlightSegment> segment)
    {
        _logger = logger;
        _flight = flight1;
        _Segment = segment;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Results()
    {

        var flights = await _flight.GetAsync(includes: [e => e.AirLine!, e => e.LeavingAirport!, e => e.ArriveAirport!]);

        return View(flights.ToList());
    }


    public async Task<IActionResult> Details([FromRoute]int id)
    {

       
        var flights22 = await _flight.GetOneAsync(includes: [e => e.AirLine!, e => e.LeavingAirport!.city, e => e.ArriveAirport!.city],expression: e=>e.Flight_Id_PK == id);
        var Segment = await _Segment.GetAsync(expression: e => e.Flight_ID_Fk == id, includes: [e=>e.DepartureAirport!.city, e=>e.ArrivalAirport!.city]);

        InitialClass Initial = new InitialClass()
        {
            flights = flights22,
            flightSegment = Segment

        };
        return View(Initial);
    }




}
