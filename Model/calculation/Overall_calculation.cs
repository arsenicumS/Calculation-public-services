namespace Calculation_public_services
{
    internal class Overall_calculation
    {
        public static Maneger_DB dB;
        public static int n;
        public Overall_calculation() { }
        public Overall_calculation(string name_dateB,int piople) 
        {
        
            dB = new Maneger_DB(name_dateB);
            n = piople;
        }
        public void Period(string name_period)=>dB.Cread_Table(name_period);

        public void Set_vale_period(int id,decimal volume_in_month,decimal summa_in_service) => dB.Data_in_service(id, volume_in_month, summa_in_service);
        
        public decimal Calculation_General(decimal V, decimal T) { return V * T; }
       
        public decimal Volume(decimal N) { return n * N; }
        

    }
}
