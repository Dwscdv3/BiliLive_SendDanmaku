using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BiliLive_SendDanmaku {
    /// <summary>
    /// SettingWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SettingWindow : Window {
        public SettingWindow() {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            Properties.Settings.Default.Room = RoomTextBox.Text;
            Properties.Settings.Default.Cookie = CookieTextBox.Text;
            Properties.Settings.Default.Save();
            Hide();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e) {
            Hide();
        }

        private void RoomTextBox_TextInput(object sender, TextCompositionEventArgs e) {
            foreach (char c in e.Text) {
                if (!char.IsDigit(c)) {
                    e.Handled = true;
                }
            }
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) {
            bool b = (bool)e.NewValue;
            if (b) {
                RoomTextBox.Text = Properties.Settings.Default.Room;
                CookieTextBox.Text = Properties.Settings.Default.Cookie;
            } else {
                RoomTextBox.Text = "";
                CookieTextBox.Text = "";
            }
        }
    }
}
