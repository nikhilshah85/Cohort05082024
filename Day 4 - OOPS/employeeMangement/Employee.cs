public class Employee
{

    #region Variables

    #endregion

    #region Properties
        public int EmployeeNo { get; set; }

        public string EmployeeName { get; set; }

        public double EmployeeSalary { get; set; }   

    #endregion

    #region Methods

        public string GetEmployeeDetails()
        {
            return $"Employee No: {EmployeeNo}, Employee Name: {EmployeeName}, Employee Salary: {EmployeeSalary}";

           // return "Employee No : " + EmployeeNo + " Employee Name : " + EmployeeName + " Employee Salary : " + EmployeeSalary;
        }


        public double GetEmployeeBonus()
        {
            double bonusValue = EmployeeSalary * 0.10;
            return bonusValue; //10% of salary is the bonus value
        }

    #endregion

}