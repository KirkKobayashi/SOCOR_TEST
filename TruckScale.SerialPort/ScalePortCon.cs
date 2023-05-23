using System.Text;

namespace TruckScale.ScaleSerialPort
{
    public class ScalePortCon : IDisposable
    {
        private ScalePort _sp;

        private StringBuilder sb;
        private string rawData;
        private string appendedData;

        public event EventHandler<SerialDataEventArgs> SerialDataReceieved;
        public ScalePortCon(ScalePort sp)
        {
            _sp = sp;
        }

        public void OpenPort()
        {
            try
            {
                if (_sp.IsOpen == false)
                {
                    _sp.DataReceived += _sp_DataReceived;
                    _sp.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void _sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (_sp.IsOpen)
            {
                rawData = _sp.ReadExisting();
                sb = new StringBuilder();
                SerialDataReceieved(this, new SerialDataEventArgs(rawData, _sp.StartIndex, _sp.EndIndex));
                //foreach (char c in rawData)
                //{
                //    if (c == _sp.TerminationCharacter)
                //    {
                //        appendedData = sb.ToString();

                //        SerialDataReceieved(this, new SerialDataEventArgs(appendedData, _sp.StartIndex, _sp.EndIndex));
                //        rawData = string.Empty;
                //        _sp.DiscardInBuffer();
                //        sb.Clear();

                //    }
                //    else
                //    {
                //        sb.Append(c);
                //    }
                //}
            }
        }

        #region Disposal
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (_sp.IsOpen == true)
                    {
                        _sp.DataReceived -= _sp_DataReceived;
                        _sp.DiscardInBuffer();
                        _sp.Close();
                    }
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            disposed = true;
            GC.SuppressFinalize(this);
        } 
        #endregion
    }
}
