using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DimTimChat.Droid.somee;

namespace DimTimChat
{
    public partial class MainPage : ContentPage
    {
        public DateTime lastTime;
        public string Username;

        public MainPage()
        {
            InitializeComponent();
            #region Size set
            Size size = Device.Info.PixelScreenSize;

            MessagesLabelScrollView.HeightRequest = size.Height - 81;
            MessageEditor.WidthRequest = size.Width / 2 - 75;
            #endregion
        }

        private bool UpdateMessages()
        {
            var b = true;
            var s = new ChatService().GetMessages(ref lastTime, ref b);

            if (s.Length > 0) {
                Device.BeginInvokeOnMainThread(() =>
                {
                    MessagesLabel.Text += '\n' + string.Join('\n', s);
                    MessagesLabelScrollView.ScrollToAsync(MessagesLabel, ScrollToPosition.End, false);
                });
            }

            return true;
        }

        private void SendButton_Clicked(object sender, EventArgs e)
        {
            if (Username == null) {

                if (MessageEditor.Text.Trim() == "" || MessageEditor.Text.Trim() == null) {
                    return;
                }
                Username = MessageEditor.Text.Trim();
                MessageEditor.Text = "";

                MessagesLabel.Text = "";

                var client = new ChatService();
                lastTime = DateTime.Now;
                var b = false;
                client.SendMessage($"Пользователь {Username} вошёл в чат.");
                var s = client.GetMessages(ref lastTime, ref b);

                MessagesLabel.Text = string.Join('\n', s);

                //Device.StartTimer(TimeSpan.FromSeconds(1), () => {
                MessagesLabelScrollView.ScrollToAsync(MessagesLabel, ScrollToPosition.End, false);
                //    return false;
                //});

                Device.StartTimer(TimeSpan.FromMilliseconds(500), UpdateMessages);

            }

            if (MessageEditor.Text != "") {
                new ChatService().SendMessage(Username + " : " + MessageEditor.Text);
                MessageEditor.Text = "";
            }
            MessagesLabelScrollView.ScrollToAsync(MessagesLabel, ScrollToPosition.End, false);
        }



        protected override void OnDisappearing()
        {
            if (Username != null)
                new ChatService().SendMessage($"Пользователь {Username} покинул чат.");
            base.OnDisappearing();
        }
    }
}
