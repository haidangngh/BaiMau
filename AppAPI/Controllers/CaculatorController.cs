using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AppAPI.Controllers
{
    [Route("api/Caculator")]
    [ApiController]

    public class CaculatorController : ControllerBase
    {

        [HttpGet("Tinh-Tien-Lai")]
        public string TinhTienLai(int money,int thang, float tilelai)
        {
            double sotiennhanduoc = money *Math.Pow(1+tilelai/100,thang) - money;
            return "So Tien Lai La: " + sotiennhanduoc;
        }



        [HttpPost("Tim-So-Thu-2-Trong-Mang")]
        public string Sothu2trongmang(int[] arr)
        {
            int[] arr1 = arr.OrderByDescending(x=>x).ToArray(); //sắp xếp từ lớn để nhỏ bằng linq
            return "phan tu thu 3 la: " + arr1[2];
        }
    }
}
