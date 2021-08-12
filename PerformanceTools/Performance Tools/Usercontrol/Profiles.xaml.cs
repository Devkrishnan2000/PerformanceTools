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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using Microsoft.Toolkit.Uwp.Notifications;
using System.IO;
using Performance_Tools.Classes;

namespace Performance_Tools.Usercontrol
{
    /// <summary>
    /// Interaction logic for Profiles.xaml
    /// This class responsible fot selecting and creating profiles 
    /// </summary>
    public partial class Profiles : UserControl
    {
        public Metadata[] metadata = new Metadata[5];  //arraty of five metadata objects it stores info about five profiles eg metadata[0] stores info about prof1
        public Profiles()
        {
            InitializeComponent();
            loadprof();
            
        }

        private void perfbtn_Click(object sender, RoutedEventArgs e)
        {
            profile_exe("--stapm-limit=30000 --fast-limit=35000 --slow-limit=25000 --tctl-temp=90","performance");
        }

        private void normfbtn_Click(object sender, RoutedEventArgs e)
        {     
            profile_exe("--stapm-limit=25000 --fast-limit=30000 --slow-limit=25000 --tctl-temp=75","Normal");
        }

        private void savfbtn_Click(object sender, RoutedEventArgs e)
        {
            profile_exe("--stapm-limit=15000 --fast-limit=20000 --slow-limit=10000 --tctl-temp=75","Powersave");
        }

        private void profile_exe(string arg ,string profname)

        {
            //clears previous notfications of the app so that notification area is not bloated
            ToastNotificationManagerCompat.History.Clear(); 

            // the bellow code takes args which contains the arguments to set the profile such as STAP-limit =2000 etc
            //and executes ryzenadj with those arguments tp change TDP and temp limit
            Process process = new Process();
            process.StartInfo.FileName = @"ryzenadj.exe";
            process.StartInfo.Arguments =arg ;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();

            //toastcontentbuilder class is responsible for showing notifcation after profile is set
            new ToastContentBuilder()      
           .AddArgument("action", "viewConversation")
           .AddArgument("conversationId", 9813)
           .AddText("Profile " + profname + " has been activated") // profile name with the given text is shown in notification
           .Show();
        }

        //bellow fun is common for all ad profile buttons
       private void profclick(object sender, RoutedEventArgs e)
        {
            
            Button btn = (Button)sender;  //identifies which of tbe 5 buttons is clicked
            int profnum;

            // each button is named like prof1 prof2 prof3 etc the bellow code gets the number part of the name
            // for eg for btn prof1 pronum value will be 1 
            // the profnum value is ALWAYS in the range of 1-5;

            profnum =  int.Parse(btn.Name.Substring(btn.Name.ToString().Length-1,1));
            
               
                switch (profnum)   
                {
                    // cases 1-5 indicates actions for each of the 5 buttons
                    // to check weather if the profile is created or not we check weather the label profXtxt is empty or not (X can be 1-5)
                    // if its empty the profile is not yet created then we execute profcreate function which returns the name of the profile
                    // otherwise we execute the profile_exe function which activates that profile

                    case 1:
                        if (!string.IsNullOrEmpty(prof1txt.Content.ToString()))
                            profile_exe(readargs(btn.Name), readname(btn.Name));
                        else
                            prof1txt.Content = profcreate(profnum, btn.Name.ToString(), btn);
                        break;
                    case 2:
                        if (!string.IsNullOrEmpty(prof2txt.Content.ToString()))
                            profile_exe(readargs(btn.Name), readname(btn.Name));
                        else
                            prof2txt.Content = profcreate(profnum, btn.Name.ToString(), btn);
                        break;

                    case 3:
                        if (!string.IsNullOrEmpty(prof3txt.Content.ToString()))
                            profile_exe(readargs(btn.Name), readname(btn.Name));
                        else
                            prof3txt.Content = profcreate(profnum, btn.Name.ToString(), btn);
                        break;

                    case 4:
                        if (!string.IsNullOrEmpty(prof4txt.Content.ToString()))
                            profile_exe(readargs(btn.Name), readname(btn.Name));
                        else
                            prof4txt.Content = profcreate(profnum, btn.Name.ToString(), btn);
                        break;

                    case 5:
                        if (!string.IsNullOrEmpty(prof5txt.Content.ToString()))
                            profile_exe(readargs(btn.Name), readname(btn.Name));
                        else
                            prof5txt.Content = profcreate(profnum, btn.Name.ToString(), btn);
                        break;

                }
            
           
        }

       

        private string profcreate(int profnum,string btnName, Button btn)
        {
            ProfInfo profInfo;  //this object is used to get stapm limit temp limit etc from createprofile window
            CreateProfile createProfile = new CreateProfile();
            createProfile.ShowDialog();
            if (createProfile.Createprof == true) //this value will only be true if we click create btn in createprofile window
            {
                profInfo = createProfile.getprofdata();
                string stapm = (profInfo.Stapmlimit * 1000).ToString();
                string fast = (profInfo.Fastlimit * 1000).ToString();
                string slow = (profInfo.Slowlimit * 1000).ToString();
                string temp = (profInfo.Templimit).ToString();
                //creates the arg for ryzenadj from given values
                string arg = "--stapm-limit=" + stapm + " --fast-limit=" + fast + " --slow-limit=" + slow + " --tctl-temp=" + temp;
                string metadata ="\nSTAPM LIMIT :"+profInfo.Stapmlimit+"\nFAST LIMIT :"+profInfo.Fastlimit+"\nSLOW LIMIT :"+profInfo.Slowlimit+"\nTEMP LIMIT :"+profInfo.Templimit;
                try
                { //creates directory profile and writes the nameof the profile and arguments to a txt file
                    //name of txt file is same as the btn from which this function is called 
                    if (!Directory.Exists("Profile"))
                    {
                        Directory.CreateDirectory("Profile");
                    }
                    else
                    {
                        if (File.Exists("profile\\" + btnName + ".txt"))       
                            File.Delete("profile\\" + btnName + ".txt");
                    }
                    using (FileStream fs = File.Create("profile\\" + btnName + ".txt"))
                    {
                        Byte[] profname = new UTF8Encoding(true).GetBytes(profInfo.Profname + '\n');
                        Byte[] ryzenadjcmd = new UTF8Encoding(true).GetBytes(arg);
                        Byte[] profilemetadata = new UTF8Encoding(true).GetBytes(metadata);
                        fs.Write(profname, 0, profname.Length);
                        fs.Write(ryzenadjcmd, 0, ryzenadjcmd.Length);
                        fs.Write(profilemetadata, 0, profilemetadata.Length);
                    }

                    setimage(btn);

                   
                    return profInfo.Profname;
                }
                catch (Exception)
                {

                }
       
            }
            return "";
        }
        
        private string readargs(string filename)
        {
            //this function gets arguments from the given file name (used as an argument in profile_exe function)
            try
            {
                if(File.Exists("profile\\" + filename + ".txt"))
                {
                    using(StreamReader st = new StreamReader("profile\\" + filename + ".txt"))
                    {
                        string val =null;
                        for(int i=0;i<2;++i)
                        {
                            val =st.ReadLine();
                        }
                        return val;
                    }
                }
            }
            catch (Exception)
            {

            }
            return null;
        }

        private string readname(string filename)
        {
            //this function gets name of the profile from the given file name (used as an argument in profile_exe function)
            try
            {
                if (File.Exists("profile\\" + filename + ".txt"))
                {
                    using (StreamReader st = new StreamReader("profile\\" + filename + ".txt"))
                    {
                        string val = null;
                        val =st.ReadLine();
                        return val;
                    }
                }
            }
            catch (Exception)
            {

            }
            return null;
        }

        private void readmeta(string filename, int profnum)
        {
            //responsible for reading profile info from file so that tooltip would work
            Metadata tempdata = new Metadata();
            try
            {
                if (File.Exists("profile\\" + filename + ".txt"))
                {
                    using (StreamReader st = new StreamReader("profile\\" + filename + ".txt"))
                    {

                       for(int i=1;i<=6;++i)
                        {
                            
                            var temp = st.ReadLine();
                            if (i == 3)
                                tempdata.Stapmval = temp;
                            if (i == 4)
                                tempdata.Fastval = temp;
                            if (i == 5)
                               tempdata.Slowval = temp;
                            if (i == 6)
                                tempdata.Tempval = temp;
                        }
                    }
                    metadata[profnum] = tempdata;  // stores data to global metdata object
                }
            }
            catch (Exception)
            {

            }
        }


        private void setimage(Button btn)
        {
            //this function changes the plus image to settings image once the profile has been created
           

            btn.ApplyTemplate(); //forces the button to apply template so that bellow code can execute without issue
            Image image = (Image)btn.Template.FindName("icon", btn); //try to get the icon component from add_btn controltemplate
            if(image != null)
                image.Source = new BitmapImage(new Uri(@"\Images\settings.png", UriKind.Relative)); //changes the img
        }


        private void loadprof()
        {//this function is executed at the begining of program 
            // it checks weather any profiles (profX.txt files) exist in profile directory
            //if exists then it gets the profile name from file
            try
            {
                for (int i = 1; i <= 5; ++i)
                {
                    if (File.Exists("profile\\prof" + i + ".txt"))
                    {
                        using (StreamReader st = new StreamReader("profile\\prof" + i + ".txt"))
                        {
                            switch (i)
                            {
                                case 1:                              //since first line of the file contains the profile name
                                    prof1txt.Content = st.ReadLine();
                                    readmeta("prof1",0);                 //reads meta data and stres in global metadata object                  
                                    setimage(prof1);
                                    break;
                                case 2:
                                    prof2txt.Content = st.ReadLine();
                                    readmeta("prof2",1);
                                    setimage(prof2);
                                    break;
                                case 3:
                                    prof3txt.Content = st.ReadLine();
                                    readmeta("prof3",2);
                                    setimage(prof3);
                                    break;
                                case 4:
                                    prof4txt.Content = st.ReadLine();
                                    readmeta("prof4",3);
                                    setimage(prof4);
                                    break;
                                case 5:
                                    prof5txt.Content = st.ReadLine();
                                    readmeta("prof5",4);
                                    setimage(prof5);
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }      
        }

        private void toolTipOpening(object sender, ToolTipEventArgs e)
        {
           Button btn = (Button)sender;
           ToolTip toolTip = (ToolTip)btn.ToolTip;
           int   profnum = int.Parse(btn.Name.Substring(btn.Name.ToString().Length - 1, 1));
            profnum = profnum - 1;   //gets the profile number acording to the btn
            if (toolTip!= null)
            { 
               
                toolTip.ApplyTemplate();
                Label stapm = (Label)toolTip.Template.FindName("stapm",toolTip);
                Label fast = (Label)toolTip.Template.FindName("fast", toolTip);
                Label slow = (Label)toolTip.Template.FindName("slow", toolTip);
                Label temp = (Label)toolTip.Template.FindName("temp", toolTip);
                Label profinfo = (Label)toolTip.Template.FindName("profinfo", toolTip);

                if (stapm!= null && fast!=null && slow!=null && temp!=null)
                {
                    
                    if(metadata[profnum]!=null)
                    {                      
                            stapm.Content = metadata[profnum].Stapmval;
                            fast.Content = metadata[profnum].Fastval;
                            slow.Content = metadata[profnum].Slowval;
                            temp.Content = metadata[profnum].Tempval;      
                    }
                    else
                    {
                       
                        profinfo.Visibility = Visibility.Collapsed;
                        stapm.Content = "Create New Profile";
                        fast.Visibility = Visibility.Collapsed;
                        slow.Visibility = Visibility.Collapsed;
                        temp.Visibility = Visibility.Collapsed;
                    }
                }
               

            }
        }
    }

    public class Metadata
    {
        string stapmval;
        string fastval;
        string slowval;
        string tempval;

        public string Stapmval
        {
            get { return stapmval; }
            set { stapmval = value; }
        }

        public string Fastval
        {
            get { return fastval; }
            set { fastval = value; }
        }

        public string Slowval
        {
            get {  return slowval; }
            set { slowval = value; }
        }

        public string Tempval
        {
            get { return tempval; }
            set { tempval = value; }
        }
    }
}
