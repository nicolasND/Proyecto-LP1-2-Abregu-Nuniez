namespace Proyecto_LP1_2_Abregu_Nuniez
{
    public partial class Form1 : Form
    {
        List<String> listaConDatos = new List<String>();
        private int masc = 0, fem = 0, fps = 0, rpg = 0, estrat = 0, sand = 0,
            hack = 0, metro = 0, otro = 0, pc = 0, consola = 0, movil = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {

            if (!rb1.Checked && !rb1.Checked || clb1.CheckedItems.Count == 0 || cb1.Text == "Seleccione una opcion:")
            {
                MessageBox.Show("Por favor, selecciona en todos los campos.");
                return;
            }
            else
            {
                if (rb1.Checked) listaConDatos.Add("Masculino");
                else listaConDatos.Add("Femenino");

                for (int i = 0; i < clb1.CheckedItems.Count; i++)
                {
                    switch (clb1.CheckedItems[i].ToString())
                    {
                        case "FPS (First Person Shooter)":
                            listaConDatos.Add("FPS (First Person Shooter)");
                            break;
                        case "RPG (Roleplay Game)":
                            listaConDatos.Add("RPG (Roleplay Game)");
                            break;
                        case "Estrategia":
                            listaConDatos.Add("Estrategia");
                            break;
                        case "Sandbox":
                            listaConDatos.Add("Sandbox");
                            break;
                        case "Hack ´n Slash":
                            listaConDatos.Add("Hack ´n Slash");
                            break;
                        case "Metroidvania":
                            listaConDatos.Add("Metroidvania");
                            break;
                        case "Otro/s":
                            listaConDatos.Add("Otro/s");
                            break;
                    }
                }
                listaConDatos.Add(cb1.SelectedItem.ToString());

                //Se resetean valores para contar nuevamente los votos
                masc = 0; fem = 0; fps = 0; rpg = 0; estrat = 0; sand = 0;
                hack = 0; metro = 0; otro = 0; pc = 0; consola = 0; movil = 0;
                for (int i = 0; i < listaConDatos.Count; i++)
                {
                    switch (listaConDatos[i].ToString())
                    {
                        case "Masculino":
                            masc++;
                            break;
                        case "Femenino":
                            fem++;
                            break;
                        case "FPS (First Person Shooter)":
                            fps++;
                            break;
                        case "RPG (Roleplay Game)":
                            rpg++;
                            break;
                        case "Estrategia":
                            estrat++;
                            break;
                        case "Sandbox":
                            sand++;
                            break;
                        case "Hack ´n Slash":
                            hack++;
                            break;
                        case "Metroidvania":
                            metro++;
                            break;
                        case "Otro/s":
                            otro++;
                            break;
                        case "PC":
                            pc++;
                            break;
                        case "Consola":
                            consola++;
                            break;
                        case "Movil":
                            movil++;
                            break;
                    }
                }

                tb1.Text = "";
                tb1.AppendText($"Resultados: \r\n" +
                               $"Masculino: {masc}\r\n" +
                               $"Femenino: {fem}\r\n" +
                               $"FPS: {fps}\r\n" +
                               $"RPG: {rpg}\r\n" +
                               $"Estrategia: {estrat}\r\n" +
                               $"Sandbox: {sand}\r\n" +
                               $"Hack ´n Slash: {hack}\r\n" +
                               $"Metroidvania: {metro}\r\n" +
                               $"Otro/s: {otro}\r\n" +
                               $"PC: {pc}\r\n" +
                               $"Consola: {consola}\r\n" +
                               $"Movil: {movil}\r\n");
            }
        }

        private void cb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("¡¡¡En este campo no se puede escribir!!!");
            e.Handled = true;
            return;
        }
    }
}