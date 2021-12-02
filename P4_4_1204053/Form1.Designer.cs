namespace P4_4_1204053
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNik = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.cbJk = new System.Windows.Forms.ComboBox();
            this.txtNIK = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lbJK = new System.Windows.Forms.Label();
            this.lbUsia = new System.Windows.Forms.Label();
            this.txtUsia = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lbNo = new System.Windows.Forms.Label();
            this.lbAlamat = new System.Windows.Forms.Label();
            this.btDaftar = new System.Windows.Forms.Button();
            this.btTutup = new System.Windows.Forms.Button();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(111, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pendaftaran Vaksinasi Covid-19 bagi Usia 10 tahun Keatas";
            // 
            // lbNik
            // 
            this.lbNik.AutoSize = true;
            this.lbNik.Location = new System.Drawing.Point(98, 133);
            this.lbNik.Name = "lbNik";
            this.lbNik.Size = new System.Drawing.Size(191, 20);
            this.lbNik.TabIndex = 1;
            this.lbNik.Text = "NIK                                      :";
            this.lbNik.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(98, 186);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(189, 20);
            this.lbNama.TabIndex = 2;
            this.lbNama.Text = "Nama Lengkap                 :";
            // 
            // cbJk
            // 
            this.cbJk.FormattingEnabled = true;
            this.cbJk.Items.AddRange(new object[] {
            "Wanita",
            "Pria"});
            this.cbJk.Location = new System.Drawing.Point(313, 237);
            this.cbJk.Name = "cbJk";
            this.cbJk.Size = new System.Drawing.Size(305, 28);
            this.cbJk.TabIndex = 3;
            this.cbJk.Leave += new System.EventHandler(this.cbJk_Leave);
            // 
            // txtNIK
            // 
            this.txtNIK.Location = new System.Drawing.Point(313, 134);
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Size = new System.Drawing.Size(305, 26);
            this.txtNIK.TabIndex = 4;
            this.txtNIK.Leave += new System.EventHandler(this.txtNIK_Leave);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(313, 186);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(305, 26);
            this.txtNama.TabIndex = 5;
            this.txtNama.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // lbJK
            // 
            this.lbJK.AutoSize = true;
            this.lbJK.Location = new System.Drawing.Point(98, 240);
            this.lbJK.Name = "lbJK";
            this.lbJK.Size = new System.Drawing.Size(190, 20);
            this.lbJK.TabIndex = 6;
            this.lbJK.Text = "Jenis Kelamin                    :";
            this.lbJK.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbUsia
            // 
            this.lbUsia.AutoSize = true;
            this.lbUsia.Location = new System.Drawing.Point(98, 310);
            this.lbUsia.Name = "lbUsia";
            this.lbUsia.Size = new System.Drawing.Size(185, 20);
            this.lbUsia.TabIndex = 7;
            this.lbUsia.Text = "Usia                                   :";
            // 
            // txtUsia
            // 
            this.txtUsia.Location = new System.Drawing.Point(313, 310);
            this.txtUsia.Name = "txtUsia";
            this.txtUsia.Size = new System.Drawing.Size(305, 26);
            this.txtUsia.TabIndex = 8;
            this.txtUsia.Leave += new System.EventHandler(this.txtUsia_Leave);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(313, 366);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(305, 26);
            this.txtNo.TabIndex = 9;
            this.txtNo.Leave += new System.EventHandler(this.txtNo_Leave);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(313, 418);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(305, 26);
            this.txtAlamat.TabIndex = 10;
            this.txtAlamat.Leave += new System.EventHandler(this.txtAlamat_Leave);
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Location = new System.Drawing.Point(102, 366);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(178, 20);
            this.lbNo.TabIndex = 11;
            this.lbNo.Text = "No telepon                      :";
            // 
            // lbAlamat
            // 
            this.lbAlamat.AutoSize = true;
            this.lbAlamat.Location = new System.Drawing.Point(102, 424);
            this.lbAlamat.Name = "lbAlamat";
            this.lbAlamat.Size = new System.Drawing.Size(175, 20);
            this.lbAlamat.TabIndex = 12;
            this.lbAlamat.Text = "Alamat                            :";
            // 
            // btDaftar
            // 
            this.btDaftar.BackColor = System.Drawing.SystemColors.Control;
            this.btDaftar.Location = new System.Drawing.Point(227, 541);
            this.btDaftar.Name = "btDaftar";
            this.btDaftar.Size = new System.Drawing.Size(115, 40);
            this.btDaftar.TabIndex = 13;
            this.btDaftar.Text = "Daftar";
            this.btDaftar.UseVisualStyleBackColor = false;
            this.btDaftar.Click += new System.EventHandler(this.btDaftar_Click);
            // 
            // btTutup
            // 
            this.btTutup.Location = new System.Drawing.Point(505, 540);
            this.btTutup.Name = "btTutup";
            this.btTutup.Size = new System.Drawing.Size(98, 41);
            this.btTutup.TabIndex = 14;
            this.btTutup.Text = "Tutup";
            this.btTutup.UseVisualStyleBackColor = true;
            this.btTutup.Click += new System.EventHandler(this.btTutup_Click);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 640);
            this.Controls.Add(this.btTutup);
            this.Controls.Add(this.btDaftar);
            this.Controls.Add(this.lbAlamat);
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtUsia);
            this.Controls.Add(this.lbUsia);
            this.Controls.Add(this.lbJK);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIK);
            this.Controls.Add(this.cbJk);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbNik);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNik;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.ComboBox cbJk;
        private System.Windows.Forms.TextBox txtNIK;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lbJK;
        private System.Windows.Forms.Label lbUsia;
        private System.Windows.Forms.TextBox txtUsia;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.Label lbAlamat;
        private System.Windows.Forms.Button btDaftar;
        private System.Windows.Forms.Button btTutup;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

