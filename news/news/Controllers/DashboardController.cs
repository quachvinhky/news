using System.Web.Mvc;

namespace news.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Index() => View();

        [ActionName("crypto-index")]
        public ActionResult CryptoIndex() => View();


        [ActionName("crm-index")]
        public ActionResult CrmIndex() => View();

        [ActionName("project-index")]
        public ActionResult ProjectIndex() => View();


        [ActionName("ecommerce-index")]
        public ActionResult EcommerceIndex() => View();


        [ActionName("helpdesk-index")]
        public ActionResult HelpdeskIndex() => View();

        [ActionName("hospital-index")]
        public ActionResult hospitalIndex() => View();
    }
}