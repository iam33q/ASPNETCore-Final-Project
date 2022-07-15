using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using build.Models;
using build.Views.Home;
using build.Models.InputModels;
namespace build.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public ActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public ActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public ActionResult TenantView(){
        //Retrieve target Tenant object, and pass it below:
        return View();
    }
    public ActionResult BalanceView(){
        //Retrieve target Tenant object, and pass it below:
        return View();
    }
    public ActionResult Dashboard(){
        //Compute and return aggregate property status
        //List Properties
        //List upcoming events
        //List recent transactions
        //Pass all this data below
        return View();
    }
    // public ActionResult AddProperty(AddPropertyInput model){
    //     Address add = new Address();
    //     add.number = model.inputAddress0;
    //     add.street = model.inputAddress1;
    //     add.city   = model.inputAddress2;
    //     add.postCode=model.inputAddress3;
    //     Property newprop = Property.createProperty(model.inputName, add, model.inputDescription);
    //     return RedirectToAction("PropertyView","Home",newprop);
    // }
    // public ActionResult PropertyView(Property newprop){
    //     PropertyView model = the_data;
    //     if (build.Views.Home.PropertyView.proplist.Count == 0){
    //         build.Views.Home.PropertyView.proplist.Add(new Property());
    //         build.Views.Home.PropertyView.proplist.Add(new Property());
    //         build.Views.Home.PropertyView.proplist.Add(new Property());
    //     }
    //     return View(model);
    // }
}