using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.DataBase
{
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// Extension Class for OnModelCreating Method to seed initial data to database
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 1,
                    name = "ProductType",
                    

                    //ParentId = Products.LookUpId.ProductType
                }
                );
            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 2,
                    name = "ProductBrand",
                    

                    //ParentId = Products.LookUpId.ProductBrand
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 3,
                    name = "Color",
                    

                    //ParentId = Products.LookUpId.Color
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 4,
                    name = "Storage",
                    

                    //ParentId = Products.LookUpId.Storage
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 5,
                    name = "SimType",
                    

                    //ParentId = Products.LookUpId.SimType
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 6,
                    name = "OperatingSystem",
                    

                    //ParentId = Products.LookUpId.OperatingSystem
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
                new Products.LookUp
                {
                    Id = 7,
                    name = "ProcessorType",
                    

                    //ParentId = Products.LookUpId.ProcessorType
                }
                );

            modelBuilder.Entity<Products.LookUp>().HasData(
               new Products.LookUp
               {
                   Id = 8,
                   name = "ProcessorCore",
                   

                   //ParentId = Products.LookUpId.ProcessorCore
               }
               );

            modelBuilder.Entity<Products.LookUp>().HasData(
               new Products.LookUp
               {
                   Id = 9,
                   name = "PrimaryCamera",
                   

                   //ParentId = Products.LookUpId.PrimaryCamera
               }
               );
        }
    }
}
