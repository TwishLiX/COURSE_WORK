using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа
{
    class Files
    {
        Storage storage = new Storage();
        public void Write()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.bin";
            save.Filter = "Binary files (*.bin) | *.bin";
            save.AddExtension = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                string filename = save.FileName;
                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                bw.Write(Storage.size);
                bw.Write(Storage.index);
                for (int i = 0; i < Storage.size; i++)
                {
                    bw.Write(Storage.product_name[i]);
                    bw.Write(Storage.manufacturer[i]);
                    bw.Write(Storage.price[i]);
                    bw.Write(Storage.quantity[i]);
                    bw.Write(Storage.store_number[i]);
                    bw.Write(Storage.consignment[i]);
                }
                MessageBox.Show("Database was successfully loaded to file.");
                bw.Close();
                fs.Close();
            }
        }

        public void Read(bool is_overwrite)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = "*.bin";
            open.Filter = "Binary files (*.bin) | *.bin";
            open.AddExtension = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                string filename = open.FileName;
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
                if (is_overwrite == true)
                {
                    Storage.size = br.ReadInt32();
                    Storage.index = br.ReadInt32();
                    storage.ArrayResize();
                    for (int i = 0; i < Storage.size; i++)
                    {
                        Storage.product_name[i] = br.ReadString();
                        Storage.manufacturer[i] = br.ReadString();
                        Storage.price[i] = br.ReadInt32();
                        Storage.quantity[i] = br.ReadInt32();
                        Storage.store_number[i] = br.ReadInt32();
                        Storage.consignment[i] = br.ReadInt32();
                    }
                }
                if (is_overwrite == false)
                {
                    int temp_size = Storage.size;
                    Storage.size += br.ReadInt32();
                    Storage.index += br.ReadInt32();
                    storage.ArrayResize();
                    for (int i = temp_size; i < Storage.size; i++)
                    {
                        Storage.product_name[i] = br.ReadString();
                        Storage.manufacturer[i] = br.ReadString();
                        Storage.price[i] = br.ReadInt32();
                        Storage.quantity[i] = br.ReadInt32();
                        Storage.store_number[i] = br.ReadInt32();
                        Storage.consignment[i] = br.ReadInt32();
                    }
                }
                MessageBox.Show("Data was successfully loaded from file.");
                br.Close();
                fs.Close();
            }
        }

    }
}
