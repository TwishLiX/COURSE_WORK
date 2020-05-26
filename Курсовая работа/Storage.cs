using System;

namespace Курсовая_работа
{
    struct CarShop
    {
        public string product_name;
        public string manufacturer;
        public int price;
        public int quantity;
        public int store_number;
        public int consignment;
    }
    class Storage
    {
        public static string password = "course_c#";
        public static int size = 0, index = size;
        public static CarShop[] car = new CarShop[size];

        public void ProductAdd(string new_product_name, string new_manufacturer, int new_price, int new_quantity, int new_store_number, int new_min_consignment)
        {
            size++;
            ArrayResize();
            car[index].product_name = new_product_name;
            car[index].manufacturer = new_manufacturer;
            car[index].price = new_price;
            car[index].quantity = new_quantity;
            car[index].store_number = new_store_number;
            car[index].consignment = new_min_consignment;
            index++;
        }

        public void ProductEdit(string new_product_name, string new_manufacturer, int new_price, int new_quantity, int new_store_number, int new_min_consignment, int current)
        {
            car[current].product_name = new_product_name;
            car[current].manufacturer = new_manufacturer;
            car[current].price = new_price;
            car[current].quantity = new_quantity;
            car[current].store_number = new_store_number;
            car[current].consignment = new_min_consignment;
        }

        public void ProductDelete(int current)
        {
            int new_size = size - 1;
            CarShop[] temp_array = new CarShop[new_size];
            Array.Copy(car, 0, temp_array, 0, current);
            Array.Copy(car, current + 1, temp_array, current, size - current - 1);
            ClearAll();
            size = new_size;
            index = size;
            ArrayResize();
            Array.Copy(temp_array, 0, car, 0, size);
            Array.Clear(temp_array, 0, size);
        }

        public void ClearAll()
        {
            Array.Clear(car, 0, size);
            size = 0;
            index = 0;
        }

        public void ArrayResize()
        {
            Array.Resize(ref car, size);
        }
    }
}
