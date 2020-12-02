using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 12346, 10);
            Employee o2 = new Employee("Amol", 12346);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);

            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o1.EMPNO);
            Console.ReadLine();
        }
    }
}class Employee
{
    public Employee(string name = null, decimal basic = 0, short deptNo = 0)
    {

        empNo = ++eNo;
        NAME = name;
        BASIC = basic;
        DEPTNO = deptNo;
    }


    #region Properties
    private string name;
    public string NAME
    {
        set
        {
            if (value != null)
            {
                name = value;
            }
            else
                Console.WriteLine("Invalid Entry name");
        }
        get
        {
            return name;
        }
    }

    private decimal basic;
    public decimal BASIC
    {
        set
        {
            if (value < 150000 && value > 0)
            {
                basic = value;
            }
            else
            {
                Console.WriteLine("Invalid Basic");
            }
        }
        get
        {
            return basic;
        }
    }

    private short deptNo;
    public short DEPTNO
    {
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Invalid Dept No !!");
            }
            else
            {
                deptNo = value;
            }
        }
        get
        {
            return deptNo;
        }
    }

    private int empNo;

    public int EMPNO
    {
        get
        {
            return empNo;
        }
    }

    private static int eNo;
    public static int ENO
    {
        set
        {
            eNo = 0;
        }
        get
        {
            return eNo;
        }
    }
    #endregion


    public decimal getNetSalary()
    {
        return BASIC + 2000 + 3000;
    }

}



