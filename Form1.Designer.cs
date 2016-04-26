namespace TestODBC
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButLaunch = new System.Windows.Forms.Button();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkListDNS = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GridResultat = new System.Windows.Forms.DataGridView();
            this.dNSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeQueryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textErrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryErrorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridResultat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryErrorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButLaunch
            // 
            this.ButLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButLaunch.Location = new System.Drawing.Point(19, 168);
            this.ButLaunch.Name = "ButLaunch";
            this.ButLaunch.Size = new System.Drawing.Size(207, 53);
            this.ButLaunch.TabIndex = 0;
            this.ButLaunch.Text = "Launch Test";
            this.ButLaunch.UseVisualStyleBackColor = true;
            this.ButLaunch.Click += new System.EventHandler(this.butLaunch_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomain.Location = new System.Drawing.Point(92, 38);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(134, 22);
            this.txtDomain.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(92, 81);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(134, 22);
            this.txtUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Domain:";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(92, 125);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(134, 22);
            this.txtPwd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // chkListDNS
            // 
            this.chkListDNS.FormattingEnabled = true;
            this.chkListDNS.Location = new System.Drawing.Point(19, 284);
            this.chkListDNS.Name = "chkListDNS";
            this.chkListDNS.Size = new System.Drawing.Size(207, 184);
            this.chkListDNS.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ODBC Sources to be Tested:";
            // 
            // GridResultat
            // 
            this.GridResultat.AllowDrop = true;
            this.GridResultat.AutoGenerateColumns = false;
            this.GridResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResultat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNSDataGridViewTextBoxColumn,
            this.zeQueryDataGridViewTextBoxColumn,
            this.textErrorDataGridViewTextBoxColumn});
            this.GridResultat.DataSource = this.queryErrorBindingSource;
            this.GridResultat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridResultat.Location = new System.Drawing.Point(252, 81);
            this.GridResultat.Name = "GridResultat";
            this.GridResultat.Size = new System.Drawing.Size(514, 383);
            this.GridResultat.TabIndex = 9;
            this.GridResultat.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridResultat_CellFormatting);
            // 
            // dNSDataGridViewTextBoxColumn
            // 
            this.dNSDataGridViewTextBoxColumn.DataPropertyName = "DNS";
            this.dNSDataGridViewTextBoxColumn.HeaderText = "DNS";
            this.dNSDataGridViewTextBoxColumn.Name = "dNSDataGridViewTextBoxColumn";
            // 
            // zeQueryDataGridViewTextBoxColumn
            // 
            this.zeQueryDataGridViewTextBoxColumn.DataPropertyName = "zeQuery";
            this.zeQueryDataGridViewTextBoxColumn.HeaderText = "zeQuery";
            this.zeQueryDataGridViewTextBoxColumn.Name = "zeQueryDataGridViewTextBoxColumn";
            // 
            // textErrorDataGridViewTextBoxColumn
            // 
            this.textErrorDataGridViewTextBoxColumn.DataPropertyName = "TextError";
            this.textErrorDataGridViewTextBoxColumn.HeaderText = "TextError";
            this.textErrorDataGridViewTextBoxColumn.Name = "textErrorDataGridViewTextBoxColumn";
            this.textErrorDataGridViewTextBoxColumn.Width = 250;
            // 
            // queryErrorBindingSource
            // 
            this.queryErrorBindingSource.DataSource = typeof(TestODBC.QueryError);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 496);
            this.Controls.Add(this.GridResultat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkListDNS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.ButLaunch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridResultat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryErrorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButLaunch;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chkListDNS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridResultat;
        private System.Windows.Forms.BindingSource queryErrorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeQueryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textErrorDataGridViewTextBoxColumn;
    }
}

