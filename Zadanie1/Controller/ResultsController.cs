using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Web.UI.WebControls;


namespace Zadanie1
{
    public class ResultsController
    {
        public ModelBazy GetDataFromTextBox(System.Web.UI.WebControls.TextBox _result)
        {
            ModelBazy nowyWynik = new ModelBazy();
            nowyWynik.Wynik = Convert.ToDouble(_result.Text);

            return nowyWynik;
        }
        public bool AddResult(ModelBazy objectResult)
        {
            var newResult = new AddResultsToBase();
            var checkIfAdd = newResult.SaveToBase(objectResult);

            MessageBox.Show(checkIfAdd ? "OK" : "error");

            return checkIfAdd;
        }
    }
}