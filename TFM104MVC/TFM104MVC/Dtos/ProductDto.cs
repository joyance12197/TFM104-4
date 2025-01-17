﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFM104MVC.Models;

namespace TFM104MVC.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } //計算方式為 OriginalPrice*DiscountPersent 等等在profile文件見真章
                                           //profile文件負責處理映射的改寫 超猛der~
        //public decimal OriginalPrice { get; set; }
        //public double? DiscountPersent { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? GoTouristTime { get; set; }
        public string Notes { get; set; }
        public double? CustomerRating { get; set; }
        public string TravelDays { get; set; }
        public string TripType { get; set; }
        public string Region { get; set; }
        public ICollection<ProductPictureDto> ProductPictures { get; set; }
    }
}
