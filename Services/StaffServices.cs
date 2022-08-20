using Assignment2.Model;
using System.Collections.Generic;

namespace Assignment2.Services
{
    public class StaffServices:IStaffServices
    {
        private List<Staff> _staffItems;

        public StaffServices()
        {
            _staffItems = new List<Staff>();
        }
        public Staff AddStaff(Staff staff)
        {
            _staffItems.Add(staff);
            return staff;
        }

        public string DeleteStaff(int id)
        {
            var deletestaff = _staffItems.Find(x => x.Id == id);
            if (deletestaff != null)
            {
                return id.ToString();
            }
            else
                return null;
        }

        public List<Staff> GetStaffs()
        {
            return _staffItems;
        }
        public Staff GetById(int id)
        {
           var staff=_staffItems.Find(x => x.Id == id); 
            if(staff == null)
            {
                return null;
            }
            return staff;
        }

        public Staff UpdateStaff(int id, Staff staffItems) 
        {
            for (var index = _staffItems.Count - 1; index >= 0; index--)
            {
                if (_staffItems[index].Id == id)
                {
                    _staffItems[index] = staffItems;
                }
            }
            return staffItems;
        }
    }
}
