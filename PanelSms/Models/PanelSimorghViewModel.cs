using Microsoft.AspNetCore.Mvc.Rendering;
using Panel.DAL;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PanelSms.Models
{
    public class PanelSimorghViewModel
    {
        [Required(ErrorMessage ="نام الزامیست")]
        [StringLength(15,ErrorMessage ="نام حداکثر شامل 15 کاراکتر میباشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "نام خانوادگی الزامیست")]
        [StringLength(20, ErrorMessage = "نام خانوادگی حداکثر شامل 20 کاراکتر میباشد")]
        public string FName { get; set; }
        [Required(ErrorMessage = "نام کاربری الزامیست")]
        [StringLength(15, ErrorMessage = "نام کاربری حداکثر شامل 20 کاراکتر میباشد")]
        public string Username { get; set; }
        [Required(ErrorMessage = "ایمیل الزامیست")]
        [DataType(DataType.EmailAddress,ErrorMessage ="آدرس ایمیل نامعتبر است")]
        public string Email { get; set; }
        [Required(ErrorMessage = "شماره همراه الزامیست")]
        [RegularExpression(@"09 [1 2 0 3]\d{8}",ErrorMessage ="شماره همراه نامعتبر است")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "شماره تلفن الزامیست")]
        [RegularExpression(@"0 \d{10}", ErrorMessage = "شماره تلفن نامعتبر است")]
        public int PhoneCall { get; set; }
        [Required(ErrorMessage = "کد ملی الزامیست")]
        public int NationalCode { get; set; }
        [Required(ErrorMessage = "شماره شناسنامه الزامیست")]
        public int BirthNo { get; set; }
        [Required(ErrorMessage = "کد پستی الزامیست")]
        public int PostalCode { get; set; }
        [Required(ErrorMessage = "آدرس الزامیست")]
        [DataType(DataType.Text)]
        public string Address { get; set; }
        public int UserPanelId { get; set; }
        public int AcquaintanceId { get; set; }
        public IEnumerable<SelectListItem> UserPanels { get; set; }
        public IEnumerable<Condition> Conditions { get; set; }
        public IEnumerable<SelectListItem> AcquaintanceTypes { get; set; }
        [Required(ErrorMessage ="پذیرش شرایط جهت ثبت نام الزامیست")]
        public bool CheckTerms { get; set; }
    }
}