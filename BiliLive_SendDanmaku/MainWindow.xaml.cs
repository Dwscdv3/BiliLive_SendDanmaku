using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BiliLive_SendDanmaku {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        SettingWindow settingWindow = null;

        public MainWindow() {
            InitializeComponent();
            settingWindow = new SettingWindow();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        public bool Send(string msg, string room, string cookie) {
            var req = WebRequest.Create("http://live.bilibili.com/msg/send") as HttpWebRequest;
            req.ProtocolVersion = HttpVersion.Version11;
            req.Method = "POST";
            req.Host = "live.bilibili.com";
            //req.Connection = "close";
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.86 Safari/537.36";
            req.ContentType = "application/x-www-form-urlencoded";
            req.Accept = "*/*";
            req.Headers.Add("DNT", "1");
            req.Headers.Add("Origin", "static.hdslb.com");
            req.Headers.Add("X-Requested-With", "ShockwaveFlash/19.0.0.245");
            req.Headers.Add("Cookie", cookie);

            var reqData = Encoding.UTF8.GetBytes(string.Format( // 参数 rnd 作用未知
                "color=16777215&fontsize=25&mode=1&msg={0}&rnd=1451379481&roomid={1}", msg, room
            ));
            req.ContentLength = reqData.Length;

            using (var stream = req.GetRequestStream()) {
                stream.Write(reqData, 0, reqData.Length);
            }

            var res = req.GetResponse() as HttpWebResponse;
            var resData = new byte[128];
            var actualBytes = 0;
            using (var stream = res.GetResponseStream()) {
                actualBytes = stream.Read(resData, 0, 128);
            }
            res.Close();

            string result = Encoding.UTF8.GetString(resData);
            if (result[result.IndexOf("code") + 6] == '0') {
                return true;
            } else {
                return false;
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) {
            settingWindow.Close();
            Close();
        }

        private void SettingButton_Click(object sender, RoutedEventArgs e) {
            settingWindow.Show();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.Room) ||
                string.IsNullOrWhiteSpace(Properties.Settings.Default.Cookie)) {

            } else {
                Send(
                    DanmakuTextBox.Text,
                    Properties.Settings.Default.Room,
                    Properties.Settings.Default.Cookie
                );
                DanmakuTextBox.Text = "";
            }
            DanmakuTextBox.Focus();
        }

        private void DanmakuTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                SendButton_Click(null, new RoutedEventArgs());
            }
        }
    }
}
