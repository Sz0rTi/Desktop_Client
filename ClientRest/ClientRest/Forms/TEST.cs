using ClientRest.Models;
using Hanssens.Net;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRest.Forms
{
    public partial class TEST : Form
    {
        public LocalStorage storage { get; set; }
        public TEST()
        {
            LocalStorage storage = new LocalStorage();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestClass rest = new RestClass();
            
            PasswordHasher hasher = new PasswordHasher();
            LoginModel login = new LoginModel { Email = textBox1.Text, Password = textBox2.Text/*hasher.HashPassword(textBox2.Text)*/ };
            LoginResult result = rest.postLogin(login);
            if(result.Error == null)
            {
                textBox3.Text = result.Token;
                //storage.Store("authToken", result.Token);
                File.WriteAllText("token.txt", result.Token);
                MainForm main = new MainForm();
                main.Show();
            }
            
        }
    }
}
