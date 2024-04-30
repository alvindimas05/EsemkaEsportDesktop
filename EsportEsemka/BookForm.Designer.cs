namespace EsportEsemka
{
    partial class BookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerbyteamidHomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetHome = new EsportEsemka.databaseDataSet();
            this.playerByTeamIdTableAdapter = new EsportEsemka.databaseDataSetTableAdapters.playerByTeamIdTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerbyteamidAwayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetAway = new EsportEsemka.databaseDataSet();
            this.labelTeamHome = new System.Windows.Forms.Label();
            this.labelTeamAway = new System.Windows.Forms.Label();
            this.labelCompanyHome = new System.Windows.Forms.Label();
            this.labelCompanyAway = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBookTickets = new System.Windows.Forms.TextBox();
            this.buttonBook = new System.Windows.Forms.Button();
            this.labelRemainingTickets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerbyteamidHomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerbyteamidAwayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetAway)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nicknameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerbyteamidHomeBindingSource;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(209, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "nick_name";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            this.nicknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nicknameDataGridViewTextBoxColumn.Width = 206;
            // 
            // playerbyteamidHomeBindingSource
            // 
            this.playerbyteamidHomeBindingSource.DataMember = "player_by_team_id";
            this.playerbyteamidHomeBindingSource.DataSource = this.databaseDataSetHome;
            // 
            // databaseDataSetHome
            // 
            this.databaseDataSetHome.DataSetName = "databaseDataSet";
            this.databaseDataSetHome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerByTeamIdTableAdapter
            // 
            this.playerByTeamIdTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.playerbyteamidAwayBindingSource;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(349, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.Size = new System.Drawing.Size(209, 280);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nick_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 206;
            // 
            // playerbyteamidAwayBindingSource
            // 
            this.playerbyteamidAwayBindingSource.DataMember = "player_by_team_id";
            this.playerbyteamidAwayBindingSource.DataSource = this.databaseDataSetAway;
            // 
            // databaseDataSetAway
            // 
            this.databaseDataSetAway.DataSetName = "databaseDataSet";
            this.databaseDataSetAway.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelTeamHome
            // 
            this.labelTeamHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamHome.ForeColor = System.Drawing.Color.White;
            this.labelTeamHome.Location = new System.Drawing.Point(54, 20);
            this.labelTeamHome.Name = "labelTeamHome";
            this.labelTeamHome.Size = new System.Drawing.Size(125, 24);
            this.labelTeamHome.TabIndex = 2;
            this.labelTeamHome.Text = "Team Home";
            this.labelTeamHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTeamAway
            // 
            this.labelTeamAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamAway.ForeColor = System.Drawing.Color.White;
            this.labelTeamAway.Location = new System.Drawing.Point(391, 20);
            this.labelTeamAway.Name = "labelTeamAway";
            this.labelTeamAway.Size = new System.Drawing.Size(119, 24);
            this.labelTeamAway.TabIndex = 3;
            this.labelTeamAway.Text = "Team Away";
            this.labelTeamAway.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCompanyHome
            // 
            this.labelCompanyHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyHome.ForeColor = System.Drawing.Color.White;
            this.labelCompanyHome.Location = new System.Drawing.Point(70, 44);
            this.labelCompanyHome.Name = "labelCompanyHome";
            this.labelCompanyHome.Size = new System.Drawing.Size(96, 15);
            this.labelCompanyHome.TabIndex = 4;
            this.labelCompanyHome.Text = "Company Home";
            this.labelCompanyHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCompanyAway
            // 
            this.labelCompanyAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyAway.ForeColor = System.Drawing.Color.White;
            this.labelCompanyAway.Location = new System.Drawing.Point(406, 44);
            this.labelCompanyAway.Name = "labelCompanyAway";
            this.labelCompanyAway.Size = new System.Drawing.Size(90, 15);
            this.labelCompanyAway.TabIndex = 5;
            this.labelCompanyAway.Text = "Company Away";
            this.labelCompanyAway.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Book Tickets";
            // 
            // textBoxBookTickets
            // 
            this.textBoxBookTickets.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxBookTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBookTickets.ForeColor = System.Drawing.Color.White;
            this.textBoxBookTickets.Location = new System.Drawing.Point(124, 395);
            this.textBoxBookTickets.Name = "textBoxBookTickets";
            this.textBoxBookTickets.Size = new System.Drawing.Size(97, 20);
            this.textBoxBookTickets.TabIndex = 7;
            this.textBoxBookTickets.Text = "1";
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonBook.FlatAppearance.BorderSize = 0;
            this.buttonBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBook.ForeColor = System.Drawing.Color.White;
            this.buttonBook.Location = new System.Drawing.Point(227, 393);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(75, 22);
            this.buttonBook.TabIndex = 8;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = false;
            // 
            // labelRemainingTickets
            // 
            this.labelRemainingTickets.AutoSize = true;
            this.labelRemainingTickets.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelRemainingTickets.Location = new System.Drawing.Point(433, 402);
            this.labelRemainingTickets.Name = "labelRemainingTickets";
            this.labelRemainingTickets.Size = new System.Drawing.Size(116, 13);
            this.labelRemainingTickets.TabIndex = 9;
            this.labelRemainingTickets.Text = "Remaining : 0 Ticket(s)";
            this.labelRemainingTickets.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(570, 427);
            this.Controls.Add(this.labelRemainingTickets);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.textBoxBookTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCompanyAway);
            this.Controls.Add(this.labelCompanyHome);
            this.Controls.Add(this.labelTeamAway);
            this.Controls.Add(this.labelTeamHome);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerbyteamidHomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerbyteamidAwayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetAway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource playerbyteamidHomeBindingSource;
        private databaseDataSet databaseDataSetHome;
        private databaseDataSetTableAdapters.playerByTeamIdTableAdapter playerByTeamIdTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource playerbyteamidAwayBindingSource;
        private databaseDataSet databaseDataSetAway;
        private System.Windows.Forms.Label labelTeamHome;
        private System.Windows.Forms.Label labelTeamAway;
        private System.Windows.Forms.Label labelCompanyHome;
        private System.Windows.Forms.Label labelCompanyAway;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBookTickets;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Label labelRemainingTickets;
    }
}