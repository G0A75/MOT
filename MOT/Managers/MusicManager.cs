#region Namespace

using System;
using System.IO;

using NAudio.Wave;

#endregion

namespace MOT.Managers
{
    internal class MusicManager
    {
        #region Methods

        /// <summary>Format the time span.</summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string FormatTimeSpan(TimeSpan timeSpan)
        {
            string hours = timeSpan.Hours.ToString("00");
            string minutes = timeSpan.Minutes.ToString("00");
            string seconds = timeSpan.Seconds.ToString("00");
            return $@"{hours} : {minutes} : {seconds}";
        }

        /// <summary>Retrieves the song duration.</summary>
        /// <param name="file">The file.</param>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public static TimeSpan GetSongDuration(FileInfo file)
        {
            return new AudioFileReader(file.FullName).TotalTime;
        }

        #endregion
    }
}