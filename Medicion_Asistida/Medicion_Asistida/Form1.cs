namespace Medicion_Asistida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }
        int drug1, drug2, drug3;

        
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                drug1 = 3;
                label2.Text= (drug1 + drug2 + drug3).ToString();   
            }
        }

               private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                drug1 = 0;
                label2.Text = (drug1 + drug2 + drug3).ToString();
            }
        }

       
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                drug2 = 3;
                label2.Text = (drug1 + drug2 + drug3).ToString();
            }
        }

                private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                drug2 = 0;
                label2.Text = (drug1 + drug2 + drug3).ToString();
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                drug3 = 3;
                label2.Text = (drug1 + drug2 + drug3).ToString();
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                drug3 = 0;
                label2.Text = (drug1 + drug2 + drug3).ToString();
            }
        }

    }



}