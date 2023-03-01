
using Blog.Models.DTO;

namespace Blog.Models.ViewModels.PostsViewModels
{
    public class PostsIndexVM
    {
        public IEnumerable<PostDto> Posts { get; set; } = default!;
        public IEnumerable<CategoryDto> Categories { get; set; } = default!;
        public int CategoryId { get; set; }
    }
}
