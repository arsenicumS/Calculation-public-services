using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_public_services
{
    internal class View_model
    {
        bool caunter_cold;
        public bool Caunter_cold { set { caunter_cold = value; } }
        
        bool caunter_hot;
        public bool Caunter_hot { set { caunter_hot = value; } }
        
        bool caunter_electric;
        public bool Caunter_electric { set { caunter_electric = value; } }


        string volume_cold;
        public string Volume_cold { set { volume_cold = value; } }

        string volume_hot;
        public string Volume_hot { set { volume_hot = value; } }

        string volume_electric;
        public string Volume_electric { set { volume_electric = value; } }
        string volume_electric_night;
        public string Volume_electric_night { set { volume_electric_night = value; } }


        private Dictionary<string,string> cold_water;
        public Dictionary<string, string> Cold_water
        {
            get { return cold_water; }
            set { cold_water = value; }
        }
        
        private Dictionary<string, string> hot_water;
        public Dictionary<string, string> Hot_water
        {
            get { return hot_water; }
            set { hot_water = value; }
        }
        private Dictionary<string, string> hot_water1;
        public Dictionary<string, string> Hot_water1
        {
            get { return hot_water1; }
            set { hot_water1 = value; }
        }


        private Dictionary<string, string> electric;
        public Dictionary<string, string> Electric
        {
            get { return electric; }
            set { electric = value; }
        }

        private Dictionary<string, string> electric_night;
        
        public Dictionary<string, string> Electric_night
        {
            get { return electric_night; }
            set { electric_night = value; }
        }
        private Dictionary<string, string> electric_total;
        public Dictionary<string, string> Electric_total
        {
            get { return electric_total; }
            set { electric_total = value; }
        }

        public View_model()
        {          

        }
        public void Cold_Waters() 
        {
            
            if (caunter_cold)
            {
                new Cold_Water(caunter_cold, Convert.ToDecimal(volume_cold),out cold_water);
            }
            else new Cold_Water(out cold_water);
        }

        public void Hot_Waters() 
        {
            if (caunter_hot)
            {
                new Hot_Water(caunter_hot, Convert.ToDecimal(volume_hot), out hot_water,out hot_water1);
            }
            else new Hot_Water(out hot_water,out hot_water1);
        }

        public void Electric_line()
        {
            if (caunter_electric)
            {
                new Electric_Line(Convert.ToDecimal(volume_electric), Convert.ToDecimal(volume_electric_night), out electric, out electric_night, out electric_total);

            }
            else
            {
                new Electric_Line(Convert.ToDecimal(volume_electric), out electric);
                
            }
        }

        public List<decimal> Period_in_dB(string name_dB,string name_period,int people) 
        {
            Overall_calculation overall_Calculation = new Overall_calculation(name_dB, people);
                overall_Calculation.Period(name_period);
            return Return_vale_old();
        }

        public List<decimal> Return_vale_old() 
        {
            List<decimal> return_vale_ = new List<decimal>{ };

            for (var n = 1; n < 6; n++)
            {
                decimal val = 0;
                All_Volume all_ = new All_Volume(n);
                if (n == 4 ||n == 5 )
                {
                    all_.Get_Volume_Total_dB(n, out val);
                    return_vale_.Add(val);
                    all_.Get_Volume_Total_dB(n, out val);
                    return_vale_.Add(val);
                }
                else
                {
                    all_.Get_Volume_Total_dB(n, out val);
                    return_vale_.Add(val);
                }
            }
            return return_vale_;

        }
        
        Maneger_DB dB = new Maneger_DB();
        public void Update_info_table(string name_dB,string name_table,out List<object>[] list_info)=>
            list_info = dB.Get_table_info(name_dB,name_table);

        internal void Get_Period_table(out string[] list_table)
        {
            string [] list =dB.Get_table_name("Month_1");
            string[] list_rez = new string[list.Length-1];
            Array.Copy(list, 1, list_rez, 0, list.Length - 1);
            list_table = list_rez;
            
        }
    }
}
