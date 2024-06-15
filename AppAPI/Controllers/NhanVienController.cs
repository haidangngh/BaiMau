using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ttc_55;
using ttc_55.Models;

namespace AppAPI.Controllers
{
    [Route("api/NhanVien")]
    [ApiController]



    public class NhanVienController : ControllerBase
    {
        AppDBContext _context = new AppDBContext();


        [HttpGet("Get-All")]
        public ActionResult Index()
        {
            return Ok(_context.nhanViens.ToList());
        }




        [HttpGet("Get-By-Id")]
        public ActionResult Details(Guid id)
        {
            return Ok(_context.nhanViens.Find(id));
        }

        [HttpPost("Create")]
        public ActionResult Create(NhanVien nv) 
        {
            try
            {
                _context.nhanViens.Add(nv);
                _context.SaveChanges();
                return Ok();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }




        [HttpPut("Update")]
        public ActionResult Edit(NhanVien nv)
        {
            try
            {
                _context.nhanViens.Update(nv);
                _context.SaveChanges();
                return Ok();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }



        [HttpDelete("Delete")] //Delete Theo ID
        public ActionResult Delete(Guid id)
        {
            try
            {
                var idRemove = _context.nhanViens.Find(id); //id muốn xóa
                _context.nhanViens.Remove(idRemove);
                _context.SaveChanges();
                return Ok();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
