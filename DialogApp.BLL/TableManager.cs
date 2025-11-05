using DialogApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogApp.BLL
{
    // Класс отвечает за бизнес-логику
    public class TableManager
    {
        // Создаем экземпляр DAL для доступа к данным
        private readonly TableRepository _repository;

        public TableManager()
        {
            _repository = new TableRepository(); // Инициализация DAL
        }

        public List<string> GetAllAvailableTables()
        {
            List<string> allTables = _repository.GetTables();

            // Применяем БИЗНЕС-ПРАВИЛО (например, фильтруем)
            // Сейчас просто исключим VIP столик, для примера.
            var availableTables = allTables.Where(t => !t.Contains("VIP")).ToList();

            return availableTables;
        }
    }
}