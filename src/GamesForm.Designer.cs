namespace Connect4
{
    partial class GamesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamesForm));
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEJUCATOR1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEJUCATOR2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTIGATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesDBDataSet = new Connect4.GamesDBDataSet();
            this.gamesTableAdapter = new Connect4.GamesDBDataSetTableAdapters.GamesTableAdapter();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGames
            // 
            this.dgvGames.AutoGenerateColumns = false;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nUMEJUCATOR1DataGridViewTextBoxColumn,
            this.nUMEJUCATOR2DataGridViewTextBoxColumn,
            this.cASTIGATORDataGridViewTextBoxColumn});
            this.dgvGames.DataSource = this.gamesBindingSource;
            this.dgvGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvGames.Location = new System.Drawing.Point(0, 0);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.RowHeadersWidth = 51;
            this.dgvGames.RowTemplate.Height = 24;
            this.dgvGames.Size = new System.Drawing.Size(710, 345);
            this.dgvGames.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nUMEJUCATOR1DataGridViewTextBoxColumn
            // 
            this.nUMEJUCATOR1DataGridViewTextBoxColumn.DataPropertyName = "NUME_JUCATOR1";
            this.nUMEJUCATOR1DataGridViewTextBoxColumn.HeaderText = "JUCATOR1";
            this.nUMEJUCATOR1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMEJUCATOR1DataGridViewTextBoxColumn.Name = "nUMEJUCATOR1DataGridViewTextBoxColumn";
            this.nUMEJUCATOR1DataGridViewTextBoxColumn.Width = 125;
            // 
            // nUMEJUCATOR2DataGridViewTextBoxColumn
            // 
            this.nUMEJUCATOR2DataGridViewTextBoxColumn.DataPropertyName = "NUME_JUCATOR2";
            this.nUMEJUCATOR2DataGridViewTextBoxColumn.HeaderText = "JUCATOR2";
            this.nUMEJUCATOR2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMEJUCATOR2DataGridViewTextBoxColumn.Name = "nUMEJUCATOR2DataGridViewTextBoxColumn";
            this.nUMEJUCATOR2DataGridViewTextBoxColumn.Width = 125;
            // 
            // cASTIGATORDataGridViewTextBoxColumn
            // 
            this.cASTIGATORDataGridViewTextBoxColumn.DataPropertyName = "CASTIGATOR";
            this.cASTIGATORDataGridViewTextBoxColumn.HeaderText = "CASTIGATOR";
            this.cASTIGATORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cASTIGATORDataGridViewTextBoxColumn.Name = "cASTIGATORDataGridViewTextBoxColumn";
            this.cASTIGATORDataGridViewTextBoxColumn.Width = 125;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.gamesDBDataSet;
            // 
            // gamesDBDataSet
            // 
            this.gamesDBDataSet.DataSetName = "GamesDBDataSet";
            this.gamesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBackToMenu.ForeColor = System.Drawing.Color.Black;
            this.btnBackToMenu.Location = new System.Drawing.Point(251, 351);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(197, 53);
            this.btnBackToMenu.TabIndex = 8;
            this.btnBackToMenu.Text = "Înapoi la meniu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 415);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.dgvGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GamesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamesForm";
            this.Load += new System.EventHandler(this.GamesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGames;
        private GamesDBDataSet gamesDBDataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private GamesDBDataSetTableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEJUCATOR1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEJUCATOR2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTIGATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}