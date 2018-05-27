using _02_油耗記錄.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_油耗記錄
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            RefuleTable data = new RefuleTable()
            {
                RefuelingData = dateTimePicker1.Value,
                Liter = Convert.ToDouble(numericUpDown1.Value),
                Kilometer = Convert.ToDouble(numericUpDown2.Value)
            };
            try
            {
                ContactsModel context = new ContactsModel();
                context.RefuleTable.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"發生錯誤 {ex.ToString()}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }
    }
}
