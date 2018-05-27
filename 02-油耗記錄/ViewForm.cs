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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            
        }

        private void BindData()
        {
            var context = new ContactsModel();
            var list = context.RefuleTable.ToList();
           // dataGridView1.DataSource = list;
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            List<RefuleTable> findData = new List<RefuleTable>(); 
            
            foreach(var item in list)
            {
                if (start <= item.RefuelingData && item.RefuelingData <= end)
                {
                    findData.Add(item);
                }
            }
             dataGridView1.DataSource = findData.ToList();

            var Sum = findData.Sum((x) => x.Kilometer)/findData.Sum((y)=>y.Liter);
            label1.Text = Sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }

       
    }
}
