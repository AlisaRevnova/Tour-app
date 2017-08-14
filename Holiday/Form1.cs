using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Holiday
{
    [Serializable]
    public partial class Form1 : Form
    {
        public static BinaryFormatter bin = new BinaryFormatter();

        public List<Country> allDirections = new List<Country>();
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();

            if(File.Exists("Countries.txt"))
            {
                FileStream st = new FileStream("Countries.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                allDirections = bin.Deserialize(st) as List<Country>;
                st.Close();
            }
            else
            {
                allDirections.Add(new Country("Egypt", new Resorts("Casablanka"), new Resorts("Fish Ocean")));
                allDirections.Add(new Country("Italy", new Resorts("Rome Coloseum"), new Resorts("Capri Paradise"), new Resorts("Venice")));
                allDirections.Add(new Country("Maldives", new Resorts("Huvafen Fushi"), new Resorts("Intercontinental Maldives")));
                allDirections.Add(new Country("France", new Resorts("Paris Midnight"), new Resorts("Gastro-Tour")));
                allDirections.Add(new Country("Goa", new Resorts("Paradise Goa"), new Resorts("Ocean Club"), new Resorts("Jungles"), new Resorts("Beach and Sun")));
            }

            comboBoxCountry.DataSource = allDirections;
            comboBoxCountry.DisplayMember = "country";
        }

        private void Add_MouseClick(object sender, MouseEventArgs e)
        {
            if(comboBoxCountry.SelectedItem!=null && listBoxResort.SelectedItem!=null)
            {
                form2.TextCountry = (comboBoxCountry.SelectedItem as Country).country;
                form2.TextResort = listBoxResort.SelectedItem.ToString();

                foreach (var w in form2.rad)
                {
                    w.Checked = false;
                }
                form2.PickerArr = DateTime.Now;
                form2.PickerDep = DateTime.Now;
                form2.ShowDialog();
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxResort.Items.Clear();
            foreach (var r in (comboBoxCountry.SelectedItem as Country).allHotels)
            {
                listBoxResort.Items.Add(r.Resort);
            }
        }

        private void listBoxResort_DoubleClick(object sender, EventArgs e)
        {
            if (comboBoxCountry.SelectedItem != null && listBoxResort.SelectedItem != null)
            {
                form2.TextCountry = (comboBoxCountry.SelectedItem as Country).country;
                form2.TextResort = listBoxResort.SelectedItem.ToString();
                form2.ShowDialog();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream st = new FileStream("Countries.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            bin.Serialize(st, allDirections);
            st.Close();
        }
    }
}
