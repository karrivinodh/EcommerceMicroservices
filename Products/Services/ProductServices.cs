using Products.Model;

namespace Products.Services
{
    public class ProductServices
    {
        public static List<Product> ProductDataList { get; }
        static ProductServices()
        {
            ProductDataList = new List<Product>
            {
                new Product
                {

                    Id = 1,
                    Title = "Dell XPS 9500 15.6 inches UHD Laptop (10th Gen Intel Core i7-10750H/32GB/1TB SSD/Windows 10 Home Plus & MS Office/4GB NVIDIA1650 Ti Graphics) Silver 1.83Kg",
                    Description = "Processor:10th Generation Intel Core i7-10750H Processor (12MB Cache, up to 5GHz,6 cores). Memory & Storage:32 GB DDR4 at 2933 MHz, dual channel |1TB M.2 PCIe NVMe Solid State Drive. Graphics:NVIDIA GeForce GTX 1650 Ti 4GB GDDR6. Display: 15.6” UHD (3840 x 2400) InfinityEdge Touch Anti-Reflecitve 500-Nit Display | 100% Adobe RGB + 94% DCI-P | 93% Screen to body ratio | Eyesafe technology. Operating System: Windows 10 Home Plus Single Language & Microsoft Office Home and Student 2019. CNC machined aluminum in platinum silver with carbon fiber composite palm rest in black Edge-to-edge Corning Gorilla Glass 6 on touch panel, Keyboard & Battery:Backlit chiclet keyboard | 6-Cell Lithium Ion Battery |6 cell 86 Whr|13 hrs battery life. I/O ports:Two Thunderbolt 3 (USB Type-C) ports with Power Delivery |1x USB-C 3.1 with power delivery & Display Port | Full size SD card reader v6.0 |1x3.5 mm headphone/microphone combo jack. Others:Killer Wi-Fi 6 AX1650 (2x2) | Bluetooth 5.1 | Finger Print Reader. 1 year Premium Support Plus | McAfee Live Safe 12 month Subscription",
                    ProductCategory = { Id = 4 },
                    Offer = { Discount = 20 },
                    Price = 302000,
                    Quantity = 560,
                    ImageName = "Dell Laptop"

                },

                new Product
                {
                    Id = 2,
                    Title = "Lenovo XPS 9500 15.6 inches UHD Laptop (11th Gen Intel Core i7-10750H/32GB/1TB SSD/Windows 10 Home Plus & MS Office/4GB NVIDIA1650 Ti Graphics) Black 1.83Kg",
                    Description = "Processor:11th Generation Intel Core i7-10750H Processor (12MB Cache, up to 5GHz,6 cores). Memory & Storage:32 GB DDR4 at 2933 MHz, dual channel |1TB M.2 PCIe NVMe Solid State Drive. Graphics:NVIDIA GeForce GTX 1650 Ti 4GB GDDR6. Display: 15.6” UHD (3840 x 2400) InfinityEdge Touch Anti-Reflecitve 500-Nit Display | 100% Adobe RGB + 94% DCI-P | 93% Screen to body ratio | Eyesafe technology. Operating System: Windows 10 Home Plus Single Language & Microsoft Office Home and Student 2019. CNC machined aluminum in platinum silver with carbon fiber composite palm rest in black Edge-to-edge Corning Gorilla Glass 6 on touch panel, Keyboard & Battery:Backlit chiclet keyboard | 6-Cell Lithium Ion Battery |6 cell 86 Whr|13 hrs battery life. I/O ports:Two Thunderbolt 3 (USB Type-C) ports with Power Delivery |1x USB-C 3.1 with power delivery & Display Port | Full size SD card reader v6.0 |1x3.5 mm headphone/microphone combo jack. Others:Killer Wi-Fi 6 AX1650 (2x2) | Bluetooth 5.1 | Finger Print Reader. 1 year Premium Support Plus | McAfee Live Safe 12 month Subscription",
                    ProductCategory = { Id = 4 },
                    Offer = { Discount = 10 },
                    Price = 50000,
                    Quantity = 500,
                    ImageName = "Lenovo Laptop"
                },
                new Product
                {
                    Id = 3,
                    Title = "Asus XPS 9500 15.6 inches UHD Laptop (11th Gen Intel Core i7-10750H/32GB/1TB SSD/Windows 10 Home Plus & MS Office/4GB NVIDIA1650 Ti Graphics) Gold 1.83Kg",
                    Description = "Processor:11th Generation Intel Core i7-10750H Processor (12MB Cache, up to 5GHz,6 cores). Memory & Storage:32 GB DDR4 at 2933 MHz, dual channel |1TB M.2 PCIe NVMe Solid State Drive. Graphics:NVIDIA GeForce GTX 1650 Ti 4GB GDDR6. Display: 15.6” UHD (3840 x 2400) InfinityEdge Touch Anti-Reflecitve 500-Nit Display | 100% Adobe RGB + 94% DCI-P | 93% Screen to body ratio | Eyesafe technology. Operating System: Windows 10 Home Plus Single Language & Microsoft Office Home and Student 2019. CNC machined aluminum in platinum silver with carbon fiber composite palm rest in black Edge-to-edge Corning Gorilla Glass 6 on touch panel, Keyboard & Battery:Backlit chiclet keyboard | 6-Cell Lithium Ion Battery |6 cell 86 Whr|13 hrs battery life. I/O ports:Two Thunderbolt 3 (USB Type-C) ports with Power Delivery |1x USB-C 3.1 with power delivery & Display Port | Full size SD card reader v6.0 |1x3.5 mm headphone/microphone combo jack. Others:Killer Wi-Fi 6 AX1650 (2x2) | Bluetooth 5.1 | Finger Print Reader. 1 year Premium Support Plus | McAfee Live Safe 12 month Subscription",
                    ProductCategory = { Id = 4 },
                    Offer = { Discount = 10 },
                    Price = 60000,
                    Quantity = 50,
                    ImageName = "Asus Laptop"
                },
            };
        }
       public  static int nextProductID = 4;
        public static List<Product> Get()
            {
                return ProductDataList;
            }
            public static Product GetByID(int id)
            {
                return ProductDataList.FirstOrDefault(Product => Product.Id == id);
            }
        public static Product Post(Product product)
        {
            product.Id =nextProductID++;
            ProductDataList.Add(product);
            return product;
        }
        public static void DeleteById(int id)
        {
            var product = ProductDataList.FirstOrDefault(o => o.Id == id);

            ProductDataList.Remove(product);
            product.Id = nextProductID--;
        }

        public static Product Update(int id,Product product)
        {
            var existingproduct = ProductDataList.FirstOrDefault(p => p.Id == id);
            if (existingproduct == null)
            {
                return null;
            }
            existingproduct.Title = existingproduct.Title;
            existingproduct.Price = existingproduct.Price;
            existingproduct.Quantity= existingproduct.Quantity; 
            existingproduct.ImageName = existingproduct.ImageName;
            existingproduct.Description = existingproduct.Description;  
            existingproduct.Offer= existingproduct.Offer;   
            return existingproduct;
        }
        public static Product GetByCategoryID(int id)
        {
            return ProductDataList.FirstOrDefault(ProductCategory => ProductCategory.Id == id);
        }

    }
    }


