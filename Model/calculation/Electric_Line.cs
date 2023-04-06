using System;
using System.Collections.Generic;

namespace Calculation_public_services
{
    internal class Electric_Line
    {
        static int ID = 2;
        int id_dey = 4;         //ID - строки в базе данных где храняться данные
        int id_night = 5;       //о тарифе и нормативе, ед.Измерений и названии услуги 

        Dictionary<string, object> dict_dey;
        Dictionary<string, object> dict_night;
            

        decimal pyment_Electric;   // переменная для рачетной суммы за период
        decimal volume_in_summ;    // Объем услуги за период

        All_Volume Volume = new All_Volume(ID, true);         //Базовый класс 

        decimal vol_dey;
        decimal vol_night;
        private decimal totol_val;
        decimal totol_dey;      // Показания предыдущего прериода
        decimal totol_night;

        public Electric_Line(decimal volume_in_month, out Dictionary<string, string> rezult)    // Если счетчик однотарифный
        {
            dict_dey = Volume.Get_Tariff_info_dB(ID); // словарь с справочной информацией из Д\Б
            Volume.Get_Volume_Total_dB(ID, out totol_val); // Получение значения общего обема за все периоды

            

                pyment_Electric = Volume.Get_Payment(Volume.Tariff, volume_in_month); // Расчет по услуге
                volume_in_summ = Volume.Volume_in_month; // получение значение обЪема по услуге

                rezult = Volume.Set_view_date
                    (volume_in_month - totol_val, (string)dict_dey["Name"], 
                                    pyment_Electric, (string)dict_dey["metric"]);

                Volume.Set_Volume_Totol_dB(ID, volume_in_month);//обновление общего объема 

            Volume.Set_vale_period(ID, volume_in_month - totol_val, pyment_Electric);//объм за период
            

        }


        public Electric_Line(decimal volume_dey, decimal volume_night,
            out Dictionary<string, string> rezult_dey, out Dictionary<string, string> rezult_night, out Dictionary<string, string> rezult_totol)  //если счетчик двух тарифный
        {
            dict_dey = Volume.Get_Tariff_info_dB(id_dey);
            dict_night = Volume.Get_Tariff_info_dB(id_night);

            Get_Payment_dey_night(volume_dey, volume_night, out decimal pay_dey, out decimal pay_night);

            
                rezult_dey = Volume.Set_view_date(vol_dey,
                               (string)dict_dey["Name"], pay_dey, (string)dict_dey["metric"]);
                rezult_night = Volume.Set_view_date(vol_night,
                                (string)dict_night["Name"], pay_night, (string)dict_dey["metric"]);
                rezult_totol = Volume.Set_view_date(volume_in_summ,
                            "Электро энергия общ.", pay_dey + pay_night, (string)dict_dey["metric"]);

                Volume.Set_Volume_Totol_dB(id_dey, volume_dey);
                Volume.Set_Volume_Totol_dB(id_night, volume_night);

            Volume.Set_vale_period(id_dey,vol_dey, pay_dey);
            Volume.Set_vale_period(id_night, vol_night, pay_night);

        }

        void Get_Payment_dey_night(decimal volume_dey,decimal volume_night ,
            out decimal payment_dey,out decimal payment_night) 
        {
               
            Volume.Get_Volume_Total_dB(id_dey ,out totol_dey);  //получаем из бызы данных сумму предыдущих показаний
            Volume.Get_Volume_Total_dB(id_night, out totol_night);
                        
            vol_dey = volume_dey - totol_dey;
            vol_night = volume_night - totol_night;

            volume_in_summ = vol_dey + vol_night; // сумма кол-во кВт за период
            

            //Возвращаем расчетную сумму за период 
            payment_dey = Volume.Calculation_General
                     ((volume_dey - totol_dey), Convert.ToDecimal(dict_dey["tariff"]));
            payment_night = Volume.Calculation_General
                     ((volume_night - totol_night), Convert.ToDecimal(dict_night["tariff"]));

            payment_dey = Math.Round(payment_dey, 2);
            payment_night = Math.Round(payment_night, 2);
        }
       
    }
}
