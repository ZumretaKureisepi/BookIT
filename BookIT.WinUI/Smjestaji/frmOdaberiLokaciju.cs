using BookIT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.Smjestaji
{
    public partial class frmOdaberiLokaciju : Form
    {
        public double Lat { get => IsValidLat(txtLat.Text) ? double.Parse(txtLat.Text) : 0; }
        public double Lng { get => IsValidLng(txtLat.Text) ? double.Parse(txtLng.Text) : 0; }
        public Smjestaj Smjestaj { get; }

        public frmOdaberiLokaciju(Model.Smjestaj smjestaj)
        {
            InitializeComponent();

            txtLat.Text = smjestaj.Latitude.ToString("0.00000");
            txtLng.Text = smjestaj.Longitude.ToString("0.00000");

            webBrowser1.Url = new Uri(Application.StartupPath + "\\map.html");
            webBrowser1.ObjectForScripting = new ScriptingObject(this);
            Smjestaj = smjestaj;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOdaberiLokaciju_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }


        [ComVisible(true)]
        public class ScriptingObject
        {
            private readonly frmOdaberiLokaciju frm;

            public ScriptingObject(frmOdaberiLokaciju frmInitial)
            {
                this.frm = frmInitial;
            }

            // can be called from JavaScript
            public void SetLatLng(double lat, double lng)
            {
                frm.txtLat.TextChanged -= frm.TxtLat_Leave;
                frm.txtLng.TextChanged -= frm.TxtLat_Leave;

                frm.txtLat.Text = lat.ToString("0.00000");
                frm.txtLng.Text = lng.ToString("0.00000");

                frm.txtLat.TextChanged += frm.TxtLat_Leave;
                frm.txtLng.TextChanged += frm.TxtLat_Leave;
            }

            public void OnLoad()
            {
                if (frm.Smjestaj.Latitude != 0 && frm.Smjestaj.Longitude != 0)
                {
                    frm.EvalCode("setLocationMarker({ lat: " + frm.Smjestaj.Latitude.ToString().Replace(",", ".") + ", lng: " + frm.Smjestaj.Longitude.ToString().Replace(",", ".") + "});");
                    frm.EvalCode("map.setCenter({ lat: " + frm.Smjestaj.Latitude.ToString().Replace(",", ".") + ", lng: " + frm.Smjestaj.Longitude.ToString().Replace(",", ".") + "});");
                    frm.EvalCode("map.setZoom(18);");
                }
                       
            }
        }


        private void TxtLat_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            if (!IsValidLat(control.Text))
                errorProvider1.SetError(control, "Decimal value is required.");
            else
            {
                errorProvider1.SetError(control, null);
                return;
            }
            e.Cancel = true;
        }

        private void TxtLng_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            if (!IsValidLng(control.Text))
                errorProvider1.SetError(control, "Decimal value is required.");
            else
            {
                errorProvider1.SetError(control, null);
                return;
            }
            e.Cancel = true;
        }

        private void TxtLat_Leave(object sender, EventArgs e)
        {
            if (IsValidLat(txtLat.Text) && IsValidLng(txtLng.Text))
            {
                var lat = double.Parse(txtLat.Text).ToString("0.00000");
                var lng = double.Parse(txtLng.Text).ToString("0.00000");

                EvalCode("map.setCenter({lat: " + lat + ", lng: " + lng + "}); ");
                EvalCode("setLocationMarker(new google.maps.LatLng(" + lat + ", " + lng + ")); ");
            }
        }



        private void EvalCode(string code)
        {
            webBrowser1.Document.InvokeScript("eval", new object[] { code });
        }

        private static bool IsValidLat(string lat)
        {
            return !string.IsNullOrWhiteSpace(lat) && double.TryParse(lat, out double val) && val >= -90 && val <= 90;
        }
        private static bool IsValidLng(string lng)
        {
            return !string.IsNullOrWhiteSpace(lng) && double.TryParse(lng, out double val) && val >= -180 && val <= 180;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
