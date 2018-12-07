using System;

namespace Prototype
{
    public class Resume : ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;
        private WorkExperience _workExperience;

        public Resume(string name)
        {
            _name = name;
            _workExperience = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            _workExperience = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            _age = age;
            _sex = sex;
        }

        public void SetWorkExperience(string workDate, string workCompany)
        {
            _workExperience.WorkDate = workDate;
            _workExperience.WorkCompany = workCompany;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", _name, _age, _sex);
            Console.WriteLine("{0} {1}", _workExperience.WorkDate, _workExperience.WorkCompany);
        }

        public Object Clone()
        {
            //return (Resume)this.MemberwiseClone(); // 浅拷贝
            Resume obj = new Resume((WorkExperience)_workExperience.Clone());
            obj._name = this._name;
            obj._age = this._age;
            obj._sex = this._sex;
            return obj;
        }
    }
}