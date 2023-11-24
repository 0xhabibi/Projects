
public class Employee

{
    private int v1;

    private int v2;

    public int Id { get; set; }

    public string Name { get; set; }

    public bool IsActive { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime PayDate { get; set; }

    public double RegularHours { get; set; }

    public double OvertimeHours { get; set; }

    public double RegularRate { get; set; }

    public double OvertimeRate { get; set; }

    public double GrossPay { get; private set; }

    public double NetPay { get; private set; }

    public double MedicareDeduction { get; private set; }

    public double RentDeduction { get; private set; }

    public double FoodDeduction { get; private set; }

    public Employee(string name, bool isActive, DateTime startDate, DateTime now, double regularRate, double overtimeRate)

    {

        Name = name;

        IsActive = isActive;

        StartDate = startDate;

        RegularRate = regularRate;

        OvertimeRate = overtimeRate;

    }

    public Employee(int v1, int v2)

    {

        this.v1 = v1;

        this.v2 = v2;

    }

    public Employee(double regularRate, double overtimeRate)

    {

        RegularRate = regularRate;

        OvertimeRate = overtimeRate;

    }

    public void CalculatePayroll()

    {

        if (IsActive)

        {

            // Calculate Gross Pay

            GrossPay = (RegularHours * RegularRate) + (OvertimeHours * OvertimeRate);

            // Calculate Deductions

            MedicareDeduction = 0.02 * GrossPay;

            RentDeduction = 0.05 * GrossPay;

            FoodDeduction = 0.03 * GrossPay;

            // Calculate Net Pay

            NetPay = GrossPay - (MedicareDeduction + RentDeduction + FoodDeduction);

        }

    }

}