using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;
using System.Web.UI.WebControls;


namespace Zadanie1
{
    public partial class Kalkulator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPodajTrzeciaLicz_Click(object sender, EventArgs e)
        {
            labThirdNum.Visible = true;
            tbThirdNum.Visible = true;
            btnDodaj1.Visible = true;
            btnOdejmij1.Visible = true;
            btnPomnoz1.Visible = true;
            btnPodziel1.Visible = true;
        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            if (labResult.Visible == false || tbResult.Visible == false || btnSaveToBase.Visible == false)
            {
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }
            else if (labResult.Visible == true || tbResult.Visible == true || btnSaveToBase.Visible == true)
            {
                labResult.Visible = false;
                tbResult.Visible = false;
                btnSaveToBase.Visible = false;
                tbResult.Text = "";
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }

            Calculating calc = new Calculating();
            double wynik = calc.Addition(Convert.ToInt32(tbFirstNum.Text), Convert.ToInt32(tbSecondNum.Text));

            tbResult.Text = Convert.ToString(wynik);

        }

        protected void btnOdejmij_Click(object sender, EventArgs e)
        {
            if (labResult.Visible == false || tbResult.Visible == false || btnSaveToBase.Visible == false)
            {
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }
            else if (labResult.Visible == true || tbResult.Visible == true || btnSaveToBase.Visible == true)
            {
                labResult.Visible = false;
                tbResult.Visible = false;
                btnSaveToBase.Visible = false;
                tbResult.Text = "";
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }

            Calculating calc = new Calculating();
            double wynik = calc.Subtraction(Convert.ToInt32(tbFirstNum.Text), Convert.ToInt32(tbSecondNum.Text));

            tbResult.Text = Convert.ToString(wynik);
        }

        protected void btnPomnoz_Click(object sender, EventArgs e)
        {
            if (labResult.Visible == false || tbResult.Visible == false || btnSaveToBase.Visible == false)
            {
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }
            else if (labResult.Visible == true || tbResult.Visible == true || btnSaveToBase.Visible == true)
            {
                labResult.Visible = false;
                tbResult.Visible = false;
                btnSaveToBase.Visible = false;
                tbResult.Text = "";
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }

            Calculating calc = new Calculating();
            double wynik = calc.Multiplication(Convert.ToInt32(tbFirstNum.Text), Convert.ToInt32(tbSecondNum.Text));

            tbResult.Text = Convert.ToString(wynik);
        }

        protected void btnPodziel_Click(object sender, EventArgs e)
        {
            if (labResult.Visible == false || tbResult.Visible == false || btnSaveToBase.Visible == false)
            {
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }
            else if (labResult.Visible == true || tbResult.Visible == true || btnSaveToBase.Visible == true)
            {
                labResult.Visible = false;
                tbResult.Visible = false;
                btnSaveToBase.Visible = false;
                tbResult.Text = "";
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }

            Calculating calc = new Calculating();
            double wynik = calc.Division(Convert.ToInt32(tbFirstNum.Text), Convert.ToInt32(tbSecondNum.Text));

            tbResult.Text = Convert.ToString(wynik);
        }

        protected void btnDodaj1_Click(object sender, EventArgs e)
        {
            if (labResult.Visible == false || tbResult.Visible == false || btnSaveToBase.Visible == false)
            {
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }
            else if (labResult.Visible == true || tbResult.Visible == true || btnSaveToBase.Visible == true)
            {
                labResult.Visible = false;
                tbResult.Visible = false;
                btnSaveToBase.Visible = false;
                tbResult.Text = "";
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }

            Calculating calc = new Calculating();
            double wynik = calc.AdditionPlus(Convert.ToInt32(tbFirstNum.Text), Convert.ToInt32(tbSecondNum.Text), Convert.ToInt32(tbThirdNum.Text));

            tbResult.Text = Convert.ToString(wynik);
        }

        protected void btnOdejmij1_Click(object sender, EventArgs e)
        {
            if (labResult.Visible == false || tbResult.Visible == false || btnSaveToBase.Visible == false)
            {
                tbResult.Text = "";
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }
            else if (labResult.Visible == true || tbResult.Visible == true || btnSaveToBase.Visible == true)
            {
                labResult.Visible = false;
                tbResult.Visible = false;
                btnSaveToBase.Visible = false;
                tbResult.Text = "";
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }

            Calculating calc = new Calculating();
            double wynik = calc.SubtractionPlus(Convert.ToInt32(tbFirstNum.Text), Convert.ToInt32(tbSecondNum.Text), Convert.ToInt32(tbThirdNum.Text));

            tbResult.Text = Convert.ToString(wynik);
        }

        protected void btnPomnoz1_Click(object sender, EventArgs e)
        {
            if (labResult.Visible == false || tbResult.Visible == false || btnSaveToBase.Visible == false)
            {
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }
            else if (labResult.Visible == true || tbResult.Visible == true || btnSaveToBase.Visible == true)
            {
                labResult.Visible = false;
                tbResult.Visible = false;
                btnSaveToBase.Visible = false;
                tbResult.Text = "";
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }

            Calculating calc = new Calculating();
            double wynik = calc.MultiplicationPlus(Convert.ToInt32(tbFirstNum.Text), Convert.ToInt32(tbSecondNum.Text), Convert.ToInt32(tbThirdNum.Text));

            tbResult.Text = Convert.ToString(wynik);
        }

        protected void btnPodziel1_Click(object sender, EventArgs e)
        {
            if (labResult.Visible == false || tbResult.Visible == false || btnSaveToBase.Visible == false)
            {
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }
            else if (labResult.Visible == true || tbResult.Visible == true || btnSaveToBase.Visible == true)
            {
                labResult.Visible = false;
                tbResult.Visible = false;
                btnSaveToBase.Visible = false;
                tbResult.Text = "";
                labResult.Visible = true;
                tbResult.Visible = true;
                btnSaveToBase.Visible = true;
            }

            Calculating calc = new Calculating();
            double wynik = calc.DivisionPlus(Convert.ToInt32(tbFirstNum.Text), Convert.ToInt32(tbSecondNum.Text), Convert.ToInt32(tbThirdNum.Text));

            tbResult.Text = Convert.ToString(wynik);
        }

        protected void btnSaveToBase_Click(object sender, EventArgs e)
        {
            ResultsController rc = new ResultsController();
            ModelBazy nextResult = rc.GetDataFromTextBox(tbResult);

            bool checkIfAdded = rc.AddResult(nextResult);

            MessageBox.Show(checkIfAdded ? "OK" : "error");
        }
    }
}