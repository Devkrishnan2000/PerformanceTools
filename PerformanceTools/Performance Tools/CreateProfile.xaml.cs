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
using Performance_Tools.Classes;

namespace Performance_Tools
{
    /// <summary>
    /// Interaction logic for CreateProfile.xaml
    /// </summary>
    public partial class CreateProfile : Window
    {
        bool createflag;

        // boolean indicator to indicate that create btn is clicked so that profile WILL NOT be created if we simply close the window 
            public bool Createprof
        {
            get { return createflag; }
        }
        public  CreateProfile()
        {
            var profile = new ProfInfo();
            InitializeComponent();
 
        }

        private void maxbtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void minbtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void closebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if(Mouse.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

       

        private void stapm_slide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {


          
        }

        public ProfInfo getprofdata()
        { //gets data form silders (from label since both are linked)
            ProfInfo info = new ProfInfo();
            info.Profname = Profname.Text;
            info.Stapmlimit = int.Parse(stapmval.Text);
            info.Fastlimit = int.Parse(fastval.Text);
            info.Slowlimit = int.Parse(slowval.Text);
            info.Templimit = int.Parse(tempwval.Text);
            return info;
        }


        private void createprof_Click(object sender, RoutedEventArgs e)
        {
            //sets createflag true to indicate create btn is clicked
            Window.GetWindow(this).DialogResult = true;
            createflag = true;
            Window.GetWindow(this).Close();    
        }
    }
}
