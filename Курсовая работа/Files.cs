using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа
{
    class Files
    {
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
                    bw.Write(Storage.car[i].product_name);
                    bw.Write(Storage.car[i].manufacturer);
                    bw.Write(Storage.car[i].price);
                    bw.Write(Storage.car[i].quantity);
                    bw.Write(Storage.car[i].store_number);
                    bw.Write(Storage.car[i].consignment);
                }
                MessageBox.Show("Database was successfully loaded to file.");
                bw.Close();
                fs.Close();
            }
        }

        public void Read(bool is_overwrite)
        {
            Storage storage = new Storage();
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
                        Reading(br, i);
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
                        Reading(br, i);
                    }
                }
                MessageBox.Show("Data was successfully loaded from file.");
                br.Close();
                fs.Close();
            }
        }

        public void Reading(BinaryReader br, int i)
        {
            Storage.car[i].product_name = br.ReadString();
            Storage.car[i].manufacturer = br.ReadString();
            Storage.car[i].price = br.ReadInt32();
            Storage.car[i].quantity = br.ReadInt32();
            Storage.car[i].store_number = br.ReadInt32();
            Storage.car[i].consignment = br.ReadInt32();
        }

    }
}
