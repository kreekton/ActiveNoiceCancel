namespace Tubitak_Active_Noice_Control
{
    partial class Form1
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
            this.listSesler = new System.Windows.Forms.ListBox();
            this.listSesCal = new System.Windows.Forms.ListBox();
            this.btnSesEkle = new System.Windows.Forms.Button();
            this.txtFrekans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSesTersEkle = new System.Windows.Forms.Button();
            this.btnSesMove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPlayList = new System.Windows.Forms.Button();
            this.btnRemoveSelect = new System.Windows.Forms.Button();
            this.btnPlaySelectSound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSesler
            // 
            this.listSesler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.listSesler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(212)))));
            this.listSesler.FormattingEnabled = true;
            this.listSesler.ItemHeight = 20;
            this.listSesler.Location = new System.Drawing.Point(18, 46);
            this.listSesler.Margin = new System.Windows.Forms.Padding(4);
            this.listSesler.Name = "listSesler";
            this.listSesler.Size = new System.Drawing.Size(373, 364);
            this.listSesler.TabIndex = 0;
            // 
            // listSesCal
            // 
            this.listSesCal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listSesCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.listSesCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(212)))));
            this.listSesCal.FormattingEnabled = true;
            this.listSesCal.ItemHeight = 20;
            this.listSesCal.Location = new System.Drawing.Point(402, 46);
            this.listSesCal.Margin = new System.Windows.Forms.Padding(4);
            this.listSesCal.Name = "listSesCal";
            this.listSesCal.Size = new System.Drawing.Size(373, 364);
            this.listSesCal.TabIndex = 1;
            // 
            // btnSesEkle
            // 
            this.btnSesEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesEkle.Location = new System.Drawing.Point(276, 420);
            this.btnSesEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSesEkle.Name = "btnSesEkle";
            this.btnSesEkle.Size = new System.Drawing.Size(115, 34);
            this.btnSesEkle.TabIndex = 2;
            this.btnSesEkle.Text = "Ekle";
            this.btnSesEkle.UseVisualStyleBackColor = true;
            this.btnSesEkle.Click += new System.EventHandler(this.btnSesEkle_Click);
            // 
            // txtFrekans
            // 
            this.txtFrekans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.txtFrekans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFrekans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(212)))));
            this.txtFrekans.Location = new System.Drawing.Point(95, 427);
            this.txtFrekans.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrekans.Name = "txtFrekans";
            this.txtFrekans.Size = new System.Drawing.Size(167, 19);
            this.txtFrekans.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 427);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Frekans: ";
            // 
            // btnSesTersEkle
            // 
            this.btnSesTersEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesTersEkle.Location = new System.Drawing.Point(18, 462);
            this.btnSesTersEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSesTersEkle.Name = "btnSesTersEkle";
            this.btnSesTersEkle.Size = new System.Drawing.Size(373, 34);
            this.btnSesTersEkle.TabIndex = 5;
            this.btnSesTersEkle.Text = "Seçilen sesin tersini üret ve ekle";
            this.btnSesTersEkle.UseVisualStyleBackColor = true;
            this.btnSesTersEkle.Click += new System.EventHandler(this.btnSesTersEkle_Click);
            // 
            // btnSesMove
            // 
            this.btnSesMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesMove.Location = new System.Drawing.Point(18, 504);
            this.btnSesMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnSesMove.Name = "btnSesMove";
            this.btnSesMove.Size = new System.Drawing.Size(373, 34);
            this.btnSesMove.TabIndex = 6;
            this.btnSesMove.Text = "Seçilen sesi çalma listesine ekle";
            this.btnSesMove.UseVisualStyleBackColor = true;
            this.btnSesMove.Click += new System.EventHandler(this.btnSesMove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sesler:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Çalma listesi:";
            // 
            // BtnPlayList
            // 
            this.BtnPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayList.Location = new System.Drawing.Point(402, 421);
            this.BtnPlayList.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayList.Name = "BtnPlayList";
            this.BtnPlayList.Size = new System.Drawing.Size(373, 34);
            this.BtnPlayList.TabIndex = 9;
            this.BtnPlayList.Text = "Seçili sesi tersi ile çal";
            this.BtnPlayList.UseVisualStyleBackColor = true;
            this.BtnPlayList.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRemoveSelect
            // 
            this.btnRemoveSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelect.Location = new System.Drawing.Point(402, 504);
            this.btnRemoveSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveSelect.Name = "btnRemoveSelect";
            this.btnRemoveSelect.Size = new System.Drawing.Size(373, 34);
            this.btnRemoveSelect.TabIndex = 10;
            this.btnRemoveSelect.Text = "Seçilen sesi çalma listesinden çıkar";
            this.btnRemoveSelect.UseVisualStyleBackColor = true;
            this.btnRemoveSelect.Click += new System.EventHandler(this.btnRemoveSelect_Click);
            // 
            // btnPlaySelectSound
            // 
            this.btnPlaySelectSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaySelectSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaySelectSound.Location = new System.Drawing.Point(402, 462);
            this.btnPlaySelectSound.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaySelectSound.Name = "btnPlaySelectSound";
            this.btnPlaySelectSound.Size = new System.Drawing.Size(373, 34);
            this.btnPlaySelectSound.TabIndex = 11;
            this.btnPlaySelectSound.Text = "Seçili Sesi Çal";
            this.btnPlaySelectSound.UseVisualStyleBackColor = true;
            this.btnPlaySelectSound.Click += new System.EventHandler(this.btnPlaySelectSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(793, 668);
            this.Controls.Add(this.btnPlaySelectSound);
            this.Controls.Add(this.btnRemoveSelect);
            this.Controls.Add(this.BtnPlayList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSesMove);
            this.Controls.Add(this.btnSesTersEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrekans);
            this.Controls.Add(this.btnSesEkle);
            this.Controls.Add(this.listSesCal);
            this.Controls.Add(this.listSesler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(212)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Tubitak Active Noice Control Projesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSesler;
        private System.Windows.Forms.ListBox listSesCal;
        private System.Windows.Forms.Button btnSesEkle;
        private System.Windows.Forms.TextBox txtFrekans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSesTersEkle;
        private System.Windows.Forms.Button btnSesMove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPlayList;
        private System.Windows.Forms.Button btnRemoveSelect;
        private System.Windows.Forms.Button btnPlaySelectSound;
    }
}

