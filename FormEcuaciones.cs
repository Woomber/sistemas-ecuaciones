/*
 * FormEcuaciones.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Interfaz gráfica para resolver sistemas de ecuaciones de 2x2 hasta 10x10
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matemáticas.Tipos;
using SistemasEcuaciones.Procesos;
using SistemasEcuaciones.Tipos;

namespace SistemasEcuaciones
{
    public partial class FormEcuaciones : Form
    {
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Propiedades
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        TextBox[,] Textboxes;
        int nIncógnitas = 2;


        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Constructor
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public FormEcuaciones()
        {
            InitializeComponent();
            actualizarTextboxes();
        }


        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Crear número de textbox necesarios
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

        private void nudNIncógnitas_ValueChanged(object sender, EventArgs e)
        {
            nIncógnitas = (int)nudNIncógnitas.Value;
            actualizarTextboxes();

        }

        void actualizarTextboxes()
        {
            panelTextbox.Controls.Clear();
            Textboxes = new TextBox[nIncógnitas, nIncógnitas + 1];
            for (int i = 0; i < nIncógnitas; i++)
            {
                for (int j = 0; j < nIncógnitas + 1; j++)
                {
                    Textboxes[i, j] = new TextBox();
                    Textboxes[i, j].Size = new Size(50, 20);
                    Textboxes[i, j].Text = "0";
                    Textboxes[i, j].Location = new Point(90 * j, 25 * i);

                    panelTextbox.Controls.Add(Textboxes[i, j]);

                    Label letra = new Label();
                    letra.Text = "";
                    if (j < nIncógnitas - 1) letra.Text += "X" + (j + 1) + " +";
                    else if (j < nIncógnitas) letra.Text += "X" + (j + 1) + " =";
                    letra.Width = (letra.Text.Length > 0) ? 35 : 0;
                    letra.Location = new Point(90 * j + 50, 25 * i + 3);

                    panelTextbox.Controls.Add(letra);
                }//for j
            }//for i
        }


        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Resolver sistema
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

        private void btnResolver_Click(object sender, EventArgs e)
        {
            SistemaEcuaciones ecuaciones = new SistemaEcuaciones(nIncógnitas);
            try
            {
                for (int i = 0; i < nIncógnitas; i++)
                {
                    for (int j = 0; j < nIncógnitas; j++)
                    {
                        ecuaciones.Coeficientes[i, j] = new Fracción(decimal.Parse(Textboxes[i, j].Text));
                    }
                    ecuaciones.Independientes[i, 0] = new Fracción(decimal.Parse(Textboxes[i, nIncógnitas].Text));
                }//for i
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al tratar de solucionar");
                return;
            }//catch
           
            try
            {
                Matriz<Fracción> solución = Ecuaciones.Resolver(ecuaciones);

                string cadena = "El resultado de este sistema es:\n";

                for(int i = 0; i < nIncógnitas; i++)
                {
                    cadena += "X" + (i + 1) + " = " + solución[i, 0] + "\n";
                }
                MessageBox.Show(cadena, "Resultado");
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No existe una solución de este sistema o no se puede resolver.",
                    "Error al tratar de solucionar"
                    );
            }//catch
            
        }
    }//class
}
