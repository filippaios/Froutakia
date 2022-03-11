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
    class Paytable
    {
        //δημιουργια συναρτησης η οποια δεχεται εναν αριθμο για να εμφανισει το αντιστοιχο messagebox και δεν επιστρεφει τιποτα απλα 
        //εμφανιζει το μηνυμα
        public void print_pay_table(int x)
        {
            if(x==1)
            {
                MessageBox.Show("3 ίδιες εικόνες με το αχλάδι κερδίζεις 2 πόντους" + Environment.NewLine +
                            "3 ίδιες εικόνες με το βατόμουρο κερδίζεις 3 πόντους  " + Environment.NewLine +
                            "3 ίδιες εικόνες με το καρπούζι κερδίζεις 4 πόντους" + Environment.NewLine +
                            "3 ίδιες εικόνες με το αστέρι κερδίζεις 20 πόντους");
            }
            else if (x==2)
            {
                MessageBox.Show("4 ίδιες εικόνες με το αχλάδι κερδίζεις 2 πόντους" + Environment.NewLine +
               "4 ίδιες εικόνες με το βατόμουρο κερδίζεις 3 πόντους  " + Environment.NewLine +
               "4 ίδιες εικόνες με το καρπούζι κερδίζεις 4 πόντους" + Environment.NewLine +
               "4 ίδιες εικόνες με το πορτοκάλι κερδίζεις 5 πόντους  " + Environment.NewLine +
               "4 ίδιες εικόνες με το λεμόνι κερδίζεις 6 πόντους" + Environment.NewLine +
               "4 ίδιες εικόνες με το αστέρι κερδίζεις 20 πόντους");
            }
            else
            {
                MessageBox.Show("5 ίδιες εικόνες με το αχλάδι κερδίζεις 2 πόντους" + Environment.NewLine +
                         "5 ίδιες εικόνες με το βατόμουρο κερδίζεις 3 πόντους  " + Environment.NewLine +
                         "5 ίδιες εικόνες με το καρπούζι κερδίζεις 4 πόντους" + Environment.NewLine +
                         "5 ίδιες εικόνες με το πορτοκάλι κερδίζεις 5 πόντους  " + Environment.NewLine +
                         "5 ίδιες εικόνες με το λεμόνι κερδίζεις 10 πόντους" + Environment.NewLine +
                         "5 ίδιες εικόνες με το κεράσι κερδίζεις 15 πόντους  " + Environment.NewLine +
                         "5 ίδιες εικόνες με το εφτά κερδίζεις 20 πόντους" + Environment.NewLine +
                         "5 ίδιες εικόνες με το αστέρι κερδίζεις 40 πόντους");

            }
        }
        
    }
}
