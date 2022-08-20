using Assignment2.Model;
using System.Collections.Generic;

namespace Assignment2.Services
{
    public interface IStaffServices 
    {
        public List<Staff> GetStaffs();
        public Staff GetById(int id);
        public Staff AddStaff(Staff staff);

        public Staff UpdateStaff(int id,Staff staff);

        public string DeleteStaff(int id);
    }
}
