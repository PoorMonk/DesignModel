using System;

namespace Prototype
{
    public class WorkExperience : ICloneable
    {
        private string _workDate;
        private string _workCompany;

        public string WorkCompany { get => _workCompany; set => _workCompany = value; }
        public string WorkDate { get => _workDate; set => _workDate = value; }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        } 
    }
}