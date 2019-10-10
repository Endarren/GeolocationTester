using System;
using System.Windows.Forms;

using System.Device.Location;
namespace PrototypeGeolocationB
{
    public partial class Form1 : Form
    {
        private GeoCoordinateWatcher Watcher = null;
        public Form1()
        {
            InitializeComponent();
            Watcher = new GeoCoordinateWatcher();
            Watcher.StatusChanged += Watcher_StatusChanged;
            Watcher.PositionChanged += Watcher_PositionChanged; ;
            Watcher.Start();
        }

        private void Watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<System.Device.Location.GeoCoordinate> e)
        {
            
        }

        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            watcherStatusLabel.Text = e.Status.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pos = Watcher.Position;
            if (!pos.Location.IsUnknown)
            {
                latitudeDisplay.Text = pos.Location.Latitude.ToString();
                longitudeDisplay.Text = pos.Location.Longitude.ToString();
                unknownLabel.Visible = false;
                positionPanel.Visible = true;
            }
            else
            {
                unknownLabel.Visible = true;
                positionPanel.Visible = false;
            }
        }
    }
}
