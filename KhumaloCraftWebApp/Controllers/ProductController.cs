using KhumaloCraftWebApp.Data;
using KhumaloCraftWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Drawing;

namespace KhumaloCraftWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult AddProductWithImage()
        {
            // Inserting image into database
            byte[] imageData;
            using (var stream = new FileStream("~/images/product1.jpg", FileMode.Open))
            {
                imageData = new byte[stream.Length];
                stream.Read(imageData, 0, (int)stream.Length);
            }

            var product = new Products
            {
                Name = "Product Name",
                Description = "Product Description",
                Price = 100.00M,
                Category = "Product Category",
                ImageData = imageData // Assign byte array to ImageData property
            };

            _context.Product.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index"); // Redirect to product listing page
        }

        public IActionResult DisplayProductImage()
        {
            // Retrieving image from database
            var productFromDb = _context.Product.FirstOrDefault();
            if (productFromDb != null)
            {
                using (var stream = new MemoryStream(productFromDb.ImageData))
                {
                    Image image = Image.FromStream(stream);
                    image.Save("retrieved_image.jpg");
                }
            }

            return View();
        }
    }
}
