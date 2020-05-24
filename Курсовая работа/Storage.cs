using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    class Storage
    {
        public static string password = "course_c#";
        public static bool first_start = true;
        public static int size = 20, index = size;
        public static string[] product_name = new string[size];
        public static string[] manufacturer = new string[size];
        public static int[] price = new int[size];
        public static int[] quantity = new int[size];
        public static int[] store_number = new int[size];
        public static int[] consignment = new int[size];

        public void BeginAssingment()
        {
            const int begin_size = 20;
            string[] begin_manufacturers = new string[begin_size] { "KIA", "BMW", "Opel", "Subaru", "Mazda",
                                                                    "Tesla", "Audi", "Ford", "Honda", "Hyundai",
                                                                    "Mitsubishi", "Nissan", "Renault", "Volkswagen", "Daewoo",
                                                                    "Peugeot", "Mercedes", "Ferrari", "Citroen", "Toyota" };
            string[] begin_names = new string[begin_size] { "LR-567", "SG-12", "X321", "PL90", "LAT-193",
                                                            "RT-15", "JK-228", "X80", "PO-20", "ST-58",
                                                            "GB-8", "DJ-667", "LP-27", "ND-500", "AR-13",
                                                            "AC-0", "DC-1", "JI-2", "KU6", "PI-27", };
            int[] begin_prices = new int[begin_size] { 5800, 2000, 1400, 1800, 3200, 16000, 4300, 8250, 3200, 4500,
                                                       2300, 4750, 5400, 2100, 1700, 2500, 2200, 30000, 3000, 1350 };
            int[] begin_quantities = new int[begin_size] { 2, 3, 1, 5, 6, 7, 2, 1, 4, 3, 6, 3, 2, 4, 1, 2, 3, 4, 2, 3 };
            int[] begin_storenumbers = new int[begin_size] { 3, 1, 11, 15, 6, 6, 7, 2, 14, 9, 4, 5, 16, 21, 5, 6, 12, 6, 8, 10 };
            int[] begin_consignments = new int[begin_size] { 20, 13, 11, 5, 8, 10, 2, 10, 9, 1, 14, 8, 9, 1, 5, 8, 12, 6, 5, 10 };

            for (int i = 0; i < begin_size; i++)
            {
                product_name[i] = begin_names[i];
                manufacturer[i] = begin_manufacturers[i];
                price[i] = begin_prices[i];
                quantity[i] = begin_quantities[i];
                store_number[i] = begin_storenumbers[i];
                consignment[i] = begin_consignments[i];
            }
            first_start = false;
        }

        public void ProductAdd(string new_product_name, string new_manufacturer, int new_price, int new_quantity, int new_store_number, int new_min_consignment)
        {
            size++;
            ArrayResize();
            product_name[index] = new_product_name;
            manufacturer[index] = new_manufacturer;
            price[index] = new_price;
            quantity[index] = new_quantity;
            store_number[index] = new_store_number;
            consignment[index] = new_min_consignment;
            index++;
        }

        public void ProductEdit(string new_product_name, string new_manufacturer, int new_price, int new_quantity, int new_store_number, int new_min_consignment, int current)
        {
            product_name[current] = new_product_name;
            manufacturer[current] = new_manufacturer;
            price[current] = new_price;
            quantity[current] = new_quantity;
            store_number[current] = new_store_number;
            consignment[current] = new_min_consignment;
        }

        public void ProductDelete(int current)
        {
            int new_size = size - 1;
            string[] temp_product_name = new string[new_size];
            string[] temp_manufacturer = new string[new_size];
            int[] temp_price = new int[new_size];
            int[] temp_quantity = new int[new_size];
            int[] temp_store_number = new int[new_size];
            int[] temp_consignment = new int[new_size];

            ArrayCopy(product_name, manufacturer, price, quantity, store_number, consignment, temp_product_name, temp_manufacturer, temp_price, temp_quantity, temp_store_number, temp_consignment, 0, 0, current);
            ArrayCopy(product_name, manufacturer, price, quantity, store_number, consignment, temp_product_name, temp_manufacturer, temp_price, temp_quantity, temp_store_number, temp_consignment, current + 1, current, size - current - 1);
            ClearAll(product_name, manufacturer, price, quantity, store_number, consignment);
            size = new_size;
            index = size;
            ArrayResize();
            ArrayCopy(temp_product_name, temp_manufacturer, temp_price, temp_quantity, temp_store_number, temp_consignment, product_name, manufacturer, price, quantity, store_number, consignment, 0, 0, size);
            ClearAll(temp_product_name, temp_manufacturer, temp_price, temp_quantity, temp_store_number, temp_consignment);
        }

        public void ClearAll(string[] product_name, string[] manufacturer, int[] price, int[] quantity, int[] store_number, int[] consignment)
        {
            Array.Clear(product_name, 0, size);
            Array.Clear(manufacturer, 0, size);
            Array.Clear(price, 0, size);
            Array.Clear(quantity, 0, size);
            Array.Clear(store_number, 0, size);
            Array.Clear(consignment, 0, size);
            size = 0;
            index = 0;
        }

        public void ArrayCopy(string[] product_name, string[] manufacturer, int[] price, int[] quantity, int[] store_number, int[] consignment, string[] temp_product_name, string[] temp_manufacturer, int[] temp_price, int[] temp_quantity, int[] temp_store_number, int[] temp_consignment, int begin_first, int begin_second, int size)
        {
            Array.Copy(product_name, begin_first, temp_product_name, begin_second, size);
            Array.Copy(manufacturer, begin_first, temp_manufacturer, begin_second, size);
            Array.Copy(price, begin_first, temp_price, begin_second, size);
            Array.Copy(quantity, begin_first, temp_quantity, begin_second, size);
            Array.Copy(store_number, begin_first, temp_store_number, begin_second, size);
            Array.Copy(consignment, begin_first, temp_consignment, begin_second, size);
        }

        public void ArrayResize()
        {
            Array.Resize(ref product_name, size);
            Array.Resize(ref manufacturer, size);
            Array.Resize(ref price, size);
            Array.Resize(ref quantity, size);
            Array.Resize(ref store_number, size);
            Array.Resize(ref consignment, size);
        }
    }
}
