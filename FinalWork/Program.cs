using FinalWork;
using Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Runtime.InteropServices;

namespace FinalWork
{
    
    partial class Specialist
    {
        public override void Serialisation() // запись в файл json информации о специалисте
        {
            FileStream specialistfile = File.Create("specialist.json");
            DataContractJsonSerializer specialistdata = new DataContractJsonSerializer(typeof(Specialist));
            specialistdata.WriteObject(specialistfile, this);
            specialistfile.Close();
        }
        public Specialist SpecialistDeserialisation(Specialist specialist) // получение информации из файла json о специалисте
        {
            FileStream specialistfile = File.OpenRead("specialist.json");
            DataContractJsonSerializer specialistdata = new DataContractJsonSerializer(typeof(Specialist));
            specialist = specialistdata.ReadObject(specialistfile) as Specialist;
            specialistfile.Close();
            return specialist;
        }
    }
    public partial class MedicalCard
    {
        public override void Serialisation() // запись в файл json информации о пациенте для медицинской карты
        {
            FileStream cardfile = File.Create("card.json");
            DataContractJsonSerializer carddata = new DataContractJsonSerializer(typeof(MedicalCard));
            carddata.WriteObject(cardfile, this);
            cardfile.Close();
        }
        public MedicalCard CardDeserialisation(MedicalCard card) // чтение из файла json информации о пациенте для медицинской карты
        {
            FileStream cardfile = File.OpenRead("card.json");
            DataContractJsonSerializer carddata = new DataContractJsonSerializer(typeof(MedicalCard));
            card = carddata.ReadObject(cardfile) as MedicalCard;
            cardfile.Close();
            return card;
            
        }
        public partial void AddCard(int countPatient,Excel excel)
        {
            string[] table = { "_№","_Фамилия", "Имя", "Отчество", "Дата рождения", "Улица(п)", "Дом(п)", "Квартира(п)", "Улица", "Дом", "Квартира", "Страховая компания", "Номер полиса", "Телефон", "Работа", "Должность"};
            string[] medcard = {Convert.ToString(countPatient),SecondName,FirstName, MiddleName, DateOfBirth, Street, HouseNumber, Apartment, AnStreet, AnHouseNumber,AnApartment,InsuranceCompany,InsuranceNumber, PhoneNumber, WorkPlace, Post };
            if (countcard == 1)
                excel.WriteCells(table, countPatient, table.Length); // запись заголовка таблица в excel
            excel.WriteCells(medcard, countPatient + 1, medcard.Length, excel.SearchTitle("_№")); // запись медицинских карт в файл excel
        }
        public partial void EddingCard(int countPatient, Excel excel)
        {
            string[] medcard = { Convert.ToString(countPatient), SecondName, FirstName, MiddleName, DateOfBirth, Street, HouseNumber, Apartment, AnStreet, AnHouseNumber, AnApartment, InsuranceCompany, InsuranceNumber, PhoneNumber, WorkPlace, Post };
            excel.RedactCells(medcard, countPatient + 1, medcard.Length, excel.SearchTitle("_№"));
        }
        public partial string[,] Editcard(int count,Excel excel)
        {
            string[,] info = excel.ReadCells(count);
            return info;
        }
    }
 
    public partial class Excel
    {
        public partial int SearchTitle(string path)
        {
            int title = 1;
            int countColumn = ColumnsCount(1);
            for (int i = 1; i < countColumn; i++)
            {
                if (ws.Cells[1,i].Value2 == path)
                {
                    break;
                }
                title++;
            }
            return title;
        }
        public partial void RedactCells(string[] medcard,int i,int j,int sort)
        {
            int startWriting = 1;
            range = ws.Range[ws.Cells[i, startWriting], ws.Cells[i, startWriting + (j - 1)]];
            range.Value2 = medcard;
            for (int x = 0; x < medcard.Length; x++)
            {

                if (medcard[x].Length >= ws.Cells[i, x + 1].EntireColumn.ColumnWidth)
                {
                    ws.Cells[i, x + 1].EntireColumn.ColumnWidth = medcard[x].Length + 3;
                }

            }
            range.Rows.Sort(range.Columns[sort]);
            wb.Save();
        }
        public partial void WriteCells(string[] medcard, int i, int j)
        {
            int startWriting = 1;
            for (int column = 1; column < ws.Columns.Count; column++)
            {

                if (ws.Cells[i, column].Value == null || ws.Cells[i,column].Value2 == "Столбец1") break;
                startWriting++;
            }
            range = ws.Range[ws.Cells[i,startWriting], ws.Cells[i,startWriting+(j-1)]];
            range.Value2 = medcard;
            for (int x = 0; x < medcard.Length; x++)
            {
                
                if (medcard[x].Length >= ws.Cells[i,x+1].EntireColumn.ColumnWidth)
                {
                    ws.Cells[i,x+1].EntireColumn.ColumnWidth = medcard[x].Length + 3;
                }
                
            }            
        }
        public partial void WriteCells(string[] medcard, int i, int j, int sort)
        {
            int startWriting = 1;
            for (int column = 1; column < ws.Columns.Count; column++)
            {

                if (ws.Cells[i, column].Value == null || ws.Cells[i, column].Value2 == "Столбец1") break;
                startWriting++;
            }
            range = ws.Range[ws.Cells[i, startWriting], ws.Cells[i, startWriting + (j - 1)]];
            range.Value2 = medcard;
            for (int x = 0; x < medcard.Length; x++)
            {

                if (medcard[x].Length >= ws.Cells[i, x + 1].EntireColumn.ColumnWidth)
                {
                    ws.Cells[i, x + 1].EntireColumn.ColumnWidth = medcard[x].Length + 3;
                }

            }
            range.Rows.Sort(range.Columns[sort]);
            wb.Save();
        }
        public partial string ReadColumns(int rows, int columns, string profession)
        {
            
                if (ws.Cells[rows, 4].Value2 == profession)
                {
                    var temp = ws.Cells[rows, columns].Value2;
                    if (temp.GetType() != profession.GetType())
                    {
                        return Convert.ToString(ws.Cells[rows, columns].Value2);
                    }
                    else
                    return ws.Cells[rows, columns].Value2;
                }
                    return "";   
        }

        public partial string ReadColumns(int rows, int columns)
        {
             
             var temp = ws.Cells[rows, columns].Value2;
             
            if(temp.GetType() != typeof(String))
            {
                return Convert.ToString(ws.Cells[rows, columns].Value2);
            }
             else 
             return ws.Cells[rows, columns].Value2;            
        }

        public partial void SortColumns(int row)   
        {
            int countColumn = ColumnsCount(row);
            range = ws.Range[ws.Cells[row, 2], ws.Cells[row, countColumn+1]];
            range.Sort(range);
            wb.Save();
 
        }
        public partial void SortRows(int rows, int columns , int sort)
        {
            range = ws.Range[ws.Cells[rows, 1], ws.Cells[rows, columns]];

            range.Rows.Sort(range.Columns[sort]);
            wb.Save();

        }
        public partial int RowsCount()
        {
            int row = 0;
            for (row = 0; row < ws.Rows.Count; row++)
            {
                if (ws.Cells[row+1, 1].Value == null) break;
                
            }
            return row; 
        }
        public partial int ColumnsCount(int row)
        {
            int column = 0;
            for (column = 0; column < ws.Columns.Count;column++)
            {
                if (ws.Cells[row, column + 1].Value == null) break;
            }
            return column;
        }
        public partial string[,] ReadCells(int i)
        {
            int j = 1;
            for (int column = 2; column < ws.Columns.Count; column++)
            {

                if (ws.Cells[i, column].Value == null) break;
                j++;
            }

            range = ws.Range[ws.Cells[i, 1], ws.Cells[i, j]];
            object[,] temp = range.Value2;
            string[,] returnstring = new string[1, j];

            for (int y = 1; y <= j; y++)
            {
                if (temp[1, y] != null)
                    returnstring[0, y - 1] = temp[1, y].ToString();
                else returnstring[0, y - 1] = "";
            }


            return returnstring;
        }
        public partial string[,] ReadCells(int i, int j)
        {
            range = ws.Range[ws.Cells[i,1], ws.Cells[i,j]];
            object [,] temp = range.Value2;
            string[,] returnstring = new string[1,j];
            
           for (int y = 1; y <= j; y++)
            {
                if (temp[1, y] != null)
                    returnstring[0, y - 1] = temp[1, y].ToString();
                else returnstring[0, y - 1] = "";
            }
            
            
            return returnstring;
        }
        public partial void CreateDefaultFile(string path)
        {
            Workbooks tmp = excelapp.Workbooks;
            wb = tmp.Add(XlWBATemplate.xlWBATWorksheet); // добавление листа в файл excel
            ws = wb.Worksheets[1];
            wb.SaveAs(path); // сохранение файла 
            wb.Close(0);
            excelapp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(tmp); // удаление ссылки на объект excel 
        }
        public partial void CreateFile(string path)
        {
            Workbooks tmp = excelapp.Workbooks;
            wb = tmp.Add(XlWBATemplate.xlWBATWorksheet); // добавление листа в файл excel
            ws = wb.Worksheets[1]; 
            ws.ListObjects.Add(XlListObjectSourceType.xlSrcRange, ws.Range["A1"].CurrentRegion,"Данные"); // добавление таблицы в создаваемый файл
            wb.SaveAs(path); // сохранение файла 
            wb.Close(0);
            excelapp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(tmp); // удаление ссылки на объект excel 
        }
        public partial void Close() 
        {
            wb.Close(true); // закрытие файла с сохранением
            excelapp.Quit(); // выход из приложения
            Marshal.ReleaseComObject(wb); // удаление ссылки на объект excel
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Excel excelmed = new Excel();
            Excel exceltime = new Excel();
          
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run((Form)new Menu(excelmed,exceltime));
        }
    }
}