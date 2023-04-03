using System;
using System.Collections.Generic;

namespace Calculation_public_services
{
    internal class Hot_Water
    {
        int ID = 3;
        int id_hot = 6;
        
        Dictionary<string,object> dict_hot;
        Dictionary<string, object> dict_water;

        decimal pyment_Water;
        decimal pyment_Hot;
        decimal volume_hot;

        All_Volume Volume;
        private decimal totol_val;

        public Hot_Water(out Dictionary<string, string> rezult, out Dictionary<string, string> rezult1) 
        {
            this.Volume= new All_Volume(ID);
            dict_hot = Volume.Get_Tariff_info_dB(id_hot);
            dict_water = Volume.Get_Tariff_info_dB(ID);

            pyment_Water =  Volume.Get_Payment(Volume.Tariff,Volume.Volume_in_month);
            volume_hot =(Volume.Volume_in_month * Convert.ToDecimal(dict_hot["norma"])) ;
            pyment_Hot = Volume.Get_Payment(Convert.ToDecimal(dict_hot["tariff"]),volume_hot);
            pyment_Hot = Math.Round(pyment_Hot,2);
            volume_hot = Math.Round(volume_hot,5);

            rezult = Volume.Set_view_date
                (Volume.Volume_in_month,(string)dict_water["Name"],pyment_Water,(string)dict_water["metric"]);
            rezult1 = Volume.Set_view_date
                (volume_hot, (string)dict_hot["Name"], pyment_Hot,(string)dict_hot["metric"]);

            Volume.Set_vale_period(ID, Volume.Volume_in_month, pyment_Water);
            Volume.Set_vale_period(id_hot, volume_hot, pyment_Hot);
        }
        public Hot_Water(bool cauner, decimal volume_in_month, out Dictionary<string, string> rezult, out Dictionary<string, string> rezult1)
        {
            this.Volume = new All_Volume(ID,cauner);
            dict_hot = Volume.Get_Tariff_info_dB(id_hot);
            dict_water = Volume.Get_Tariff_info_dB(ID);
            Volume.Get_Volume_Total_dB(ID, out totol_val, "volume");


            volume_hot = ((volume_in_month - totol_val) * Convert.ToDecimal(dict_hot["norma"]));
            pyment_Hot = Convert.ToDecimal(dict_hot["tariff"])* volume_hot;
            pyment_Hot = Math.Round(pyment_Hot, 2);
            pyment_Water = Volume.Get_Payment(Volume.Tariff,volume_in_month);

            rezult =Volume.Set_view_date
                (volume_in_month - totol_val, (string)dict_water["Name"],pyment_Water, (string)dict_water["metric"]);
            rezult1 = Volume.Set_view_date
                (volume_hot, (string)dict_hot["Name"],pyment_Hot, (string)dict_hot["metric"]);

            Volume.Set_Volume_Totol_dB(ID, Convert.ToString(volume_in_month));

            Volume.Set_vale_period(ID, volume_in_month - totol_val, pyment_Water);
            Volume.Set_vale_period(id_hot, volume_hot, pyment_Hot);
        }

        

    }
}
