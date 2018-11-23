using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCrossApp.Models;

namespace XamarinCrossApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserView : ContentPage
    {
        private SQLiteConnection conn;
        public User model;
        public UserView()
        {
            InitializeComponent();
            conn = DependencyService.Get<Interface.ISQLite>().GetConnection();
            conn.CreateTable<User>();
        }

        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            model = new User();
            model.UserName = entryUserName.Text;
            model.UserPassword = entryPasswordName.Text;
            model.UserEmail = entryEmail.Text;
            conn.Insert(model);
            entryUserName.Text = "";
            entryPasswordName.Text = "";
            entryEmail.Text = "";
        }

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            try
            {
                var data = (from luser in conn.Table<User>() select luser);
                dataListUser.ItemsSource = data;
             
                    //DisplayAlert("Login", data[0], "OK");
                
            }
            catch (Exception ex) { DisplayAlert("Error", ex.Message, "Cancel"); }

         
        }
    }
}