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
                ImageUrl = "Images/Curtains/2.jpg",
                Id = 1,
                ImageOne = "Images/Curtains/3.jpg",
                ImageTwo = "Images/Curtains/8.jpg",
                ImageThree = "Images/Curtains/9.jpg",
            });

        curtains.Add(
new Curtain
{
    Name = "Single Panel",
    Description = "With a single panel curtain, one panel covers the entire window. The curtain panel can be pulled to either side to open, and it can be tied back to create a modern, asymmetrical look. These types are at once a modern curtain style and equally timeless style – making them great in most decorative settings.",
    ImageUrl = "Images/Curtains/4.jpg",
    Id = 2,
    ImageOne = "Images/Curtains/3.jpg",
    ImageTwo = "Images/Curtains/8.jpg",
    ImageThree = "Images/Curtains/9.jpg",
});

        curtains.Add(
new Curtain
{
    Name = "Window Treatment Set",
    Description = "A window treatment set includes everything you’ll need to create a full window treatment. A window treatment set almost always includes one or two curtains and a valance. Some window kits also include accessories like tiebacks and a curtain rod, and in rare cases, they can even include a pelmet.",
    ImageUrl = "Images/Curtains/11.jpg",
    Id = 3,
    ImageOne = "Images/Curtains/3.jpg",
    ImageTwo = "Images/Curtains/8.jpg",
    ImageThree = "Images/Curtains/9.jpg",
});

        curtains.Add(
new Curtain
{
    Name = "Valance",
    Description = "A valance is a short curtain that hangs at the top of your curtains. These are an optional decorative addition. Valances are a great way to complete a look. These curtains are available separately, or as part of a window treatment set. You can use a valance without additional curtains in windows with blinds, or to add a decorative flair on windows where full curtains aren’t desired.",
    ImageUrl = "Images/Curtains/15.jpg",
    Id = 4,
    ImageOne = "Images/Curtains/3.jpg",
    ImageTwo = "Images/Curtains/8.jpg",
    ImageThree = "Images/Curtains/9.jpg",
});

        curtains.Add(
new Curtain
{
    Name = "Window Tier",
    Description = "Window tiers are commonly used on kitchen windows or any window where you want privacy yet still allow light in.  They conceal the lower portion of the window but the top part of the window is uncovered. Here’s an example. Window tier",
    ImageUrl = "Images/Curtains/16.jpg",
    Id = 5,
    ImageOne = "Images/Curtains/3.jpg",
    ImageTwo = "Images/Curtains/8.jpg",
    ImageThree = "Images/Curtains/9.jpg",
});

        curtains.Add(
new Curtain
{
    Name = "Window Scarf",
    Description = "A window scarf is similar to a valance. It’s a long, thin piece of curtain fabric that is hung from the top of the window. Window scarfs are a great way to create a dramatic look with your window treatment.",
    ImageUrl = "Images/Curtains/17.jpg",
    Id = 6,
    ImageOne = "Images/Curtains/3.jpg",
    ImageTwo = "Images/Curtains/8.jpg",
    ImageThree = "Images/Curtains/9.jpg",
});

        curtains.Add(
new Curtain
{
    Name = "Liner",
    Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
    ImageUrl = "Images/Curtains/4.jpg",
    Id = 7,
    ImageOne = "Images/Curtains/3.jpg",
    ImageTwo = "Images/Curtains/8.jpg",
    ImageThree = "Images/Curtains/9.jpg",
});

        curtains.Add(
new Curtain
{
    Name = "Opacity",
    Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
    ImageUrl = "Images/Curtains/11.jpg",
    Id = 8,
    ImageOne = "Images/Curtains/3.jpg",
    ImageTwo = "Images/Curtains/8.jpg",
    ImageThree = "Images/Curtains/9.jpg",
});

        curtains.Add(
new Curtain
{
    Name = "Sheer",
    Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
    ImageUrl = "Images/Curtains/2.jpg",
    Id = 9,
    ImageOne = "Images/Curtains/3.jpg",
    ImageTwo = "Images/Curtains/8.jpg",
    ImageThree = "Images/Curtains/9.jpg",
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
                    ImageUrl = "Images/SofaCover/s1.jpg",
                    Id = 1,
                    ImageOne = "Images/SofaCover/s2.jpg",
                    ImageTwo = "Images/SofaCover/s3.jpg",
                    ImageThree = "Images/SofaCover/s4.jpg",
                }
            );

        sofaCovers.Add(
    new SofaCover
    {
        Name = "Cover Two",
        Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
        ImageUrl = "Images/SofaCover/s9.jpg",
        Id = 2,
        ImageOne = "Images/SofaCover/s4.jpg",
        ImageTwo = "Images/SofaCover/s5.jpg",
        ImageThree = "Images/SofaCover/s6.jpg",
    }
);

        sofaCovers.Add(
    new SofaCover
    {
        Name = "Cover Three",
        Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
        ImageUrl = "Images/SofaCover/s8.jpg",
        Id = 3,
        ImageOne = "Images/SofaCover/s9.jpg",
        ImageTwo = "Images/SofaCover/s4.jpg",
        ImageThree = "Images/SofaCover/s6.jpg",
    }
);

        sofaCovers.Add(
    new SofaCover
    {
        Name = "Cover Four",
        Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
        ImageUrl = "Images/SofaCover/s9.jpg",
        Id = 4,
        ImageOne = "Images/SofaCover/s4.jpg",
        ImageTwo = "Images/SofaCover/s3.jpg",
        ImageThree = "Images/SofaCover/s2.jpg",
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
                    ImageUrl = "Images/Eyelet/e1.jpg",
                    Id = 1,
                    ImageOne = "Images/Eyelet/e2.jpg",
                    ImageTwo = "Images/Eyelet/e3.jpg",
                    ImageThree = "Images/Eyelet/e4.jpg",
                }
            );

        eyelets.Add(
    new Eyelet
    {
        Name = "Eyelet Two",
        Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
        ImageUrl = "Images/Eyelet/e2.jpg",
        Id = 2,
        ImageOne = "Images/Eyelet/e2.jpg",
        ImageTwo = "Images/Eyelet/e3.jpg",
        ImageThree = "Images/Eyelet/e4.jpg",
    }
);

        eyelets.Add(
    new Eyelet
    {
        Name = "Eyelet Three",
        Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
        ImageUrl = "Images/Eyelet/e3.jpg",
        Id = 3,
        ImageOne = "Images/Eyelet/e2.jpg",
        ImageTwo = "Images/Eyelet/e3.jpg",
        ImageThree = "Images/Eyelet/e4.jpg",
    }
);

        eyelets.Add(
    new Eyelet
    {
        Name = "Eyelet Four",
        Description = "Panel pair curtains feature two separate curtain panels. This type of curtain is popular in classic and contemporary styles. With a panel pair, you place a curtain on either side of the window. To close these curtains, you’d pull each curtain panel together. Panel pair curtains can be tied back to create a symmetrical look for your window treatment.",
        ImageUrl = "Images/Eyelet/e4.jpg",
        Id = 4,
        ImageOne = "Images/Eyelet/e2.jpg",
        ImageTwo = "Images/Eyelet/e3.jpg",
        ImageThree = "Images/Eyelet/e4.jpg",
    }
);

        return eyelets;
    }
}
