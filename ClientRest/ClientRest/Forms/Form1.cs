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

        /*górny textbox to InputTB - jeśli wrzucimy do niego np. https://localhost:44361/api/products i klikniemy button1,
         *to GET'em zostaną pobrane wszystkie produkty. Następnie zostaną one przypisane do comboboxa; 
         * json zostanie wyświetlony w dolnym textboxie OutputTB.
         * */
        private void button1_Click(object sender, EventArgs e)
        {
            RestClass rest = new RestClass();
            rest.endPoint = InputTB.Text;
            string json = OutputTB.Text = rest.makeRequest();
            Test test = new Test();
            TestCollection ts = new TestCollection();
            ts.tests = JsonConvert.DeserializeObject<List<Test>>(json);
            comboBox1.DataSource = ts.tests;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "name";
        }


        /*w tym przypadku po kliknięciu button2 na adres podany w InputTB wysyłamy POST'em json pobierany z OutputTB.
         * 
         * */
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
