using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttc_55
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        [MaxLength(30,ErrorMessage ="toi da 30 ki tu")] // validate toi da 30 ki tu
        public string Ten {  get; set; }
        [Required(ErrorMessage ="bat buoc phai co")] //validate bắt buộc phải nhập vào
        public int Tuoi { get; set; }
        public int Role { get; set; }
        [EmailAddress(ErrorMessage ="sai dinh dang")] // validate dinh dang email
        public string Email { get; set; }
        [Range(100,500,ErrorMessage ="luong sai ")] //validate trong 1 khoảng
        public int Luong { get; set; }
        public bool TrangThai {  get; set; }
    }
}
