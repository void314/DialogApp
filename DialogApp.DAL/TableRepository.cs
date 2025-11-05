using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogApp.DAL
{
    // Класс отвечает только за работу с данными
    public class TableRepository
    {
        public List<string> GetTables()
        {
            // Сейчас возвращаем фиктивные данные:
            return new List<string>
            {
                "Стол #1 (2 чел)",
                "Стол #5 (4 чел)",
                "Стол #8 (VIP)"
            };
        }
    }
}