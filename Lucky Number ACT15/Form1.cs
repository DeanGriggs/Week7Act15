namespace Lucky_Number_ACT15
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public int lckyNum;

        public Form1()
        {
            InitializeComponent();
            
            
        }
        
        

        int cbNum = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lckyNum = Int16.Parse(TB_age.Text);
            cbNum = CB_month.SelectedIndex + 1; 
            lckyNum = lckyNum / cbNum;
            cbNum = CB_Day.SelectedIndex + 1;
            lckyNum = (lckyNum * cbNum);
            lckyNum = ((lckyNum / 12) + (CB_month.SelectedIndex / 20)) / 2;
            

            instance = this;
            Form2 form2 = new Form2();
            form2.Show();
        }

       
    }
}