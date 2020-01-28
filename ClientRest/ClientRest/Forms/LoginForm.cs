using ClientRest.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRest.Forms
{
    public partial class LoginForm : Form
    {
        


        public LoginForm()
        {
            InitializeComponent();
        }
            private void RegisterLabel_Click(object sender, EventArgs e)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("http://localhost:63186/register");
                Process.Start(sInfo);
            }

            private void LoginButton_Click(object sender, EventArgs e)
            {
                RestClass rest = new RestClass();

                PasswordHasher hasher = new PasswordHasher();
                LoginModel login = new LoginModel { Email = MailTB.Text, Password = PasswordTB.Text };
                LoginResult result = rest.postLogin(login);

                if (result.Error == null)
                {
                    using (FileStream stream = new FileStream("token", FileMode.Create))
                    {
                        using (BinaryWriter writer = new BinaryWriter(stream))
                        {
                            writer.Write(result.Token);
                        }
                    }

                    using (FileStream stream = new FileStream("settings", FileMode.Create))
                    {
                        using (BinaryWriter writer = new BinaryWriter(stream))
                        {
                            if (AutoLoginChB.Checked)
                            {
                                writer.Write(1);
                            }
                            else
                            {
                                writer.Write(0);
                            }
                        }
                    }

                    //File.WriteAllText("token.txt", result.Token);
                    MainForm main = new MainForm();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    ErrorLabel.Text = "Błędny login i/lub hasło!";
                }
            }
        }
    }
