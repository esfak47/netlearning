using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.ViewModels
{
    public class StudentCreateModel
    {
        [Display(Name = "出生日期")]
        public DateTime birthday { get; set; }
        [Display(Name = "名")]
        [Required]
        [MaxLength(10)]
        public string firstName { get; set; }
        [Display(Name = "姓")]
        [Required]
        [MaxLength(10)]
        public string lastName { get; set; }
        [Display(Name = "性别")]
        [Required]
        public Gender gender { get; set; }
    }
}
