using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMap_Control
{
    public partial class Form1 : Form
    {
        //https://marketplace.visualstudio.com/items?itemName=NuGetTeam.NuGetPackageManagerforVisualStudio2013
        GMap.NET.WindowsForms.GMapControl gmap;
        public Form1()
        {
            InitializeComponent();
            gmap = new GMap.NET.WindowsForms.GMapControl();
            gmap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            gmap.Dock = DockStyle.Fill;
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.ShowCenter = false;
            gmap.MinZoom = 1;
            gmap.MaxZoom = 20;
            splitContainer1.Panel2.Controls.Add(gmap);

            gmap.Position = new PointLatLng(Convert.ToDouble(latitude.Text), Convert.ToDouble(longitude.Text));
            gmap.Zoom = 5;
        }

        private void go_Coordinate_Click(object sender, EventArgs e)
        {
            gmap.Position = new PointLatLng(Convert.ToDouble(latitude.Text),Convert.ToDouble(longitude.Text));
            gmap.Zoom = 5;
            gmap.Update();
            gmap.Refresh(); 

        }
        private void change_zoom_Click(object sender, EventArgs e)
        {
            gmap.Zoom = Convert.ToDouble(zoom_level.Text);
            gmap.Update();
            gmap.Refresh();

        }

        private void activate_drag_Click(object sender, EventArgs e)
        {
            gmap.DragButton = MouseButtons.Left;
        }

        private void active_mouse_click_Click(object sender, EventArgs e)
        {
            gmap.MouseClick += gmap_MouseClick;
        }

        void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("X:" + e.X.ToString() + " and Y:" + e.Y.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("marker1");
       
            var marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                new PointLatLng(Convert.ToDouble(latitude.Text), Convert.ToDouble(longitude.Text)),
                GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small);

            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
        }

        private void add_marker_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var markersOverlay = gmap.Overlays.FirstOrDefault(overlay => overlay.Id == "marker1");

            if (markersOverlay != null)
            {
                markersOverlay.Markers.Clear();
                gmap.Overlays.Remove(markersOverlay);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gmap.MouseClick -= gmap_MouseClick;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gmap.DragButton = MouseButtons.None;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void zoom_level_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
