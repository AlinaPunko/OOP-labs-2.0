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
    public class Deposite
    {
        public int number { get; set; }
        public string type { get; set; }
        public double balance { get; set; }
        public string date { get; set; }
        public bool hassms { get; set; }
        public bool hasinternetbanking { get; set; }
        public Owner owner;
        public Deposite() { }
        public Deposite(int number, string type, double balance, string date, bool hassms, bool hasinternetbanking, Owner owner)
        {
            this.number = number;
            this.type = type;
            this.balance = balance;
            this.date = date;
            this.hassms = hassms;
            this.hasinternetbanking = hasinternetbanking;
            this.owner = owner;
        }
        public override string ToString()
        {
            return "Номер вклада: "+this.number + ", Тип  вклада: " + this.type + ", Баланс " + this.balance + " Дата открытия " + this.date + ", Подключён ли СМС " + this.hassms + ", Подключён ли интернет-банкинг? " + this.hasinternetbanking;
        }
    }
}
