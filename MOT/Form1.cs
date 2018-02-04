using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualPlus;
using System.IO;
using NAudio.Wave;
using System.Collections;
namespace MOT
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        int n = 0;
     
        ArrayList musicFile = new ArrayList();
       
        string[] musicFiles;
        
        public Form1()
        {
            InitializeComponent();
        }
#region PlayBack
        
        private void BtPlay_Click(object sender, EventArgs e)
        {
            PlayMusic();
           
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            outputDevice.PlaybackStopped += OnPlaybackStopped;
            
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            
            try
            {
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
            }
            catch(Exception wait)
            {
                
            }
        }

        private void PlayMusic()
        {

            n = visualCheckedListBox1.SelectedIndex;
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                
            }

            if (audioFile == null)
            {
              
                audioFile = new AudioFileReader(musicFiles[n]);
                outputDevice.Init(audioFile);
                
                
            }
            else if (audioFile != null)
            {
                audioFile = new AudioFileReader(musicFiles[n]);
                outputDevice?.Stop();

                outputDevice.Init(audioFile);
               
            }
           

            outputDevice.Play();
            outputDevice.Volume = (float)trackBar1.Value / 100;
        }
        #endregion

        private void BtLoadFolder_Click(object sender, EventArgs e)
        {
           
            FolderBrowserDialog addMusic = new FolderBrowserDialog();
            addMusic.ShowDialog();
            string musicFolder = addMusic.SelectedPath;
            var _extensions = new List<string>
                {
                    "*.mp3",
                    "*.wav",
                    "*.wma",
                    "*.aiff",
                    "*.flac"
                    
                };
            
            visualCheckedListBox1.Items.Clear();

            var _files = FileHelper.SearchDirectory(musicFolder, _extensions, true);
            musicFiles = _files.ToArray();
            int fileLength;
            foreach (string _file in _files)
            {
                fileLength = _file.LastIndexOf('\\');
                visualCheckedListBox1.Items.Add(_file.Remove(0,fileLength+1));
            }

        }
    
        private void VisualCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayMusic();

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

            if (outputDevice.Volume <= 1.0f)
            {

                outputDevice.Volume = (float)trackBar1.Value / 100;
                visualLabel1.Text = outputDevice.Volume.ToString();
            }
         
        }
    }
   
}
