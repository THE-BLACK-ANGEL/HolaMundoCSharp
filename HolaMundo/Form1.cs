using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.Linq;


namespace HolaMundo
{
    public partial class Form1 : Form
    {
        private BindingList<Tarea> tareas = new BindingList<Tarea>();
        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Método generado por el Diseñador de Windows Forms.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realizada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 232);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca la tarea que quieres guardar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha máxima de la tarea : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 308);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Sin fecha limite";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Image = global::HolaMundo.Properties.Resources.logo_hortalan_liveplantgroup;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(859, 125);
            this.label3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Realizada,
            this.Fecha,
            this.descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(272, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 360);
            this.dataGridView1.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Realizada
            // 
            this.Realizada.HeaderText = "Realizada";
            this.Realizada.Name = "Realizada";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Limite";
            this.Fecha.Name = "Fecha";
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 275;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(65, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Añadir tarea";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.añadirTarea);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(64, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar tarea";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.eliminarTarea);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(859, 565);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Método para añadir una nueva tarea a la lista de tareas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void añadirTarea(object sender, EventArgs e)
        {
            Tarea nuevaTarea = new Tarea(textBox1.Text,dateTimePicker1.Value,checkBox1.Checked);
            tareas.Add(nuevaTarea);
            dataGridView1.Rows.Clear(); // Limpiar el DataGridView antes de agregar nuevas filas
            mostrarTareas(); // Mostrar las tareas

        }

        /// <summary>
        /// Método para eliminar una tarea seleccionada en el DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarTarea(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenemos el objeto que está en la fila seleccionada
                var filaSeleccionada = dataGridView1.SelectedRows[0];
                Tarea tareaSeleccionada = null;
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    // Obtenemos el ID de la tarea seleccionada
                    if (celda.OwningColumn.Name == "ID")
                    {
                        int idTarea = Convert.ToInt32(celda.Value);
                        // Buscamos la tarea en la lista de tareas por su ID
                        tareaSeleccionada = tareas.FirstOrDefault(t => t.ID == idTarea);
                        if (tareaSeleccionada != null)
                        {
                            // Eliminamos la tarea de la lista
                            tareas.Remove(tareaSeleccionada);
                            break; // Salimos del bucle una vez que hemos encontrado y eliminado la tarea
                        }
                    }
                }

                if (tareaSeleccionada != null)
                {
                    tareas.Remove(tareaSeleccionada); // Se elimina de la lista
                }
                dataGridView1.Rows.Clear();// Limpiamos el DataGridView antes de agregar la lista actualizada
                mostrarTareas();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminarla.");
            }

        }

        /// <summary>
        /// Método para mostrar las tareas en el DataGridView.
        /// </summary>
        private void mostrarTareas()
        {
            foreach (Tarea tarea in tareas)
            {
                dataGridView1.Rows.Add(tarea.ID, tarea.realizada, tarea.fecha.ToShortDateString(), tarea.descripcion);
            }
        }



    }
}
