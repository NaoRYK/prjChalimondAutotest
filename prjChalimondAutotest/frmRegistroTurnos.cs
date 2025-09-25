namespace prjChalimondAutotest
{
    public partial class frmRegistroTurnos : Form
    {

        string dominio;
        int a�oFabricacion;
        string titular;
        int numeroTurno;

        public class Turno
        {
            public string Dominio;
            public int A�oFabricacion;
            public string Titular;
            public int NumeroTurno;

        }
        int contadorTurnos = 0;

        int cantidadTurnosIngresados, vehiculoMasAntiguo, cantidadVechiculosDominioCorto;

        Turno[] turnos = new Turno[50];

        public frmRegistroTurnos()
        {
            InitializeComponent();
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (contadorTurnos <= 49)
            {
                dominio = txtDominio.Text;
                a�oFabricacion = Convert.ToInt32(numA�oFabricacion.Value);
                titular = txtTitular.Text;
                numeroTurno = Convert.ToInt32(numNumTurno.Value);

                bool turnoValido = Validaciones();
                if (!turnoValido)
                {

                    return;

                }

                turnos[contadorTurnos] = new Turno();
                turnos[contadorTurnos].Dominio = dominio;
                turnos[contadorTurnos].A�oFabricacion = a�oFabricacion;
                turnos[contadorTurnos].Titular = titular;
                turnos[contadorTurnos].NumeroTurno = numeroTurno;
                MessageBox.Show("Turno registrado con �xito");
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
                MessageBox.Show("El dominio solo puede contener letras may�sculas y n�meros del 1 al 9.");
                return false;
            }

            if (numA�oFabricacion.Value < 1950 || numA�oFabricacion.Value > DateTime.Now.Year)
            {
                MessageBox.Show("El a�o de fabricaci�n debe estar entre 1950 y el a�o actual.");
                return false;
            }

            if (txtTitular.Text.Length <= 2)
            {
                MessageBox.Show("El nombre del titular debe tener m�s de 2 caracteres.");
                return false;
            }

            if (!(numeroTurno > 0))
            {
                MessageBox.Show("El n�mero de turno debe mayor a 0.");
                return false;
            }
            bool turnoValido = validarNumTurno(numeroTurno);

            if (!turnoValido)
            {

                MessageBox.Show("El n�mero de turno ya existe. Por favor, ingrese un n�mero de turno diferente.");
                return false;
            }



            return true;
        }

        private void calcularEstadisticas()
        {
            if (turnos.Length > 0)
            {
                cantidadTurnosIngresados = contadorTurnos;
                vehiculoMasAntiguo = DateTime.Now.Year;
                cantidadVechiculosDominioCorto = 0;


                for (int i = 0; i < contadorTurnos; i++)
                {
                    if (turnos[i].A�oFabricacion < vehiculoMasAntiguo)
                    {
                        vehiculoMasAntiguo = turnos[i].A�oFabricacion;
                    }
                    if (turnos[i].Dominio.Length < 7)
                    {
                        cantidadVechiculosDominioCorto++;
                    }
                }
                lblCantTurnos.Text = cantidadTurnosIngresados.ToString();
                lblA�oMasAntiguo.Text = vehiculoMasAntiguo.ToString();
                lblDominio6Char.Text = cantidadVechiculosDominioCorto.ToString();
            }
        }

        private bool validarNumTurno(int _numTurno)
        {
            for (int i = 0; i < contadorTurnos; i++)
            {
                if (turnos[i].NumeroTurno == _numTurno)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            calcularEstadisticas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
aa
        }
    }

}
