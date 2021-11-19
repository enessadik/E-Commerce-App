using shopapp.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Models
{

    public class ProductModel
    { 
        public int ProductId { get; set; }

        //[Display(Name = "Name", Prompt = "Enter product name")]
        //[Required(ErrorMessage = "Name zorunlu bir alan.")]
        //[StringLength(60, MinimumLength = 5, ErrorMessage = "Ürün ismi 5-10 karakter aralığında olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Url zorunlu bir alan.")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Price zorunlu bir alan.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Lütfen bir sayı giriniz!!")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Description zorunlu bir alan.")]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "Description 5-100 karakter aralığında olmalıdır.")]

        public string Description { get; set; }

        [Required(ErrorMessage = "ImageUrl zorunlu bir alan.")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
        
    }
}
