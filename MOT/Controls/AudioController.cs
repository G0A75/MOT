#region Namespace

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using MOT.Managers;

using NAudio.Wave;

using TagLib;

#endregion

namespace MOT.Controls
{
    /// <summary>The audio controller.</summary>
    public partial class AudioController : UserControl
    {
        #region Variables

        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;
        private int previousVolume;
        private System.Timers.Timer timeElapsed;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="AudioController" /> class.</summary>
        /// <param name="file">The file.</param>
        public AudioController(string file) : this()
        {
            audioFile = new AudioFileReader(file);
        }

        /// <summary>Initializes a new instance of the <see cref="AudioController" /> class.</summary>
        public AudioController()
        {
            InitializeComponent();

            audioFile = null;
            outputDevice = new WaveOutEvent();
            outputDevice.PlaybackStopped += OutputDevice_PlaybackStopped;

            outputDevice.Volume = 0.7F;
            pbVolume.Value = Convert.ToInt32(outputDevice.Volume * 100);

            tbTimeLine.Value = 0;

            timeElapsed = new System.Timers.Timer
            {
                       Interval = 1000 
                    };

            timeElapsed.Elapsed += TimeElapsed_Elapsed;
        }

        #endregion

        #region Events

        /// <summary>The volume updated event.</summary>
        public event EventHandler PlayButtonClick
        {
            add
            {
                btPlay.Click += value;
            }

            remove
            {
                btPlay.Click -= value;
            }
        }

        /// <summary>The song completed playing.</summary>
        public event EventHandler SongCompleted;

        /// <summary>The song playing event.</summary>
        public event EventHandler SongPlaying;

        /// <summary>The volume updated event.</summary>
        public event EventHandler VolumeUpdated;

        #endregion

        #region Properties

        /// <summary>Gets the song duration.</summary>
        [Browsable(false)]
        public TimeSpan Duration
        {
            get
            {
                return audioFile.TotalTime;
            }
        }

        [Browsable(false)]
        public MusicListView History { get; set; }

        [Browsable(false)]
        public MusicListView Library { get; set; }

        /// <summary>Gets a value whether the music player is muted.</summary>
        [Browsable(false)]
        public bool Muted
        {
            get
            {
                if (outputDevice.Volume == 0.0F)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>Retrieves the playback state.</summary>
        [Browsable(false)]
        public PlaybackState PlaybackState
        {
            get
            {
                return outputDevice.PlaybackState;
            }
        }

        [Browsable(false)]
        public bool PlayButtonEnabled
        {
            get
            {
                return btPlay.Enabled;
            }

            set
            {
                if (btPlay.InvokeRequired)
                {
                    btPlay.Invoke(new MethodInvoker(delegate
                        {
                            btPlay.Enabled = value;
                        }));
                }
                else
                {
                    btPlay.Enabled = value;
                }
            }
        }

        /// <summary>Determines whether the control is playing a song.</summary>
        [Browsable(false)]
        public bool Playing
        {
            get
            {
                return outputDevice.PlaybackState == PlaybackState.Playing;
            }
        }

        [Browsable(false)]
        public MusicListView UpNext { get; set; }

        /// <summary>Gets or sets the volume.</summary>
        public int Volume
        {
            get
            {
                return Convert.ToInt32(outputDevice.Volume * 100);
            }

            set
            {
                if (value < 0)
                {
                    outputDevice.Volume = 0F;
                    OnVolumeUpdated();
                }
                else if (value > 100)
                {
                    outputDevice.Volume = 1F;
                    OnVolumeUpdated();
                }
                else
                {
                    int currentVolume = Convert.ToInt32(outputDevice.Volume * 100);

                    if (currentVolume != value)
                    {
                        float newVolume = value / 100.0F;
                        outputDevice.Volume = newVolume;

                        OnVolumeUpdated();
                    }
                }
            }
        }

        #endregion

        #region Overrides

        /// <summary>Occurs when the song completed.</summary>
        protected virtual void OnSongCompleted()
        {
            SongCompleted?.Invoke(this, EventArgs.Empty);

            if (UpNext.Items.Count == 0)
            {
                tbTimeLine.Value = 0;
                btPlay.Text = AudioControllerConstants.Play;
                btPlay.Refresh();

                // Clear the current value.
                lCurrent.Text = MusicManager.FormatTimeSpan(new TimeSpan());
            }

            // Retrieve current completed song path.
            string path = audioFile.FileName;

            // Add song to history.
            if (History.InvokeRequired)
            {
                History.Invoke(new MethodInvoker(delegate
                    {
                        History.Items.Add(ListManager.CreateItem(path));
                    }));
            }
            else
            {
                History.Items.Add(ListManager.CreateItem(path));
            }

            NextSong();
        }

        /// <summary>Occurs when the song is playing.</summary>
        protected virtual void OnSongPlaying()
        {
            SongPlaying?.Invoke(this, EventArgs.Empty);

            string currentTime = MusicManager.FormatTimeSpan(audioFile.CurrentTime);
            string durationTime = MusicManager.FormatTimeSpan(audioFile.TotalTime);

            if (lCurrent.InvokeRequired)
            {
                lCurrent.Invoke(new MethodInvoker(delegate
                    {
                        lCurrent.Text = currentTime;
                    }));
            }
            else
            {
                lCurrent.Text = currentTime;
            }

            if (lDurationTotal.InvokeRequired)
            {
                lDurationTotal.Invoke(new MethodInvoker(delegate
                    {
                        lDurationTotal.Text = durationTime;
                    }));
            }
            else
            {
                lDurationTotal.Text = durationTime;
            }

            // var progress = (musicPlayer.CurrentTime.TotalSeconds / musicPlayer.Duration.TotalSeconds) * 100;
            int currentSeconds = Convert.ToInt32(audioFile.CurrentTime.TotalSeconds);

            if (tbTimeLine.InvokeRequired)
            {
                tbTimeLine.Invoke(new MethodInvoker(delegate
                    {
                        tbTimeLine.Value = currentSeconds;
                    }));
            }
            else
            {
                tbTimeLine.Value = currentSeconds;
            }
        }

        /// <summary>Occurs when the volume is updated.</summary>
        protected virtual void OnVolumeUpdated()
        {
            pbVolume.Value = Convert.ToInt32(outputDevice.Volume * 100);
            pbVolume.Refresh();
            VolumeUpdated?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Methods

        /// <summary>Decrease the volume.</summary>
        /// <param name="value">The value</param>
        public void DecreaseVolume(int value)
        {
            float volume = value / 100.0F;
            float total = outputDevice.Volume - volume;

            // Bug: Unable to go below 10%.
            if (total < 0.0F)
            {
                return;
            }

            outputDevice.Volume -= volume;
            OnVolumeUpdated();
        }

        /// <summary>Increase the volume.</summary>
        /// <param name="value">The value</param>
        public void IncreaseVolume(int value)
        {
            float volume = value / 100.0F;
            float total = outputDevice.Volume + volume;

            if (total > 1.0F)
            {
                return;
            }

            outputDevice.Volume += volume;
            OnVolumeUpdated();
        }

        /// <summary>Forward to next song.</summary>
        public void NextSong()
        {
            if (UpNext.Items.Count == 0)
            {
                return;
            }

            string path = UpNext.GetFilePath(0);
            ListViewItem currentlyPlaying = ListManager.CreateItem(path);

            if (UpNext.Items.Count != 0)
            {
                if (UpNext.InvokeRequired)
                {
                    UpNext.Invoke(new MethodInvoker(delegate
                        {
                            if (UpNext.Items[0].Text == currentlyPlaying.Text)
                            {
                                UpNext.Items.RemoveAt(0);
                            }
                        }));
                }
                else
                {
                    if (UpNext.Items[0].Text == currentlyPlaying.Text)
                    {
                        UpNext.Items.RemoveAt(0);
                    }
                }

                PlaySong(UpNext.GetFilePath(0));
            }
        }

        /// <summary>Pause playing the song.</summary>
        public void Pause()
        {
            btPlay.Text = AudioControllerConstants.Play;
            tbTimeLine.Enabled = false;
            outputDevice.Pause();
            timeElapsed.Stop();
        }

        /// <summary>Play the song file.</summary>
        /// <param name="filePath">The file path.</param>
        public void PlaySong(string filePath)
        {
            Play(new FileInfo(filePath));
        }

        /// <summary>Play the previous song.</summary>
        public void PreviousSong()
        {
            if (History.Items.Count != 0)
            {
                if (History.InvokeRequired)
                {
                    History.Invoke(new MethodInvoker(delegate
                        {
                            string path = History.GetFilePath(History.Items.Count);
                            PlaySong(path);
                        }));
                }
                else
                {
                    string path = History.GetFilePath(History.Items.Count - 1);
                    PlaySong(path);
                }
            }
        }

        /// <summary>Stop the audio from playing.</summary>
        public void Stop()
        {
            btPlay.Text = AudioControllerConstants.Play;
            btPlay.Refresh();
            tbTimeLine.Enabled = false;
            outputDevice.Stop();
            timeElapsed.Stop();
        }

        /// <summary>Toggles the volume mute control.</summary>
        public void ToggleMute()
        {
            if (Muted)
            {
                outputDevice.Volume = (float)previousVolume / 100;
            }
            else
            {
                previousVolume = Convert.ToInt32(outputDevice.Volume * 100);
                outputDevice.Volume = 0F;
            }

            OnVolumeUpdated();
        }

        /// <summary>TogglePlayState the song file.</summary>
        /// <param name="filePath">The file path.</param>
        public void TogglePlayState(string filePath)
        {
            if ((Library.Items.Count > 0) || (UpNext.Items.Count > 0))
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    filePath = Library.GetFilePath(Library.SelectedItems[0].Index);
                }

                switch (outputDevice.PlaybackState)
                {
                    case PlaybackState.Stopped:
                        {
                            PlaySong(filePath);
                            break;
                        }

                    case PlaybackState.Playing:
                        {
                            Pause();
                            break;
                        }

                    case PlaybackState.Paused:
                        {
                            PlaySong(filePath);
                            break;
                        }

                    default:
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                }

                btPlay.Refresh();
            }
        }

        /// <summary>Play button.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void BtPlay_Click(object sender, EventArgs e)
        {
            TogglePlayState(null);
        }

        /// <summary>Occurs when the playback stopped.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            try
            {
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        /// <summary>TogglePlayState the selected song.</summary>
        /// <param name="file">The file.</param>
        private void Play(FileInfo file)
        {
            if (!file.Exists)
            {
                throw new FileNotFoundException(nameof(file.FullName));
            }

            btPlay.Text = AudioControllerConstants.Pause;
            btPlay.Refresh();

            Tag fileTags = FileManager.GetFileTags(file.FullName);
            lTitle.Text = $@"{fileTags.Title} - {fileTags.FirstAlbumArtist}";

            tbTimeLine.Enabled = true;

            if (audioFile == null)
            {
                audioFile = new AudioFileReader(file.FullName);
                outputDevice.Init(audioFile);
                tbTimeLine.Value = 0;
                tbTimeLine.Maximum = Convert.ToInt32(audioFile.TotalTime.TotalSeconds);
            }
            else if (audioFile != null)
            {
                audioFile = new AudioFileReader(file.FullName);

                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Init(audioFile);
                }

                tbTimeLine.Value = 0;
                tbTimeLine.Maximum = Convert.ToInt32(audioFile.TotalTime.TotalSeconds);
            }

            if (outputDevice != null)
            {
                outputDevice.Play();
            }

            timeElapsed.Start();
        }

        /// <summary>Occurs when the time line is scrolled.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void TbTimeLine_Scroll(object sender, EventArgs e)
        {
            switch (outputDevice.PlaybackState)
            {
                case PlaybackState.Stopped:
                    {
                        audioFile.CurrentTime = new TimeSpan(0, 0, 0, tbTimeLine.Value, 0);
                        break;
                    }

                case PlaybackState.Playing:
                    {
                        // outputDevice.Stop();
                        outputDevice.Pause();
                        audioFile.CurrentTime = new TimeSpan(0, 0, 0, tbTimeLine.Value, 0);
                        outputDevice.Play();
                        break;
                    }

                case PlaybackState.Paused:
                    {
                        audioFile.CurrentTime = new TimeSpan(0, 0, 0, tbTimeLine.Value, 0);
                        break;
                    }

                default:
                    {
                        throw new ArgumentOutOfRangeException();
                    }
            }
        }

        /// <summary>Occurs when the timer event is firing.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void TimeElapsed_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            OnSongPlaying();

            if (tbTimeLine.InvokeRequired)
            {
                tbTimeLine.Invoke(new MethodInvoker(delegate
                    {
                        if (tbTimeLine.Value == Convert.ToInt32(audioFile.TotalTime.TotalSeconds))
                        {
                            timeElapsed.Stop();
                            OnSongCompleted();
                        }
                    }));
            }
            else
            {
                if (tbTimeLine.Value == Convert.ToInt32(audioFile.TotalTime.TotalSeconds))
                {
                    timeElapsed.Stop();
                    OnSongCompleted();
                }
            }
        }

        private struct AudioControllerConstants
        {
            public static FontFamily FontFamily = new FontFamily("Webdings");
            public const string Pause = ";";
            public const string Play = "4";
        }

        #endregion
    }
}