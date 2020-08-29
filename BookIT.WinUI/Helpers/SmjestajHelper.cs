using BookIT.WinUI.Smjestaji;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.Helpers
{
    public class SmjestajHelper
    {

        public static void EditSmjestaj(Model.Smjestaj entity, Form callerForm)
        {
            switch (entity.TipSmjestaja)
            {
                case Model.TipSmjestaja.Apartman:
                case Model.TipSmjestaja.Vila:
                case Model.TipSmjestaja.Kuca:
                    var frm1 = new frmSmjestajDetalji(entity.SmjestajId, callerForm);

                    callerForm.Hide();
                    frm1.Location = callerForm.Location;
                    if (callerForm is frmSmjestaji frmSmjestaji)
                    {
                        frmSmjestaji.FrmMain.UpdateSizeAndLocation(frm1);
                        frmSmjestaji.ChildForm = frm1;
                    }
                    if (callerForm is frmDodajSmjestaj frmDodajSmjestaj)
                    {
                        frmDodajSmjestaj.FrmMain.UpdateSizeAndLocation(frm1);
                        frmDodajSmjestaj.ChildForm = frm1;
                    }


                    frm1.ShowDialog();
                    callerForm.Show();
                    break;

                case Model.TipSmjestaja.Hotel:
                case Model.TipSmjestaja.Hostel:
                case Model.TipSmjestaja.Motel:
                    var frm2 = new frmSmjestajDetaljiSobe(entity.SmjestajId, callerForm);

                    callerForm.Hide();
                    frm2.Location = callerForm.Location;
                    if (callerForm is frmSmjestaji frmSmjestaji1)
                    {
                        frmSmjestaji1.FrmMain.UpdateSizeAndLocation(frm2);
                        frmSmjestaji1.ChildForm = frm2;
                    }
                    if (callerForm is frmDodajSmjestaj frmDodajSmjestaj1)
                    {
                        frmDodajSmjestaj1.FrmMain.UpdateSizeAndLocation(frm2);
                        frmDodajSmjestaj1.ChildForm = frm2;
                    }
                    frm2.ShowDialog();
                    callerForm.Show();
                    break;
                default:
                    break;
            }
        }





    }
}
