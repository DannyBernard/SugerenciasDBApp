using BLL;
using Entities;
using RegistroconAzure.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroconAzure.Registros
{
    public partial class RegistroPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            if (!Page.IsPostBack)
            {
                int id = Utils.ToInt(Request.QueryString["id"]);
                if (id > 0)
                {
                    RepositorioBase<Sugerencia> repositorio = new RepositorioBase<Sugerencia>();
                    Sugerencia user = repositorio.Buscar(id);
                    if (user == null)
                        Utils.ShowToastr(this, "Id no existe", "Error", "error");
                    else
                        LlenaCampo(user);
                    repositorio.Dispose();

                }

                else
                {
                    nuevoButton_Click(null, null);
                }

            }
        }
        public Sugerencia LlenaClase()
        {
            Sugerencia sg = new Sugerencia();
            sg.SugerenciaID = Utils.ToInt(IDTextBox.Text);
            bool resulado = DateTime.TryParse(FechaTextBox.Text, out DateTime fecha);
            sg.Fecha = fecha;
            sg.Descripcion = DescripcionTextBox.Text;

            return sg;
        }

        public void LlenaCampo(Sugerencia sugerencia)
        {
            FechaTextBox.Text = sugerencia.Fecha.ToString("yyyy-MM-dd");
            DescripcionTextBox.Text = sugerencia.Descripcion;
        }

        protected void Limpiar()
        {
            IDTextBox.Text = "0";
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DescripcionTextBox.Text = "";
        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Validar()
        {
            bool estado = false;
            if (String.IsNullOrWhiteSpace(IDTextBox.Text))
            {
                Utils.ShowToastr(this, "Debe tener un id válido.", "Error", "error");
                estado = true;
            }
            if (String.IsNullOrWhiteSpace(FechaTextBox.Text))
            {
                Utils.ShowToastr(this, "Debe tener una Fecha", "Error", "error");
                estado = true;
            }
            if (String.IsNullOrWhiteSpace(IDTextBox.Text))
            {
                Utils.ShowToastr(this, "Debe tener una Descripcion.", "Error", "error");
                estado = true;
            }
            return estado;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RepositorioBase<Sugerencia> repositorio = new RepositorioBase<Sugerencia>();

            var sugerencia = repositorio.Buscar(Utils.ToInt(IDTextBox.Text));
            if (sugerencia != null)
            {
                Utils.ShowToastr(this, "Busqueda exitosa", "Exito", "success");
                LlenaCampo(sugerencia);
            }
            else
            {
                Limpiar();
                Utils.ShowToastr(this, "No existe la Factura especificada", "Error", "error");
            }
        }




        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Sugerencia> db = new RepositorioBase<Sugerencia>();
            Sugerencia sugerencia = db.Buscar(Utils.ToInt(IDTextBox.Text));
            return (sugerencia != null);

        }

        protected void guadarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Sugerencia> db = new RepositorioBase<Sugerencia>();
            Sugerencia sugerencia;
            bool paso = false;

            sugerencia = LlenaClase();

            if (IDTextBox.Text == Convert.ToString(0))
            {
                paso = db.Guardar(sugerencia);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    Utils.ShowToastr(this.Page, "LLenar este campo", "Error", "error");
                    return;
                }
                paso = db.Modificar(sugerencia);
                Utils.ShowToastr(this.Page, "Modificado ", "Exito", "success");
                return;
            }

            if (paso)
                Utils.ShowToastr(this.Page, "Guardado ", "Exito", "success");
            else
                Utils.ShowToastr(this.Page, "Error No Guardado", "Error", "error");
            Limpiar();
        }

        protected void eliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Sugerencia> repositorio = new RepositorioBase<Sugerencia>();
            int id = Utils.ToInt(IDTextBox.Text);
            var sugerencia = repositorio.Buscar(id);

            if (sugerencia != null)
            {
                if (repositorio.Eliminar(id))
                {
                    Utils.ShowToastr(this.Page, "Exito Eliminado", "success");
                    Limpiar();
                }
                else
                    Utils.ShowToastr(this.Page, "No Eliminado", "error");
        

                }
                repositorio.Dispose();
            }
        }

    }