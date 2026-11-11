using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MyMp3Player
{
    public class Mp3Player
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        private void SendCommand(string command)
        {
            mciSendString(command, null, 0, 0);
        }

        public void Open(string file)
        {
            SendCommand("close MediaFile");
            string command = "open \"" + file + "\" type MPEGVideo alias MediaFile";
            SendCommand(command);
        }

        public void Play()
        {
            SendCommand("play MediaFile");
        }

        public void Pause()
        {
            SendCommand("pause MediaFile");
        }

        public void Stop()
        {
            SendCommand("stop MediaFile");
            SendCommand("seek MediaFile to start");
        }
        public int GetLenght()
        {
            StringBuilder sb = new StringBuilder(128);
            mciSendString("status MediaFile lenght", sb, 128, 0);
            if (int.TryParse(sb.ToString(), out int lenght))
            {
                return lenght / 1000;
            }
            return 0;
        }

        public int GetPosition()
        {
            StringBuilder sb = new StringBuilder(128);
            mciSendString("status MediaFile position", sb, 128, 0);
            if (int.TryParse(sb.ToString(),out int position))
            {
                return position / 1000;
            }
            return 0;
        }

        public void Seek (int seconds)
        {
            int miliseconds = seconds * 1000;
            SendCommand("seek MediFile to " + miliseconds);
            SendCommand("play MediaFile");
        }
    }
}