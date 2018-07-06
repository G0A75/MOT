#region Namespace

using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

#endregion

namespace MOT.Structure
{
    /// <summary>The Bytes structure.</summary>
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ComVisible(true)]
    [Description("The Bytes structure allows you to easily represent file sizes.")]
    [DesignerCategory("code")]
    public sealed class Bytes
    {
        #region Variables

        private bool _abbreviated;
        private Abbreviations _abbreviations;
        private FileSizeTypes _fileSizeTypes;
        private bool _formatted;
        private long _formattedSize;
        private long _totalSize;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="Bytes" /> class.</summary>
        /// <param name="fileSizeType">The file size type.</param>
        /// <param name="value">The value size.</param>
        public Bytes(FileSizeTypes fileSizeType, long value) : this()
        {
            Update(GetTotalBytes(fileSizeType, value));
        }

        /// <summary>Initializes a new instance of the <see cref="Bytes" /> class.</summary>
        /// <param name="value">The total value size.</param>
        public Bytes(long value) : this()
        {
            Update(value);
        }

        /// <summary>Initializes a new instance of the <see cref="Bytes" /> class.</summary>
        /// <param name="file">The file.</param>
        public Bytes(string file) : this()
        {
            Update(GetFileSize(file));
        }

        /// <summary>Initializes a new instance of the <see cref="Bytes" /> class.</summary>
        public Bytes()
        {
            _abbreviated = false;
            _abbreviations = Abbreviations.B;
            _fileSizeTypes = FileSizeTypes.Bytes;
            _formatted = true;
            _formattedSize = 0;
            _totalSize = 0;

            Update(_totalSize);
        }

        #endregion

        #region Enumerators

        /// <summary>The <see cref="Abbreviations" />.</summary>
        [DefaultValue(B)]
        public enum Abbreviations
        {
            /// <summary>The bytes.</summary>
            B = 0,

            /// <summary>The kilobytes.</summary>
            KB = 1,

            /// <summary>The megabytes.</summary>
            MB = 2,

            /// <summary>The gigabytes.</summary>
            GB = 3,

            /// <summary>The terabytes.</summary>
            TB = 4,

            /// <summary>The petabytes.</summary>
            PB = 5,

            /// <summary>The exabyte.</summary>
            EB = 6,

            /// <summary>The zetta byte.</summary>
            ZB = 7,

            /// <summary>The yotta byte.</summary>
            YB = 8
        }

        /// <summary>The <see cref="FileSizeTypes" />.</summary>
        [DefaultValue(Bytes)]
        public enum FileSizeTypes
        {
            /// <summary>The bytes.</summary>
            Bytes = 0,

            /// <summary>The kilobytes.</summary>
            Kilobyte = 1,

            /// <summary>The megabytes.</summary>
            Megabyte = 2,

            /// <summary>The gigabytes.</summary>
            Gigabyte = 3,

            /// <summary>The terabytes.</summary>
            Terabyte = 4,

            /// <summary>The petabytes.</summary>
            Petabyte = 5,

            /// <summary>The exabyte.</summary>
            Exabyte = 6,

            /// <summary>The zetta byte.</summary>
            ZettaByte = 7,

            /// <summary>The yotta byte.</summary>
            YottaByte = 8
        }

        #endregion

        #region Properties

        /// <summary>Determines whether the <see cref="string"></see> is abbreviated.</summary>
        [DefaultValue(false)]
        public bool Abbreviated
        {
            get
            {
                return _abbreviated;
            }

            set
            {
                if (_abbreviated == value)
                {
                    return;
                }

                _abbreviated = value;
                Update(_totalSize);
            }
        }

        /// <summary>The <see cref="Abbreviation" />.</summary>
        [DefaultValue(typeof(FileSizeTypes), "B")]
        public Abbreviations Abbreviation
        {
            get
            {
                return _abbreviations;
            }
        }

        /// <summary>Determines whether the <see cref="Bytes"></see> is formatted.</summary>
        [DefaultValue(true)]
        public bool Formatted
        {
            get
            {
                return _formatted;
            }

            set
            {
                if (_formatted == value)
                {
                    return;
                }

                _formatted = value;
                Update(_totalSize);
            }
        }

        /// <summary>The amount of <see cref="long"></see> in the <see cref="Bytes"></see>.</summary>
        [DefaultValue(0)]
        public long FormattedSize
        {
            get
            {
                return _formattedSize;
            }
        }

        /// <summary>The <see cref="SizeType" />.</summary>
        [DefaultValue(typeof(FileSizeTypes), "Bytes")]
        public FileSizeTypes SizeType
        {
            get
            {
                return _fileSizeTypes;
            }
        }

        /// <summary>The total amount of <see cref="long"></see> in the <see cref="Bytes"></see>.</summary>
        [DefaultValue(0)]
        public long TotalSize
        {
            get
            {
                return _totalSize;
            }

            set
            {
                if (_totalSize == value)
                {
                    return;
                }

                _totalSize = value;
                Update(_totalSize);
            }
        }

        #endregion

        #region Overrides

        /// <inheritdoc />
        /// <returns>The <see cref="string" />.</returns>
        public override string ToString()
        {
            long _bytesValue = _formatted ? FormatBytes(_totalSize) : _totalSize;
            string _byteExtension = _abbreviated ? GetAbbreviations(_totalSize, _formatted).ToString() : GetFileSizeType(_totalSize, _formatted).ToString();
            return _bytesValue.ToString("0.##") + " " + _byteExtension;
        }

        #endregion

        #region Methods

        /// <summary>Get the abbreviation of the size type.</summary>
        /// <param name="fileSizeTypes">The size type.</param>
        /// <returns>The <see cref="Abbreviations" />.</returns>
        public Abbreviations ConvertToAbbreviation(FileSizeTypes fileSizeTypes)
        {
            Abbreviations _convertAbbreviation;

            switch (fileSizeTypes)
            {
                case FileSizeTypes.Bytes:
                    {
                        _convertAbbreviation = Abbreviations.B;
                        break;
                    }

                case FileSizeTypes.Kilobyte:
                    {
                        _convertAbbreviation = Abbreviations.KB;
                        break;
                    }

                case FileSizeTypes.Megabyte:
                    {
                        _convertAbbreviation = Abbreviations.MB;
                        break;
                    }

                case FileSizeTypes.Gigabyte:
                    {
                        _convertAbbreviation = Abbreviations.GB;
                        break;
                    }

                case FileSizeTypes.Terabyte:
                    {
                        _convertAbbreviation = Abbreviations.TB;
                        break;
                    }

                case FileSizeTypes.Petabyte:
                    {
                        _convertAbbreviation = Abbreviations.PB;
                        break;
                    }

                case FileSizeTypes.Exabyte:
                    {
                        _convertAbbreviation = Abbreviations.EB;
                        break;
                    }

                case FileSizeTypes.ZettaByte:
                    {
                        _convertAbbreviation = Abbreviations.ZB;
                        break;
                    }

                case FileSizeTypes.YottaByte:
                    {
                        _convertAbbreviation = Abbreviations.YB;
                        break;
                    }

                default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(fileSizeTypes), fileSizeTypes, null);
                    }
            }

            return _convertAbbreviation;
        }

        /// <summary>Get the full size type.</summary>
        /// <param name="abbreviations">The abbreviation.</param>
        /// <returns>The <see cref="FileSizeTypes" />.</returns>
        public FileSizeTypes ConvertToSizeType(Abbreviations abbreviations)
        {
            FileSizeTypes _convertSizeType;

            switch (abbreviations)
            {
                case Abbreviations.B:
                    {
                        _convertSizeType = FileSizeTypes.Bytes;
                        break;
                    }

                case Abbreviations.KB:
                    {
                        _convertSizeType = FileSizeTypes.Kilobyte;
                        break;
                    }

                case Abbreviations.MB:
                    {
                        _convertSizeType = FileSizeTypes.Megabyte;
                        break;
                    }

                case Abbreviations.GB:
                    {
                        _convertSizeType = FileSizeTypes.Gigabyte;
                        break;
                    }

                case Abbreviations.TB:
                    {
                        _convertSizeType = FileSizeTypes.Terabyte;
                        break;
                    }

                case Abbreviations.PB:
                    {
                        _convertSizeType = FileSizeTypes.Petabyte;
                        break;
                    }

                case Abbreviations.EB:
                    {
                        _convertSizeType = FileSizeTypes.Exabyte;
                        break;
                    }

                case Abbreviations.ZB:
                    {
                        _convertSizeType = FileSizeTypes.ZettaByte;
                        break;
                    }

                case Abbreviations.YB:
                    {
                        _convertSizeType = FileSizeTypes.YottaByte;
                        break;
                    }

                default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(abbreviations), abbreviations, null);
                    }
            }

            return _convertSizeType;
        }

        /// <summary>Format bytes.</summary>
        /// <param name="value">The value.</param>
        /// <param name="division">The division.</param>
        /// <returns>The <see cref="long" />.</returns>
        public long FormatBytes(long value, long division = 1000)
        {
            var _count = 0;

            while ((value >= division) && (_count + 1 < Enum.GetNames(typeof(FileSizeTypes)).Length))
            {
                _count++;
                value = value / division;
            }

            return value;
        }

        /// <summary>Retrieves the Abbreviations.</summary>
        /// <param name="value">The value.</param>
        /// <param name="formatted">The formatting toggle.</param>
        /// <returns>The <see cref="Abbreviations" />.</returns>
        public Abbreviations GetAbbreviations(long value, bool formatted)
        {
            int _count = formatted ? GetStepCount(value) : 0;
            Abbreviations _getAbbreviations = (Abbreviations)_count;
            return _getAbbreviations;
        }

        /// <summary>Gets the size, in bytes, of the current file.</summary>
        /// <param name="file">The fully qualified name of the file, or the relative file name.</param>
        /// <returns>The <see cref="long" />.</returns>
        public long GetFileSize(string file)
        {
            if (!File.Exists(file))
            {
                throw new FileNotFoundException($"The file was not found: {file}");
            }

            return new FileInfo(file).Length;
        }

        /// <summary>Retrieves the FileSizeType.</summary>
        /// <param name="value">The value.</param>
        /// <param name="formatted">The formatting toggle.</param>
        /// <returns>The <see cref="FileSizeTypes" />.</returns>
        public FileSizeTypes GetFileSizeType(long value, bool formatted)
        {
            int _count = formatted ? GetStepCount(value) : 0;
            FileSizeTypes _getFileSizeTypes = (FileSizeTypes)_count;
            return _getFileSizeTypes;
        }

        /// <summary>Retrieve the step count from the value.</summary>
        /// <param name="value">The total bytes value.</param>
        /// <returns>The <see cref="int" />.</returns>
        public int GetStepCount(long value)
        {
            var _count = 0;

            while ((value >= 1000) && (_count + 1 < Enum.GetNames(typeof(FileSizeTypes)).Length))
            {
                _count++;
                value = value / 1000;
            }

            return _count;
        }

        /// <summary>Retrieves the total bytes.</summary>
        /// <param name="sizeType">The size type.</param>
        /// <param name="value">The value.</param>
        /// <param name="division">The division.</param>
        /// <returns>The <see cref="long" />.</returns>
        public long GetTotalBytes(FileSizeTypes sizeType, long value, long division = 1000)
        {
            long _totalValue;

            switch (sizeType)
            {
                case FileSizeTypes.Bytes:
                    {
                        _totalValue = value;
                        break;
                    }

                case FileSizeTypes.Kilobyte:
                    {
                        _totalValue = value * division;
                        break;
                    }

                case FileSizeTypes.Megabyte:
                    {
                        _totalValue = value * division * division;
                        break;
                    }

                case FileSizeTypes.Gigabyte:
                    {
                        _totalValue = value * division * division * division;
                        break;
                    }

                case FileSizeTypes.Terabyte:
                    {
                        _totalValue = value * division * division * division * division;
                        break;
                    }

                case FileSizeTypes.Petabyte:
                    {
                        _totalValue = value * division * division * division * division * division;
                        break;
                    }

                case FileSizeTypes.Exabyte:
                    {
                        _totalValue = value * division * division * division * division * division * division;
                        break;
                    }

                case FileSizeTypes.ZettaByte:
                    {
                        _totalValue = value * division * division * division * division * division * division * division;
                        break;
                    }

                case FileSizeTypes.YottaByte:
                    {
                        _totalValue = value * division * division * division * division * division * division * division * division;
                        break;
                    }

                default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(sizeType), sizeType, null);
                    }
            }

            return _totalValue;
        }

        /// <summary>Update the structure.</summary>
        /// <param name="value">The total bytes value.</param>
        private void Update(long value)
        {
            _formattedSize = value;
            _totalSize = value;

            if (_formatted)
            {
                _formattedSize = FormatBytes(_totalSize);
            }

            _fileSizeTypes = GetFileSizeType(_totalSize, _formatted);
            _abbreviations = ConvertToAbbreviation(_fileSizeTypes);
        }

        #endregion
    }
}