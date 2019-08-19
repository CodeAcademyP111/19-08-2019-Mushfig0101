using Microsoft.EntityFrameworkCore;
using P111_CodeAcademy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P111_CodeAcademy.DAL;

namespace P111_CodeAcademy.DAL
{
    public class AppDbContext : DbContext 
    {
        //AppDbContext Database-in qarsiligi olaraq DataBase class-dir
     //DbContext vasitesile bir database-nin lazimi configlerini miras alir.
     //Yeni DbContext den miras alir. 
     //DbContext classinin constructorlarindan biri bizeden
     //DbContext tipinden bir options gozleyir ki, DbContext ozu de 
     //bir Generic (Custom) tipdirGeneric tipe onun ozunden yaranan pobyecti gonderirik.
     //Her bir user daxil olanda onun ucun bir connection yaransin deye biz startup da bir connection yaratduq.

        //services.AddDbContext<AppDbContext>(options => {
        //        options.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);//incapsule olunmus version
        //        // options.UseSqlServer(_config"Server=DESKTOP-VG62E1O; Initial catalog=FirstDb; Security integrated = sspi");
        //    });

     //ve hemin connectionu
     //butun sehifelere gonderirik 
        #region
        //public DbContext([NotNullAttribute] DbContextOptions options);
      
         // Инициализирует новый экземпляр класса Microsoft.EntityFrameworkCore.DbContext
         // используя указанные опции. Microsoft.EntityFrameworkCore.DbContext.OnConfiguring (Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)
         // метод по-прежнему будет вызываться для дальнейшей настройки параметров.
         //
         // Параметры:
         // опции:
         // Опции для этого контекста.

        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employer> Employers { get; set; }
        //Biz Employer Tipinden(Custom tip) Employers table-ni
        //yaratdiq    
        public DbSet<Managers> Managers { get; set; }
    }    
  
}
