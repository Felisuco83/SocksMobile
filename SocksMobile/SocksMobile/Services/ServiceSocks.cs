using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SocksMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SocksMobile.Services
{
    public class ServiceSocks
    {

        private Uri UriApi;
        private MediaTypeWithQualityHeaderValue Header;

        public ServiceSocks()
        {
            this.UriApi = new Uri("https://ecommercesocksapi.azurewebsites.net/");
            this.Header = new MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<String> GetToken()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);

                ApiUser user = new ApiUser("admin@admin.com", "1234");
                String json = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                String request = "api/Auth/Login";
                HttpResponseMessage response = await client.PostAsync(request, content);

                if (response.IsSuccessStatusCode)
                {
                    String data = await response.Content.ReadAsStringAsync();
                    JObject jobject = JObject.Parse(data);
                    String token = jobject.GetValue("response").ToString();
                    return token;
                }
                else
                {
                    return null;
                }
            }
        }

        //private async Task<T> CallApi<T>(String request, String token)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = this.UriApi;
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(this.Header);
        //        client.DefaultRequestHeaders.Add("Authorization", "bearer " + token);
        //        HttpResponseMessage response = await client.GetAsync(request);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            T data = await response.Content.ReadAsAsync<T>();
        //            return data;
        //        }
        //        else
        //        {
        //            return default(T);
        //        }
        //    }
        //}

        //private async Task<T> CallApi<T>(String request)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = this.UriApi;
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(this.Header);
        //        HttpResponseMessage response = await client.GetAsync(request);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            T data = await response.Content.ReadAsAsync<T>();
        //            return data;
        //        }
        //        else
        //        {
        //            return default(T);
        //        }
        //    }
        //}

        private async Task<T> CallApi<T>(String request)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                HttpResponseMessage response = await client.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    T data = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                    return data;
                }
                else
                {
                    return default(T);
                }
            }
        }

        private async Task<T> CallApi<T>(String request, String token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + token);
                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    T data = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                    return data;
                }
                else
                {
                    return default(T);
                }
            }
        }

        #region PRODUCTS
        public async Task<List<Product>> GetProductsAsync()
        {
            String request = "api/Products";
            List<Product> products = await this.CallApi<List<Product>>(request);
            return products;
        }

        public async Task<Product> GetProductAsync(int productId)
        {
            String request = "api/Products/" + productId;
            Product product = await this.CallApi<Product>(request);
            return product;
        }

        public async Task<List<Product>> GetLastProductAsync(int amount)
        {
            String request = "api/Products/GetLastProducts/" + amount;
            List<Product> products = await this.CallApi<List<Product>>(request);
            return products;
        }

        public async Task<List<Product>> GetFirstProductAsync(int amount)
        {
            String request = "api/Products/GetFirstProducts/" + amount;
            List<Product> products = await this.CallApi<List<Product>>(request);
            return products;
        }

        public async Task<List<String>> GetProductsStylesAsync()
        {
            String request = "api/Products/GetProductsStyles";
            List<String> styles = await this.CallApi<List<String>>(request);
            return styles;
        }

        public async Task<List<String>> GetProductsPrintAsync()
        {
            String request = "api/Products/GetProductsPrint";
            List<String> styles = await this.CallApi<List<String>>(request);
            return styles;
        }

        public async Task<List<String>> GetProductsColorAsync()
        {
            String request = "api/Products/GetProductColor";
            List<String> styles = await this.CallApi<List<String>>(request);
            return styles;
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            String request = "api/Products/GetProductsByCategory/" + categoryId;
            List<Product> styles = await this.CallApi<List<Product>>(request);
            return styles;
        }
        #endregion

        #region PRODUCT_COMPLETE

        public async Task<List<Product_Complete>> GetProductCompleteAsync()
        {
            String request = "api/Products_Complete";
            List<Product_Complete> products = await this.CallApi<List<Product_Complete>>(request);
            return products;
        }

        public async Task<List<Product_Complete>> GetProductCompleteByCategoryAsync(int categoryId)
        {
            String request = "api/Products_Complete/GetProduct_CompletesByCategory/" + categoryId;
            List<Product_Complete> productsComplete = await this.CallApi<List<Product_Complete>>(request);
            return productsComplete;
        }

        public async Task<Product_Complete> GetProductCompleteAsync(int productId)
        {
            string request = "api/Products_Complete/GetProduct_Complete/" + productId;
            Product_Complete productComplete = await this.CallApi<Product_Complete>(request);
            return productComplete;
        }

        public async Task<List<Product_Complete>> GetFirstProduct_CompleteAsync(int amount)
        {
            String request = "api/Products_Complete/GetFirstProduct_Complete/" + amount;
            List<Product_Complete> productsComplete = await this.CallApi<List<Product_Complete>>(request);
            return productsComplete;
        }

        public async Task<List<Product_Complete>> FilterProductCompleteAsync(int categoryId, String subcategoryId,
            String? style, String? print, String? color)
        {
            String request = "api/Products_Complete/FilterProduct_Completes/" + categoryId + "/" +
                subcategoryId + "/" + style + "/" + print + "/" + color;
            List<Product_Complete> productsComplete = await this.CallApi<List<Product_Complete>>(request);
            return productsComplete;
        }

        #endregion

        #region CATEGORIES

        public async Task<List<Category>> GetCategoriesAsync()
        {
            String request = "api/Categories";
            List<Category> categories = await this.CallApi<List<Category>>(request);
            return categories;
        }
        public async Task<Category> GetCategoryAsync(int categoryId)
        {
            String request = "api/Categories/" + categoryId;
            Category category = await this.CallApi<Category>(request);
            return category;
        }

        #endregion

        #region SUBCATEGORIES

        public async Task<List<Subcategory>> GetSubcategoriesAsync()
        {
            String request = "api/Subcategories";
            List<Subcategory> subcategories = await this.CallApi<List<Subcategory>>(request);
            return subcategories;
        }

        public async Task<Subcategory> GetSubcategoryAsync(int subcategoryId)
        {
            String request = "api/Subcategories/" + subcategoryId;
            Subcategory subcategory = await this.CallApi<Subcategory>(request);
            return subcategory;
        }

        #endregion

        #region SIZE

        public async Task<List<Size>> GetSizes()
        {
            String request = "api/Sizes";
            List<Size> sizes = await this.CallApi<List<Size>>(request);
            return sizes;
        }

        public async Task<Size> GetSize(int sizeId)
        {
            String request = "api/Sizes/" + sizeId;
            Size size = await this.CallApi<Size>(request);
            return size;
        }

        #endregion

        #region PRODUCT_SIZE

        public async Task<List<Product_sizes>> GetProduct_SizesByProductAsync(int productId)
        {
            String request = "api/Product_Sizes/GetProduct_Sizes/" + productId;
            List<Product_sizes> productSizes = await this.CallApi<List<Product_sizes>>(request);
            return productSizes;
        }

        public async Task<Product_sizes> GetProduct_SizesByProductSizeAsync
            (int productId, int sizeId)
        {
            String request = "api/Product_Sizes/GetProduct_Size/" + productId + "/" + sizeId;
            Product_sizes productSize = await this.CallApi<Product_sizes>(request);
            return productSize;
        }

        #endregion

        #region FAVORITES

        public async Task<List<Favorite>> GetFavoritesAsync()
        {
            String request = "api/Favorites";
            List<Favorite> favorites = await this.CallApi<List<Favorite>>(request);
            return favorites;
        }

        public async Task<List<Favorite>> GetUserFavoritesAsync(int userId)
        {
            String request = "api/Favorites/GetUserFavorites/" + userId;
            List<Favorite> favorites = await this.CallApi<List<Favorite>>(request);
            return favorites;
        }

        public async void AddFavoriteAsync(int favoriteProduct, int favoriteUser)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/Favorites/AddFavorite";
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                int lastId = 0;
                List<Favorite> fav = await this.GetFavoritesAsync();
                if (fav.Count > 0)
                {
                    lastId = fav.OrderByDescending(x => x.Favorite_id).FirstOrDefault().Favorite_id;
                }
                Favorite favorites = new Favorite((lastId + 1), favoriteProduct, favoriteUser);
                String json = JsonConvert.SerializeObject(favorites);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(request, content);
            }
        }

        public async void DeleteFavoriteAsync(int userId)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/Favorites/RemoveUserFavorites/" + userId;
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                await client.DeleteAsync(request);
            }
        }

        #endregion

        #region ADDRESSES

        public async Task<List<Addresses>> GetAddressesAsync()
        {
            String request = "api/Addresses";
            List<Addresses> addresses = await this.CallApi<List<Addresses>>(request);
            return addresses;
        }
        public async Task<Addresses> GetAddressAsync(int addressId)
        {
            String request = "/api/Addresses/GetAddress/" + addressId;
            Addresses address = await this.CallApi<Addresses>(request);
            return address;
        }

        public async Task<List<Addresses>> GetAddressesByUserAsync(int userId)
        {
            String request = "api/Addresses/GetUserAddresses/" + userId;
            List<Addresses> addresses = await this.CallApi<List<Addresses>>(request);
            return addresses;
        }

        public async void AddAddressAsync(int addressId, int userId, String name, String street,
            String cp, String country, String province, String city)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/Addresses/AddAddress";
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                Addresses address = new Addresses(addressId, userId, name, street, cp, country, province, city);
                String json = JsonConvert.SerializeObject(address);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(request, content);
            }
        }

        public async void EditAddressAsync(int addressId, int userId, String name, String street,
            String cp, String country, String province, String city)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/Addresses/EditAddress";
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                Addresses address = new Addresses(addressId, userId, name, street, cp, country, province, city);
                String json = JsonConvert.SerializeObject(address);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PutAsync(request, content);
            }
        }

        public async void DeleteAddressAsync(int addressId)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/Addresses/deleteAddress/" + addressId;
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                await client.DeleteAsync(request);
            }
        }
        #endregion

        #region ORDERS

        public async Task<List<Orders>> GetOrdersAsync(int userId)
        {
            String request = "api/Orders/GetOrders/" + userId;
            List<Orders> orders = await this.CallApi<List<Orders>>(request);
            return orders;
        }

        public async Task<Orders> GetOrderByIdAsync(int orderId)
        {
            String request = "api/Orders/GetOrderById/" + orderId;
            Orders order = await this.CallApi<Orders>(request);
            return order;
        }

        public async Task<List<Order_details>> GetOrderDetailsAsync(int orderId)
        {
            String request = "api/Orders/GetOrder_Detail/" + orderId;
            List<Order_details> order_Details = await this.CallApi<List<Order_details>>(request);
            return order_Details;
        }

        public async Task<Orders> AddOrderAsync(int orderUser, DateTime orderDate)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/Orders/AddOrder";
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                Orders order = new Orders(this.generateRandomId(), orderUser, orderDate);
                String json = JsonConvert.SerializeObject(order);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(request, content);
                return order;
            }
        }

        public async void AddOrderDetailsAsync(int orderId,
            int product_id, int size_id, int amount)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/Orders/AddOrderDetails";
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                Order_details orderDetails = new Order_details(orderId, product_id, size_id, amount);
                String json = JsonConvert.SerializeObject(orderDetails);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(request, content);
            }
        }
        #endregion

        #region USERS

        public async Task<Users> GetUserAsync(int userId)
        {
            String request = "api/User/" + userId;
            Users user = await this.CallApi<Users>(request, await this.GetToken());
            return user;
        }

        public async Task<Users> GetUserByCredentialsAsync(String email, String password)
        {
            String request = "api/User/GetUserByCredentials/" + email + "/" + password;
            Users user = await this.CallApi<Users>(request, await this.GetToken());
            return user;
        }

        public async Task<Users> GetUserByEmailAsync(String email)
        {
            String request = "api/User/GetUserByEmail/" + email;
            Users user = await this.CallApi<Users>(request, await this.GetToken());
            return user;
        }

        public async void AddUserAsync(String userName, String userLastName,
            String userEmail, String userPassword, String userNationality, String userPhone,
            DateTime userBirthDate, String userGender, String userSalt)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/User/AddUser";
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + await this.GetToken());
                Users user = new Users(this.generateRandomId(), userName + " " + userLastName, userEmail, userPassword,
                    userNationality, userPhone, userBirthDate, userGender, userSalt);
                String json = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(request, content);
            }
        }


        public async void EditUserAsync(int userId, String userName, String userLastName,
            String userEmail, String userPassword, String userNationality, String userPhone,
            DateTime userBirthDate, String userGender, String userSalt)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/User/EditUser";
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + await this.GetToken());
                Users user = new Users(userId, userName + " " + userLastName, userEmail, userPassword,
                    userNationality, userPhone, userBirthDate, userGender, userSalt);
                String json = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PutAsync(request, content);
            }
        }


        public async void SetPasswordAsync(int userId, String password)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "/api/User/SetPassword/" + userId + "/" + password;
                client.BaseAddress = this.UriApi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + await this.GetToken());
                await client.PutAsync(request, null);
            }
        }
        #endregion

        public int generateRandomId()
        {
            int randomValue;
            Random random = new Random();
            randomValue = random.Next(1000, 9999);
            return randomValue;
        }
    }
}
