namespace GraWindowsFormsApp
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
            this.btnNowaGra = new System.Windows.Forms.Button();
            this.btnPrzerwij = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbZakresOd = new System.Windows.Forms.TextBox();
            this.tbZakresDo = new System.Windows.Forms.TextBox();
            this.btnWylosuj = new System.Windows.Forms.Button();
            this.labelKomunikat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPropozycja = new System.Windows.Forms.TextBox();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.labelOdp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblWylosowana = new System.Windows.Forms.Label();
            this.lblStatystyki = new System.Windows.Forms.Label();
            this.btnHistoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNowaGra
            // 
            this.btnNowaGra.Location = new System.Drawing.Point(12, 12);
            this.btnNowaGra.Name = "btnNowaGra";
            this.btnNowaGra.Size = new System.Drawing.Size(75, 23);
            this.btnNowaGra.TabIndex = 0;
            this.btnNowaGra.Text = "Nowa gra";
            this.btnNowaGra.UseVisualStyleBackColor = true;
            this.btnNowaGra.Click += new System.EventHandler(this.btnNowaGra_Click);
            // 
            // btnPrzerwij
            // 
            this.btnPrzerwij.Location = new System.Drawing.Point(351, 12);
            this.btnPrzerwij.Name = "btnPrzerwij";
            this.btnPrzerwij.Size = new System.Drawing.Size(75, 23);
            this.btnPrzerwij.TabIndex = 1;
            this.btnPrzerwij.Text = "Przerwij";
            this.btnPrzerwij.UseVisualStyleBackColor = true;
            this.btnPrzerwij.Visible = false;
            this.btnPrzerwij.Click += new System.EventHandler(this.btnPrzerwij_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(351, 440);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zakres od:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zakres do:";
            this.label2.Visible = false;
            // 
            // tbZakresOd
            // 
            this.tbZakresOd.Location = new System.Drawing.Point(98, 59);
            this.tbZakresOd.Name = "tbZakresOd";
            this.tbZakresOd.Size = new System.Drawing.Size(100, 20);
            this.tbZakresOd.TabIndex = 6;
            this.tbZakresOd.Text = "0";
            this.tbZakresOd.Visible = false;
            // 
            // tbZakresDo
            // 
            this.tbZakresDo.Location = new System.Drawing.Point(98, 109);
            this.tbZakresDo.Name = "tbZakresDo";
            this.tbZakresDo.Size = new System.Drawing.Size(100, 20);
            this.tbZakresDo.TabIndex = 7;
            this.tbZakresDo.Text = "100";
            this.tbZakresDo.Visible = false;
            // 
            // btnWylosuj
            // 
            this.btnWylosuj.Location = new System.Drawing.Point(239, 83);
            this.btnWylosuj.Name = "btnWylosuj";
            this.btnWylosuj.Size = new System.Drawing.Size(75, 23);
            this.btnWylosuj.TabIndex = 8;
            this.btnWylosuj.Text = "Wylosuj";
            this.btnWylosuj.UseVisualStyleBackColor = true;
            this.btnWylosuj.Visible = false;
            this.btnWylosuj.Click += new System.EventHandler(this.btnWylosuj_Click);
            // 
            // labelKomunikat
            // 
            this.labelKomunikat.AutoSize = true;
            this.labelKomunikat.Location = new System.Drawing.Point(34, 164);
            this.labelKomunikat.Name = "labelKomunikat";
            this.labelKomunikat.Size = new System.Drawing.Size(13, 13);
            this.labelKomunikat.TabIndex = 9;
            this.labelKomunikat.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Twoja propozycja:";
            // 
            // tbPropozycja
            // 
            this.tbPropozycja.Location = new System.Drawing.Point(133, 183);
            this.tbPropozycja.Name = "tbPropozycja";
            this.tbPropozycja.Size = new System.Drawing.Size(100, 20);
            this.tbPropozycja.TabIndex = 11;
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(239, 181);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(48, 23);
            this.btnWyslij.TabIndex = 12;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // labelOdp
            // 
            this.labelOdp.AutoSize = true;
            this.labelOdp.Location = new System.Drawing.Point(34, 220);
            this.labelOdp.Name = "labelOdp";
            this.labelOdp.Size = new System.Drawing.Size(30, 13);
            this.labelOdp.TabIndex = 13;
            this.labelOdp.Text = "Odp:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(34, 255);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(29, 13);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "czas";
            // 
            // lblWylosowana
            // 
            this.lblWylosowana.AutoSize = true;
            this.lblWylosowana.Location = new System.Drawing.Point(34, 284);
            this.lblWylosowana.Name = "lblWylosowana";
            this.lblWylosowana.Size = new System.Drawing.Size(16, 13);
            this.lblWylosowana.TabIndex = 15;
            this.lblWylosowana.Text = "...";
            this.lblWylosowana.Visible = false;
            // 
            // lblStatystyki
            // 
            this.lblStatystyki.AutoSize = true;
            this.lblStatystyki.Location = new System.Drawing.Point(34, 313);
            this.lblStatystyki.Name = "lblStatystyki";
            this.lblStatystyki.Size = new System.Drawing.Size(16, 13);
            this.lblStatystyki.TabIndex = 16;
            this.lblStatystyki.Text = "...";
            // 
            // btnHistoria
            // 
            this.btnHistoria.Location = new System.Drawing.Point(270, 440);
            this.btnHistoria.Name = "btnHistoria";
            this.btnHistoria.Size = new System.Drawing.Size(75, 23);
            this.btnHistoria.TabIndex = 17;
            this.btnHistoria.Text = "Historia";
            this.btnHistoria.UseVisualStyleBackColor = true;
            this.btnHistoria.Click += new System.EventHandler(this.btnHistoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 475);
            this.Controls.Add(this.btnHistoria);
            this.Controls.Add(this.lblStatystyki);
            this.Controls.Add(this.lblWylosowana);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.labelOdp);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.tbPropozycja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelKomunikat);
            this.Controls.Add(this.btnWylosuj);
            this.Controls.Add(this.tbZakresDo);
            this.Controls.Add(this.tbZakresOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnPrzerwij);
            this.Controls.Add(this.btnNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNowaGra;
        private System.Windows.Forms.Button btnPrzerwij;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbZakresOd;
        private System.Windows.Forms.TextBox tbZakresDo;
        private System.Windows.Forms.Button btnWylosuj;
        private System.Windows.Forms.Label labelKomunikat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPropozycja;
        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.Label labelOdp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblWylosowana;
        private System.Windows.Forms.Label lblStatystyki;
        private System.Windows.Forms.Button btnHistoria;
    }
}

