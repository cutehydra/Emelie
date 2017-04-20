using Starcounter;

namespace Emelie
{
    partial class Emelie_Company_Json : Json, IBound<Company>
    {
        public string NameInfo => CompanyName;
        
        /*
        public int CalcHomesSold()
        {
            if (HomesSold < 1) return 1;
            return (int)HomesSold;
        }
        public decimal CalcAverageCommission => Commission / CalcHomesSold();

        void Handle(Input.DeleteEstateTrigger action)
        {
            Db.SlowSQL("DELETE FROM Company WHERE Spender = ?", this.Data);
            this.Estates.Clear();
        }
        
        void Handle(Input.AddNewEstateTrigger action)
        {
            var estate = new Estate()
            {
                Seller = (Company)this.Data,
                EstateStreet = "",
                EstateNumber = 0,
                EstateZipCode = 0,
                EstateCity = "",
                EstateCountry = "",
                EstateDate = "",
                EstateSalePrice = 0,
                EstateCommission = 0
            };
            AddEstate(estate);
        }
        
        public void AddEstate(Estate estate)
        {
            var estateJson = Self.GET("/Emelie/partial/estate/" + estate.GetObjectID());
            this.Estates.Add(estateJson);
        }
        public void RefreshEstates(QueryResultRows<Estate> estates)
        {
            this.Estates.Clear();
            foreach (Estate estate in estates)
            {
                AddEstate(estate);
            }
        }*/

    }
}
