namespace CarApp.Controllers
{
	using Umbraco.Web.Mvc;
	using System.Web.Mvc;

	public class HomeController : SurfaceController
	{
		private const string PartialsViewPath = "~/Views/Partials/Home/";

		public ActionResult RenderFeaturedSection()
		{
			return PartialView(PartialsViewPath + "_FeaturedSection.cshtml");
		}

		public ActionResult RenderFeaturedProduct()
		{
			return PartialView(PartialsViewPath + "_FeaturedProductSection.cshtml");
		}

		public ActionResult RenderPortfolioSection()
		{
			return PartialView(PartialsViewPath + "_PortfolioSection.cshtml");
		}

		public ActionResult RenderContentSection()
		{
			return PartialView(PartialsViewPath + "_ContentSection.cshtml");
		}

		public ActionResult RenderServicesSection()
		{
			return PartialView(PartialsViewPath + "_ServicesSection.cshtml");
		}

		public ActionResult RenderBlogSection()
		{
			return PartialView(PartialsViewPath + "_BlogSection.cshtml");
		}
	}
} 