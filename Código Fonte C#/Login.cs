using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using Sistema___CPA.Arquivos;

namespace Sistema___CPA
{
    public partial class Login : Form
    {
        public bool asLogin = false;
        public Login()
        {
            InitializeComponent();
            tSenha.UseSystemPasswordChar = true;
            this.asLogin = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
      
        private void Button1_Click(object sender, EventArgs e)
        {
           

           

            if (String.IsNullOrEmpty(tLogin.Text))
            {
                MessageBox.Show("Não deixe o Login em branco");
                return;
            }
            if (String.IsNullOrEmpty(tSenha.Text))
            {
                MessageBox.Show("Não deixe a Senha em branco");

                return;
            }

            DataBase Data = new DataBase();

            string Query = "select `user`.* from `user` where `login` = '"+tLogin.Text+ "' and `pass` = '" + tSenha.Text + "';";
            Data.processQuery(Query, nResult =>
            {
                if (nResult.Read())
                {
                    if (String.IsNullOrEmpty(nResult["id"].ToString()))
                        return;

            
                    this.asLogin = true;
                }
                nResult.Close();
            });

            if (this.asLogin)
            {
                
              
                this.Hide();
  

                Window Forms = new Window(); Forms.Show();
                return;
            }
            else
                MessageBox.Show("Credenciais inválidas, solicite uma com o administrador de T.I");


        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
      
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
