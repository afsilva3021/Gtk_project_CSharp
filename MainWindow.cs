using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Gtk;
using program.Controllers;
using UI = Gtk.Builder.ObjectAttribute;

namespace program
{
    class MainWindow : Window
    {
        [UI] private Entry TextUser = null;
        [UI] private Entry TextSenha = null;
        [UI] private Button btnEntrar = null;
        [UI] private Label labelInf = null;


        public MainWindow() : this(new Builder("WindowsForm.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetRawOwnedObject("WindowsForm"))
        {
            builder.Autoconnect(this);

            // DeleteEvent += Window_DeleteEvent;
            btnEntrar.Clicked += Button_Clicked;
            this.Close();

        }

        public void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        public void Button_Clicked(object sender, EventArgs a)
        {
            

            if (TextUser.Text == "admin" && TextSenha.Text == "123")
            {
                this.Hide();

                var app = new Application("org.program.program", GLib.ApplicationFlags.None);
                

                Dashboard dash = new Dashboard();
                app.AddWindow(dash);

                dash.Show();
                
                
            }
            else
            {
                labelInf.Text = "Usuário ou senha incorretos";
            }
        }

    }
}
