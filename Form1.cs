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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // δημιουργια της εντολης sql select για τον ελεγχο αν υπαρχει ο χρηστης στην βαση 
            string query = "Select * From Login where username='" + textBox1.Text.Trim() + "' and password ='" + textBox2.Text.Trim() + "'";
            //δημιουργια αντικειμενου logincon της κλασης ConnectDatabase 
            ConnectDatabase logincon = new ConnectDatabase();
            // η συναρτηση logincheckdatabase στελνει το query και επιστρεφει τα διαθεσιμα coins του παικτη ειτε -1 αν δεν βρει τον παικτη
            int x = logincon.logincheckdatabase(query);
            // αν υπαρχει ο παικτης του δινει προσβαση 
            if (x != -1)
            {
                Form2 form2 = new Form2();
                Form3 form3 = new Form3();
                Form4 form4 = new Form4();

                //το αποτελεσμα της συναρτησης το στελνουμε στην φορμα 2
                form2.setcoins(x);
                //στελνω στην φορμα 2 , 3 και 4 το ονομα που δοθηκε στο textbox 1
                form2.setusername(textBox1.Text.Trim());
                form3.setusername(textBox1.Text.Trim());
                form4.setusername(textBox1.Text.Trim());
                //ανοιξε την φορμα 2 για να ξεκινησει το προγρμμα
                form2.Show();
            }
        }
    }
}
