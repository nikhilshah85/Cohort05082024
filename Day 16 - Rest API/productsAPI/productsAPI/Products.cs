namespace productsAPI
{
    public class Products
    {
        #region Properties
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductCategory { get; set; }
        public bool ProductIsAvailable { get; set; }
        #endregion

        //in memory collection of data
        static List<Products> products = new List<Products>()
        {
            new Products { ProductId = 1, ProductName = "Pepsi", ProductCategory = "Cold-Drink", ProductIsAvailable = true, ProductPrice = 50 },
           new Products { ProductId = 2, ProductName="Nintendo Wii", ProductCategory ="Console", ProductIsAvailable=true, ProductPrice=499},
            new Products { ProductId = 3, ProductName = "Pepsi", ProductCategory = "Cold-Drink", ProductIsAvailable = false, ProductPrice = 50 },
             new Products { ProductId = 4, ProductName="Nintendo Switch", ProductCategory ="Electronics", ProductIsAvailable=true, ProductPrice=299},
             new Products { ProductId = 5, ProductName="Redbull", ProductCategory ="Cold-Drink", ProductIsAvailable=true, ProductPrice=75},
             new Products { ProductId = 6, ProductName="Air Forces", ProductCategory ="Shoes", ProductIsAvailable=true, ProductPrice=120},
             new Products { ProductId = 7, ProductName="Oreo", ProductCategory ="Snack", ProductIsAvailable=false, ProductPrice=1},
             new Products { ProductId = 8, ProductName="Pistachio", ProductCategory ="Dried organics", ProductIsAvailable=true, ProductPrice=73.99},
             new Products { ProductId = 9, ProductName="Skittles", ProductCategory ="Snack", ProductIsAvailable=true, ProductPrice=4},
             new Products { ProductId = 10, ProductName = "Cashew Nuts", ProductCategory = "Nuts", ProductIsAvailable = true, ProductPrice = 25},
             new Products { ProductId = 11, ProductName="Reign", ProductCategory ="Energy-Drink", ProductIsAvailable=false, ProductPrice=3.98},
             new Products { ProductId = 12, ProductName="Mac", ProductCategory ="Technology", ProductIsAvailable=true, ProductPrice=149.99},
        };

        #region Get Methods
        public List<Products> AllProducts()
       {
            return products;
       }

       public Products ProductById(int id)
        {
            var pr = (from p in products
                    where p.ProductId == id
                    select p).Single();

            if (pr != null)
            {
                return pr;
            }
            throw new Exception("Product Not Found");
        }

        public List<Products> ProductByCategory(string category)
        {
            var pr = (from p in products
                      where p.ProductCategory == category
                      select p).ToList();
            if (pr.Count > 0)
            {
                return pr.ToList();
            }
            throw new Exception("No Produts found");
        }

        public List<Products> ProductsInStock(bool yesNo)
        {
            var pr = (from p in products
                      where p.ProductIsAvailable == yesNo
                      select p).ToList();

            if (pr.Count > 0) 
            {
                return pr;
            }
            throw new Exception("0 Products");
        }

        public int TotalProducts()
        {
            return products.Count;
        }
        #endregion

        #region Post, Delete and Put Methods
        public string AddNewProduct(Products newProduct)
        {
            //we can do some data validation here or data formatting etc... business logic
            products.Add(newProduct);
            return "Product Added Successfully";
        }

        public string RemoveProduct(int id) 
        {
            var pr = (from p in products
                      where p.ProductId == id
                      select p).Single();

            if (pr != null) 
            {
                products.Remove(pr);
                return "Product Removed Sucessfully";
            }
            throw new Exception("Product Not Found");
        }

        public string EditProduct(Products product)
        {
            var pr = (from p in products
                     where p.ProductId == product.ProductId
                     select p).Single();

            if (pr != null) 
            {
                pr.ProductName = product.ProductName;
                pr.ProductPrice = product.ProductPrice;
                pr.ProductCategory = product.ProductCategory;
                return "Product Updated Successfully";
            }
            throw new Exception("Product Not Found");
        }
        #endregion
    }
}






