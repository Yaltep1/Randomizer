using System.Collections;

namespace Randomizer
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
            this.end = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.randBut = new System.Windows.Forms.Button();
            this.logoutBut = new System.Windows.Forms.Button();
            this.endl = new System.Windows.Forms.Label();
            this.errLabel2 = new System.Windows.Forms.Label();
            this.startl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.end.Location = new System.Drawing.Point(183, 40);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(100, 34);
            this.end.TabIndex = 0;
            this.end.Visible = false;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(29, 40);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 34);
            this.start.TabIndex = 1;
            this.start.Visible = false;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.White;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(29, 152);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result.Size = new System.Drawing.Size(213, 286);
            this.result.TabIndex = 2;
            this.result.Visible = false;
            // 
            // randBut
            // 
            this.randBut.Location = new System.Drawing.Point(342, 43);
            this.randBut.Name = "randBut";
            this.randBut.Size = new System.Drawing.Size(87, 41);
            this.randBut.TabIndex = 4;
            this.randBut.Text = "Random";
            this.randBut.UseVisualStyleBackColor = true;
            this.randBut.Visible = false;
            this.randBut.Click += new System.EventHandler(this.randBut_Click);
            // 
            // logoutBut
            // 
            this.logoutBut.Location = new System.Drawing.Point(445, 43);
            this.logoutBut.Name = "logoutBut";
            this.logoutBut.Size = new System.Drawing.Size(84, 39);
            this.logoutBut.TabIndex = 5;
            this.logoutBut.Text = "LogOut";
            this.logoutBut.UseVisualStyleBackColor = true;
            this.logoutBut.Visible = false;
            this.logoutBut.Click += new System.EventHandler(this.logoutBut_Click);
            // 
            // endl
            // 
            this.endl.AutoSize = true;
            this.endl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endl.Location = new System.Drawing.Point(177, -3);
            this.endl.Name = "endl";
            this.endl.Size = new System.Drawing.Size(65, 36);
            this.endl.TabIndex = 6;
            this.endl.Text = "end";
            this.endl.Visible = false;
            // 
            // errLabel2
            // 
            this.errLabel2.AutoSize = true;
            this.errLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errLabel2.ForeColor = System.Drawing.Color.Crimson;
            this.errLabel2.Location = new System.Drawing.Point(26, 90);
            this.errLabel2.Name = "errLabel2";
            this.errLabel2.Size = new System.Drawing.Size(114, 24);
            this.errLabel2.TabIndex = 7;
            this.errLabel2.Text = "Wrong Data!";
            this.errLabel2.Visible = false;
            // 
            // startl
            // 
            this.startl.AutoSize = true;
            this.startl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startl.Location = new System.Drawing.Point(23, -3);
            this.startl.Name = "startl";
            this.startl.Size = new System.Drawing.Size(72, 36);
            this.startl.TabIndex = 8;
            this.startl.Text = "start";
            this.startl.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Result";
            this.label6.Visible = false;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.White;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history.ForeColor = System.Drawing.Color.Black;
            this.history.Location = new System.Drawing.Point(292, 152);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.history.ShortcutsEnabled = false;
            this.history.Size = new System.Drawing.Size(270, 286);
            this.history.TabIndex = 10;
            this.history.Visible = false;
            this.history.WordWrap = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(287, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 25);
            this.label18.TabIndex = 11;
            this.label18.Text = "History";
            this.label18.Visible = false;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(139, 333);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(272, 55);
            this.enter.TabIndex = 0;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(139, 84);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(272, 36);
            this.login.TabIndex = 1;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(139, 190);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(272, 36);
            this.password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.errorLabel.Location = new System.Drawing.Point(136, 262);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(288, 29);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "Wrong login or password!";
            this.errorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.history);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startl);
            this.Controls.Add(this.errLabel2);
            this.Controls.Add(this.endl);
            this.Controls.Add(this.logoutBut);
            this.Controls.Add(this.randBut);
            this.Controls.Add(this.result);
            this.Controls.Add(this.start);
            this.Controls.Add(this.end);
            this.Name = "Form1";
            this.Text = "Rand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private int user_id ;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button logoutBut;
        private System.Windows.Forms.Button randBut;
        private System.Windows.Forms.TextBox start;
        public System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label startl;
        private System.Windows.Forms.Label endl;
        private System.Windows.Forms.Label errLabel2;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.Label label18;

     private void hideForm2() {
            logoutBut.Visible = false;
            randBut.Visible = false;
            start.Visible = false;
            result.Visible = false;
            end.Visible = false;
            label6.Visible = false;
            startl.Visible = false;
            endl.Visible = false;
            errLabel2.Visible = false;
            history.Visible = false;
            label18.Visible = false;
            user_id = 0;
      }
        private void hideForm1()
        {
            enter.Visible = false;
            login.Visible = false;
            password.Visible = false;
            errorLabel.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }
        private void showForm2(int num, ArrayList hist)
        {
           hideForm1();
            logoutBut.Visible = true;
            randBut.Visible = true;
            start.Visible = true;
            result.Visible = true;
            end.Visible = true;
            label6.Visible = true;
            startl.Visible = true;
            endl.Visible = true;
            errLabel2.Visible = false;
            history.Visible = true;
            label18.Visible = true;
            user_id = num;
            foreach( object s in hist) { history.Text += s+ " \r\n\r\n"; }

        }
    }
    
}

