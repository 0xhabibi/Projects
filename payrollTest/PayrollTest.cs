using Xunit;

namespace PayrollTest
{
    public class PayrollTest
    {
        public PayrollTest()
        {
            
        }

        [Fact]

        // TEST FOR VALID CASE
        public void validAddEmployeeToList()
        {

            var employee = new Employee(regularRate: 10.0, overtimeRate: 12.0);
            employee.IsActive = true;
            employee.RegularHours = 40.0;
            employee.OvertimeHours = 5.0;


            employee.CalculatePayroll();


            Assert.Equal(475.0, employee.GrossPay);
            Assert.Equal(9.5, employee.MedicareDeduction);
            Assert.Equal(23.75, employee.RentDeduction);
            Assert.Equal(14.25, employee.FoodDeduction);
            Assert.Equal(427.5, employee.NetPay);


        }

        //TEST FOR INVALID CASE

        [Fact]
        public void invalidAddEmployeeToList()
        {


            var employee = new Employee(regularRate: 10.0, overtimeRate: 15.0);
            employee.IsActive = true;
            employee.RegularHours = 40.0;
            employee.OvertimeHours = 5.0;

            employee.CalculatePayroll();

            Assert.Equal(475.0, employee.GrossPay);
            Assert.Equal(9.5, employee.MedicareDeduction);
            Assert.Equal(23.75, employee.RentDeduction);
            Assert.Equal(14.25, employee.FoodDeduction);
            Assert.Equal(427.5, employee.NetPay);


        }
        // TEST FOR EDGE CAES
        [Fact]
        public void EdgeCaseNoWork()
        {
            var employee = new Employee(regularRate: 10.0, overtimeRate: 15.0);
            employee.IsActive = true;
            employee.RegularHours = 0.0;
            employee.OvertimeHours = 0.0;

            employee.CalculatePayroll();

            Assert.Equal(0.0, employee.GrossPay);
            Assert.Equal(0.0, employee.MedicareDeduction);
            Assert.Equal(0.0, employee.RentDeduction);
            Assert.Equal(0.0, employee.FoodDeduction);
            Assert.Equal(0.0, employee.NetPay);
        }

    }


}