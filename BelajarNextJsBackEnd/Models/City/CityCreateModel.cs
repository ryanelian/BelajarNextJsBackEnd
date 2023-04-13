﻿using BelajarNextJsBackEnd.Entities;

namespace BelajarNextJsBackEnd.Models.City
{
    public class CityCreateModel
    {
        public string Name { set; get; } = "";

        public string ProvinceId { set; get; } = "";
    }

    public class CityDetailModel
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public string ProvinceId { set; get; } = "";

        public string ProvinceName { set; get; } = "";
    }
}