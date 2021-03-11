using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinformsTask2.Entities;

namespace WinformsTask2
{
    public partial class Form2 : Form
    {
        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;
        private Worker _worker;

        private Form1 _form;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form) : this()
        {
            _form = form;
        }

        public Form2(Form1 form, Worker worker):this(form)
        {
            _worker = worker;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(_worker != null)
            {
                FirstNameTxtB.ForeColor = Color.Black;
                FirstNameTxtB.Text = _worker.FirstName;

                LastNameTxtB.ForeColor = Color.Black;
                LastNameTxtB.Text = _worker.LastName;

                EmailTxtB.ForeColor = Color.Black;
                EmailTxtB.Text = _worker.Email;

                PhoneNumberMaskBox.Text = _worker.PhoneNumber;

                TitleTxtB.Text = _worker.Title;

                DepartmentTxtB.Text = _worker.Department;

                CompanyNameTxtB.Text = _worker.CompanyName;

                IndustryTxtB.Text = _worker.Industry;

                if (_worker.Gender == MaleRBtn.Text)
                {
                    MaleRBtn.Checked = true;
                }
                else if(_worker.Gender == FemaleRBtn.Text)
                {
                    FemaleRBtn.Checked = true;
                }
                else
                {
                    OthersRBtn.Checked = true;
                }

                if (_worker.Languages.Contains(EnglishChBox.Text))
                    EnglishChBox.Checked = true;

                if (_worker.Languages.Contains(RussianChBox.Text))
                    RussianChBox.Checked = true;

                if (_worker.Languages.Contains(TurkishChBox.Text))
                    TurkishChBox.Checked = true;

                if (_worker.Languages.Contains(FrenchChBox.Text))
                    FrenchChBox.Checked = true;
            }
        }

        private void DraggablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void DraggablePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                this.Location = Point.Add(_dragFormPoint, new Size(dif));
            }
        }

        private void DraggablePanel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LeftArrowBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
            _form.Show();
        }

        private void FemaleRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameTxtB_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterToTextBox(this.FirstNameTxtB, "First Name", Color.Black);
        }

        private void FirstNameTxtB_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFromTextBox(this.FirstNameTxtB, "First Name", Color.Gray);
        }

        private void LastNameTxtB_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterToTextBox(this.LastNameTxtB, "Last Name", Color.Black);
        }

        private void LastNameTxtB_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFromTextBox(this.LastNameTxtB, "Last Name", Color.Gray);
        }

        private void MouseEnterToTextBox(TextBox textBox, string text, Color color)
        {
            if (textBox.Text == text)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = color;
            }
        }

        private void MouseLeaveFromTextBox(TextBox textBox, string text, Color color)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
                return;

            textBox.Text = text;
            textBox.ForeColor = color;
        }

        private void EmailTxtB_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterToTextBox(this.EmailTxtB, "example@example.com", Color.Black);
        }

        private void EmailTxtB_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveFromTextBox(this.EmailTxtB, "example@example.com", Color.Gray);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CheckRequiredInputs())
            {
                var firstName = Capitalize(FirstNameTxtB.Text);
                var lastName = Capitalize(LastNameTxtB.Text);

                var jsonFile = $"{firstName}{lastName}.json";


                var worker = new Worker();

                worker.FirstName = firstName;
                worker.LastName = lastName;
                worker.Gender = (MaleRBtn.Checked) ? $"{MaleRBtn.Text}" :
                    (FemaleRBtn.Checked) ? $"{FemaleRBtn.Text}" : $"{OthersRBtn.Text}";

                worker.Email = EmailTxtB.Text;
                worker.PhoneNumber = PhoneNumberMaskBox.Text;
                worker.Title = TitleTxtB.Text;
                worker.Department = DepartmentTxtB.Text;
                worker.CompanyName = CompanyNameTxtB.Text;
                worker.Industry = IndustryTxtB.Text;

                if (EnglishChBox.Checked)
                {
                    worker.Languages.Add(EnglishChBox.Text);
                }

                if(RussianChBox.Checked)
                {
                    worker.Languages.Add(RussianChBox.Text);
                }

                if (TurkishChBox.Checked)
                {
                    worker.Languages.Add(TurkishChBox.Text);
                }

                if (FrenchChBox.Checked)
                {
                    worker.Languages.Add(FrenchChBox.Text);
                }


                if (_worker == null)
                {
                    _form.Workers.Add(worker);
                    _worker = worker;
                }
                else
                {
                    _worker.FirstName = worker.FirstName;
                    _worker.LastName = worker.LastName;
                    _worker.Gender = worker.Gender;
                    _worker.Email = worker.Email;
                    _worker.PhoneNumber = worker.PhoneNumber;
                    _worker.Title = worker.Title;
                    _worker.Department = worker.Department;
                    _worker.CompanyName = worker.CompanyName;
                    _worker.Industry = worker.Industry;
                    _worker.Languages = worker.Languages;
                }

                _form.Changes = true;

                FileHelper.WriteToJson(_form.Workers);
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("You must be fill all required inputs!");
            }
        }

        private string Capitalize(string name)
        {
            return $"{char.ToUpper(name[0])}{name.Substring(1)}";
        }

        private bool CheckRequiredInputs()
        {
            var requiredInputs = true;

            if (FirstNameTxtB.Text == "First Name")
            {
                firstNameRequiredLbl.ForeColor = Color.Red;
                requiredInputs = false;
            }
            else
            {
                firstNameRequiredLbl.ForeColor = Color.Black;
            }

            if (LastNameTxtB.Text == "Last Name")
            {
                LastNameRequiredLbl.ForeColor = Color.Red;
                requiredInputs = false;
            }
            else
            {
                LastNameRequiredLbl.ForeColor = Color.Black;
            }

            if (!MaleRBtn.Checked && !FemaleRBtn.Checked && !OthersRBtn.Checked)
            {
                GenderRequiredLbl.ForeColor = Color.Red;
                requiredInputs = false;
            }
            else
            {
                GenderRequiredLbl.ForeColor = Color.Black;
            }


            if (!ValidateMail(EmailTxtB.Text))
            {
                EmailRequiredLbl.ForeColor = Color.Red;
                requiredInputs = false;
            }
            else
            {
                EmailRequiredLbl.ForeColor = Color.Black;
            }


            if (!PhoneNumberMaskBox.MaskFull)
            {
                PhoneNumberRequiredLbl.ForeColor = Color.Red;
                requiredInputs = false;
            }
            else
            {
                PhoneNumberRequiredLbl.ForeColor = Color.Black;
            }

            return requiredInputs;
        }

        private bool ValidateMail(string mail)
        {
            return Regex.IsMatch(mail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
