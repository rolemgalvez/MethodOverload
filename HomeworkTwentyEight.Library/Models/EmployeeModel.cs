namespace HomeworkTwentyEight.Library.Models
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }

        public EmployeeModel()
        {
            SetData("Juan Dela Cruz", "Software Engineer", 12345);
        }

        public EmployeeModel(string name)
        {
            SetData(name, "Software Engineer", 12345);
        }

        public EmployeeModel(string name, string job)
        {
            SetData(name, job, 12345);
        }

        public EmployeeModel(string name, string job, decimal salary)
        {
            SetData(name, job, salary);
        }

        public void SetData(string name, string job, decimal salary)
        {
            Name = name;
            Job = job;
            Salary = salary;
        }
    }
}
