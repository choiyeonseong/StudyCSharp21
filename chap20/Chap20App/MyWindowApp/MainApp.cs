using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowApp
{
    class MainApp : Form
    {
        public MainApp(string title)
        {
            this.Text = title;
            this.MouseClick += MainApp_MouseClick;  // 마우스 클릭 이벤트
        }

        private void MainApp_MouseClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            var result = $"sender : {sender}\r\n" +
                         $"e : {e}\r\n" +
                         $"e.X : {e.X}, e.Y : {e.Y}\r\n" +
                         $"Button : {e.Button}, Clicks : {e.Clicks}";
            MessageBox.Show(result);
        }

        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event App"));
        }
    }
}
