using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core2.ViewModels
{
    public class IndexViewModel
    {
        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
    }
}
