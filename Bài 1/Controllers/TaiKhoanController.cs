using Microsoft.AspNetCore.Mvc;
using static Bài_1.Models.TaiKhoan;

namespace Bài_1.Controllers
{
    [Route("v1")]
    [ApiController]
    public class TaiKhoanController : Controller
    {
        [HttpGet("get-banks")]
        public IActionResult GetBanks()
        {
            var banks = new[]
            {
                new { BankCode = "VCB", BankName = "Vietcombank", Status = "Active" },
                new { BankCode = "TCB", BankName = "Techcombank", Status = "Active" },
                new { BankCode = "ACB", BankName = "ACB", Status = "Active" }
            };

            return Ok(new { success = true, data = banks });
        }

        // 2. Danh sách số tài khoản (Phân trang)
        [HttpPost("get-va-paging")]
        public IActionResult GetVaPaging([FromBody] VaPagingRequest request)
        {
            // Xử lý logic truy vấn database phân trang tài khoản ảo
            return Ok(new { success = true, page = request.Page, pageSize = request.PageSize, data = new List<object>() });
        }

    }
}