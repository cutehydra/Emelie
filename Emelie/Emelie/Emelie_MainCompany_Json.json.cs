using Starcounter;

namespace Emelie
{
    partial class Emelie_MainCompany_Json : Json, IBound<MainCompany>
    {
        public string Info => Name;
        
        void Handle(Input.SaveTrigger action)
        {
            Transaction.Commit();
        }

        void Handle(Input.DeleteCompanyTrigger action)
        {
            Db.SlowSQL("DELETE FROM Company WHERE Spender = ?", this.Data);
            this.Companies.Clear();
        }
        void Handle(Input.CancelTrigger action)
        {
            Transaction.Rollback();
            RefreshCompanies(this.Data.CompanyList);
        }


        void Handle(Input.AddNewCompanyTrigger action)
        {
            var company = new Company()
            {
                Spender = (MainCompany)this.Data,
                CompanyName = "",
                Street = "",
                Number = 0,
                ZipCode = 0,
                City = "",
                Country = ""
            };

            AddCompany(company);
        }

        public void AddCompany(Company company)
        {
            var companyJson = Self.GET("/Emelie/partial/company/" + company.GetObjectID());
            this.Companies.Add(companyJson);
        }
        public void RefreshCompanies(QueryResultRows<Company> companies)
        {
            this.Companies.Clear();
            foreach (Company company in companies)
            {
                AddCompany(company);
            }
        }

    }
}
