using System;
using System.Collections.Generic;

namespace Calculation_public_services
{
    internal class All_Volume : Overall_calculation
    {
        int id;
        decimal total_volume;   //показания прибора за весь период
        
        bool cauntor;                   //наличие счетчика
        public decimal Volume_in_month { get; set; } //обем за месяц по счетчику

        public Dictionary<string, object> dict_all;

        private decimal tariff;
        public decimal Tariff  //тариф по услуге
        {
            get { return tariff; }
            set { tariff = value; }
        }       


       public All_Volume(int id , bool cauntor = false) 
        {
            dict_all = Get_Tariff_info_dB(id);
            tariff = Convert.ToDecimal(dict_all["tariff"]);

            this.cauntor = cauntor;
            this.id = id;
            if (cauntor) Get_Volume_Total_dB(id, out this.total_volume);
            else if (!cauntor) this.Volume_in_month = Volume(Convert.ToDecimal(dict_all["norma"])); 
            // Получаем месячный объем произведение норматива на кол-во человек 
        }
                
        public Dictionary<string, object> Get_Tariff_info_dB(int id)=>dB.Get_Date_Tariff_info(id);

        public void Set_Volume_Totol_dB(int id,decimal volum,string name_column = "volume") => 
                    dB.Set_Date("Totol_valume", id,name_column,volum) ;

        public void Get_Volume_Total_dB(int id, out decimal total_volume,string name_column = "volume" ) 
        {
            Dictionary<string, object> data_volume = dB.Get_Date_Total_Valume(id);
            total_volume = Convert.ToDecimal(data_volume[name_column]);   //показания прибора за весь период
        }

        public decimal Get_Payment( decimal tariff,decimal volume_in_month )
        {
            decimal summ;
            if (!cauntor) { summ = Calculation_General(volume_in_month, tariff); }
            else 
            {
                decimal V = volume_in_month - total_volume;
                this.Volume_in_month = V;
                summ = Calculation_General(V, tariff);
            }
            return Math.Round(summ,2);
        }

        public Dictionary<string, string> Set_view_date
            (decimal volume_in_month, string name, object payment,string metric)
        {

            return new System.Collections.Generic.Dictionary<string, string>
                { { "Name", name },
                { "Volume", Convert.ToString(volume_in_month) },
                { "Pyment", Convert.ToString(payment) },
                {"metric", metric } };
        }

    }
}
