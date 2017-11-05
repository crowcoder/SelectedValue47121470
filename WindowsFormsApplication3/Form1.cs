using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ListOfStuff> los = new List<ListOfStuff>
            {
                new ListOfStuff { intProperty = 1, stringProperty = "one" },
                new ListOfStuff { intProperty = 2, stringProperty = "two" },
                new ListOfStuff { intProperty = 3, stringProperty = "three" }
            };

            comboBox1.DataSource = los;
            comboBox1.ValueMember = "intProperty";
            comboBox1.DisplayMember = "stringProperty";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This works too
            //var nls = new ListOfStuff { intProperty = 2, stringProperty = "two" }; 
            //comboBox1.SelectedValue = nls.intProperty;

            comboBox1.SelectedValue = 1;
        }
    }
}
