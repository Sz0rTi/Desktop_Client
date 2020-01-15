using ClientRest.Models.In;
using ClientRest.Models.Out;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRest.Forms
{
    public partial class NewCategoryForm : Form
    {
        RestClass rest = new RestClass();
        public NewCategoryForm()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox1.Text != "")
            {
                CategoryOut temp = new CategoryOut { Name = textBox1.Text };
                var category = rest.postRequest<Category, CategoryOut>(temp, controller.categories);
                //this.Parent.Refresh();
                this.Close();
            }
        }
    }
}
