using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Assignment.Entity;
using Assignment.Service;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        private MemberService memberService;
        private int gender = 0;

        public Register()
        {
            this.InitializeComponent();
            this.memberService = new MemberServiceImp();
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var member = new Member
            {
                //firstName = "Le",
                //lastName = "Que",
                //password = "2701le@que",
                //address = "Thanh Xuan",
                //avatar = "https://i.ytimg.com/vi/MBtJdkiEhBk/maxresdefault.jpg",
                //birthday = "1994-12-16",
                //email = "ngocquektqd@gmail.com",
                //gender = 1,
                //introduction = "Assignmet Sem 3",
                //phone = "0358789709"
                firstName = this.FirstName.Text,
                lastName = this.LastName.Text,
                password = this.Password.Text,
                address = this.Address.Text,
                avatar = this.Avatar.Text,
                birthday = Birthday.Date.ToString("yyyy-MM-dd"),
                email = this.Email.Text,
                gender = gender,
                introduction = this.Introduction.Text,
                phone = this.Phone.Text
            };
            // validate phía client.
            Debug.WriteLine(JsonConvert.SerializeObject(member));

            member = memberService.Register(member);
            if (member == null)
            {
                // show error
            }
            else
            {
                // show success
            }
        }
        private void BGRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null)
            {
                string colorName = rb.Tag.ToString();
                switch (colorName)
                {
                    case "Male":
                        break;
                    case "Female":
                        gender = 1;
                        break;
                    case "Other":
                        gender = 2;
                        break;
                }
            }
        }


    }
}
