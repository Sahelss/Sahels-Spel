namespace Sahels_Spel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Datorn = new Random().Next(1,3);
            int Dintal = int.Parse(lblGissa.Text);
            int Po�ng = 0;
            if (Dintal == Datorn)

            {
                string Svar = Datorn.ToString();
                lblResultat.Text = "R�tt: " + Svar;
                Po�ng = Po�ng + 1;
                string resultat = Po�ng.ToString();
                tbxMinaResultat.Text = resultat;
            }
            else
            {
                lblResultat.Text = "Fel gissa igen";
                lblDator.Text = Datorn.ToString();
                tbxMinaResultat.Text = "0";
            }
        }
    }
}