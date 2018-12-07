using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume rs1 = new Resume("HarKey");
            rs1.SetPersonalInfo("Boy", "26");
            rs1.SetWorkExperience("10/2017-12/2018", "3g");

            Resume rs2 = (Resume)rs1.Clone();
            rs2.SetWorkExperience("06/2016-08/2017", "Neware");

            rs1.Display();
            rs2.Display();
        }
    }
}
