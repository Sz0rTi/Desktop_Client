using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestClass rest = new RestClass();
            rest.endPoint = InputTB.Text;
            //OutputTB.Text = rest.makeRequest();
            string json = rest.makeRequest();
            Test test = new Test();
            //test = JsonConvert.DeserializeObject<Test>(OutputTB.Text);
            TestCollection ts = new TestCollection();
            ts.tests = JsonConvert.DeserializeObject<List<Test>>(json);
            comboBox1.DataSource = ts.tests;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "name";
            //string a = httpVerb.DELETE.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RestClass rest = new RestClass();
            rest.endPoint = InputTB.Text;
            string json = OutputTB.Text;
            Test test = new Test();
            test = JsonConvert.DeserializeObject<Test>(json);
            rest.postRequest(test);
        }

    }
}
