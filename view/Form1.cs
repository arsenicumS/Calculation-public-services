using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation_public_services
{
    public partial class Form1 : Form
    {
        View_model view_Model = new View_model();

        public List<string> vale;
        private string name_period = "month_";
        private int caunt;

        public Form1()
        {
            InitializeComponent();
        }
        private void checkBoxCold_CheckedChanged(object sender, EventArgs e)
        {
            labelCold.Visible = checkBoxCold.Checked;
            TextBoxCold.Visible = checkBoxCold.Checked;   
            
            view_Model.Caunter_cold = checkBoxCold.Checked;
            
        }
        private void checkBoxHot_CheckedChanged(object sender, EventArgs e)
        {
            labelHot.Visible = checkBoxHot.Checked;
            TextBoxHot.Visible = checkBoxHot.Checked;

            view_Model.Caunter_hot = checkBoxHot.Checked;

        }
        private void checkBoxElectric_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxElectric_night.Visible = checkBoxElectric.Checked;
            labelNight.Visible = checkBoxElectric.Checked;
            if (checkBoxElectric.Checked) labelDey.Text = "День";
            else labelDey.Text = "Показания Эл.Энергии";

            view_Model.Caunter_electric = checkBoxElectric.Checked;

        }



        private void button_start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            view_Model.Period_in_dB(name_period,(int)numeric_people.Value);
           
            view_Model.Volume_cold = TextBoxCold.Text;
            view_Model.Volume_hot =TextBoxHot.Text;
            view_Model.Volume_electric = TextBoxElectric.Text;
            view_Model.Volume_electric_night = TextBoxElectric_night.Text;

            view_Model.Cold_Waters();
            view_Model.Hot_Waters();
            view_Model.Electric_line();
            var cold = view_Model.Cold_water;
            var hot = view_Model.Hot_water;
            var hot1 = view_Model.Hot_water1;
            var electric = view_Model.Electric;
            var electric_night = view_Model.Electric_night;
            var electric_total = view_Model.Electric_total;

           TextBoxRezult.Text =
                RezultString(cold["Name"], cold["Volume"], cold["Pyment"], cold["metric"]) + "\n";
           

            
           TextBoxRezult.Text += 
                RezultString(hot["Name"], hot["Volume"], hot["Pyment"], hot["metric"]) +
                    RezultString(hot1["Name"], hot1["Volume"], hot1["Pyment"], hot1["metric"]) + "\n";

            TextBoxRezult.Text +=
                RezultString(electric["Name"], electric["Volume"], electric["Pyment"], electric["metric"]);
                if (electric_night != null)
                {

                    TextBoxRezult.Text += RezultString(electric_night["Name"], electric_night["Volume"], electric_night["Pyment"], electric_night["metric"]) + "\n" +
                    RezultString(electric_total["Name"], electric_total["Volume"],
                             electric_total["Pyment"], electric_total["metric"]) +
                    string.Format("\n\tИтого к оплате: {0}руб",
                            Pay_Sum(cold["Pyment"], hot["Pyment"], hot1["Pyment"], electric["Pyment"], electric_night["Pyment"]));
                }
                else TextBoxRezult.Text += string.Format("\n\tИтого к оплате: {0}руб",
                            Pay_Sum(cold["Pyment"], hot["Pyment"], hot1["Pyment"], electric["Pyment"]));

            List <decimal> val = view_Model.Return_vale_old();
            labelInfo.Text = string.Format("Введенные показания долны быть больше предыдущих\n" +
                                "Предыдущий период в обеме по услугам:\n" +
                                "ХВС: {0}m3\n" +
                                "ГВС: {1}m3\n" +
                                "ЭЭ : {2}кВт.ч", val[0], val[2], val[1]);


            
        }

        private string RezultString(string name,string vale,string payment = "",string metric = "")
        {
            string n = "";
            if (name.Length < 10) 
            {
                for (int i = 0; i < 10 - name.Length; i++) n += "_";
            }
            name = n+name ;
            
            return string.Format("{0,-25}\t{1,20:F5} {3,-10}\t{2,15:C2}руб\n",name,vale,payment,metric);
        }

        private decimal Pay_Sum(params string[] operand)
        {
            decimal result = 0;
            foreach (var n in operand)
            {
                var k = Convert.ToDecimal(n);
                result += k;
            }
            return result;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            caunt += 1;
            name_period = name_period.Split('_').First() +"_"+Convert.ToString(caunt);
            button_start.Enabled = true;
        }
    }
}
