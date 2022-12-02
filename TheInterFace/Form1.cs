using System.Net.NetworkInformation;

namespace TheInterFace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string userInfo = nameTextBox.Text + "," + dayTextBox.Text + "," + ageTextBox.Text + ",\n";
            File.AppendAllText("MyNewFile.txt", userInfo);
            //StreamWriter sw = File.AppendText("MyNewFile.txt");
            //sw.WriteLine(userInfo);
            //sw.Close();
            nameTextBox.Text = "Enter Name";
            dayTextBox.Text = "Enter Day";
            ageTextBox.Text = "Enter Age";
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Enter Name")
            {
                nameTextBox.Text = "";
            }
        }

        private void dayTextBox_Click(object sender, EventArgs e)
        {
            if (dayTextBox.Text == "Enter Day")
            {
                dayTextBox.Text = "";
            }
        }

        private void ageTextBox_Click(object sender, EventArgs e)
        {
            if (ageTextBox.Text == "Enter Age")
            {
                ageTextBox.Text = "";
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameTextBox.Text = "Enter Name";
            }
        }

        private void dayTextBox_Leave(object sender, EventArgs e)
        {
            if (dayTextBox.Text == "")
            {
                dayTextBox.Text = "Enter Day";
            }
        }

        private void ageTextBox_Leave(object sender, EventArgs e)
        {
            if (ageTextBox.Text == "")
            {
                ageTextBox.Text = "Enter Age";
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("MyNewFile.txt");
            string[] lineSplit = lines[0].Split(',');
            WorkDays day;
            day = (WorkDays)Enum.Parse(typeof(WorkDays), lineSplit[1]);
            nameTextBox.Text = lineSplit[0];
            dayTextBox.Text = day.ToString();
            ageTextBox.Text = lineSplit[2];
        }
        public enum WorkDays
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
        }

        IItem[] drinksArr = new IItem[5];
        int ind = 0;

        private void colaBtn_Click(object sender, EventArgs e)
        {
            if (ind != drinksArr.Length)
            {
                IItem cola = new Cola();
                drinksArr[ind] = cola;
                ind++;
            }
            else
            {
                ind = 0;
            }
        }

        private void kinleyBtn_Click(object sender, EventArgs e)
        {
            if (ind != drinksArr.Length)
            {
                IItem kinley = new Kinley();
                drinksArr[ind] = kinley;
                ind++;
            }
            else
            {
                ind = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Drinks = "";
            for (int i = 0; i < drinksArr.Length; i++)
            {
                if (drinksArr[i] is Cola)
                {
                    Drinks += "Cola: " + drinksArr[i].GetPrice().ToString() + "$\n";
                }
                else if (drinksArr[i] is Kinley)
                {
                    Drinks += "Kinley: " + drinksArr[i].GetPrice().ToString() + "$\n";
                }
            }
            MessageBox.Show(Drinks);
            if (ind == drinksArr.Length)
            {
                for (int i = 0; i < drinksArr.Length; i++)
                     {
                         drinksArr[i] = null;
                     }
            }
        }
    }
}