using DVD.Connection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVD.Functions
{
    public class ClassAutorization
    {
        public static ObservableCollection<Sotrudnik> sotrudniks { get; set; }
        public static void RegistrationSotr (string fio, string phone, string password)
        {

            Sotrudnik newSotr = new Sotrudnik();
            newSotr.FIO = fio.Trim();
            newSotr.Phone = phone.Trim();
            newSotr.Password = password.Trim();
            newSotr.Id_role = 1;
            newSotr.Salary = 25000;
            DBconn.conn.Sotrudnik.Add(newSotr);
            DBconn.conn.SaveChanges();
             
        }
    }
}
