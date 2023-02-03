using Products.Model;
using System.Security.Cryptography.X509Certificates;
using Products.Services;

namespace Products.Services
{
    public class ProductCategoryService
    {
        public static List<Productcategory> ProductCategoryDataList { get; }
        static ProductCategoryService()
        {
            ProductCategoryDataList = new List<Productcategory>
                {
                new Productcategory{
                    Id=1,
                    Category="electronics",
                    SubCategory="mobiles"
                    },

                new Productcategory
                {
                    Id=2,
                    Category="furniture",
                    SubCategory="chairs"

                },

                new Productcategory
                {
                    Id=3,
                    Category= "furniture",
                    SubCategory="tables"

                },

            new Productcategory
            {
                Id =4,
                    Category ="electronics",
                    SubCategory ="laptops"

                },
            new Productcategory
                {
                    Id=5,
                    Category="clothes",
                    SubCategory="mens-tshirt"

            },
            };
             
        }
        static int NextProductCategoryId = 6;
        public static Productcategory GetByID(int id)
        {
            return ProductCategoryDataList.FirstOrDefault(Productcategory => Productcategory.Id == id);
        }
        public static List<Productcategory> Get()
        {
            return ProductCategoryDataList;
        }
        public static Productcategory Post(Productcategory productcategory)
        {
            productcategory.Id = NextProductCategoryId++;
            ProductCategoryDataList.Add(productcategory);
            return productcategory;
        }




        public static void DeleteById(int id)
        {
            var product = ProductCategoryDataList.FirstOrDefault(o => o.Id == id);

             ProductCategoryDataList.Remove(product);
            product.Id = NextProductCategoryId--;
          
        }
        //update

        public static Productcategory Update(int id,Productcategory productcategory)
        {
            var existingproductcategory = ProductCategoryDataList.FirstOrDefault(p => p.Id == id);
            if (existingproductcategory == null)
            {
                return null;
            }
            existingproductcategory.Category = existingproductcategory.Category;
            existingproductcategory.SubCategory = existingproductcategory.SubCategory;  
           
            return existingproductcategory;
        }
    }
}
    
   
 
