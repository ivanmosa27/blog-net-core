using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_net_core.Project.Modules.Model.Repositories
{
    
    public class PostModel
    {
        [JsonProperty("postId")]
        public int postId { get; set; }
        [JsonProperty("post")]
        public string postName { get; set; }
        public string postDescription { get; set; }

    }
}
