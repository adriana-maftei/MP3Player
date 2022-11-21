using System.Runtime.InteropServices;
using System.Text;

namespace MP3Player
{
    internal class Mp3player
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString,
            int uReturnLenght, int hwdCallBack);

        public void OpenFile(string file)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, file);
            mciSendString(command, null, 0, 0);
        }

        public void Play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void Stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }
    }
}