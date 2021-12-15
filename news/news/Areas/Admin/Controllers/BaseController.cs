using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;

namespace news.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private void AddModelError()
        {
            List<string> errors = new List<string>();
            foreach (var value in ModelState.Values)
            {
                if (value.Errors == null || value.Errors.Count == 0) continue;

                value.Errors.ToList().ForEach(e =>
                {
                    Debug.WriteLine("error: " + e.ErrorMessage);
                    errors.Add(e.ErrorMessage);
                });
            }

            errors.ForEach(err => ModelState.AddModelError("", err));
        }

        protected void AddErrors(string error)
        {
            if (!string.IsNullOrEmpty(error) || !string.IsNullOrWhiteSpace(error))
            {
                ModelState.AddModelError("", error);
            }

            AddModelError();
        }

        protected void AddErrors(List<string> erros)
        {
            erros.ForEach(err => AddErrors(err));
            AddModelError();
        }

        protected void Alert(string message, bool isError = false)
        {
            if (isError)
            {
                TempData["error"] = message;
            }
            else
            {
                TempData["success"] = message;
            }
        }
    }
}