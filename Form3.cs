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
    public partial class Form3 : Form
    {
        //δημιουργια μεταβλητης random για την αλλαγη των εικονων σε καθε timer
        Random random = new Random();
        //οι μεταβλητες αυτες χρησιμοποιουντε για τα δευτερολεπτα οπου περιμενουν οι εικονες για να σταματησουν οι timers
        int count_play1 = 0, count_play2 = 0, count_play3 = 0, count_play4=0;
        string username;
        //η μεταβλητη αυτη χρεισιμοποιειται για τις αλλαγες που γινονται στα coins οπου εχει ο παικτης κατα τη διαρκεια του παιχνιδιου
        int coins;
        public Form3()
        {
            InitializeComponent();
        }
        //αρχικοποιει τα διαθεσιμα coins του χρηστη 
        public void setcoins(int x)
        {
            coins = x;
            label2.Text = coins.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //δημιουργια της εντολης της sql για να γινουν οι αλλαγες στην βαση
            string query2 = "Update Login Set coins='" + label2.Text.Trim() + "' where username='" + label5.Text.Trim() + "'";
            //δημιουγια αντικειμενου exit της κλασης ConnectDatabase
            ConnectDatabase exit = new ConnectDatabase();
            //στελνει στην συναρτηση connecttodatabase το query2 και κλεινει το προγραμμα με την συναρτηση close_application
            exit.connecttodatabase(query2);
            exit.close_application();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")//γίνεται έλεγχος σε περίπτωση που δεν έχει άλλα coins ο χρήστης 
            {
                MessageBox.Show("Δεν έχετε άλλα coins");
            }
            else
            {
                //με το που πατάει το κουμπί αρχίζουν να λειτουργούν οι timers για να γίνει το random
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = true;
                timer1.Interval = 500;//αλλιώς μειώνεται ο χρόνος που τρέχουν οι εικόνες στο πρώτο picturebox
                coins--;//κάθε φορά που ο χρήστης παίζει ποντάρει ένα coin και για αυτό μειώνονται
                label2.Text = coins.ToString();
            }
        }
        //αρχικοποιει το ονομα του χρηστη οπου το πηραμε απο τη βαση
        public void setusername(string x)
        {
            username = x;
            label5.Text = username.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int froutou = random.Next(1, 6);//δημιουργία τυχαίου αριθμού

            if (froutou == 1)//αν ο τυχαίος αριθμός είναι το 1 εμφάνισε την εικόνα αστέρι
            {
                pictureBox1.ImageLocation = "αστέρι.png";

            }
            else if (froutou == 2)
            {
                pictureBox1.ImageLocation = "αχλάδι.png";

            }
            else if (froutou == 3)
            {
                pictureBox1.ImageLocation = "βατόμουρο.png";

            }
            else if (froutou == 4)
            {
                pictureBox1.ImageLocation = "καρπούζι.png";

            }
            else if (froutou == 5)
            {
                pictureBox1.ImageLocation = "πορτοκάλι.png";

            }
            else if (froutou == 6)
            {
                pictureBox1.ImageLocation = "λεμόνι.png";

            }

            if (timer1.Interval == 500)//στην περίπτωση που έχει μειωθεί ο χρόνος εμφάνισης των εικονών
            {
                count_play1++;//αν το count_start1 δεν είναι τρια ακόμα αύξησέ το 
                if (count_play1 == 3)//μέτρα μέχρι το τρια
                {
                    timer1.Enabled = false;//και μετά κλείσε το timer του picturebox1 
                    timer2.Interval = 500;//και μείωσε το χρόνο λειτουργίας στο επόμενο picturebox2
                    count_play1 = 0;//μηδένισε το count_start1 για όταν ξανά χρησιμοποιηθεί
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int froutou = random.Next(1, 6);//δημιουργία τυχαίου αριθμού

            if (froutou == 1)//αν ο τυχαίος αριθμός είναι το ένα εμφάνισε την εικόνα αστέρι
            {
                pictureBox2.ImageLocation = "πορτοκάλι.png";

            }
            else if (froutou == 2)
            {
                pictureBox2.ImageLocation = "αχλάδι.png";

            }
            else if (froutou == 3)
            {
                pictureBox2.ImageLocation = "λεμόνι.png"; 

            }
            else if (froutou == 4)
            {
                pictureBox2.ImageLocation = "καρπούζι.png";

            }
            else if (froutou == 5)
            {
                pictureBox2.ImageLocation = "αστέρι.png";

            }
            else if (froutou == 6)
            {
                pictureBox2.ImageLocation = "βατόμουρο.png";

            }

            if (timer2.Interval == 500)//στην περίπτωση που έχει μειωθεί ο χρόνος εμφάνισης των εικονών
            {
                count_play2++;//αν το count_start1 δεν είναι τρια ακόμα αύξησέ το 
                if (count_play2 == 3)//μέτρα μέχρι το τρια
                {
                    timer2.Enabled = false;//και μετά κλείσε το timer του picturebox1 
                    timer3.Interval = 500;//και μείωσε το χρόνο λειτουργίας στο επόμενο picturebox2
                    count_play2 = 0;//μηδένισε το count_start1 για όταν ξανά χρησιμοποιηθεί
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //δημιουργια αντικειμενου paytable της κλασης Paytable 
            Paytable paytable = new Paytable();
            //στελνει στην συναρτηση print_pay_table τον αριθμο 1 για να εμφανιστει το αντιστοιχο messagebox
            paytable.print_pay_table(2);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int froutou = random.Next(1, 6);//δημιουργία τυχαίου αριθμού

            if (froutou == 1)//αν ο τυχαίος αριθμός είναι το ένα εμφάνισε την εικόνα αστέρι
            {
                pictureBox3.ImageLocation = "καρπούζι.png"; 

            }
            else if (froutou == 2)
            {
                pictureBox3.ImageLocation = "βατόμουρο.png"; 

            }
            else if (froutou == 3)
            {
                pictureBox3.ImageLocation = "λεμόνι.png";

            }
            else if (froutou == 4)
            {
                pictureBox3.ImageLocation = "πορτοκάλι.png";

            }
            else if (froutou == 5)
            {
                pictureBox3.ImageLocation = "αστέρι.png";

            }
            else if (froutou == 6)
            {
                pictureBox3.ImageLocation = "αχλάδι.png";

            }

            if (timer3.Interval == 500)//στην περίπτωση που έχει μειωθεί ο χρόνος εμφάνισης των εικονών
            {
                count_play3++;//αν το count_start1 δεν είναι τρια ακόμα αύξησέ το 
                if (count_play3 == 3)//μέτρα μέχρι το τρια
                {
                    timer3.Enabled = false;//και μετά κλείσε το timer του picturebox1 
                    timer4.Interval = 500;//και μείωσε το χρόνο λειτουργίας στο επόμενο picturebox2
                    count_play3 = 0;//μηδένισε το count_start1 για όταν ξανά χρησιμοποιηθεί
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //ανοιγω την φορμα 2 ενω πριν στελνω σε αυτη τα coins που υπαρχουν ηδη στην φορμα 3
            Form2 form2 = new Form2();
            form2.setcoins(coins);
            form2.setusername(username);
            form2.Show();
     
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //ανοιγω την φορμα 4 ενω πριν στελνω σε αυτη τα coins που υπαρχουν ηδη στην φορμα 3
            Form4 form4 = new Form4();
            form4.setcoins(coins);
            form4.setusername(username);
            form4.Show();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int froutou = random.Next(1, 6);//δημιουργία τυχαίου αριθμού

            if (froutou == 1)//αν ο τυχαίος αριθμός είναι το ένα εμφάνισε την εικόνα αστέρι
            {
                pictureBox4.ImageLocation = "καρπούζι.png";

            }
            else if (froutou == 2)
            {
                pictureBox4.ImageLocation = "βατόμουρο.png";

            }
            else if (froutou == 3)
            {
                pictureBox4.ImageLocation = "λεμόνι.png";

            }
            else if (froutou == 4)
            {
                pictureBox4.ImageLocation = "πορτοκάλι.png";

            }
            else if (froutou == 5)
            {
                pictureBox4.ImageLocation = "αστέρι.png";

            }
            else if (froutou == 6)
            {
                pictureBox4.ImageLocation = "αχλάδι.png";

            }

            if (timer4.Interval == 500)
            {
                count_play4++;
                if (count_play4 == 3)
                {
                    timer4.Enabled = false;
                    count_play4 = 0;
                    //σε περίπτωση που όλα τα picturebox έχουν την ίδια εικόνα βγαίνει μήνυμα με τους πόντους που κέρδισε 
                    //και αυξάνεται το coins ανάλογα με τους πόντους που κέρδισε
                    if (pictureBox1.ImageLocation == "αστέρι.png" & pictureBox2.ImageLocation == "αστέρι.png" & pictureBox3.ImageLocation == "αστέρι.png" & pictureBox4.ImageLocation == "αστέρι.png")
                    {
                        MessageBox.Show("Κέρδισες 20 πόντους!!!");
                        coins = coins + 20;
                        label2.Text = coins.ToString();

                       
                    }
                    else if (pictureBox1.ImageLocation == "καρπούζι.png" & pictureBox2.ImageLocation == "καρπούζι.png" & pictureBox3.ImageLocation == "καρπούζι.png" & pictureBox4.ImageLocation == "καρπούζι.png")
                    {
                        MessageBox.Show("Κέρδισες 4 πόντους!!!");
                        coins = coins + 4;
                        label2.Text = coins.ToString();

                       
                    }
                    else if (pictureBox1.ImageLocation == "βατόμουρο.png" & pictureBox2.ImageLocation == "βατόμουρο.png" & pictureBox3.ImageLocation == "βατόμουρο.png" & pictureBox4.ImageLocation == "βατόμουρο.png")
                    {
                        MessageBox.Show("Κέρδισες 3 πόντους!!!");
                        coins = coins + 3;
                        label2.Text = coins.ToString();

                       
                    }
                    else if (pictureBox1.ImageLocation == "αχλάδι.png" & pictureBox2.ImageLocation == "αχλάδι.png" & pictureBox3.ImageLocation == "αχλάδι.png" & pictureBox4.ImageLocation == "αχλάδι.png")
                    {
                        MessageBox.Show("Κέρδισες 2 πόντους!!!");
                        coins = coins + 2;
                        label2.Text = coins.ToString();

                        
                    }
                    else if (pictureBox1.ImageLocation == "πορτοκάλι.png" & pictureBox2.ImageLocation == "πορτοκάλι.png" & pictureBox3.ImageLocation == "πορτοκάλι.png" & pictureBox4.ImageLocation == "πορτοκάλι.png")
                    {
                        MessageBox.Show("Κέρδισες 5 πόντους!!!");
                        coins = coins + 5;
                        label2.Text = coins.ToString();

                        
                    }
                    else if (pictureBox1.ImageLocation == "λεμόνι.png" & pictureBox2.ImageLocation == "λεμόνι.png" & pictureBox3.ImageLocation == "λεμόνι.png" & pictureBox4.ImageLocation == "λεμόνι.png")
                    {
                        MessageBox.Show("Κέρδισες 6 πόντους!!!");
                        coins = coins + 6;
                        label2.Text = coins.ToString();

                        
                    }
                    else
                    {
                        MessageBox.Show("Χάσατε!!!");

                      

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //καθε φορα που παταμε το κουμπι Προσθήκη coins αυτο αυξανεται και φαινεται στο label2
            coins++;
            label2.Text = coins.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label5.Text = username;
            radioButton2.Checked = true;
            

        }
    }
}
