using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace FinalWork
{
    [Serializable]
    public abstract class Info
    {
        
        public string FirstName { get; set; } // Имя
        public string SecondName { get; set; } // Фаимилия
        public string MiddleName { get; set; } // Отчество 
        public string DateOfBirth { get; set; } // Дата рождения
        public string Street { get; set; } // Улица проживания
        public string HouseNumber { get; set; } // Номер дома
        public string Apartment { get; set; } // Номер квартиры
        public string PhoneNumber { get; set; } // Номер телефона
        public string Post { get; set; } // Должность/Специальность
        public virtual void Serialisation() { }

    }
    [Serializable]
    public class Patient : Info
    {
        public bool AnotherAd { get; set; } // Проверка соответствует ли адрес прописки фактическому адресу проживания

        public string AnStreet { get; set; } // Улица проживания не по прописке

        public string AnHouseNumber { get; set; } // Номер дома не по прописке
        public string AnApartment { get; set; } // Номер квартиры не по прописке

        public string InsuranceNumber { get; set; } // Номер страховки
        public string InsuranceCompany { get; set; } // Страховая компания
        public string WorkPlace { get; set; } // Место работы
    }
    [Serializable]
    partial class Specialist : Info
    {
        public string DayofWeek { get; set; } // текущий день недели
        public int Day { get; set; } // Выбранный индекс дня в просмотре расписания
        public int Specialisation { get; set; } // Выбранный индекс специальности в просмотре расписания

        public int SpecialisationRecording { get; set; } // Выбранный индекс специальности в записи пациентов
        public int SpecialistName { get; set; } // Выбранный индекс специалиста в записи пациентов 
        public int SpecialistTime { get; set; } // Выбранный индекс времени в записи пациентов

    }
    [Serializable]
    public partial class MedicalCard : Patient
    {
        static bool createfile; // флаг для создания файла для хранения данных о медицинских картах
        int countcard = 1; // счетчик медицинских карт
        public bool CreateFile { get { return createfile; } set { createfile = value; } }
        public int CountCard { set { countcard = value; } get { return countcard; } }
        public partial void EddingCard(int countPatient, Excel excel); // функция для редактирования медицинской карты
        public partial void AddCard(int countPatient, Excel excel); // функция для добавления карты в файл excel
        public partial string[,] Editcard(int count, Excel excel); // функция для чтения медицинской карты для редактирования 

    }

    public partial class Excel 
    {
        _Application excelapp = new _Excel.Application(); // работа с приложением excel
         public Workbook wb; // переменная для работы с книгами excel
         public Worksheet ws; // переменная для работы со страницами в книге excel
        
         Microsoft.Office.Interop.Excel.Range range; // переменная для хранения диапазонов при работе с excel 

        public Excel()
        {

        }
            
        public Excel (string path, int Sheet) // конструктор, принимающий в качестве параметров название файла (string path) и номер открываемого листа
        {
            Workbooks tmp = excelapp.Workbooks;
            wb = tmp.Open(path);
            ws = wb.Worksheets[Sheet];
            Marshal.ReleaseComObject(tmp); // удаление ссылки на excel
        }
        public partial void WriteCells(string[] medcard, int i, int j); // запись строки в файл
        public partial void WriteCells(string[] medcard, int i, int j, int sort); // запись строки в файл с последующей сортировкой
        public partial void CreateDefaultFile(string path); // создание файла excel 
        public partial void CreateFile(string path); // создание файла excel с таблицей
        public partial string[,] ReadCells(int i); // получение всей строки из файла excel
        public partial string[,] ReadCells(int i, int j); // получение необходимого количества клеток в строке из файла excel
        public partial string ReadColumns(int rows, int columns,string profession); // чтение клетки из excel для определенного специалиста

        public partial void RedactCells(string[] medcard, int i, int j, int sort); // редактирование строки в файле excel
        public partial string ReadColumns(int rows, int columns); // чтение клетки из excel
        public partial void SortColumns(int row); // сортировка одной строки в excel
        public partial void SortRows(int rows, int columns,int sort); // сортировка всех строк в файле excel по определенному столбцу
        public partial int SearchTitle(string path); // получение номера колонки с определенным заголовком в файле excel

        public partial int RowsCount(); // получение количества заполненных строк в файле excel
        public partial int ColumnsCount(int row); // получение количества заполенных столбцов в файле excel
        public partial void Close(); // закрытие файла excel

    }
}
