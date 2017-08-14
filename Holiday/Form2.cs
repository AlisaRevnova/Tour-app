using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Holiday
{
    [Serializable]
    public partial class Form2 : Form
    {
        public ArrayList ListOfAllTours = new ArrayList();

        public List<RadioButton> rad = new List<RadioButton>();
        public Form2()
        {
            InitializeComponent();

            rad.Add(radioButton1);
            rad.Add(radioButton2);
            rad.Add(radioButton3);
            rad.Add(radioButton4);
            rad.Add(radioButton5);

            if(File.Exists("Tours.txt"))
            {
                FileStream st = new FileStream("Tours.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                ListOfAllTours = Form1.bin.Deserialize(st) as ArrayList;
                st.Close();
            }
        }
        
        public string TextCountry
        {
            get
            {
                return textBoxCountry.Text;
            }
            set
            {
                textBoxCountry.Text = value;
            }
        }
        public string TextResort
        {
            get
            {
                return textBoxResort.Text;
            }
            set
            {
                textBoxResort.Text = value;
            }
        }
        public DateTime PickerDep
        {
            get
            {
                return dateTimePickerDepar.Value;
            }
            set
            {
                dateTimePickerDepar.Value = value;
            }
        }
        public DateTime PickerArr
        {
            get
            {
                return dateTimePickerArr.Value;
            }
            set
            {
                dateTimePickerArr.Value = value;
            }
        }

        private void OK_MouseClick(object sender, MouseEventArgs e)
        {
            if (dateTimePickerDepar.Value.Year>=DateTime.Now.Year && dateTimePickerDepar.Value.Month>=DateTime.Now.Month
                && dateTimePickerDepar.Value.Day>=DateTime.Now.Day &&
                dateTimePickerArr.Value.Year >= DateTime.Now.Year && dateTimePickerArr.Value.Month >= DateTime.Now.Month
                && dateTimePickerArr.Value.Day >= DateTime.Now.Day && dateTimePickerArr.Value>=dateTimePickerDepar.Value)
            {
                if(rad.Any(x=>(x.Checked==true)))
                {
                    Tour tmp = new Tour(textBoxCountry.Text, new Resorts(textBoxResort.Text, Int32.Parse(rad.Find(x => x.Checked == true).Name.Last().ToString())), dateTimePickerDepar.Value, dateTimePickerArr.Value);

                    ListOfAllTours.Add(tmp);

                    MessageBox.Show(String.Format("Country: " + tmp.direction + "\n\n" + "Resort: " + tmp.hotel.Resort + "\n\n" +
                        "Departure:" + tmp.depart.ToShortDateString() + "\n\n" + "Arrival: " + tmp.arrive.ToShortDateString()), "Tour",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Cancel_MouseClick(object sender, MouseEventArgs e)
        {
            dateTimePickerDepar.Value = DateTime.Now;
            dateTimePickerArr.Value = DateTime.Now;
            foreach(var q in rad)
            {
                if(q.Checked == true)
                {
                    q.Checked = false;
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream st = new FileStream("Tours.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            Form1.bin.Serialize(st, ListOfAllTours);
            st.Close();
        }
    }
}
