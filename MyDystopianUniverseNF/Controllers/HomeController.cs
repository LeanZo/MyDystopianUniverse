using DatabaseModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDystopianUniverseNF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CarregarPosts(int UltimoPostId = 0, int Top = 10)
        {
            var posts = new PostCore().RetornarListaDePosts(UltimoPostId, Top);

            var post_json = posts.Select(
                post =>
                new
                {
                    post.Id,
                    post.Titulo,
                    post.Conteudo,
                    post.DataHora,
                    AutorId = post.Autor.Id,
                    PenName = post.Autor.PenName
                });

            var json_result = Json(post_json, JsonRequestBehavior.AllowGet);
            json_result.MaxJsonLength = int.MaxValue;
            return json_result;
        }
    }
}