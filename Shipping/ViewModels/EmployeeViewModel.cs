﻿using Shipping.Models;
using System.ComponentModel.DataAnnotations;

namespace Shipping.ViewModels
{
    public class EmployeeViewModel
    {
        public string? Id { get; set; }
        [Required(ErrorMessage = "يجب ادخال الاسم")]
        public string Name { get; set; }
        [Required(ErrorMessage = "يجب ادخال البريد الالكتروني")]
        [RegularExpression("^\\S+@\\S+\\.\\S+$", ErrorMessage = "ادخل بريد الكتروني صحيح")]
        public string Email { get; set; }
        [Required(ErrorMessage = "يجب ادخال رقم الهاتف")]
        [RegularExpression(@"^1[0125][0-9]{8}$", ErrorMessage = "ادخل رقم هاتف صحيح كالاتى : 1224479550")]
        public string Phone { get; set; }
        public bool Status { get; set; }
        public string BranchName { get; set; }
        public string Role { get; set; }
        [StringLength(255, ErrorMessage = "ادخل ع الاقل 6احرف و ارقام", MinimumLength = 6)]
        [Required(ErrorMessage = "يجب ادخال الرقم السري")]
        public string Password{ get; set;}

    }
}
