using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.Core
{
    public class PostCore : DefaultCore<Post>
    {
        public List<Post> RetornarListaDePosts(int UltimoPostId, int Top)
        {
            if(UltimoPostId == 0)
                return (from post in Query
                        orderby post.Id descending
                        select post).Take(Top).ToList();
            else
                return (from post in Query
                        where post.Id < UltimoPostId
                        orderby post.Id descending
                        select post).Take(Top).ToList();
        }
    }
}
