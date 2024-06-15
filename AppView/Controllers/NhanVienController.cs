using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ttc_55;

namespace AppView.Controllers
{
    public class NhanVienController : Controller
    {



        HttpClient client = new HttpClient();




        public ActionResult Index()
        {
            string requestURL = "https://localhost:7198/api/NhanVien/Get-All";
            var response = client.GetStringAsync(requestURL).Result;    //lấy ra kết quả GetAll
            var data = JsonConvert.DeserializeObject<List<NhanVien>>(response);
            return View(data);
        }

        // GET: NhanVienController/Details/5
        public ActionResult Details(Guid id)
        {
            string requestURL = $"https://localhost:7198/api/NhanVien/Get-By-Id?id={id}";
            var response = client.GetStringAsync(requestURL).Result;    //lấy ra kết quả Get-By-Id
            var data = JsonConvert.DeserializeObject<NhanVien>(response);
            return View(data);
        }

        // GET: NhanVienController/Create
        public ActionResult Create()
        {
            NhanVien nv = new NhanVien()
            {
                Id = new Guid(),
                Ten = "dang",
                Email = "dang@gmail.com",
                Luong = 300,
                Role = 1,
                Tuoi = 20,
                TrangThai = true
            };
            return View(nv);
        }

        // POST: NhanVienController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NhanVien nhanVien)
        {
            string requestURL = "https://localhost:7198/api/NhanVien/Create";
            var response = client.PostAsJsonAsync(requestURL,nhanVien).Result;    
            return RedirectToAction("Index");
        }

        // GET: NhanVienController/Edit/5
        public ActionResult Edit(Guid id)
        {
            string requestURL = $"https://localhost:7198/api/NhanVien/Get-By-Id?id={id}";
            var response = client.GetStringAsync(requestURL).Result;    //lấy ra kết quả Get-By-Id
            var data = JsonConvert.DeserializeObject<NhanVien>(response);
            return View(data);
        }

        // POST: NhanVienController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NhanVien nv)
        {
            string requestURL = "https://localhost:7198/api/NhanVien/Update";
            var response = client.PutAsJsonAsync(requestURL,nv).Result;    //lấy ra kết quả Get-By-Id
            return RedirectToAction("Index");
        }

        // GET: NhanVienController/Delete/5
        public ActionResult Delete(Guid id)
        {
            string requestURL = $"https://localhost:7198/api/NhanVien/Delete?id={id}";
            var response = client.DeleteAsync(requestURL).Result;    //lấy ra kết quả Get-By-Id
            return RedirectToAction("Index");
        }
    }
}
