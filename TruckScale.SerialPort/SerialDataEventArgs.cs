namespace TruckScale.ScaleSerialPort
{
    public class SerialDataEventArgs
    {
        public string Data;

        public SerialDataEventArgs(string dataInArray, int trimStart, int trimEnd)
        {
            var len = dataInArray.Length;

            //if (len >= trimStart + trimEnd)
            if (len >= trimEnd + trimStart)
            {
                Data = dataInArray.Substring(trimStart, trimEnd);
            }
        }
    }
}