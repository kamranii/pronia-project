using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProniaBE.Models;
using ProniaBE.Services;
using ProniaBE.Services.Implementations;

namespace ProniaBE.Controllers;

public class HomeController : Controller
{
    private readonly ProductService _productService;
    private readonly ImageService _imageService;
    private readonly CustomerService _customerService;
    private readonly BrandService _brandService;
    private readonly PostService _postService;

    public HomeController (ProductService productService,
            ImageService imageService,
            CustomerService customerService,
            BrandService brandService,
            PostService postService)
    {
        _productService = productService;
        _imageService = imageService;
        _customerService = customerService;
        _brandService = brandService;
        _postService = postService;
    }

    public async Task<IActionResult> Index()
    {
        IndexVM model = new IndexVM();
        model.ProductsByTabs = await _productService.GetProductsDictionary();
        model.BannerImages = await _imageService.GetBrandImages();
        model.Customers = await _customerService.GetCustomersWithComments();
        model.Brands = await _brandService.GetBestBrands();
        model.Posts = await _postService.GetLatestPosts();
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

