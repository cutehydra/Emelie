using System;
using Starcounter;




namespace Emelie
{
    [Database]
    public class MainCompany
    {
        public string Name;
        public QueryResultRows<Company> CompanyList => Db.SQL<Company>("SELECT e FROM Emelie.Company e WHERE e.Spender = ?", this);
        public decimal TotalHomesSold => Db.SQL<decimal>("SELECT SUM(e.HomesSold) FROM Emelie.Company e WHERE e.Spender = ?", this).First;

    }

    [Database]
    public class Company
    {
        public string CompanyName;
        public string Street;
        public int Number;
        public int ZipCode;
        public string City;
        public string Country;
        public int HomesSold; //=> Db.SQL<int>("SELECT COUNT(e) FROM Emelie.Estate e WHERE e.Seller = ?", this).First;
        public decimal Commission; // => Db.SQL<decimal>("SELECT SUM(e.EstateCommission) FROM Emelie.Estate e WHERE e.Seller = ?", this).First;
        // No calculation for average here since it will cause initial divide-by-zero
        public decimal AverageCommission; // => (Db.SQL<decimal>("SELECT SUM(e.EstateCommission) FROM Emelie.Estate e WHERE e.Seller = ?", this).First) / HomesSold;
        public decimal Trend;
        public MainCompany Spender;
        //public QueryResultRows<Estate> EstateList => Db.SQL<Estate>("SELECT e FROM Emelie.Estate e WHERE e.Seller = ?", this);
    }
    /*
    [Database]
    public class Estate
    {
        public string EstateStreet;
        public int EstateNumber;
        public int EstateZipCode;
        public string EstateCity;
        public string EstateCountry;
        public string EstateDate;
        public int EstateSalePrice;
        public int EstateCommission;
        public Company Seller;

    }*/


    class Program
    {
        static void Main()
        {
            Db.Transact(() =>
            {
                var anyone = Db.SQL<MainCompany>("SELECT m FROM MainCompany m").First;
                if (anyone == null)
                {
                    new MainCompany
                    {
                        Name = ""
                    };
                }
            });

            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/Emelie", () =>
            {
                return Db.Scope(() =>
                {
                    var company = Db.SQL<MainCompany>("SELECT m FROM MainCompany m").First;
                    var json = new Emelie_MainCompany_Json
                    {
                        Data = company
                    };

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;

                    if (company.CompanyList != null)
                    {
                        json.RefreshCompanies(company.CompanyList);
                    }

                    return json;
                });
               
            });

            Handle.GET("/Emelie/partial/company/{?}", (string id) =>
            {
                var json = new Emelie_Company_Json();
                json.Data = (Company) DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                //json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                return json;
            });
            /*
            Handle.GET("/Emelie/partial/estate/{?}", (string id) =>
            {
                var json = new Emelie_Estate_Json();
                json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                return json;
            });*/
        }
    }
}