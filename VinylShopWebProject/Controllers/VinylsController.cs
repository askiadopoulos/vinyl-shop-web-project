using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VinylShopWebProject.Models;
using VinylShopWebProject.ViewModels;

namespace VinylShopWebProject.Controllers
{
    public class VinylsController : Controller
    {
        // Declare an object reference of type Identity Framework
        // to use with EF and perform CRUD operations on database 
        private readonly ApplicationDbContext context;

        // Initialize that object
        public VinylsController()
        {
            context = new ApplicationDbContext();
        }

        // Release all the resources related with that object
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        //GET: Vinyls/TopSales
        public ViewResult TopSales()
        {
            // TODO

            // Top 5 best selling vinyls
            var bestSellingVinyls = context.OrderDetails.Where(v => v.ProductId > 20).Count();

            // Top selling vinyl
            var topChoiceVinyl = context.OrderDetails.Select(v => v.ProductId);

            return View();
        }


        // GET: Vinyls/BestTopVinyl
        // Fetch all the best selling and top choice albums
        public ViewResult TopSellingVinyls()
        {
            var vinyls = context.Vinyls
                .OrderBy(v => v.Artist)
                .ToList();

            var topSellings = new VinylTopSalesViewModel
            {
                Vinyls = vinyls
            };

            return View(topSellings);
        }

        // GET
        public ActionResult Edit(int id)
        {
            var vinyl = context.Vinyls.SingleOrDefault(v => v.Id == id);

            // Bad scenario
            if (vinyl == null)
                return HttpNotFound();

            // Good scenario
            var viewModel = new VinylFormViewModel()
            {
                Vinyl = vinyl,
                Categories = context.Categories.ToList(),
                Genres = context.Genres.ToList(),
                RecordLabels = context.RecordLabels.ToList()
                //ContentFiles = context.ContentFiles.ToList(),
                
                
            };

            return View("VinylForm", viewModel);
        }

        // GET:
        //[Authorize]
        public ViewResult New()
        {
            var categories = context.Categories.ToList();
            var genres = context.Genres.ToList();
            var recordLabels = context.RecordLabels.ToList();
            //var contentFiles = context.ContentFiles.ToList();

            var viewModel = new VinylFormViewModel()
            {
                Vinyl = new Vinyl(),
                Categories = categories,
                Genres = genres,
                RecordLabels = recordLabels
                //ContentFiles = contentFiles
            };

            return View("VinylForm", viewModel);
        }

        // POST: Add New Vinyls
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Vinyl vinyl, HttpPostedFileBase postedImage, HttpPostedFileBase postedAudio)
        {
            // Validation: If the model is not valid maintain the specific view
            if (!ModelState.IsValid)
            {
                var viewModel = new VinylFormViewModel()
                {
                    Vinyl = vinyl,
                    Categories = context.Categories.ToList(),
                    Genres = context.Genres.ToList(),
                    RecordLabels = context.RecordLabels.ToList(),
                    //ContentFiles = context.ContentFiles.ToList()
                };
                return View("VinylForm", viewModel);
            }

            // Create
            if (vinyl.Id == 0)
                context.Vinyls.Add(vinyl);

            // Edit
            else
            {
                var vinylInDb = context.Vinyls.Single(v => v.Id == vinyl.Id);

                // properties from base model Product
                vinylInDb.Price = vinyl.Price;
                vinylInDb.Quantity = vinyl.Quantity;
                vinylInDb.IsAvailable = vinyl.IsAvailable;
                //vinylInDb.CategoryId = vinyl.CategoryId; // categories are constants
                //vinylInDb.ContentFiles = vinyl.ContentFiles;
                //vinylInDb.OrderDetails = vinyl.OrderDetails;

                // properties from derived model Vinyl
                //vinylInDb.Artist = vinyl.Artist;
                //vinylInDb.Title = vinyl.Title;
                //vinylInDb.ReleaseDate = vinyl.ReleaseDate;
                //vinylInDb.GenreId = vinyl.GenreId;
                //vinylInDb.RecordLabelId = vinyl.RecordLabelId;
                //vinylInDb.Formats = vinyl.Formats;
            }
            context.SaveChanges();

            return RedirectToAction("Index", "Vinyls");
        }



        ////[Authorize]
        //[HttpPost]
        //public ActionResult Create(VinylFormViewModel viewModel, HttpPostedFileBase postedImage, HttpPostedFileBase postedAudio)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (postedImage != null && postedAudio != null && postedImage.ContentLength > 0 && postedAudio.ContentLength > 0)
        //        {
        //            var image = new ContentFile
        //            {
        //                FileName = Path.GetFileName(postedImage.FileName),
        //                FileType = FileType.ImageSample,
        //                ContentType = postedImage.ContentType
        //            };

        //            var audio = new ContentFile
        //            {
        //                FileName = Path.GetFileName(postedAudio.FileName),
        //                FileType = FileType.AudioSample,
        //                ContentType = postedAudio.ContentType
        //            };

        //            using (var imageFileReader = new BinaryReader(postedImage.InputStream))
        //            {
        //                image.Content = imageFileReader.ReadBytes(postedImage.ContentLength);
        //            }

        //            using (var audioFileReader = new BinaryReader(postedAudio.InputStream))
        //            {
        //                audio.Content = audioFileReader.ReadBytes(postedAudio.ContentLength);
        //            }

        //            // Initialize a product of type vinyl
        //            var vinyl = new Vinyl
        //            {
        //                // Properties of Product model (base)
        //                Price = viewModel.Vinyl.Price,
        //                Quantity = viewModel.Vinyl.Quantity,
        //                IsAvailable = viewModel.Vinyl.IsAvailable,
        //                // Properties of Vinyl model
        //                Artist = viewModel.Vinyl.Artist,
        //                Title = viewModel.Vinyl.Title,
        //                ReleaseDate = viewModel.Vinyl.ReleaseDate,
        //                // Navigation property on Product model
        //                //CategoryId = viewModel.Category,
        //                ContentFiles = new List<ContentFile> { image, audio },
        //                // Navigation properties on Vinyl model
        //                Genre = viewModel.Vinyl.Genre,
        //                //RecordLabelId = viewModel.RecordLabel
        //            };
        //            context.Products.Add(vinyl);
        //            context.SaveChanges();
        //            return RedirectToAction("Create", "Vinyls");
        //        }
        //    }
        //    return View();
        //}

        // GET: Vinyls/Edit/id
        //public ActionResult Edit(int id)
        //{
        //    var vinyl = context.Vinyls.SingleOrDefault(v => v.Id == id);

        //    if (vinyl == null)
        //        return HttpNotFound();

        //    var vinylModel = new VinylFormViewModel()
        //    {
        //        Vinyl = vinyl,
        //        Categories = context.Categories.ToList(),
        //        Genres = context.Genres.ToList(),
        //        RecordLabels = context.RecordLabels.ToList()
        //    };

        //    //vinylModel.Categories = context.Categories.ToList();
        //    //vinylModel.Genres = context.Genres.ToList();
        //    //vinylModel.RecordLabels = context.RecordLabels.ToList();

        //    return View("Edit", vinylModel);
        //}

        // POST:
        //[HttpPost]
        //public ActionResult Edit(Vinyl vinyl)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var viewModel = new VinylFormViewModel()
        //        {
        //            Vinyl = vinyl,
        //            Categories = context.Categories.ToList(),
        //            Genres = context.Genres.ToList(),
        //            RecordLabels = context.RecordLabels.ToList()
        //        };

        //        return View("Edit", viewModel);
        //    }

        //    if (vinyl.Id == 0) // create
        //    {
        //        context.Vinyls.Add(vinyl);
        //    }
        //    else // edit
        //    {
        //        // Properties of Product model (base)
        //        var vinylInDb = context.Vinyls.Single(s => s.Id == vinyl.Id);
        //        vinylInDb.Price = vinyl.Price;
        //        vinylInDb.Quantity = vinyl.Quantity;
        //        vinylInDb.IsAvailable = vinyl.IsAvailable;
        //        // Properties of Vinyl model
        //        vinylInDb.Artist = vinyl.Artist;
        //        vinylInDb.Title = vinyl.Title;
        //        vinylInDb.ReleaseDate = vinyl.ReleaseDate;
        //        // Navigation property on Product model
        //        vinylInDb.CategoryId = vinyl.CategoryId;
                
        //        // Navigation properties on Vinyl model
        //        vinylInDb.GenreId = vinyl.GenreId;
        //        vinylInDb.RecordLabelId = vinyl.RecordLabelId;
        //    }

        //    context.SaveChanges();

        //    return RedirectToAction("Index", "Home");
        //}


        // Vinyls/Index
        //public ViewResult Index()
        //{
        //    if (User.IsInRole(RoleName.CanManageSeries))
        //        return View("ListSeries");
        //    // aliws tha dw auto
        //    return View("ListSeriesReadOnly");
        //}

        // GET: Vinyls
        public ViewResult Index()
        {

            return View("ListVinyls");
        }
    }
}