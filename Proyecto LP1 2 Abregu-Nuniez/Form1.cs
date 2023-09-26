namespace Proyecto_LP1_2_Abregu_Nuniez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            String sexo;
            if (rb1.Checked)
            {
                sexo = "Masculino";
            }
            else { sexo = "Femenino";
            }
            String genero = clb1.GetItemChecked(clb1.Text);
            String consola = (string)cb1.SelectedItem;
            tb1.AppendText($"Sexo:{sexo},Genero/s:{genero},Consola:{consola}\r\n\r\n");
        }
    }
}