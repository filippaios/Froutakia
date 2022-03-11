using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class ConnectDatabase
    {
        //χρησιμοποιειται μονο στην φορμα 1 για τον ελεγχο των στοιχειων
        public int  logincheckdatabase (string query2)
        {
            //εδω αποθηκευεται το connection string στο οποιο υπαρχει η συνδεση με τη βαση 
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gfilippaios\Desktop\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");            
            //εδω γινεται η συνδεση του connection string και του query
            SqlDataAdapter sda = new SqlDataAdapter(query2, con);
            //δημιουργια πινακα για την αποθηκευση των  αποτελεσματων απο την συνδεση
            DataTable dt = new DataTable();
            // το αποτελεσμα την συνδεσης της sda την αποθηκευουμε στον πινακα dt
            sda.Fill(dt);
            //αν υπαρχει αποτελεσμα που αντιστοιχει στα στοιχεια του χρηστη τοτε κανε τις παρακατω λειτουργιες
            if (dt.Rows.Count == 1)
            {
                //ελεγχει στην βαση στην στηλη coins στην  αντιστοιχη γραμμη και το αποτελεσμα το επιστρεφει
                return (int)dt.Rows[0]["coins"];
            }
            else 
            {
                return -1;
            }
        }
        //χρησιμοποιειται στο κουμπι exit για την αλλαγη στη στηλη coins
        public void connecttodatabase(string query2)
        {
            //εδω αποθηκευεται το connection string στο οποιο υπαρχει η συνδεση με τη βαση 
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gfilippaios\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
            //εδω γινεται η συνδεση του connection string και του query
            SqlDataAdapter sda = new SqlDataAdapter(query2, con);
            //δημιουργια πινακα για την αποθηκευση των  αποτελεσματων απο την συνδεση
            DataTable dt = new DataTable();
            // το αποτελεσμα την συνδεσης της sda την αποθηκευουμε στον πινακα dt
            sda.Fill(dt);
        }

        public void close_application()
        {
            Application.Exit();//κλείνει όλο το πρόγραμμα
        }
        
    }
}
