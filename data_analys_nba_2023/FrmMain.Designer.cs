namespace data_analys_nba_2023
{
    partial class FrmMain
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
            this.Cmb_Item_1 = new System.Windows.Forms.ComboBox();
            this.Cmb_Item_2 = new System.Windows.Forms.ComboBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Item_3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Pcb_Vteam = new System.Windows.Forms.PictureBox();
            this.Pcb_Hteam = new System.Windows.Forms.PictureBox();
            this.Lbl_Vteam_Name = new System.Windows.Forms.Label();
            this.Lbl_Hteam_Name = new System.Windows.Forms.Label();
            this.lbl_Vteam_Score = new System.Windows.Forms.Label();
            this.lbl_Hteam_Score = new System.Windows.Forms.Label();
            this.Btn_Show_Data = new System.Windows.Forms.Button();
            this.Txt_Gameid = new System.Windows.Forms.TextBox();
            this.Btn_Show_Games = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_SeasonYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Vteam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Hteam)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_Item_1
            // 
            this.Cmb_Item_1.FormattingEnabled = true;
            this.Cmb_Item_1.Location = new System.Drawing.Point(138, 24);
            this.Cmb_Item_1.Name = "Cmb_Item_1";
            this.Cmb_Item_1.Size = new System.Drawing.Size(121, 20);
            this.Cmb_Item_1.TabIndex = 2;
            this.Cmb_Item_1.TextChanged += new System.EventHandler(this.Cmb_Item_1_TextChanged);
            // 
            // Cmb_Item_2
            // 
            this.Cmb_Item_2.Enabled = false;
            this.Cmb_Item_2.FormattingEnabled = true;
            this.Cmb_Item_2.Location = new System.Drawing.Point(274, 24);
            this.Cmb_Item_2.Name = "Cmb_Item_2";
            this.Cmb_Item_2.Size = new System.Drawing.Size(121, 20);
            this.Cmb_Item_2.TabIndex = 3;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(562, 22);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 23);
            this.Btn_Search.TabIndex = 5;
            this.Btn_Search.Text = "GET JSON";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECT ITEMS";
            // 
            // Cmb_Item_3
            // 
            this.Cmb_Item_3.Enabled = false;
            this.Cmb_Item_3.FormattingEnabled = true;
            this.Cmb_Item_3.Location = new System.Drawing.Point(413, 24);
            this.Cmb_Item_3.Name = "Cmb_Item_3";
            this.Cmb_Item_3.Size = new System.Drawing.Size(121, 20);
            this.Cmb_Item_3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "GAMEID:";
            this.label2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 110);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(645, 434);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(881, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "VS";
            // 
            // Pcb_Vteam
            // 
            this.Pcb_Vteam.Location = new System.Drawing.Point(742, 263);
            this.Pcb_Vteam.Name = "Pcb_Vteam";
            this.Pcb_Vteam.Size = new System.Drawing.Size(100, 100);
            this.Pcb_Vteam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcb_Vteam.TabIndex = 7;
            this.Pcb_Vteam.TabStop = false;
            // 
            // Pcb_Hteam
            // 
            this.Pcb_Hteam.Location = new System.Drawing.Point(956, 263);
            this.Pcb_Hteam.Name = "Pcb_Hteam";
            this.Pcb_Hteam.Size = new System.Drawing.Size(100, 100);
            this.Pcb_Hteam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcb_Hteam.TabIndex = 7;
            this.Pcb_Hteam.TabStop = false;
            // 
            // Lbl_Vteam_Name
            // 
            this.Lbl_Vteam_Name.AutoSize = true;
            this.Lbl_Vteam_Name.Location = new System.Drawing.Point(752, 235);
            this.Lbl_Vteam_Name.Name = "Lbl_Vteam_Name";
            this.Lbl_Vteam_Name.Size = new System.Drawing.Size(39, 12);
            this.Lbl_Vteam_Name.TabIndex = 4;
            this.Lbl_Vteam_Name.Text = "vTeam";
            // 
            // Lbl_Hteam_Name
            // 
            this.Lbl_Hteam_Name.AutoSize = true;
            this.Lbl_Hteam_Name.Location = new System.Drawing.Point(967, 235);
            this.Lbl_Hteam_Name.Name = "Lbl_Hteam_Name";
            this.Lbl_Hteam_Name.Size = new System.Drawing.Size(39, 12);
            this.Lbl_Hteam_Name.TabIndex = 4;
            this.Lbl_Hteam_Name.Text = "hTeam";
            // 
            // lbl_Vteam_Score
            // 
            this.lbl_Vteam_Score.AutoSize = true;
            this.lbl_Vteam_Score.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Vteam_Score.Location = new System.Drawing.Point(760, 381);
            this.lbl_Vteam_Score.Name = "lbl_Vteam_Score";
            this.lbl_Vteam_Score.Size = new System.Drawing.Size(44, 48);
            this.lbl_Vteam_Score.TabIndex = 4;
            this.lbl_Vteam_Score.Text = "0";
            // 
            // lbl_Hteam_Score
            // 
            this.lbl_Hteam_Score.AutoSize = true;
            this.lbl_Hteam_Score.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Hteam_Score.Location = new System.Drawing.Point(973, 381);
            this.lbl_Hteam_Score.Name = "lbl_Hteam_Score";
            this.lbl_Hteam_Score.Size = new System.Drawing.Size(44, 48);
            this.lbl_Hteam_Score.TabIndex = 4;
            this.lbl_Hteam_Score.Text = "0";
            // 
            // Btn_Show_Data
            // 
            this.Btn_Show_Data.Location = new System.Drawing.Point(974, 71);
            this.Btn_Show_Data.Name = "Btn_Show_Data";
            this.Btn_Show_Data.Size = new System.Drawing.Size(88, 23);
            this.Btn_Show_Data.TabIndex = 5;
            this.Btn_Show_Data.Text = "SHOW DATA";
            this.Btn_Show_Data.UseVisualStyleBackColor = true;
            this.Btn_Show_Data.Visible = false;
            this.Btn_Show_Data.Click += new System.EventHandler(this.Btn_Show_Data_Click);
            // 
            // Txt_Gameid
            // 
            this.Txt_Gameid.Location = new System.Drawing.Point(895, 73);
            this.Txt_Gameid.Name = "Txt_Gameid";
            this.Txt_Gameid.Size = new System.Drawing.Size(63, 19);
            this.Txt_Gameid.TabIndex = 8;
            this.Txt_Gameid.Visible = false;
            // 
            // Btn_Show_Games
            // 
            this.Btn_Show_Games.Location = new System.Drawing.Point(236, 71);
            this.Btn_Show_Games.Name = "Btn_Show_Games";
            this.Btn_Show_Games.Size = new System.Drawing.Size(88, 23);
            this.Btn_Show_Games.TabIndex = 5;
            this.Btn_Show_Games.Text = "SHOW GAMES";
            this.Btn_Show_Games.UseVisualStyleBackColor = true;
            this.Btn_Show_Games.Click += new System.EventHandler(this.Btn_Show_Games_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "seasonYear";
            // 
            // Cmb_SeasonYear
            // 
            this.Cmb_SeasonYear.FormattingEnabled = true;
            this.Cmb_SeasonYear.Location = new System.Drawing.Point(138, 73);
            this.Cmb_SeasonYear.Name = "Cmb_SeasonYear";
            this.Cmb_SeasonYear.Size = new System.Drawing.Size(72, 20);
            this.Cmb_SeasonYear.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 623);
            this.Controls.Add(this.Txt_Gameid);
            this.Controls.Add(this.Pcb_Hteam);
            this.Controls.Add(this.Pcb_Vteam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Show_Games);
            this.Controls.Add(this.Btn_Show_Data);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Hteam_Name);
            this.Controls.Add(this.lbl_Hteam_Score);
            this.Controls.Add(this.lbl_Vteam_Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_Vteam_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_Item_3);
            this.Controls.Add(this.Cmb_SeasonYear);
            this.Controls.Add(this.Cmb_Item_2);
            this.Controls.Add(this.Cmb_Item_1);
            this.Name = "FrmMain";
            this.Text = "NBAデータ表示画面";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Vteam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Hteam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Cmb_Item_1;
        private System.Windows.Forms.ComboBox Cmb_Item_2;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Item_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Pcb_Vteam;
        private System.Windows.Forms.PictureBox Pcb_Hteam;
        private System.Windows.Forms.Label Lbl_Vteam_Name;
        private System.Windows.Forms.Label Lbl_Hteam_Name;
        private System.Windows.Forms.Label lbl_Vteam_Score;
        private System.Windows.Forms.Label lbl_Hteam_Score;
        private System.Windows.Forms.Button Btn_Show_Data;
        private System.Windows.Forms.TextBox Txt_Gameid;
        private System.Windows.Forms.Button Btn_Show_Games;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_SeasonYear;
    }
}