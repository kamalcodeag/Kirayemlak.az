using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string AdvertisementURL { get; set; }
        [NotMapped]
        public IFormFile UploadFile { get; set; }
    }
}
