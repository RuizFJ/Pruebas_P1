namespace PjPromedio_Prueba
{
    partial class FrmPromedio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEstudiante = new TextBox();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            lvDatos = new ListView();
            btnCalcular = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(43, 82);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(188, 23);
            txtEstudiante.TabIndex = 0;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(326, 82);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(35, 23);
            txtNota1.TabIndex = 1;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(379, 82);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(35, 23);
            txtNota2.TabIndex = 2;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(430, 82);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(35, 23);
            txtNota3.TabIndex = 3;
            // 
            // lvDatos
            // 
            lvDatos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvDatos.GridLines = true;
            lvDatos.Location = new Point(33, 162);
            lvDatos.Name = "lvDatos";
            lvDatos.Size = new Size(564, 185);
            lvDatos.TabIndex = 5;
            lvDatos.UseCompatibleStateImageBehavior = false;
            lvDatos.View = View.Details;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(484, 82);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Estudiante";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nota1";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nota2";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nota3";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Promedio";
            columnHeader5.Width = 100;
            // 
            // FrmPromedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lvDatos);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(txtEstudiante);
            Name = "FrmPromedio";
            Text = "FrmPromedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEstudiante;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private ListView lvDatos;
        private Button btnCalcular;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}