namespace prjChalimondAutotest
{
    public partial class frmRegistroTurnos : Form
    {

        string dominio;
        int añoFabricacion;
        string titular;
        int numeroTurno;

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

            if (contadorTurnos <= 49)
            {
                dominio = txtDominio.Text;
                añoFabricacion = Convert.ToInt32(numAñoFabricacion.Value);
                titular = txtTitular.Text;
                numeroTurno = Convert.ToInt32(numNumTurno.Value);

                turnos[contadorTurnos] = new Turno();
                turnos[contadorTurnos].Dominio = dominio;
                turnos[contadorTurnos].AñoFabricacion = añoFabricacion;
                turnos[contadorTurnos].Titular = titular;
                turnos[contadorTurnos].NumeroTurno = numeroTurno;
                MessageBox.Show("Turno registrado con éxito");
                contadorTurnos++;
            }
            else
            {
                MessageBox.Show("Maximo de turnos alcanzados");
            }
        }

        private bool Validaciones()
        {
            string dominio = txtDominio.Text;

            if (dominio.Length < 6)
            {
                MessageBox.Show("El dominio debe tener al menos 6 caracteres.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(dominio, @"^[A-Z1-9]+$"))
            {
                MessageBox.Show("El dominio solo puede contener letras mayúsculas y números del 1 al 9.");
                return false;
            }

            if(numAñoFabricacion.Value < 1950 || numAñoFabricacion.Value > DateTime.Now.Year)
            {
                MessageBox.Show("El año de fabricación debe estar entre 1950 y el año actual.");
                return false;
            }

            if(txtTitular.Text.Length <= 2)
            {
                MessageBox.Show("El nombre del titular debe tener más de 2 caracteres.");
                return false;
            }

            if (numNumTurno.Value > 0)
            {
                MessageBox.Show("El número de turno debe mayor a 0.");
                return false;
            }
            bool turnoValido = validarNumTurno(numeroTurno);

            if (!turnoValido) { 

                MessageBox.Show("El número de turno ya existe. Por favor, ingrese un número de turno diferente.");
                return false;
            }
            
            

            return true;
        }

        private bool validarNumTurno(int _numTurno)
        {
            foreach (var _turno in turnos)
            {
                if(_turno.NumeroTurno == _numTurno)
                {
                    return false;
                }
            }

            return true;
        }
    }
    }
}
