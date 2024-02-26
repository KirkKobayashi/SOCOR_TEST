namespace TruckScale.UI.HelperClass
{
    public class PrintSettings
    {
        public string  PrinterName { get; set; }
        public int startX { get; set; } = 10;
        public int startY { get; set; } = 10;
        public int yOffset { get; set; } = 20;
        public int xOffset { get; set; } = 0;
        public string HeaderFont { get; set; } = "Courier New";
        public int HeaderFontHeight { get; set; } = 12;
        public string BodyFont { get; set; } = "Courier New";
        public int BodyFontHeigt { get; set; } = 9;
        public int PaperSize_X { get; set; } = 300;
        public int PaperSize_Y { get; set; } = 600;
        public string HeaderText1 { get; set; } = string.Empty;
        public string HeaderText2 { get; set; } = string.Empty;
    }
}
