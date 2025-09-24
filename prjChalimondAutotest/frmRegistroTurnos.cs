namespace prjChalimondAutotest
{
    public partial class frmRegistroTurnos : Form
    {

        public class Turno
        {
            public string Dominio;
            public int AñoFabricacion;
            public string Titular;
            public int NumeroTurno;

        }
        int contadorTurnos = 0;

        Turno[] turnos = new Turno[50];

        public frmRegistroTurnos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           turnos[0] = new Turno();
            contadorTurnos++;
        }
    }
}
