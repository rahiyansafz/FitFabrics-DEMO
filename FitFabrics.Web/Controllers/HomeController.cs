using FitFabrics.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FitFabrics.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ProductViewModel products = new();
        products.Curtains = GetCurtains();
        products.SofaCovers = GetSofaCovers();
        products.Eyelets = GetEyelets();

        return View(products);
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

    public IActionResult Curtains(int? id)
    {
        if (id is not null)
        {
            Curtain curtain = GetCurtains().FirstOrDefault(c => c.Id == id)!;
            return View(curtain);
        }
        else
        {
            return RedirectToAction("Index");
        }
    }

    public IActionResult SofaCovers(int? id)
    {
        if (id is not null)
        {
            SofaCover sofaCover = GetSofaCovers().FirstOrDefault(c => c.Id == id)!;
            return View(sofaCover);
        }
        else
        {
            return RedirectToAction("Index");
        }
    }

    public IActionResult Eyelets(int? id)
    {
        if (id is not null)
        {
            Eyelet eyelet = GetEyelets().FirstOrDefault(c => c.Id == id)!;
            return View(eyelet);
        }
        else
        {
            return RedirectToAction("Index");
        }
    }

    private List<Curtain> GetCurtains()
    {
        List<Curtain> curtains = new();
        curtains.Add(
            new Curtain
            {
                Name = "Panel Pair",
                Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
                ImageUrl = "Images/Curtains/1.png",
                Id = 1,
                ImageOne = "Images/Curtains/2.png",
                ImageTwo = "Images/Curtains/3.png",
                ImageThree = "Images/Curtains/4.png",
            });

        curtains.Add(
new Curtain
{
    Name = "Single Panel",
    Description = "With a single panel curtain, one panel covers the entire window. The curtain panel can be pulled to either side to open, and it can be tied back to create a modern, asymmetrical look. These types are at once a modern curtain style and equally timeless style – making them great in most decorative settings.",
    ImageUrl = "Images/Curtains/1.png",
    Id = 2,
    ImageOne = "Images/Curtains/2.png",
    ImageTwo = "Images/Curtains/3.png",
    ImageThree = "Images/Curtains/4.png",
});

        curtains.Add(
new Curtain
{
    Name = "Window Treatment Set",
    Description = "A window treatment set includes everything you’ll need to create a full window treatment. A window treatment set almost always includes one or two curtains and a valance. Some window kits also include accessories like tiebacks and a curtain rod, and in rare cases, they can even include a pelmet.",
    ImageUrl = "Images/Curtains/1.png",
    Id = 3,
    ImageOne = "Images/Curtains/2.png",
    ImageTwo = "Images/Curtains/3.png",
    ImageThree = "Images/Curtains/4.png",
});
        return curtains;
    }

    private List<SofaCover> GetSofaCovers()
    {
        List<SofaCover> sofaCovers = new();

        sofaCovers.Add(
                new SofaCover
                {
                    Name = "Cover One",
                    Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
                    ImageUrl = "Images/Curtains/1.png",
                    Id = 1,
                    ImageOne = "Images/Curtains/2.png",
                    ImageTwo = "Images/Curtains/3.png",
                    ImageThree = "Images/Curtains/4.png",
                }
            );

        sofaCovers.Add(
    new SofaCover
    {
        Name = "Cover Two",
        Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
        ImageUrl = "Images/Curtains/1.png",
        Id = 2,
        ImageOne = "Images/Curtains/2.png",
        ImageTwo = "Images/Curtains/3.png",
        ImageThree = "Images/Curtains/4.png",
    }
);

        sofaCovers.Add(
    new SofaCover
    {
        Name = "Cover Three",
        Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
        ImageUrl = "Images/Curtains/1.png",
        Id = 3,
        ImageOne = "Images/Curtains/2.png",
        ImageTwo = "Images/Curtains/3.png",
        ImageThree = "Images/Curtains/4.png",
    }
);

        return sofaCovers;
    }

    private List<Eyelet> GetEyelets()
    {
        List<Eyelet> eyelets = new();

        eyelets.Add(
                new Eyelet
                {
                    Name = "Eyelet One",
                    Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
                    ImageUrl = "Images/Curtains/1.png",
                    Id = 1,
                    ImageOne = "Images/Curtains/2.png",
                    ImageTwo = "Images/Curtains/3.png",
                    ImageThree = "Images/Curtains/4.png",
                }
            );

        eyelets.Add(
    new Eyelet
    {
        Name = "Eyelet Two",
        Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
        ImageUrl = "Images/Curtains/1.png",
        Id = 2,
        ImageOne = "Images/Curtains/2.png",
        ImageTwo = "Images/Curtains/3.png",
        ImageThree = "Images/Curtains/4.png",
    }
);

        eyelets.Add(
    new Eyelet
    {
        Name = "Eyelet Three",
        Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
        ImageUrl = "Images/Curtains/1.png",
        Id = 3,
        ImageOne = "Images/Curtains/2.png",
        ImageTwo = "Images/Curtains/3.png",
        ImageThree = "Images/Curtains/4.png",
    }
);
        return eyelets;
    }
}
