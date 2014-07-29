using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YoutubeMusicStoreAndPlay
{
    public partial class Form1 : Form
    {

        private List<YoutubeVideo> YoutubeVideoList = new List<YoutubeVideo>();

        public Form1()
        {
            InitializeComponent();

            LoadVideoItems();

            ReloadListBox();

        }

        #region ButtonControls

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            if (txtVideoName.Text != "" && txtVideoURL.Text.Substring(0, 31) == "http://www.youtube.com/watch?v=")
            {
                YoutubeVideoList.Add(new YoutubeVideo(txtVideoName.Text, txtVideoURL.Text.Substring(31, 11))); 
                txtVideoName.Clear();
                txtVideoURL.Clear();
            }
            else if (txtVideoName.Text != "" && txtVideoURL.Text.Substring(0, 32) == "https://www.youtube.com/watch?v=")
            {
                YoutubeVideoList.Add(new YoutubeVideo(txtVideoName.Text, txtVideoURL.Text.Substring(32, 11)));
                txtVideoName.Clear();
                txtVideoURL.Clear();
            }
            else
                MessageBox.Show("You didn't filled in the name or Youtube url right.");

            SaveVideoItems();

            ReloadListBox();

            DisableAddVideo();

            lbVideoList.SelectedIndex = YoutubeVideoList.Count -1;
        }

        private void btnCopySelectedVideoName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(YoutubeVideoList[lbVideoList.SelectedIndex].Title);
        }

        private void btnCopySelectedVideoURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("http://www.youtube.com/watch?v=" + YoutubeVideoList[lbVideoList.SelectedIndex].VideoURL);
        }

        private void btnCopyVideoListNames_Click(object sender, EventArgs e)
        {
            string tempString = "";
            foreach (YoutubeVideo item in YoutubeVideoList)
            {
                tempString += string.Format("{0}\r\n", item.Title);
            }

            Clipboard.SetText(tempString);

        }

        private void btnAddNewVideo_Click(object sender, EventArgs e)
        {
            if (btnAddVideo.Visible == false)
            {
                EnableAddVideo();
                btnAddNewVideo.Text = "Dis. add video";
            }
            else
            {
                DisableAddVideo();
                btnAddNewVideo.Text = "Ena. add video";
            }
        }

        private void btnUpdateVideoInto_Click(object sender, EventArgs e)
        {
            if (btnAddVideo.Visible == false)
            {
                if (txtVideoName.Text != "" && txtVideoURL.Text.Substring(0, 31) == "http://www.youtube.com/watch?v=")
                {
                    YoutubeVideoList[lbVideoList.SelectedIndex] = new YoutubeVideo(txtVideoName.Text, txtVideoURL.Text.Substring(31, 11));
                    txtVideoName.Clear();
                    txtVideoURL.Clear();
                }
                else if (txtVideoName.Text != "" && txtVideoURL.Text.Substring(0, 32) == "https://www.youtube.com/watch?v=")
                {
                    YoutubeVideoList[lbVideoList.SelectedIndex] = new YoutubeVideo(txtVideoName.Text, txtVideoURL.Text.Substring(32, 11));
                    txtVideoName.Clear();
                    txtVideoURL.Clear();
                }
                else
                    MessageBox.Show("You didn't filled in the name or Youtube url right.");

                SaveVideoItems();

                ReloadListBox();
            }
            else
            {
                MessageBox.Show("Disable add video mode first! Then you can update the selected video's info.");
            }

        }

        private void btnPlayRandomVideo_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            int tempInt = random.Next(0, YoutubeVideoList.Count());

            string tempURL = YoutubeVideoList[tempInt].VideoURL;

            axShockwaveFlash1.Movie = "http://youtube.com/v/" + tempURL + "&loop=1&autoplay=1";

            lbVideoList.SelectedIndex = tempInt;

            tabControl1.SelectedIndex = 1;

        }

        private void btnPlayAndRemove_Click(object sender, EventArgs e)
        {

            string tempURL = YoutubeVideoList[lbVideoList.SelectedIndex].VideoURL;

            axShockwaveFlash1.Movie = "http://youtube.com/v/" + tempURL + "?autoplay=1&showinfo=0&rel=0&showinfo=0";

            tabControl1.SelectedIndex = 1;

            YoutubeVideoList.RemoveAt(lbVideoList.SelectedIndex);

            SaveVideoItems();

            ReloadListBox();

        }

        #endregion


        #region OtherControls

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveVideoItems();
        }

        private void txtVideoURL_Enter_1(object sender, EventArgs e)
        {
            if (btnAddVideo.Visible)
                txtVideoURL.Clear();
            else
                txtVideoName.SelectAll();
        }

        private void txtVideoURL_Leave_1(object sender, EventArgs e)
        {
            if (txtVideoURL.Text == "")
                txtVideoURL.Text = "Example: http://www.youtube.com/watch?v=abcdefghijk";
        }

        private void btnPlaySelectedVideo_Click(object sender, EventArgs e)
        {
            if(lbVideoList.SelectedIndex != -1)
            {

                string tempURL = YoutubeVideoList[lbVideoList.SelectedIndex].VideoURL;

                axShockwaveFlash1.Movie = "http://youtube.com/v/" + tempURL + "?autoplay=1&showinfo=0&rel=0&showinfo=0";

                tabControl1.SelectedIndex = 1;

            }
        }

        private void lbVideoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbVideoList.SelectedIndex != -1)
            {
                
                DisableAddVideo();
            }
            
        }


        #endregion


        #region Methodes

        private void DirectoryAndFileChecker()
        {
            #region CheckDirectory
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\"))
            {

            }
            else
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\");
            }
            #endregion

            #region CheckStoringFile
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\" + "YoutubeVideo.txt"))
            {

            }
            else
            {
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\" + "YoutubeVideo.txt");
            }
            #endregion

        }

        private void SaveVideoItems()
        {
            List<string> tempStringList = new List<string>();

            foreach (YoutubeVideo item in YoutubeVideoList)
            {
                tempStringList.Add(item.PrintVideoStorage);
            }
            
            DirectoryAndFileChecker();

            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\" + "YoutubeVideo.txt", tempStringList.ToArray());

        }

        private void LoadVideoItems()
        {

            string[] tempStringArray;

            DirectoryAndFileChecker();

            tempStringArray = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Youtube video Storing\\" + "YoutubeVideo.txt");

            foreach (string item in tempStringArray)
            {

                YoutubeVideoList.Add(new YoutubeVideo(item.Substring(11), item.Substring(0, 11)));

            }
            

        }

        private void ReloadListBox()
        {

            lbVideoList.DataSource = null;

            List<string> tempTitleList = new List<string>();

            foreach (YoutubeVideo item in YoutubeVideoList)
            {
                tempTitleList.Add(item.Title);
            }

            lbVideoList.DataSource = tempTitleList;

        }

        private void EnableAddVideo()
        {

            txtVideoName.Text = "";
            txtVideoURL.Text = "Example: http://www.youtube.com/watch?v=abcdefghijk";
            btnAddVideo.Visible = true;


        }

        private void DisableAddVideo()
        {

            txtVideoName.Text = YoutubeVideoList[lbVideoList.SelectedIndex].Title;
            txtVideoURL.Text = "http://www.youtube.com/watch?v=" + YoutubeVideoList[lbVideoList.SelectedIndex].VideoURL;
            btnAddVideo.Visible = false;

        }

        #endregion

        private void btnRemoveVideo_Click(object sender, EventArgs e)
        {

            YoutubeVideoList.RemoveAt(lbVideoList.SelectedIndex);

            SaveVideoItems();

            ReloadListBox();

        }

        private void btnMoveSelectedItemUp_Click(object sender, EventArgs e)
        {

            if(lbVideoList.SelectedIndex != -1 && lbVideoList.SelectedIndex != 0)
            {

                YoutubeVideo tempYoutubeVideo = YoutubeVideoList[lbVideoList.SelectedIndex];

                YoutubeVideoList[lbVideoList.SelectedIndex] = YoutubeVideoList[lbVideoList.SelectedIndex - 1];

                YoutubeVideoList[lbVideoList.SelectedIndex - 1] = tempYoutubeVideo;

                lbVideoList.SelectedIndex--;

                SaveVideoItems();

                ReloadListBox();


            }
        }

        private void btnMoveSelectedItemDown_Click(object sender, EventArgs e)
        {

            if (lbVideoList.SelectedIndex != -1 && lbVideoList.SelectedIndex != YoutubeVideoList.Count)
            {

                YoutubeVideo tempYoutubeVideo = YoutubeVideoList[lbVideoList.SelectedIndex];

                YoutubeVideoList[lbVideoList.SelectedIndex] = YoutubeVideoList[lbVideoList.SelectedIndex + 1];

                YoutubeVideoList[lbVideoList.SelectedIndex + 1] = tempYoutubeVideo;

                lbVideoList.SelectedIndex++;

                SaveVideoItems();

                ReloadListBox();


            }

        }       

        
        #region URLControlMethodes

        #endregion

    }
}
