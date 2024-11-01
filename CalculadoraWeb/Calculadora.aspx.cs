using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace CalculadoraWeb
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rsuma.Checked = true;
            csuma.Checked = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //MetodoRadiobutton();
            //MetodoListaDespegable();
            MetodoCheckBox();
        }

        public void MetodoCheckBox()
        {
            float num1 = 0, num2 = 0, total = 0;

            num1 = float.Parse(tvalor1.Text);
            num2 = float.Parse(tvalor2.Text);

            string valor = string.Empty;

            if (csuma.Checked)
            {
                total = num1 + num2;
                valor = valor + "Suma = " + total.ToString();
            }

            if (cresta.Checked)
            {
                total = num1 - num2;
                valor = valor + "Resta = " + total.ToString();
            }

            if (cmultipicacion.Checked)
            {
                total = num1 * num2;
                valor = valor + "Multiplicación = " + total.ToString();
            }

            if (cdivision.Checked)
            {
                total = num1 / num2;
                valor = valor + "División = " + total.ToString();
            }
            lresultado.Text = valor;
        }

        public void MetodoListaDespegable()
        {
            float num1 = 0, num2 = 0, total = 0;

            num1 = float.Parse(tvalor1.Text);
            num2 = float.Parse(tvalor2.Text);

            if (dlista.SelectedIndex == 0)
            {
                total = num1 + num2;
            }
            else if (dlista.SelectedIndex == 1)
            {
                total = num1 - num2;
            }
            else if (dlista.SelectedIndex == 2)
            {
                total = num1 * num2;
            }
            else if (dlista.SelectedIndex == 3)
            {
                total = num1 / num2;
            }
            lresultado.Text = total.ToString();
        }

        public void MetodoRadiobutton()
        {
            float num1 = 0, num2 = 0, total = 0;

            num1 = float.Parse(tvalor1.Text);
            num2 = float.Parse(tvalor2.Text);

            if (rsuma.Checked)
            {
                total = num1 + num2;
            }
            else if(rresta.Checked)
            {
                total = num1 - num2;
            }
            else if (rmultiplicacion.Checked)
            {
                total = num1 * num2;
            }
            else if (rdivision.Checked)
            {
                total = num1 / num2;
            }
            lresultado.Text = total.ToString();
        }
    }
}