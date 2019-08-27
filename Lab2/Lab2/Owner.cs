using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Банк. Объект – «Счет». Поля: номер, тип вклада, баланс, дата
//открытия, владелец, подключение смс оповещения, подключение
//интернет-банкинга и т.д.Агрегируемый объект – «Владелец».
//Поля: ФИО, дата рождения, паспортные данные и т.д.
namespace Lab2
{
    [Serializable]
    public class Owner
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string secondname { get; set; }
        public string dateofbirth { get; set; }
        public int passport { get; set; }
        public Owner() { }
        public Owner (string name, string surname, string secondname, string dateofbirth, int passport)
        {
            this.name = name;
            this.surname = surname;
            this.secondname = secondname;
            this.dateofbirth = dateofbirth;
            this.passport = passport;
        }
        public override string ToString()
        {
            return"Владелец: "+ this.name + " " + this.surname + " " + this.secondname + ", Дата рождения:" + this.dateofbirth + ",Номер паспорта: " + this.passport;
        }
    }
}
