namespace Bài_1.Models
{
    public class TaiKhoan
    {
        public class VaPagingRequest
        {
            public int Page { get; set; } = 1;
            public int PageSize { get; set; } = 10;
            public string? Keyword { get; set; }
        }
    }
}
