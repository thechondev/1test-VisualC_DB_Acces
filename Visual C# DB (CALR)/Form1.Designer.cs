namespace Visual_C__DB__CALR_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdAgregarPro = new System.Windows.Forms.Button();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecioPro = new System.Windows.Forms.TextBox();
            this.lblVentasPro = new System.Windows.Forms.Label();
            this.txtUnidadesVen = new System.Windows.Forms.TextBox();
            this.cmdEditarpro = new System.Windows.Forms.Button();
            this.cmdEliminarpro = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.productos_y_VentasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productos_y_VentasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dtgProVen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productos_y_VentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productos_y_VentasDataSet = new Visual_C__DB__CALR_.Productos_y_VentasDataSet();
            this.productos_y_VentasTableAdapter = new Visual_C__DB__CALR_.Productos_y_VentasDataSetTableAdapters.Productos_y_VentasTableAdapter();
            this.tableAdapterManager = new Visual_C__DB__CALR_.Productos_y_VentasDataSetTableAdapters.TableAdapterManager();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productos_y_VentasBindingNavigator)).BeginInit();
            this.productos_y_VentasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProVen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos_y_VentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos_y_VentasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAgregarPro
            // 
            this.cmdAgregarPro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregarPro.Location = new System.Drawing.Point(503, 242);
            this.cmdAgregarPro.Name = "cmdAgregarPro";
            this.cmdAgregarPro.Size = new System.Drawing.Size(116, 50);
            this.cmdAgregarPro.TabIndex = 0;
            this.cmdAgregarPro.Text = "Agregar Producto";
            this.cmdAgregarPro.UseVisualStyleBackColor = true;
            this.cmdAgregarPro.Click += new System.EventHandler(this.cmdAgregarPro_Click);
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePro.Location = new System.Drawing.Point(186, 211);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(281, 26);
            this.txtNombrePro.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 214);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(154, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre del producto";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Navy;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(455, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(248, 33);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Registro Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 258);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(144, 18);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio del producto";
            // 
            // txtPrecioPro
            // 
            this.txtPrecioPro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPro.Location = new System.Drawing.Point(186, 255);
            this.txtPrecioPro.Name = "txtPrecioPro";
            this.txtPrecioPro.Size = new System.Drawing.Size(281, 26);
            this.txtPrecioPro.TabIndex = 6;
            this.txtPrecioPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioPro_KeyPress);
            // 
            // lblVentasPro
            // 
            this.lblVentasPro.AutoSize = true;
            this.lblVentasPro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasPro.Location = new System.Drawing.Point(12, 302);
            this.lblVentasPro.Name = "lblVentasPro";
            this.lblVentasPro.Size = new System.Drawing.Size(142, 18);
            this.lblVentasPro.TabIndex = 9;
            this.lblVentasPro.Text = "Unidades vendidas";
            // 
            // txtUnidadesVen
            // 
            this.txtUnidadesVen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadesVen.Location = new System.Drawing.Point(186, 299);
            this.txtUnidadesVen.Name = "txtUnidadesVen";
            this.txtUnidadesVen.Size = new System.Drawing.Size(281, 26);
            this.txtUnidadesVen.TabIndex = 8;
            this.txtUnidadesVen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidadesVen_KeyPress);
            // 
            // cmdEditarpro
            // 
            this.cmdEditarpro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditarpro.Location = new System.Drawing.Point(186, 363);
            this.cmdEditarpro.Name = "cmdEditarpro";
            this.cmdEditarpro.Size = new System.Drawing.Size(116, 50);
            this.cmdEditarpro.TabIndex = 10;
            this.cmdEditarpro.Text = "Guardar Cambios";
            this.cmdEditarpro.UseVisualStyleBackColor = true;
            this.cmdEditarpro.Click += new System.EventHandler(this.cmdEditarpro_Click);
            // 
            // cmdEliminarpro
            // 
            this.cmdEliminarpro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarpro.Location = new System.Drawing.Point(351, 363);
            this.cmdEliminarpro.Name = "cmdEliminarpro";
            this.cmdEliminarpro.Size = new System.Drawing.Size(116, 50);
            this.cmdEliminarpro.TabIndex = 13;
            this.cmdEliminarpro.Text = "Eliminar Producto";
            this.cmdEliminarpro.UseVisualStyleBackColor = true;
            this.cmdEliminarpro.Click += new System.EventHandler(this.cmdEliminarpro_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Navy;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1206, 100);
            this.pnlTitulo.TabIndex = 15;
            // 
            // productos_y_VentasBindingNavigator
            // 
            this.productos_y_VentasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productos_y_VentasBindingNavigator.BindingSource = this.productos_y_VentasBindingSource;
            this.productos_y_VentasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productos_y_VentasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productos_y_VentasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.productos_y_VentasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productos_y_VentasBindingNavigatorSaveItem});
            this.productos_y_VentasBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.productos_y_VentasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productos_y_VentasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productos_y_VentasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productos_y_VentasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productos_y_VentasBindingNavigator.Name = "productos_y_VentasBindingNavigator";
            this.productos_y_VentasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productos_y_VentasBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.productos_y_VentasBindingNavigator.TabIndex = 16;
            this.productos_y_VentasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productos_y_VentasBindingNavigatorSaveItem
            // 
            this.productos_y_VentasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productos_y_VentasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productos_y_VentasBindingNavigatorSaveItem.Image")));
            this.productos_y_VentasBindingNavigatorSaveItem.Name = "productos_y_VentasBindingNavigatorSaveItem";
            this.productos_y_VentasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productos_y_VentasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.productos_y_VentasBindingNavigatorSaveItem.Click += new System.EventHandler(this.productos_y_VentasBindingNavigatorSaveItem_Click_1);
            // 
            // dtgProVen
            // 
            this.dtgProVen.AutoGenerateColumns = false;
            this.dtgProVen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProVen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtgProVen.DataSource = this.productos_y_VentasBindingSource;
            this.dtgProVen.Location = new System.Drawing.Point(649, 142);
            this.dtgProVen.Name = "dtgProVen";
            this.dtgProVen.Size = new System.Drawing.Size(465, 359);
            this.dtgProVen.TabIndex = 16;
            this.dtgProVen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productos_y_VentasDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ventas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ventas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ventas totales";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ventas totales";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // productos_y_VentasBindingSource
            // 
            this.productos_y_VentasBindingSource.DataMember = "Productos y Ventas";
            this.productos_y_VentasBindingSource.DataSource = this.productos_y_VentasDataSet;
            // 
            // productos_y_VentasDataSet
            // 
            this.productos_y_VentasDataSet.DataSetName = "Productos_y_VentasDataSet";
            this.productos_y_VentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productos_y_VentasTableAdapter
            // 
            this.productos_y_VentasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Productos_y_VentasTableAdapter = this.productos_y_VentasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Visual_C__DB__CALR_.Productos_y_VentasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 539);
            this.Controls.Add(this.dtgProVen);
            this.Controls.Add(this.productos_y_VentasBindingNavigator);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.cmdEliminarpro);
            this.Controls.Add(this.lblVentasPro);
            this.Controls.Add(this.txtUnidadesVen);
            this.Controls.Add(this.cmdEditarpro);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecioPro);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombrePro);
            this.Controls.Add(this.cmdAgregarPro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productos_y_VentasBindingNavigator)).EndInit();
            this.productos_y_VentasBindingNavigator.ResumeLayout(false);
            this.productos_y_VentasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProVen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos_y_VentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos_y_VentasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAgregarPro;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecioPro;
        private System.Windows.Forms.Label lblVentasPro;
        private System.Windows.Forms.TextBox txtUnidadesVen;
        private System.Windows.Forms.Button cmdEditarpro;
        private System.Windows.Forms.Button cmdEliminarpro;
        private System.Windows.Forms.Button cmdVerTabla;
        private System.Windows.Forms.Panel pnlTitulo;
        private Productos_y_VentasDataSet productos_y_VentasDataSet;
        private System.Windows.Forms.BindingSource productos_y_VentasBindingSource;
        private Productos_y_VentasDataSetTableAdapters.Productos_y_VentasTableAdapter productos_y_VentasTableAdapter;
        private Productos_y_VentasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productos_y_VentasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productos_y_VentasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dtgProVen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

