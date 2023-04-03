using System;
using System.Collections.Generic;

namespace Calculation_public_services
{
    internal class Cold_Water
    {
        int ID = 1;
        decimal pyment_Water;
        All_Volume Volume;
        private decimal totol_val;

        public  Cold_Water(out Dictionary<string, string> rezult)
        {
            this.Volume = new All_Volume(ID);
            
            pyment_Water = Volume.Get_Payment(Volume.Tariff,Volume.Volume_in_month);

             rezult = Volume.Set_view_date
                (Volume.Volume_in_month,(string)Volume.dict_all["Name"],pyment_Water, (string)Volume.dict_all["metric"]);
            Volume.Set_vale_period(ID, Volume.Volume_in_month, pyment_Water);

        }
        public Cold_Water(bool cauner, decimal volume_in_month,out Dictionary<string, string> rezult)
        {
            this.Volume = new All_Volume(ID, cauner);

            Volume.Get_Volume_Total_dB(ID, out totol_val, "volume");

            pyment_Water =Volume.Get_Payment(Volume.Tariff,volume_in_month);

            rezult = Volume.Set_view_date
                (volume_in_month - totol_val, (string)Volume.dict_all["Name"], pyment_Water, (string)Volume.dict_all["metric"]);

            Volume.Set_Volume_Totol_dB(ID, Convert.ToString(volume_in_month));
            Volume.Set_vale_period(ID, volume_in_month - totol_val, pyment_Water);
        }

        
    }
}
