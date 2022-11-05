using AutoMapper;
using Data;
using Data.Entities;
using MathCornerForum_aspnetcore.HelperMethods;
using MathCornerForum_aspnetcore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System.IO;

namespace MathCornerForum_aspnetcore.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public AccountController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            //if(userName == null || password == null)
            return View();
        }
        public IActionResult Signup()
        {
            ViewBag.Message = "";
            return View();
        }

        [HttpPost]
        public IActionResult Signup(UserCreateModel userCreate, IFormFile file)
        {
            if (file != null)
            {
                string extension = Path.GetExtension(file.FileName);
                List<string> extensions = new List<string>() { ".png", ".jpg", ".jpeg" };

                if (extensions.Contains(extension))
                {
                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        userCreate.Picture = fileBytes;
                    }
                }
                else
                {
                    ViewBag.Message = "Error: File extensions can be '.png', '.jpg', '.jpeg' ";
                    return View();
                }
            }

            //Add user to database if username, email, password correct/unique
            if (!userCreate.Email.IsValidEmailAddress())
            {
                ViewBag.Message = "Check your email";
                return View();
            }
            if (!userCreate.Password.IsValidPassword())
            {
                ViewBag.Message = "Check your password"; // write limitation
                return View();
            }

            // check if user with given email/password/username exists
            //
            var usermap = _mapper.Map<User>(userCreate);
            //User user = new User();
            //user.UserName = userCreate.UserName;
            //user.Picture = userCreate.Picture;
            //user.Email = userCreate.Email;
            //user.Password = userCreate.Password;

            _context.Users.Add(usermap);
            _context.SaveChanges();


            return View("UserInfo", userCreate); // Return new view with user info; add edit
        }
    }
}
