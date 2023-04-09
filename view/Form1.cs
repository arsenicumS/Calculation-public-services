using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleTables;

namespace Calculation_public_services
{
    public partial class Form1 : Form
    {
        View_model view_Model = new View_model();

        public List<string> vale;
        private string name_period;        

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
            bool valid = false;
           
            List<decimal> val = view_Model.Period_in_dB("Month_1", name_period, (int)numeric_people.Value);
            String_old_period(val);
            
            if (checkBoxElectric.Checked)
            {
                if (checkBoxCold.Checked && val[0] > Convert.ToDecimal(TextBoxCold.Text)) String_error("ХВС");
                else if (checkBoxHot.Checked && val[3] > Convert.ToDecimal(TextBoxHot.Text))String_error("ГВС");
                else if (val[4] > Convert.ToDecimal(TextBoxElectric.Text) ||
                    val[5] > Convert.ToDecimal(TextBoxElectric_night.Text)) String_error("ЭЭ");
                else valid = true;
            }
            else 
            {
                if (checkBoxCold.Checked && val[0] > Convert.ToDecimal(TextBoxCold.Text)) String_error("ХВС");
                else if (checkBoxHot.Checked && val[2] > Convert.ToDecimal(TextBoxHot.Text))String_error("ГВС");
                else if (val[1] > Convert.ToDecimal(TextBoxElectric.Text))String_error("ЭЭ");                
                else valid = true;
            }
            if (valid)
            {
                view_Model.Volume_cold = TextBoxCold.Text;
                view_Model.Volume_hot = TextBoxHot.Text;
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

                TextBoxRezult.Text ="\t\t\t" + name_period+"\n\n";
                TextBoxRezult.Text +=RezultString(cold) + "\n";
                TextBoxRezult.Text +=RezultString(hot) + RezultString(hot1) + "\n";

                TextBoxRezult.Text +=RezultString(electric);
                if (electric_night != null)
                {
                    TextBoxRezult.Text += RezultString(electric_night) + "\n" + RezultString(electric_total) +
                    string.Format("\n\tИтого к оплате: {0}руб",
                            Pay_Sum(cold, hot, hot1, electric, electric_night));
                }
                else
                {
                    TextBoxRezult.Text +=string.Format("\n\nИтого к оплате: {0}руб",
                        Pay_Sum(cold, hot, hot1, electric));
                }

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                buttonNext.Visible = true;
                button_start.Enabled = false;
            }
        }

        private void String_error(string name_servis)
        {
            TextBoxRezult.Text = $"Неверные показания {name_servis} пожалуйста введите коректные данные";
        }

        private void String_old_period(List<decimal> val)
        {
            labelInfo.Text = string.Format("Введенные показания долны быть больше предыдущих\n" +
                                        "Предыдущий период в объеме по услугам:\n" +
                                        "ХВС : {0}m3\n", val[0]);
           
            if (checkBoxElectric.Checked)
            {
                labelInfo.Text += string.Format (
                    "ГВС : {0}m3\n" +
                    "ЭЭ_Д: {1}кВт.ч\n" +
                    "ЭЭ_Н: {2}кВт.ч",val[3], val[4], val[5]);
            }

            else labelInfo.Text += string.Format(
                "ГВС: {2}m3\n" +
                "ЭЭ : {1}кВт.ч", val[0], val[1], val[2]);
        }

        private string RezultString(Dictionary<string,string> servis)
        {
            string n = "";
            if (servis["Name"].Length < 10) 
            {
                for (int i = 0; i < 10 - servis["Name"].Length; i++) n += "_";
            }
            servis["Name"] = n+servis["Name"] ;
            
            return string.Format("{0,-25}{1,-8:F5}{3:5}{2,15:C2}руб\n",
                servis["Name"], servis["Volume"], servis["Pyment"], servis["metric"]);
        }

        private decimal Pay_Sum(params Dictionary<string, string>[] operand)
        {
            decimal result = 0;
            foreach (var n in operand)
            {
                var k = Convert.ToDecimal(n["Pyment"]);
                result += k;
            }
            return result;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            buttonNext.Visible = false; 
            TextBox_period.Clear() ;
        }
             

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Создать шрифт myFont
            Font myFont = new Font("Lucida Console", 18, FontStyle.Regular, GraphicsUnit.Pixel);

            string curLine; // текущая выводимая строка

            // Отступы внутри страницы
            float leftMargin = e.MarginBounds.Left; // отступы слева в документе
            float topMargin = e.MarginBounds.Top; // отступы сверху в документе
            float yPos = 0; // текущая позиция Y для вывода строки

            int nPages; // количество страниц
            int nLines; // максимально-возможное количество строк на странице
            int i; // номер текущей строки для вывода на странице

            // Вычислить максимально возможное количество строк на странице
            nLines = (int)(e.MarginBounds.Height / myFont.GetHeight(e.Graphics));

            // Вычислить количество страниц для печати
            nPages = (TextBoxRezult.Lines.Length - 1) / nLines + 1;

            // Цикл печати/вывода одной страницы
            int counter = 0;
            i = 0;
            while ((i < nLines) && (counter < TextBoxRezult.Lines.Length))
            {
                // Взять строку для вывода из richTextBox1
                curLine = TextBoxRezult.Lines[counter];

                // Вычислить текущую позицию по оси Y
                yPos = topMargin + i * myFont.GetHeight(e.Graphics);

                // Вывести строку в документ
                e.Graphics.DrawString(curLine, myFont, Brushes.Blue,
                  leftMargin, yPos);

                counter++;
                i++;
            }
            // сначала принять, что следующая страница не генерируется
            e.HasMorePages = false;


        }

        // Команда Page Setup
        private void button_Setup(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog(); // отобразить окно
        }

        // Команда Print()
        private void button_Print(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        // Команда PrintPreviewDialog()
        private void button_Preview_Dialog(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button_set_period(object sender, EventArgs e)
        {
            
            name_period = "Period_"+TextBox_period.Text ;
            button_start.Visible= true;
            button_start.Enabled=true;
        }

        private void Page_Click(object sender, EventArgs e)
        {
            List<object>[]info;
            List<object>[]olde;
            string[] list_table;

            view_Model.Update_info_table("TestDB", "Tariff_Info", out info );
            view_Model.Update_info_table("TestDB", "Totol_valume", out olde);
            view_Model.Get_Period_table(out list_table);

            var table_olde = new ConsoleTable("Услуга","Объем за весь период", "Ед.изм");
            var table_info = new ConsoleTable("Услуга","Тариф руб/ед.изм","Норматив","Ед.изм");

            for (int i = 0;i< info.Length;i++) 
            {
                if (i < olde.Length)
                {                    
                    table_olde.AddRow(olde[i][1], olde[i][2],info[i][4]);
                }
                string s = $"{info[i][2]:C2}";                
                table_info.AddRow(info[i][1], s, info[i][3], info[i][4]);
                
            }
            TextBox_tariff_page2.Text = table_info.ToMarkDownString();
            TextBox_olde_page2.Text = table_olde.ToMarkDownString();
            listBox_period_page2.Items.Clear();
            listBox_period_page2.Items.AddRange(list_table);


        }

        private void listBox_period_page2_Click(object sender, EventArgs e)
        {
            List<object>[] tab_period;
            var table_period = new ConsoleTable("Услуга",  "Ед.изм","Объем","Тариф ", "Услуга в руб");
            var table_name =listBox_period_page2.SelectedItem.ToString();
            view_Model.Update_info_table("Month_1", table_name, out tab_period);
            foreach(var row in tab_period) 
            {
                table_period.AddRow(row[1], row[2], row[3], row[4], row[5]);
            }

            TextBox_Period_page2.Text = table_period.ToMinimalString();
        }
    }
}
