namespace lap0003
{
    public partial class Form1 : Form
    {
        //array <--> List
        List<Student1> _students1 = new List<Student1>();
        // max min grade 
        double MaxNgrade = 0;
        double MinNgrade = int.MaxValue;
        int NumBer_Student = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            //get value form texbox
            String name = this.TextBoxname.Text;
            String id = this.TextBoxID.Text;
            String year = this.TextBoxbirthyear.Text;
            String hight = this.TextBoxhight.Text;
            String grade = this.TextBoxgrade.Text;
            String major = this.TextBoxmajor.Text;

            //convert string to in
            int iYear = Int32.Parse(year);
            int iHight = Int32.Parse(hight);
            double iGrade = Double.Parse(grade);

            //create obj form student
            Student1 newStudent = new Student1(name, id, iYear, iHight, iGrade, major);
            //add new student to list
            this._students1.Add(newStudent);

            //cal max min
            if (iGrade > MaxNgrade)
            {
                MaxNgrade = iGrade;
            }
            if (iGrade < MinNgrade)
            {
                MinNgrade = iGrade;
            }

            //cal num Student
            NumBer_Student = NumBer_Student + 1;

            //clear textbox
            this.TextBoxname.Text = "";
            this.TextBoxID.Text = "";
            this.TextBoxbirthyear.Text = "";
            this.TextBoxhight.Text = "";
            this.TextBoxgrade.Text = "";
            this.TextBoxmajor.Text = "";
            this.TextBoxMaxx.Text = "";
            this.TextBoxMinx.Text = "";
            this.TextBoxNumx.Text = "";

            //show max min grade
            this.TextBoxMaxx.Text = this.TextBoxMaxx.Text + MaxNgrade;
            this.TextBoxMinx.Text = this.TextBoxMinx.Text + MinNgrade;

            //show num Stdent1
            this.TextBoxNumx.Text = this.TextBoxNumx.Text + NumBer_Student;

            //add data to DataGridView
            BindingSource source = new BindingSource();
            source.DataSource = this._students1;
            this.dataGridView1.DataSource = source;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //clear textbox
            this.TextBoxname.Text = "";
            this.TextBoxID.Text = "";
            this.TextBoxbirthyear.Text = "";
            this.TextBoxhight.Text = "";
            this.TextBoxgrade.Text = "";
            this.TextBoxmajor.Text = "";
        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}