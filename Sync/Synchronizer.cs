using PadangCyberApp.Classes.Strings;
using PadangCyberApp.Controller;
using PadangCyberApp.Model;
using PadangCyberApp.View.Template.CustomLabel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Sync
{
    public class Synchronizer
    {
        private DateTime? prevCategoryLastUpdatedAt;
        private DateTime? prevDishLastUpdatedAt;
        private DateTime? prevCustomerLastUpdatedAt;
        public Synchronizer()
        {
            prevCategoryLastUpdatedAt = new DateTime();
            prevDishLastUpdatedAt = new DateTime();
            prevCustomerLastUpdatedAt = new DateTime();
        }

        public async Task ForceUpdateDish()
        {
            string json = await WebServiceController.Get($"{URLWebService.Get.dish}/lastupdated");
            DateTime dishLastUpdatedAt = await JsonController.JsonConvertDeserializeAsync<DateTime>(json);

            var getData = await GetData<DishModel[]>(dishLastUpdatedAt, prevDishLastUpdatedAt, URLWebService.Get.dish);

            ModelController.DataDishModel = getData;
        }

        public async Task ForceUpdateCategory()
        {
            string json = await WebServiceController.Get($"{URLWebService.Get.category}/lastupdated");
            DateTime? categoryLastUpdatedAt = (JsonController.isJsonNull(json) ? DateTime.Now : await JsonController.JsonConvertDeserializeAsync<DateTime>(json));

            var getData = await GetData<CategoryModel[]>(categoryLastUpdatedAt, prevCategoryLastUpdatedAt, URLWebService.Get.category);

            ModelController.DataCategoryModel = getData;
        }

        public async void StartLastUpdatedAsync()
        {
            while (true)
            {
                await TryLastUpdatedAsync();
                await Task.Delay(3000);
            }
        }

        public async void StartLastUpdatedAsync(CommonLabel commonLabel)
        {
            while (true)
            {
                bool isConnected = await TryLastUpdatedAsync();
                if (isConnected)
                {
                    commonLabel.Text = "berhasil terkoneksi ke padangcyber";
                }
                else
                {
                    commonLabel.Text = "gagal terkoneksi dengan padangcyber";
                }
                await Task.Delay(3000);
            }
        }

        public async Task<bool> TryLastUpdatedAsync()
        {
            List<Task> tasksAsync = new List<Task>();
            try
            {
                string json = await WebServiceController.Get($"{URLWebService.Get.package}/lastupdated");
                LastUpdatedModel lastUpdatedModel = await JsonController.JsonConvertDeserializeAsync<LastUpdatedModel>(json);
                if (lastUpdatedModel.DishLastUpdatedAt != null)
                {
                    tasksAsync.Add(CheckDishLastUpdated(lastUpdatedModel.DishLastUpdatedAt));
                }
                if (lastUpdatedModel.CategoryLastUpdatedAt != null)
                {
                    tasksAsync.Add(CheckCategoryLastUpdated(lastUpdatedModel.CategoryLastUpdatedAt));
                }
                if (lastUpdatedModel.CustomerLastUpdatedAt != null)
                {
                    tasksAsync.Add(CheckCustomerLastUpdated(lastUpdatedModel.CustomerLastUpdatedAt));
                }
                await Task.WhenAll(tasksAsync);
                return true;
            }
            catch
            {
                return false;
            }
        }

        async Task CheckDishLastUpdated(DateTime? dishLastUpdatedAt)
        {
            if (dishLastUpdatedAt == prevDishLastUpdatedAt)
            {
                return;
            }
            var getData = await GetData<DishModel[]>(dishLastUpdatedAt, prevDishLastUpdatedAt, URLWebService.Get.dish);
            prevDishLastUpdatedAt = dishLastUpdatedAt;
            ModelController.DataDishModel = getData;
        }

        async Task CheckCategoryLastUpdated(DateTime? categoryLastUpdatedAt)
        {
            if (categoryLastUpdatedAt == prevCategoryLastUpdatedAt)
            {
                return;
            }
            var getData = await GetData<CategoryModel[]>(categoryLastUpdatedAt, prevCategoryLastUpdatedAt, URLWebService.Get.category);
            prevCategoryLastUpdatedAt = categoryLastUpdatedAt;
            ModelController.DataCategoryModel = getData;
        }
        async Task CheckCustomerLastUpdated(DateTime? customerLastUpdatedAt)
        {
            if (customerLastUpdatedAt == prevCustomerLastUpdatedAt)
            {
                return;
            }
            var getData = await GetData<CustomerModel[]>(customerLastUpdatedAt, prevCustomerLastUpdatedAt, URLWebService.Get.category);
            prevCustomerLastUpdatedAt = customerLastUpdatedAt;
            ModelController.DataCustomerModel = getData;
        }

        async Task<T> GetData<T>(DateTime? lastUpdated, DateTime? prevLastUpdated, string get)
        {
            string json = await WebServiceController.Get(get);
            var model = await JsonController.JsonConvertDeserializeAsync<T>(json);
            return model;
        }

        class LastUpdatedModel
        {
            public DateTime? CategoryLastUpdatedAt { get; set; }
            public DateTime? DishLastUpdatedAt { get; set; }
            public DateTime? CustomerLastUpdatedAt { get; set; }
        }
    }
}
