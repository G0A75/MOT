#region Namespace

using System.Collections.Generic;

#endregion

namespace MOT.Structure
{
    internal class Extension
    {
        #region Methods

        /// <summary>Retrieves the supported extension filter for the file dialog.</summary>
        /// <returns>The <see cref="string" />.</returns>
        public static string SupportedExtensionFilter()
        {
            string extensionFilter = null;
            var supportedExtensions = SupportedExtensions();

            // Setup filter.
            for (var i = 0; i < supportedExtensions.Count; i++)
            {
                if (i == 0)
                {
                    extensionFilter += $@"{supportedExtensions[i]}";
                }
                else
                {
                    extensionFilter += $@";{supportedExtensions[i]}";
                }
            }

            return $@"Audio Files|{extensionFilter}";
        }

        /// <summary>The supported application extensions.</summary>
        /// <returns>The <see cref="string" />.</returns>
        public static List<string> SupportedExtensions()
        {
            return new List<string>
                {
                    "*.mp3",
                    "*.wav",
                    "*.wma",
                    "*.aiff",
                    "*.flac"
                };
        }

        #endregion
    }
}