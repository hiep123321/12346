using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class class1service
    {
        private List<Class1> list = new List<Class1>();
        public string suaclass1(Class1 C1)
        {
            var ex =  list.FirstOrDefault(x => x.Id == C1.Id);

            if(ex == null)
            {
                return "Không tìm thấy sản phẩm cần sửa";
            }
            ex.Name = C1.Name;
            ex.Description = C1.Description;
            ex.UpdatedDate = C1.UpdatedDate;
            ex.CreatedDate = C1.CreatedDate;
            ex.IsActive = C1.IsActive;
            return "Sửa thành công";
        }
        public bool KTma(string Description)
        {
            return list.Any(x => x.Description == Description);
        }
        public void Them(Class1 SP)
        {
            list.Add(SP);
        }
    }
}
