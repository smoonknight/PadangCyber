using PadangCyberApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Controller
{
    public class ModelController
    {
        private static CustomerModel[] dataCustomerModel;
        private static DishModel[] dataDishModel;
        private static CategoryModel[] dataCategoryModel;
        public static DateTime dataCustomerLastUpdated { get; private set; }
        public static DateTime dataDishLastUpdated { get; private set; }
        public static DateTime dataCategoryLastUpdated { get; private set; }


        public static CategoryModel[] DataCategoryModel
        {
            get
            {
                return dataCategoryModel;
            }
            set
            {
                dataCategoryModel = value;
                dataCategoryLastUpdated = DateTime.Now;
            }
        }


        public static CustomerModel[] DataCustomerModel
        {
            get
            {
                return dataCustomerModel;
            }
            set
            {
                dataCustomerModel = value;
                dataCustomerLastUpdated = DateTime.Now;
            }
        }

        public static DishModel[] DataDishModel
        {
            get
            {
                return dataDishModel;
            }
            set
            {
                dataDishModel = value;
                dataDishLastUpdated = DateTime.Now;
            }
        }

    }
}
