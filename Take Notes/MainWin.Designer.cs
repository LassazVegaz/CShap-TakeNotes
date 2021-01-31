namespace Take_Notes
{
    partial class MainWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing )
            {
                if ( components != null )
                    components.Dispose();
                if ( dataStore != null )
                    dataStore.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.CTitle_TXT = new System.Windows.Forms.TextBox();
            this.CDescription_TXT = new System.Windows.Forms.TextBox();
            this.CDataView_DGVIEW = new System.Windows.Forms.DataGridView();
            this.CSave_BTN = new System.Windows.Forms.Button();
            this.CRead_BTN = new System.Windows.Forms.Button();
            this.CDelete_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CDataView_DGVIEW)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CTitle_TXT
            // 
            this.CTitle_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CTitle_TXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CTitle_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CTitle_TXT.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTitle_TXT.Location = new System.Drawing.Point(12, 39);
            this.CTitle_TXT.Name = "CTitle_TXT";
            this.CTitle_TXT.Size = new System.Drawing.Size(350, 24);
            this.CTitle_TXT.TabIndex = 0;
            // 
            // CDescription_TXT
            // 
            this.CDescription_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CDescription_TXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CDescription_TXT.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDescription_TXT.Location = new System.Drawing.Point(15, 112);
            this.CDescription_TXT.Multiline = true;
            this.CDescription_TXT.Name = "CDescription_TXT";
            this.CDescription_TXT.Size = new System.Drawing.Size(350, 264);
            this.CDescription_TXT.TabIndex = 1;
            // 
            // CDataView_DGVIEW
            // 
            this.CDataView_DGVIEW.AllowUserToAddRows = false;
            this.CDataView_DGVIEW.AllowUserToDeleteRows = false;
            this.CDataView_DGVIEW.AllowUserToOrderColumns = true;
            this.CDataView_DGVIEW.AllowUserToResizeColumns = false;
            this.CDataView_DGVIEW.AllowUserToResizeRows = false;
            this.CDataView_DGVIEW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CDataView_DGVIEW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CDataView_DGVIEW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CDataView_DGVIEW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CDataView_DGVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CDataView_DGVIEW.DefaultCellStyle = dataGridViewCellStyle2;
            this.CDataView_DGVIEW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CDataView_DGVIEW.Location = new System.Drawing.Point(422, 22);
            this.CDataView_DGVIEW.MultiSelect = false;
            this.CDataView_DGVIEW.Name = "CDataView_DGVIEW";
            this.CDataView_DGVIEW.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CDataView_DGVIEW.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CDataView_DGVIEW.RowHeadersVisible = false;
            this.CDataView_DGVIEW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CDataView_DGVIEW.Size = new System.Drawing.Size(350, 354);
            this.CDataView_DGVIEW.TabIndex = 2;
            // 
            // CSave_BTN
            // 
            this.CSave_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CSave_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.CSave_BTN.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.CSave_BTN.FlatAppearance.BorderSize = 0;
            this.CSave_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CSave_BTN.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSave_BTN.Location = new System.Drawing.Point(0, 0);
            this.CSave_BTN.Name = "CSave_BTN";
            this.CSave_BTN.Size = new System.Drawing.Size(100, 51);
            this.CSave_BTN.TabIndex = 0;
            this.CSave_BTN.Text = "SAVE";
            this.CSave_BTN.UseVisualStyleBackColor = false;
            this.CSave_BTN.Click += new System.EventHandler(this.CSave_BTN_Click);
            // 
            // CRead_BTN
            // 
            this.CRead_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CRead_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRead_BTN.FlatAppearance.BorderSize = 0;
            this.CRead_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CRead_BTN.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRead_BTN.Location = new System.Drawing.Point(100, 0);
            this.CRead_BTN.Name = "CRead_BTN";
            this.CRead_BTN.Size = new System.Drawing.Size(584, 51);
            this.CRead_BTN.TabIndex = 1;
            this.CRead_BTN.Text = "READ";
            this.CRead_BTN.UseVisualStyleBackColor = false;
            this.CRead_BTN.Click += new System.EventHandler(this.CRead_BTN_Click);
            // 
            // CDelete_BTN
            // 
            this.CDelete_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CDelete_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CDelete_BTN.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CDelete_BTN.FlatAppearance.BorderSize = 0;
            this.CDelete_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CDelete_BTN.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDelete_BTN.Location = new System.Drawing.Point(684, 0);
            this.CDelete_BTN.Name = "CDelete_BTN";
            this.CDelete_BTN.Size = new System.Drawing.Size(100, 51);
            this.CDelete_BTN.TabIndex = 2;
            this.CDelete_BTN.Text = "DELETE";
            this.CDelete_BTN.UseVisualStyleBackColor = false;
            this.CDelete_BTN.Click += new System.EventHandler(this.CDelete_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CRead_BTN);
            this.panel1.Controls.Add(this.CSave_BTN);
            this.panel1.Controls.Add(this.CDelete_BTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 51);
            this.panel1.TabIndex = 8;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CDataView_DGVIEW);
            this.Controls.Add(this.CDescription_TXT);
            this.Controls.Add(this.CTitle_TXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 430);
            this.Name = "MainWin";
            this.Text = "Take Notes";
            ((System.ComponentModel.ISupportInitialize)(this.CDataView_DGVIEW)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CTitle_TXT;
        private System.Windows.Forms.TextBox CDescription_TXT;
        private System.Windows.Forms.DataGridView CDataView_DGVIEW;
        private System.Windows.Forms.Button CSave_BTN;
        private System.Windows.Forms.Button CRead_BTN;
        private System.Windows.Forms.Button CDelete_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

