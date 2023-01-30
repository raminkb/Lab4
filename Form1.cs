namespace Lab4
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        double maxIGPA = 0;
        double minIGPA = int.MaxValue;
        string Namemax = "";
        string Namemin = "";

        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
           
        }

        private void button1_Click(object sender, EventArgs e, double g)
        {
            

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;
            string birhtYear = this.textBoxBYear.Text;
            string gpa = this.textBoxGPA.Text;
            int iYear = Int32.Parse(birhtYear);
            double iGPA = double.Parse(gpa);
            //
            Person person = new Person(name, iYear,iGPA);
            this.classroom.addPerson2Class(person);
            //display person
            this.textBox1.Text = this.classroom.showAllPersoninClass();
            
           
            
            

            if (iGPA > maxIGPA)
            {
                maxIGPA = iGPA;
            }
            if (iGPA < minIGPA)
            {
                minIGPA = iGPA;
            }
            
            
            //clear
            this.textBoxName.Text = "";
            this.textBoxBYear.Text = "";
            this.textBoxGPA.Text = "";
            this.textBoxGPAmax.Text = "";
            this.textBoxGPAmin.Text = "";
            this.textBoxGPAavg.Text = "";

            //displaymax min avg

            this.textBoxGPAmax.Text = this.textBoxGPAmax.Text + maxIGPA;
            this.textBoxGPAmin.Text = this.textBoxGPAmin.Text + minIGPA;
            this.Namemax = this.textBoxNameGPAmax.Text ;
            this.Namemin = this.textBoxNameGPAmin.Text;
            this.textBoxGPAavg.Text = this.classroom.AvggradeinClass().ToString("#.##");
           //display total age of class
           this.textBoxTotal.Text = this.classroom.showsumageClass().ToString();
        }
    }
}