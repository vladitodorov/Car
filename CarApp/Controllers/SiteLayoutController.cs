namespace CarApp.Controllers
{
	using System.Web.Mvc;
	using Umbraco.Web.Mvc;

	public class SiteLayoutController : SurfaceController
	{
		private const string  PartialsViewPath = "~/Views/Partials/SiteLayout/";

		public ActionResult RenderHeader()
		{
			return PartialView(PartialsViewPath + "_Header.cshtml");
		}

		public ActionResult RenderFooter()
		{
			return PartialView(PartialsViewPath + "_Footer.cshtml");
		}
	}
}