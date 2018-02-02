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
        }
        #endregion

        private void BtLoadFolder_Click(object sender, EventArgs e)
        {
           
            FolderBrowserDialog addMusic = new FolderBrowserDialog();
            addMusic.ShowDialog();
            string musicFolder = addMusic.SelectedPath;
            
            try
            {
                musicFiles = Directory.EnumerateFiles(musicFolder, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith(";
                foreach(string o in musicFiles)
                {
                    musicFile.Add(o);
                }
                musicFiles = (string[])musicFile.ToArray(typeof(string));
               
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(@"Unable to open folder." + Environment.NewLine + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int what = visualCheckedListBox1.Items.Count;
            int Filelength = musicFolder.Length + 1;
            visualCheckedListBox1.Items.Clear();
            
            if (visualCheckedListBox1.Items.Count == 0)
            {
                
                for (int i = 0; i < musicFiles.Length; i++)
                {
                    int temp = musicFiles[i].LastIndexOf('\\');
                    visualCheckedListBox1.Items.Add(musicFiles[i].Remove(0, temp+1));
                }
               
            }
            
        }
    
        private void VisualCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayMusic();

        }

       
    }
}
