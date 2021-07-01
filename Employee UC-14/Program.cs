using System;

namespace Employee_UC_14
{
    class Program
    {
        static void Main(string[] args)
            {
                EmpWageBuilderArray empWageBuilder = new EmpWageBuilder();
                empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
                empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
                empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage for DMart company : " + empWageBuilder.getTotalwage("DMart"));
            }
        }
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth);

        public void computeEmpWage();

        public int getTotalWage(string company);
    }
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            private int totalEmpWage;
            public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }

            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }

            public string toString()
            {
                return "Total Emp Wage for company : " + "is: " + this.totalEmpWage;
            }
        }
public class EmpWageBuilder : IComputeEmpWage
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;

    private LinkedList<CompanyEmpWage> companyEmpWageList;
    private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

    public EmpWageBuilder()
    {
        this.companyEmpWagesList = new LinkedList<CompanyEmpWage>();
        this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
    }

    public void addCompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHrsPerMonth)
    {
        CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numofWorkingDays, maxHoursPerMonth);
        this.companyToEmpWageList.AddLast(companyEmpWage);
        this.companyToEmpWageMap.Add(company, companyEmpWage);

    }

    public void computeEmpWage()
    {
        foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
        {
            companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
            Console.WriteLine(companyEmpWage.toString());
        }
    }

    private int computeEmpWage(CompanyEmpWage companyEmpWage)

            public int getTotalWage(string company)
    {
        return this.companyToEmpWageMap[company].totalEmpWage;
    }
}
             