using ClientSideValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientSideValidation.Controllers
{
	public class UsersController : Controller
	{
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(WebUser webUser)
		{
			if(ModelState.IsValid) {
				// Here the WebUser should be saved. Afterwards we would normally return
				// another View, to indicate that the User has been sucessfully created, or
				// redirect to another page
			}

			return View();
		}
	}
}