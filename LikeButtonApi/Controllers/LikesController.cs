using LikeButtonWeb.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        private readonly LikeContext context;

        public LikesController(LikeContext db)
        {
            context = db;
        }

        [HttpPost]
        public IActionResult Post([FromBody] LikeModel model)
        {
            var like = new LikeModel
            {
                likeCount = model.likeCount
            };
            var result = context.PostLikesCount(like);
            return Ok(like);
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = context.GetLikesCount();
            return Ok(result);
        }
    }
}
