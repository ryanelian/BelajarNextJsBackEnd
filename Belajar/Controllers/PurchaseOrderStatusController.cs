using Belajar.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Data.Entity;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace Belajar.Controllers
{
    public class ProvinceCreateModel
    {
        public string Name { set; get; } = "";
    }

    public class ProvinceUpdateModel
    {
        public string Name { set; get; } = "";
    }
}
